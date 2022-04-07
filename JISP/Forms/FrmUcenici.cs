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
            colOriginal = lblStatus.BackColor;
            dgvUcenici.ColumnsForCopyOnClick = new int[] { dgvcJOB.Index };
            dgvUcenici.CopyOnCellClick = true;
            dgvUcenici.CellTextCopied += Dgv_CellTextCopied;
            lblStatus.TextChanged += LblStatus_TextChanged;
            timStatus.Tick += TimStatus_Tick;
            ttOceneProvera.SetToolTip(chkOceneSaVladanjem, "Provera naziva ocena");
            ResetLblOceneProsekText();
            FilterData();
            dgvUcenici.StandardSort = bsUcenici.Sort;
            dgvUcenici.LoadSettings();

            //T
            //foreach (var uc in AppData.Ds.Ucenici)
            //    Console.WriteLine(uc);
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

        private void ChkSamoTekuci_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            try
            {
                var s = txtFilter.Text;
                var ids = IDeviZaDeoImena(s);
                var deoImena = ids.Count() > 0 ? $"IdUcenika IN ({string.Join(", ", ids)}) OR " : "";

                var filter = $"{deoImena} JOB LIKE '%{s}%' "
                       + $" OR Skola LIKE '%{s}%' OR Razred LIKE '%{s}%' OR Odeljenje LIKE '%{s}%'";
                if (chkSamoTekuci.Checked)
                    filter = $"({filter}) AND RegUceLiceId IS NOT NULL";

                bsUcenici.Filter = filter;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Greška pri filtriranju podataka"); }
        }

        private void BtnSaveData_Click(object sender, EventArgs e)
            => AppData.SaveDsData();

        private void TxtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvUcenici.CopyCellText(dgvcJOB.Index);
                e.SuppressKeyPress = true; // protiv "kling" zvuka
            }
        }

        private async void BtnOceneSmerovi_Click(object sender, EventArgs e)
        {
            try
            {
                // dohvatanje ocena
                var x = dgvUcenici.SelectedDataRows<Ds.UceniciRow>().ToList();
                foreach (var uc in x)
                {
                    var nivo = uc.JeOsnovac ? "Osnovno" : "Srednje";
                    var url = $"https://jisp.mpn.gov.rs/webapi/api/ucenik/Vrati{nivo}ObrazovanjeZavrsetakPolugodistaById/";
                    var ocene = await WebApi.GetObject<OceneUcenika>(url + uc.Id);
                    uc.BrojOcenaPolu = ocene.UkupanBrojOcena;
                }

                // dohvatanje smera - samo za srednjoskolce
                foreach (var uc in dgvUcenici.SelectedDataRows<Ds.UceniciRow>().Where(it => !it.JeOsnovac))
                {
                    var url = "https://jisp.mpn.gov.rs/webapi/api/ucenik/VratiUpisSrednjeObrazovanjeById/";
                    var json = await WebApi.GetJson(url + uc.Id);
                    dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
                    var str = (string)obj.smerObrazovniProfilNaziv;
                    uc.Smer = str.Contains('(') ? str.Substring(0, str.IndexOf('(')).Trim() : str;
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnOceneSmerovi.ToolTipText); }
        }

        private async void BtnOpstiPodaci_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUcenici.SelectedRows.Count == 0)
                    throw new Exception("Nije selektovan nijedan red u tabeli.");
                foreach (DataGridViewRow row in dgvUcenici.SelectedRows)
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
                var ucenici = dgvUcenici.SelectedDataRows<Ds.UceniciRow>();
                if (ucenici.Any(it => it.JeOsnovac))
                    await GetDuosData(WebApi.ReqEnum.Uc_DuosOS, ucenici.Where(it => it.JeOsnovac));
                if (ucenici.Any(it => it.JeSrednjoskolac))
                    await PostForDuosData(WebApi.ReqEnum.Uc_DuosSS, ucenici.Where(it => it.JeSrednjoskolac));
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnOdRaz.ToolTipText); }
        }

        /// <summary>Preuzimanje DUOS podataka o ucenicima za tekucu sk. godinu.</summary>
        private static async Task GetDuosData(WebApi.ReqEnum reqEnumDuos, IEnumerable<Ds.UceniciRow> selRows)
        {
            var duoses = await WebApi.GetList<DUOS>(reqEnumDuos);
            duoses = duoses.Where(it => it.SkolskaGodina == DUOS.TekucaSkGod)
                .ToList();
            AcceptDuosData(duoses, reqEnumDuos, selRows);
        }

        /// <summary>Preuzimanje DUOS podataka o ucenicima za tekucu sk. godinu.</summary>
        private static async Task PostForDuosData(WebApi.ReqEnum reqEnum, IEnumerable<Ds.UceniciRow> selRows)
        {
            var body = "{\"ustanovaId\":" + WebApi.SV_SAVA_ID + ",\"pageIndex\":0,\"pageSize\":1000,\"searchTerm\":\"\"}";
            var duosSS = await WebApi.PostForObject<DUOS_SS>(reqEnum, body);
            AcceptDuosData(duosSS.UpisSrednje, reqEnum, selRows);
        }

        private static void AcceptDuosData(List<DUOS> duoses, WebApi.ReqEnum reqEnum, IEnumerable<Ds.UceniciRow> selRows)
        {
            var selectedJOBs = selRows.Select(it => it.JOB);
            foreach (var duos in duoses.Where(it => selectedJOBs.Contains(it.JOB)))
            {
                var uc = AppData.Ds.Ucenici.FirstOrDefault(it => it.JOB == duos.JOB);
                if (uc != null)
                {
                    uc.RegUceLiceId = duos.RegUceLiceId;
                    uc.Skola = reqEnum == WebApi.ReqEnum.Uc_DuosOS ? "Основна" : "Средња";
                    uc.Razred = duos.Razred;
                    uc.Odeljenje = duos.Odeljenje;
                    uc.Id = duos.Id;
                    uc.RegUceLiceObrazovanjeId = reqEnum == WebApi.ReqEnum.Uc_DuosOS
                        ? duos.RegUceLiceOsnovnoObrazovanjeId : duos.RegUceLiceSrednjeObrazovanjeId;
                }
                else
                    throw new Exception($"JOB {duos.JOB} nije pronadjen.");
            }
        }

        private void ChkAllowNew_CheckedChanged(object sender, EventArgs e)
        {
            dgvUcenici.AllowUserToAddRows = chkAllowNew.Checked;
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
            var imeFajlaLista = "PreuzmiListuZahteva.json";
            var mboxResult = MessageBox.Show($"Yes - dodavanje jednog učenika\r\nNo - dodavanje učenika iz fajla {imeFajlaLista}"
                , "Dodavanje jednog ili više učenika?"
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (mboxResult == DialogResult.Yes)
                new FrmUcenikOsnovno(null).ShowDialog();

            if (mboxResult == DialogResult.No)
                try
                {
                    var ofd = new OpenFileDialog
                    {
                        InitialDirectory = AppData.FilePath(""),
                        Filter = $"{imeFajlaLista}|{imeFajlaLista}|JSON files (*.json)|*.json|All Files (*.*)|*.*"
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

        private void BtnOcenePaste_Click(object sender, EventArgs e)
        {
            try
            {
                ResetLblOceneProsekText();
                var avg = Ocene.Prosek(Clipboard.GetText(), chkOceneSaVladanjem.Checked);
                lblOceneProsek.Text = avg.ToString("0.00");
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Računanje proseka ocena"); }
        }

        private void ResetLblOceneProsekText()
            => lblOceneProsek.Text = "";

        private void FrmUcenici_Activated(object sender, EventArgs e)
        {
            txtFilter.Focus();
            txtFilter.SelectAll();
        }

        private void DgvUcenici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.ColumnIndex == dgvcIme.Index || e.ColumnIndex == dgvcJOB.Index)
            {
                var uc = dgvUcenici.CurrDataRow<Ds.UceniciRow>();
                new FrmUcenikOsnovno(uc).ShowDialog();
            }
        }
    }
}
