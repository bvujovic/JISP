using JISP.Classes;
using JISP.Controls;
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
            dgvUcenikSkGod.ColumnsForCopyOnClick = new int[] 
                { jobDgvc.Index, ocenePoluJSONDgvc.Index, oceneKrajJSONDgvc.Index, ZavrsObrazovanjaRezimeDgvc.Index };
            dgvUcenikSkGod.CopyOnCellClick = true;
            bsUcenikSkGod.DataSource = AppData.Ds;
            dgvUcenikSkGod.StandardSort = bsUcenici.Sort;
            dgvUcenikSkGod.CellTextCopied += Dgv_CellTextCopied;
            dgvUcenikSkGod.LoadSettings();
            colOriginal = lblStatus.BackColor;
            lblStatus.TextChanged += LblStatus_TextChanged;
            timStatus.Tick += TimStatus_Tick;
            ttOceneProvera.SetToolTip(chkOceneSaVladanjem, "Provera naziva ocena");
            ResetLblOceneProsekText();
            FilterData();
            PodesiCmbPodaciZaDohvatanje();

            formLoadStarted = DateTime.Now;
        }

        private void PodesiCmbPodaciZaDohvatanje()
        {
            cmbPodaciZaDohvatanje.Items.Clear();
            cmbPodaciZaDohvatanje.Items.AddRange(new[] {
                CmbDohvatiOpste,
                CmbDohvatiOdRaz,
                CmbDohvatiSmer,
                CmbDohvatiOcenePG,
                CmbDohvatiOceneKraj,
                CmbDohvatiZavrsObraz,
            });
            cmbPodaciZaDohvatanje.AdjustWidth();
        }

        private const string CmbDohvatiOpste = "Opšte: pol, datum rođenja...";
        private const string CmbDohvatiOdRaz = "Razredi i odeljenja";
        private const string CmbDohvatiSmer = "Smerovi za srednjoškolce";
        private const string CmbDohvatiOcenePG = "Ocene na polugodištu";
        private const string CmbDohvatiOceneKraj = "Ocene za kraj godine";
        private const string CmbDohvatiZavrsObraz = "Završetak obrazovanja";

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
            FilterData();
        }

        private void FilterData()
        {
            try
            {
                var filter = "";
                var s = txtFilter.Text;
                // pretraga razreda i odeljenja
                if (s.StartsWith("I") || s.StartsWith("V"))
                    filter = $"Razred LIKE '{s}%' OR Odeljenje LIKE '{s}%'";
                else // 
                {
                    var ids = IDeviZaDeoImena(s);
                    var deoImena = ids.Count() > 0 ? $"IdUcenika IN ({string.Join(", ", ids)}) OR " : "";

                    filter = $"{deoImena} _JOB LIKE '%{s}%' "
                           + $" OR Skola LIKE '%{s}%' OR Razred LIKE '%{s}%' OR Odeljenje LIKE '%{s}%'";
                }
                filter = $"({filter}) AND SkGod = '{AppData.SkolskaGodina}'";
                bsUcenikSkGod.Filter = filter;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Greška pri filtriranju podataka"); }
        }

        private void BtnSaveData_Click(object sender, EventArgs e)
            => AppData.SaveDsData();

        private void TxtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvUcenikSkGod.CopyCellText(jobDgvc.Index);
                e.SuppressKeyPress = true; // protiv "kling" zvuka
            }
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
                new FrmUcenikImeJOB(null).ShowDialog();

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
                var strAvg = avg.ToString("0.00");
                lblOceneProsek.Text = strAvg;
                Clipboard.SetText(strAvg);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Računanje proseka ocena"); }
        }

        private void ResetLblOceneProsekText()
            => lblOceneProsek.Text = "";

        private DateTime formLoadStarted;

        private void FrmUcenici_Activated(object sender, EventArgs e)
        {
            if ((DateTime.Now - formLoadStarted).TotalMilliseconds > 100)
            {
                txtFilter.Focus();
                txtFilter.SelectAll();
            }
        }

        private void DgvUcenikSkGod_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.ColumnIndex == imeDgvc.Index || e.ColumnIndex == jobDgvc.Index)
            {
                var uc = dgvUcenikSkGod.CurrDataRow<Ds.UceniciRow>();
                new FrmUcenikImeJOB(uc).ShowDialog();
            }
        }

        private void FrmUcenici_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvUcenikSkGod.SaveSettings();
        }

        /// <summary>Preuzimanje DUOS podataka o ucenicima za tekucu sk. godinu.</summary>
        private static async Task GetDuosData(WebApi.ReqEnum reqEnumDuos)
        {
            var duoses = await WebApi.GetList<DUOS>(reqEnumDuos);
            AcceptDuosData(duoses, reqEnumDuos);
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
                var u = AppData.Ds.Ucenici.FirstOrDefault(it => it.JOB == duos.JOB);
                if (u == null)
                    continue;
                if (u.IsRegUceLiceIdNull())
                    u.RegUceLiceId = duos.RegUceLiceId;

                var exUsk = AppData.Ds.UcenikSkGod.FirstOrDefault
                    (it => it.IdUcenika == u.IdUcenika && it.SkGod == duos.SkolskaGodina);
                var regUceLiceObrazovanjeId = reqEnum == WebApi.ReqEnum.Uc_DuosOS
                        ? duos.RegUceLiceOsnovnoObrazovanjeId : duos.RegUceLiceSrednjeObrazovanjeId;
                var skola = reqEnum == WebApi.ReqEnum.Uc_DuosOS ? "Основна" : "Средња";
                if (exUsk == null)
                {
                    var usk = AppData.Ds.UcenikSkGod.NewUcenikSkGodRow();
                    usk.Id = duos.Id;
                    usk.IdUcenika = u.IdUcenika;
                    usk.SkGod = duos.SkolskaGodina;
                    usk.RegUceLiceObrazovanjeId = regUceLiceObrazovanjeId;
                    usk.Skola = skola;
                    usk.Razred = duos.Razred;
                    usk.Odeljenje = duos.Odeljenje;
                    AppData.Ds.UcenikSkGod.AddUcenikSkGodRow(usk);
                }
                else
                {
                    var usk = exUsk;
                    if (usk.Id != duos.Id)
                        usk.Id = duos.Id;
                    if (usk.IdUcenika != u.IdUcenika)
                        usk.IdUcenika = u.IdUcenika;
                    if (usk.SkGod != duos.SkolskaGodina)
                        usk.SkGod = duos.SkolskaGodina;
                    if (usk.RegUceLiceObrazovanjeId != regUceLiceObrazovanjeId)
                        usk.RegUceLiceObrazovanjeId = regUceLiceObrazovanjeId;
                    if (usk.Skola != skola)
                        usk.Skola = skola;
                    if (usk.Razred != duos.Razred)
                        usk.Razred = duos.Razred;
                    if (usk.Odeljenje != duos.Odeljenje)
                        usk.Odeljenje = duos.Odeljenje;
                }
            }
        }

        private async void BtnDohvatiPodatke_Click(object sender, EventArgs e)
        {
            var selItem = (string)cmbPodaciZaDohvatanje.SelectedItem;

            if (selItem == CmbDohvatiOpste)
                await (sender as UcButton).RunAsync(async () =>
                {
                    foreach (var uc in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>())
                    {
                        var u = AppData.Ds.Ucenici.FindByIdUcenika(uc.IdUcenika);
                        var uo = await WebApi.GetObject<UcenikOpste>
                            (WebApi.ReqEnum.Uc_OpstiPodaci, u.RegUceLiceId.ToString());
                        u.Pol = uo.PolSlovo;
                        if (uo.DatumRodjenja.HasValue)
                            u.DatumRodjenja = uo.DatumRodjenja.Value;
                    }
                });

            if (selItem == CmbDohvatiOdRaz)
                await (sender as UcButton).RunAsync(async () =>
                {
                    await GetDuosData(WebApi.ReqEnum.Uc_DuosOS);
                    await PostForDuosData(WebApi.ReqEnum.Uc_DuosSS);
                });

            if (selItem == CmbDohvatiSmer)
                await (sender as UcButton).RunAsync(async () =>
                {
                    foreach (var u in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>().Where(it => !it.JeOsnovac))
                    {
                        var url = "https://jisp.mpn.gov.rs/webapi/api/ucenik/VratiUpisSrednjeObrazovanjeById/";
                        var json = await WebApi.GetJson(url + u.Id);
                        dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
                        var str = (string)obj.smerObrazovniProfilNaziv;
                        u.Smer = str.Contains('(') ? str.Substring(0, str.IndexOf('(')).Trim() : str;
                    }
                });

            if (selItem == CmbDohvatiOcenePG)
                await (sender as UcButton).RunAsync(async () =>
                {
                    foreach (var u in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>())
                    {
                        var nivo = u.JeOsnovac ? "Osnovno" : "Srednje";
                        var url = $"https://jisp.mpn.gov.rs/webapi/api/ucenik/Vrati{nivo}ObrazovanjeZavrsetakPolugodistaById/";
                        var json = await WebApi.GetJson(url + u.Id);
                        var ocene = Newtonsoft.Json.JsonConvert.DeserializeObject<OceneUcenika>(json);
                        if (ocene.UkupanBrojOcena == 0)
                        {
                            u.SetOcenePoluJSONNull();
                            u.SetOcenePoluBrojNull();
                        }
                        else
                        {
                            u.OcenePoluJSON = json;
                            u.OcenePoluBroj = ocene.UkupanBrojOcena;
                        }
                    }
                });

            if (selItem == CmbDohvatiOceneKraj)
                await (sender as UcButton).RunAsync(async () =>
                {
                    foreach (var u in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>())
                    {
                        var nivo = u.JeOsnovac ? "Osnovno" : "Srednje";
                        var url = $"https://jisp.mpn.gov.rs/webapi/api/ucenik/Vrati{nivo}ObrazovanjeZavrsetakRazredaById/" + u.Id;
                        var json = await WebApi.GetJson(url);
                        var ocene = Newtonsoft.Json.JsonConvert.DeserializeObject<OceneUcenika>(json);
                        if (ocene.UkupanBrojOcena == 0)
                        {
                            u.SetOceneKrajJSONNull();
                            u.SetOceneKrajBrojNull();
                        }
                        else
                        {
                            u.OceneKrajJSON = json;
                            u.OceneKrajBroj = ocene.UkupanBrojOcena;
                        }
                    }
                });

            if (selItem == CmbDohvatiZavrsObraz)
                await (sender as UcButton).RunAsync(async () =>
                {
                    foreach (var u in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>())
                    {
                        var nivo = u.JeOsnovac ? "Osnovno" : "Srednje";
                        var url = $"https://jisp.mpn.gov.rs/webapi/api/ucenik/Vrati{nivo}ObrazovanjeZavrsetak{nivo[0]}OById/" + u.RegUceLiceObrazovanjeId;
                        var json = await WebApi.GetJson(url);
                        dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
                        if (obj.datumZavrsetka == null)
                        {
                            u.SetZavrsObrazovanjaJSONNull();
                            u.SetZavrsObrazovanjaRezimeNull();
                        }
                        else
                        {
                            u.ZavrsObrazovanjaJSON = json;
                            u.ZavrsObrazovanjaRezime
                                = (string)obj.datumZavrsetka + "; "
                                + obj.zavrsetakIsprave[0].ispravaNaziv + "; "
                                + obj.regNoksNacionalnaKvalifikacijaId + ", "
                                + obj.prosecnaOcenaNaZavrsnomMatruskomIspitu;
                        }
                    }
                });
        }
    }
}
