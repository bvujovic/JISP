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
            txtFilter.BindingSource = bsUcenikSkGod;
            formLoadStarted = DateTime.Now;
            this.FormStandardSettings();
        }

        private void PodesiCmbPodaciZaDohvatanje()
        {
            cmbPodaciZaDohvatanje.Items.Clear();
            cmbPodaciZaDohvatanje.Items.AddRange(new[] {
                CmbDohvatiOpste,
                CmbDohvatiJmbg,
                CmbDohvatiOdRaz,
                CmbDohvatiDomGrupe,
                CmbDohvatiSmer,
                CmbDohvatiOcenePG,
                CmbDohvatiOceneKraj,
                CmbDohvatiZavrsObraz,
            });
            cmbPodaciZaDohvatanje.AdjustWidth();
        }

        private const string CmbDohvatiOpste = "Opšte: pol, datum rođenja...";
        private const string CmbDohvatiJmbg = "Lista zahteva: JMBG, ime, prezime, roditelj";
        private const string CmbDohvatiOdRaz = "Razredi, odeljenja i vrtić-grupe";
        private const string CmbDohvatiDomGrupe = "Vaspitne grupe za dom učenika";
        private const string CmbDohvatiSmer = "Smerovi za srednjoškolce";
        private const string CmbDohvatiOcenePG = "Ocene na polugodištu";
        private const string CmbDohvatiOceneKraj = "Ocene za kraj godine (ispisan)";
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
            foreach (var uc in AppData.Ds.Ucenici.Where(it => !it.IsUcenikStringNull()))
            {
                var deloviIme = uc.UcenikString.Split();
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

        private void ChkAktivni_CheckStateChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            try
            {
                var filter = "";
                var s = LatinicaCirilica.Lat2Cir(txtFilter.Text);
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
                if (chkAktivni.CheckState != CheckState.Indeterminate)
                    filter += " AND Ispisan = " + !chkAktivni.Checked;
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
            var ci = e.ColumnIndex;
            if (e.RowIndex != -1 &&
                (ci == -1 || ci == imeDgvc.Index || ci == PrezimeDgvc.Index || ci == ImeRoditeljaDgvc.Index
                || ci == ImePrezimeDgvc.Index || ci == jobDgvc.Index || ci == dgvcPrebivaliste.Index))
            {
                var ucSkGod = dgvUcenikSkGod.CurrDataRow<Ds.UcenikSkGodRow>();
                new FrmUcenikImeJOB(ucSkGod.UceniciRow).ShowDialog();
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
            if (reqEnum == WebApi.ReqEnum.Uc_DuosSS)
            {
                var duosSS = await WebApi.PostForObject<DUOS_SS>(reqEnum, body);
                AcceptDuosData(duosSS.UpisSrednje, reqEnum);
            }
            else
            {
                var json = await WebApi.PostForJson(WebApi.ReqEnum.Uc_DuosDeca, body);
                dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
                var duoses = new List<DUOS>();
                foreach (var it in obj.decaPredskolskoList)
                    if (it.radnaGodina == AppData.SkolskaGodina.Naziv)
                        duoses.Add(new DUOS
                        {
                            RegUceLiceId = it.regUceLiceId,
                            JOB = it.job,
                            SkolskaGodina = it.radnaGodina,
                            Razred = AppData.NazivPppRazreda,
                            Odeljenje = it.vaspitnaGrupa,
                            Id = it.id,
                        });
                AcceptDuosData(duoses, reqEnum);
            }
        }

        private static void AcceptDuosData(List<DUOS> duoses, WebApi.ReqEnum reqEnum)
        {
            var skola = WebApi.ReqEnumToSkola(reqEnum);
            foreach (var duos in duoses)
            {
                duos.Razred = Utils.SkratiRazredSS(duos.Razred);
                var u = AppData.Ds.Ucenici.FirstOrDefault(it => it.JOB == duos.JOB);
                if (u == null)
                    continue;
                if (u.IsRegUceLiceIdNull())
                    u.RegUceLiceId = duos.RegUceLiceId;

                var exUsk = AppData.Ds.UcenikSkGod.FirstOrDefault
                    (it => it.IdUcenika == u.IdUcenika && it.SkGod == duos.SkolskaGodina);
                var regUceLiceObrazovanjeId = reqEnum == WebApi.ReqEnum.Uc_DuosOS
                        ? duos.RegUceLiceOsnovnoObrazovanjeId : duos.RegUceLiceSrednjeObrazovanjeId;
                if (exUsk == null)
                {
                    var usk = AppData.Ds.UcenikSkGod.NewUcenikSkGodRow();
                    usk.Id = duos.Id;
                    usk.IdUcenika = u.IdUcenika;
                    usk.SkGod = duos.SkolskaGodina;
                    if (reqEnum != WebApi.ReqEnum.Uc_DuosDeca)
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
                    if (reqEnum != WebApi.ReqEnum.Uc_DuosDeca && usk.RegUceLiceObrazovanjeId != regUceLiceObrazovanjeId)
                        usk.RegUceLiceObrazovanjeId = regUceLiceObrazovanjeId;
                    if (usk.Skola != skola)
                        usk.Skola = skola;
                    if (usk.IsRazredNull() || usk.Razred != duos.Razred)
                        usk.Razred = duos.Razred;
                    if (usk.Odeljenje != duos.Odeljenje)
                        usk.Odeljenje = duos.Odeljenje;
                }

                //var x = duoses.Where(it => it.JOB == exUsk._JOB);
                //var y = duoses.Where(it => it.JOB == exUsk._JOB
                //    && it.SkolskaGodina == AppData.SkolskaGodina.ToString());
                //;
                //var x = AppData.Ds.UcenikSkGod.Where(it =>
                //    it.SkGod == AppData.SkolskaGodina.ToString()
                //    && it.Skola == WebApi.ReqEnumToSkola(reqEnum)
                //    && it._JOB == exUsk._JOB);
                //    // && !duoses.Any(d => d.JOB == it._JOB));
                //if (x.Any())
                //    Console.WriteLine();

                //foreach (var usk in AppData.Ds.UcenikSkGod.Where(it => it.SkGod == AppData.SkolskaGodina.ToString()))
                //{
                //}
            }

            var zaBrisanje = new List<Ds.UcenikSkGodRow>();
            var skGod = AppData.SkolskaGodina.ToString();
            foreach (var usk in AppData.Ds.UcenikSkGod.Where(it => it.SkGod == skGod && it.Skola == skola))
                if (!duoses.Where(it => it.JOB == usk._JOB && it.SkolskaGodina == skGod).Any())
                    zaBrisanje.Add(usk);

            if (zaBrisanje.Any() && Utils.ShowMboxYesNo(string.Join(Environment.NewLine, zaBrisanje)
                    , $"Brisanje unosa učenika za školsku godinu {skGod} - {skola}")
                    == DialogResult.Yes)
            {
                foreach (var usk in zaBrisanje)
                    AppData.Ds.UcenikSkGod.RemoveUcenikSkGodRow(usk);
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

            if (selItem == CmbDohvatiJmbg)
            {
                var mboxResult = MessageBox.Show($"Koliko stranica od po 50 zahteva je potrebno učitati?\r\n" +
                    $"Yes - Samo prvu stranicu (najnoviji podaci)\r\nNo - Kompletnu listu zahteva"
                    , "Učitavanje liste zahteva za JOBom"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (mboxResult != DialogResult.Cancel)
                    await (sender as UcButton).RunAsync(async () =>
                        {
                            await DataGetter.GetListaJobZahteva(mboxResult == DialogResult.Yes);
                        });
            }

            if (selItem == CmbDohvatiOdRaz)
                await (sender as UcButton).RunAsync(async () =>
                {
                    await PostForDuosData(WebApi.ReqEnum.Uc_DuosDeca);
                    await GetDuosData(WebApi.ReqEnum.Uc_DuosOS);
                    await PostForDuosData(WebApi.ReqEnum.Uc_DuosSS);
                });

            if (selItem == CmbDohvatiDomGrupe)
                await (sender as UcButton).RunAsync(async () =>
                {
                    var url = WebApi.UrlForReq(WebApi.ReqEnum.Uc_DuosDomGrupe);
                    var json = await WebApi.GetJson(url);
                    dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
                    var jobs = AppData.Ds.UcenikSkGod.Where(it => it.SkGod == AppData.SkolskaGodina.Naziv)
                        .Select(it => it._JOB).ToList();
                    foreach (var obj in arr)
                        if (obj.skolskaGodinaNaziv == AppData.SkolskaGodina.Naziv)
                        {
                            var ucSkGod = AppData.Ds.UcenikSkGod.FirstOrDefault
                                (it => it._JOB == (string)obj.job && it.SkGod == AppData.SkolskaGodina.Naziv);
                            if (ucSkGod != null && obj.datumNapustanjaUstanove == null)
                            {
                                ucSkGod.DomGrupa = obj.vaspitnaGrupaNaziv;
                                jobs.Remove(ucSkGod._JOB);
                            }
                        }
                    foreach (var uc in AppData.Ds.UcenikSkGod.Where(it => it.SkGod == AppData.SkolskaGodina.Naziv
                        && jobs.Contains(it._JOB) && !it.IsDomGrupaNull()))
                        uc.SetDomGrupaNull();
                });

            if (selItem == CmbDohvatiSmer)
                await (sender as UcButton).RunAsync(async () =>
                {
                    foreach (var u in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>().Where(it => it.JeSrednjoskolac))
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
                    foreach (var u in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>().Where(it => !it.JePredskolac))
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
                    foreach (var u in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>().Where(it => !it.JePredskolac))
                    {
                        var nivo = u.JeOsnovac ? "Osnovno" : "Srednje";
                        var url = $"https://jisp.mpn.gov.rs/webapi/api/ucenik/Vrati{nivo}ObrazovanjeZavrsetakRazredaById/" + u.Id;
                        var json = await WebApi.GetJson(url);
                        dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
                        if (obj.ispraveZavrsetak != null && obj.ispraveZavrsetak.Count > 0)
                        {
                            var ispravaNaziv = obj.ispraveZavrsetak[0].ispravaNaziv;
                            u.Ispisan = ispravaNaziv == "исписница";
                        }
                        else
                            u.Ispisan = false;
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
                    foreach (var u in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>().Where(it => it.JePredskolac))
                    {
                        var url = $"https://jisp.mpn.gov.rs/webapi/api/ucenik/DeteUPredskolskojZavrsetak?id=" + u.Id;
                        var json = await WebApi.GetJson(url);
                        dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
                        u.Ispisan = obj.datumZavrsetkaPPP != null;
                    }
                });

            if (selItem == CmbDohvatiZavrsObraz)
                await (sender as UcButton).RunAsync(async () =>
                {
                    foreach (var u in dgvUcenikSkGod.SelectedDataRows<Ds.UcenikSkGodRow>().Where(it => !it.JePredskolac))
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
                            u.ZavrsObrazovanjaRezime = Utils.RezimeZavrsetkaObrazovanja(json);
                        }
                    }
                });
        }

        private void ChkCopyOnClick_CheckedChanged(object sender, EventArgs e)
            => dgvUcenikSkGod.CopyOnCellClick = dgvUcenikSkGod.CopyOnCellClick = chkCopyOnClick.Checked;

        private void BtnOdRaz_Click(object sender, EventArgs e)
        {
            new FrmRazrediOdeljenja().ShowDialog();
        }
    }
}
