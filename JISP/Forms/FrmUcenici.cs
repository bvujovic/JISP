using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmUcenici : Form
    {
        public FrmUcenici()
        {
            InitializeComponent();
        }

        private void FrmUcenici_Load(object sender, EventArgs e)
        {
            bsUcenici.DataSource = AppData.Ds;
            dgv.CopyOnCellClick = true;
            DisplayPositionRowCount();
            colOriginal = lblStatus.BackColor;
            dgv.CellTextCopied += Dgv_CellTextCopied;
            lblStatus.TextChanged += LblStatus_TextChanged;
            timStatus.Tick += TimStatus_Tick;
        }

        private void Dgv_CellTextCopied(object sender, EventArgs e)
        {
            lblStatus.Text = "Kopiran tekst: " + Clipboard.GetText();
        }

        private void LblStatus_TextChanged(object sender, EventArgs e)
        {
            lblStatus.BackColor = Color.Green;
            timStatus.Start();
        }

        private Color colOriginal;
        private readonly Timer timStatus = new Timer { Interval = 250 };

        private void TimStatus_Tick(object sender, EventArgs e)
        {
            timStatus.Stop();
            lblStatus.BackColor = colOriginal;
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var s = txtFilter.Text;
                bsUcenici.Filter = $"Ime LIKE '%{s}%' OR Prezime LIKE '%{s}%' OR JOB LIKE '%{s}%' "
                        + $" OR Skola LIKE '%{s}%' OR Razred LIKE '%{s}%' OR Odeljenje LIKE '%{s}%'";
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Greška pri filtriranju podataka"); }
            DisplayPositionRowCount();
        }

        private void DisplayPositionRowCount()
             => lblRowCount.Text = $"Red {bsUcenici.Position + 1} / {bsUcenici.Count}";

        private void BtnSaveData_Click(object sender, EventArgs e)
            => AppData.SaveDsData();

        private void TxtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv.CopyCellText(dgvcJOB.Index);
                e.SuppressKeyPress = true; // protiv "kling" zvuka
            }
        }

        private void BtnSrednjoskolci_Click(object sender, EventArgs e)
            => Utils.ShowForm(typeof(FrmSrednjoskolci));

        private async void BtnOdRaz_Click(object sender, EventArgs e)
        {
            try
            {
                await GetDuosData(WebApi.ReqEnum.Uc_DuosOS);
                await GetDuosData(WebApi.ReqEnum.Uc_DuosSS);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Uzimanje podataka o razredima i odeljenjima"); }
        }

        /// <summary>Preuzimanje DUOS podataka o ucenicima za tekucu sk. godinu.</summary>
        private static async Task GetDuosData(WebApi.ReqEnum reqEnumDuos)
        {
            var data = await WebApi.GetList<DUOS>(reqEnumDuos);
            data = data.Where(it => it.SkolskaGodina == DUOS.TekucaSkGod)
                .ToList();
            foreach (var duos in data)
            {
                var uc = AppData.Ds.Ucenici.FirstOrDefault(it => it.JOB == duos.JOB);
                if (uc != null)
                {
                    uc.Skola = reqEnumDuos == WebApi.ReqEnum.Uc_DuosOS ? "Основна" : "Средња";
                    uc.Razred = duos.Razred;
                    uc.Odeljenje = duos.Odeljenje;
                }
                else
                    throw new Exception($"JOB {duos.JOB} nije pronadjen.");
            }
        }

        private void ChkAllowNew_CheckedChanged(object sender, EventArgs e)
        {
            dgv.AllowUserToAddRows = chkAllowNew.Checked;
            if (chkAllowNew.Checked)
                bsUcenici.MoveLast();
        }

        private void Dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var msg = e.Exception?.Message;
            if (msg != null)
            {
                var caption = "Greška u tabeli.";
                msg += "\r\n\r\nPrikaži dodatne informacije?";
                var res = Utils.ShowMboxYesNo(msg, caption);
                if (res == DialogResult.Yes)
                    Utils.ShowMbox(e.Exception.StackTrace, caption);
            }
        }

        /// <summary>
        /// Ucitavaju se podaci o ucenicima na osnovu vec preuzetog JSON fajla
        /// (Pregled zahteva) i izdvajaju se oni ciji JOBovi nisu 
        /// pronadjeni u postojecem spisku ucenika.
        /// </summary>
        private void BtnNoviUcenici_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog
                {
                    InitialDirectory = AppData.FilePath(""),
                    Filter = "PreuzmiListuZahteva.json|PreuzmiListuZahteva.json|JSON files (*.json)|*.json|All Files (*.*)|*.*"
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var json = System.IO.File.ReadAllText(ofd.FileName);
                    var ucenici = WebApi.DeserializeList<JobZahtev>(json);

                    var novi = new HashSet<Ucenik>();
                    foreach (var uc in ucenici.Where(it => it.Lice != null))
                    {
                        var row = AppData.Ds.Ucenici.FirstOrDefault(it => it.JOB == uc.Lice.JOB);
                        if (row == null)
                            novi.Add(uc.Lice);
                    }
                    Clipboard.SetText(string.Join(Environment.NewLine, novi.OrderBy(it => it.NazivUcenika)));
                    Utils.ShowMbox
                        ("Lista novih JOBova sa imenima učenika je u clipboard-u.", "Učitavanje JOB-ova");
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Učitavanje JOB-ova"); }
        }

        private void BsUcenici_CurrentChanged(object sender, EventArgs e)
            => DisplayPositionRowCount();
    }
}
