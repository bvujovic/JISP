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
            DisplayPositionRowCount();
            colOriginal = lblStatus.BackColor;
            dgv.ColumnsForCopyOnClick = new int[] { dgvcJOB.Index };
            dgv.CopyOnCellClick = true;
            dgv.CellTextCopied += Dgv_CellTextCopied;
            lblStatus.TextChanged += LblStatus_TextChanged;
            timStatus.Tick += TimStatus_Tick;
            ttOceneProvera.SetToolTip(chkOceneProveraNaziva, "Provera naziva ocena");
            ResetLblOceneProsekText();
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

        /// <summary>IDevi ucenika cija imena/prezimena pocinju datim stringom.</summary>
        /// <example>str "stef rad" -> Stefan Snezana Radovanovic</example>
        private static IEnumerable<int> IDeviZaDeoImena(string str)
        {
            var ss = str.ToLower().Split();
            var ids = new List<int>();
            foreach (var uc in AppData.Ds.Ucenici)
            {
                var deloviIme = uc.Ime.Split();
                var hits = 0;
                foreach (var s in ss)
                    if (deloviIme.Any(it => it.ToLower().StartsWith(s)))
                        hits++;
                if (hits == ss.Length) // ako svaki deo datog stringa zapocinje bar neki deo imena
                    ids.Add(uc.IdUcenika); // onda ucenik zadovoljava uslov i njegov ID je deo rezultata
            }
            return ids;
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var s = txtFilter.Text;
                var ids = IDeviZaDeoImena(s);
                var deoImena = ids.Count() > 0 ? $"IdUcenika IN ({string.Join(", ", ids)}) OR " : "";
                bsUcenici.Filter = $"{deoImena} JOB LIKE '%{s}%' "
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

        private async void BtnOpstiPodaci_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                    throw new Exception("Nije selektovan nijedan red u tabeli.");
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    var drv = row.DataBoundItem as DataRowView;
                    var uc = drv.Row as Ds.UceniciRow;
                    if (!uc.IsRegUceLiceIdNull())
                    {
                        var uo = await WebApi.GetObject<UcenikOpste>
                            (WebApi.ReqEnum.Uc_OpstiPodaci, uc.RegUceLiceId.ToString());
                        uc.Pol = uo.PolSlovo;
                        if (uo.DatumRodjenja.HasValue)
                            uc.DatumRodjenja = uo.DatumRodjenja.Value;
                    }
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnOpstiPodaci.ToolTipText); }
        }

        private async void BtnOdRaz_Click(object sender, EventArgs e)
        {
            try
            {
                await GetDuosData(WebApi.ReqEnum.Uc_DuosOS);
                await PostForDuosData(WebApi.ReqEnum.Uc_DuosSS);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnOdRaz.ToolTipText); }
        }

        /// <summary>Preuzimanje DUOS podataka o ucenicima za tekucu sk. godinu.</summary>
        private static async Task PostForDuosData(WebApi.ReqEnum reqEnum)
        {
            var body = "{\"ustanovaId\":" + WebApi.SV_SAVA_ID + ",\"pageIndex\":0,\"pageSize\":1000,\"searchTerm\":\"\"}";
            var duosSS = await WebApi.PostForObject<DUOS_SS>(reqEnum, body);
            AcceptDuosData(duosSS.UpisSrednje, reqEnum);
        }

        private static void AcceptDuosData(List<DUOS> duoses, WebApi.ReqEnum reqEnum)
        {
            foreach (var duos in duoses)
            {
                var uc = AppData.Ds.Ucenici.FirstOrDefault(it => it.JOB == duos.JOB);
                if (uc != null)
                {
                    uc.RegUceLiceId = duos.RegUceLiceId;
                    uc.Skola = reqEnum == WebApi.ReqEnum.Uc_DuosOS ? "Основна" : "Средња";
                    uc.Razred = duos.Razred;
                    uc.Odeljenje = duos.Odeljenje;
                }
                else
                    throw new Exception($"JOB {duos.JOB} nije pronadjen.");
            }
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
                    uc.RegUceLiceId = duos.RegUceLiceId;
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
                        ("Lista novih JOBova sa imenima učenika je u clipboard-u.", btnNoviUcenici.Text);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnNoviUcenici.Text); }
        }

        private void BsUcenici_CurrentChanged(object sender, EventArgs e)
            => DisplayPositionRowCount();

        private void BtnOcenePaste_Click(object sender, EventArgs e)
        {
            try
            {
                ResetLblOceneProsekText();
                var avg = Marks.CalcAverage(Clipboard.GetText(), chkOceneProveraNaziva.Checked);
                lblOceneProsek.Text = avg.ToString("0.00");
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Računanje proseka ocena"); }
        }

        private void ResetLblOceneProsekText()
            => lblOceneProsek.Text = ""; // "Prosek: /";

        private void FrmUcenici_Activated(object sender, EventArgs e)
        {
            if (this.ActiveControl.Equals(txtFilter) && txtFilter.Text != "")
                txtFilter.SelectAll();
        }
    }
}
