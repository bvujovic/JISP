using JISP.Classes;
using JISP.Classes.ObracunZarada;
using JISP.Controls;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmZaposleni : Form
    {
        public FrmZaposleni()
        {
            InitializeComponent();
            Ds = AppData.Ds;
        }

        private void FrmZaposleni_Load(object sender, EventArgs e)
        {
            bsZaposleni.DataSource = Ds;
            bsZaposlenja.DataMember = "FK_Zaposleni_Zaposlenja";
            bsZaposlenja.Sort = "Aktivan DESC, DatumZaposlenOd DESC, DatumZaposlenDo DESC";
            chkAktivniZap.CheckState = CheckState.Checked;
            dgvZaposleni.StandardSort = bsZaposleni.Sort = "Ime, Prezime";
            dgvZaposleni.LoadSettings();
            dgvZaposlenja.LoadSettings();
            PodesiComboBoxove();
            txtFilter.BindingSource = bsZaposleni;
            this.FormStandardSettings();
        }

        /// <summary>
        /// Podesavanje ComboBox kontrola (cmbPodaciZaDohvatanje i cmbIzracunajStatuse):
        /// stavke (Items) i sirina (AdjustWidth).
        /// </summary>
        private void PodesiComboBoxove()
        {
            cmbPodaciZaDohvatanje.Items.AddRange(new[] {
                CmbDohvatiOpste,
                CmbDohvatiDodatno,
                CmbDohvatiSve,
            });
            cmbPodaciZaDohvatanje.AdjustWidth();

            cmbIzracunajStatuse.Items.AddRange(new[] {
                CmbStatusStaz,
                CmbStatusBolovanja,
                CmbStatus40cNedelja,
                CmbStatusDokUgovor,
                CmbStatusDo60DanaIsteklo,
                CmbStatusBezZamenjenih,
            });
            cmbIzracunajStatuse.AdjustWidth();
        }

        private const string CmbDohvatiOpste = "Opšte: ime, prezime, JMBG";
        private const string CmbDohvatiDodatno = "Dodatno: Mejl, tel, adresa, pol, devojačko";
        private const string CmbDohvatiSve = "Sve: zaposlenja, angažovanja i obračuni z.";
        private const string CmbStatusStaz = "Staž";
        private const string CmbStatusBolovanja = "Aktivna bolovanja";
        private const string CmbStatus40cNedelja = "Bez 40-čas nedelje";
        private const string CmbStatusDokUgovor = "Bez dokumenta-ugovora";
        private const string CmbStatusDo60DanaIsteklo = "Istekao ugovor do 60 dana";
        private const string CmbStatusBezZamenjenih = "Zaposlenja bez unetih zamenjenih zaposlenih";

        private readonly Ds Ds;

        private void ChkCopyOnClick_CheckedChanged(object sender, EventArgs e)
            => dgvZaposleni.CopyOnCellClick = dgvZaposlenja.CopyOnCellClick = chkCopyOnClick.Checked;

        private void BtnSaveData_Click(object sender, EventArgs e)
            => AppData.SaveDsData();

        /// <summary>Za dati naziv radnog mesta ili njegov deo,
        /// vraca skup IDeva zaposlenih sa tim radim mestom.</summary>
        private static IEnumerable<int> FilterRadnoMesto(string s, bool aktivnoZap)
        {
            s = s.ToLower();
            var ids = new HashSet<int>();
            foreach (var zap in AppData.Ds.Zaposlenja.Where
                (it => (!aktivnoZap || (aktivnoZap && it.Aktivan)) && it.RadnoMestoNaziv.ToLower().Contains(s)
                || (it.Aktivan && it.VrstaAngazovanja.ToLower().Contains(s))))
                ids.Add(zap.IdZaposlenog);
            return ids;
        }

        private static IEnumerable<int> FilterZamenjeni(string s, bool aktivnoZap)
        {
            s = s.ToLower();
            var ids = new HashSet<int>();
            foreach (var zap in AppData.Ds.Zaposlenja.Where
                (it => (!aktivnoZap || (aktivnoZap && it.Aktivan))
                && !it.IsIdZamenjenogZaposlenogNull() && it._ZamenjeniZaposleni.ToLower().Contains(s)))
                ids.Add(zap.IdZaposlenog);
            return ids;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            try
            {
                var s = LatinicaCirilica.Lat2Cir(txtFilter.Text);
                // filtriranje statusa aktivnosti - izdvajanje redova koji imaju * ili ** ili ***
                if (s != "" && s.StartsWith("*"))
                {
                    bsZaposleni.Filter = $"StatusAktivnosti2 = '*' OR StatusAktivnosti2 = '**' OR StatusAktivnosti2 = '***'";
                    return;
                }
                var aktivnoZap = !s.StartsWith("-");
                if (!aktivnoZap)
                    s = s.Substring(1);
                // osnovna pretraga: ime, prezime, angazovanja, jmbg
                var filter = $"Ime LIKE '%{s}%' OR Prezime LIKE '%{s}%' OR Angazovanja LIKE '%{s}%' OR JMBG LIKE '%{s}%' ";
                // pretraga po zaposlenjima (radna mesta)
                var ids = FilterRadnoMesto(s, aktivnoZap);
                if (ids.Count() > 0)
                    filter += $" OR IdZaposlenog IN ({string.Join(", ", ids)})";
                // pretraga po zamenjenim zaposlenima
                ids = FilterZamenjeni(s, aktivnoZap);
                if (ids.Count() > 0)
                    filter += $" OR IdZaposlenog IN ({string.Join(", ", ids)})";
                // da li je zaposleni aktivan ili ne
                if (chkAktivniZap.CheckState != CheckState.Indeterminate)
                    filter = $"({filter}) AND Aktivan = {chkAktivniZap.Checked}";
                bsZaposleni.Filter = filter;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Pretraga zaposlenih"); }
        }

        private void DgvZaposleni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var drv = dgvZaposleni.CurrentRow.DataBoundItem as System.Data.DataRowView;
            if (drv.Row is Ds.ZaposleniRow zap)
            {
                // otvaranje stranice o zaposlenom u JISPu
                if (e.ColumnIndex == dgvcZapId.Index)
                {
                    var url = $"https://jisp.mpn.gov.rs/regzaposlenih/sekcije/{zap.JMBG}/{zap.IdZaposlenog}";
                    Clipboard.SetText(url);
                }
                // prikaz ili postavljanje slike za zaposlenog
                if (e.ColumnIndex == dgvcImaSliku.Index)
                {
                    if (zap.ImaSliku)
                        SlikeZaposlenih.PrikaziSliku(zap);
                    else
                        if (ofdZapSlika.ShowDialog() == DialogResult.OK)
                    {
                        SlikeZaposlenih.SacuvajSlikuZaZap(ofdZapSlika.FileName, zap.IdZaposlenog);
                        SlikeZaposlenih.PrikaziIkonicu(dgvZaposleni.CurrentRow, dgvcImaSliku.Name);
                    }
                }
                // Ponovno sastavljanje stringa Angazovanje: finansiranje, norma, predmet za sva ang.
                if (e.ColumnIndex == dgvcAngazovanja.Index)
                    zap.CalcAngazovanja();
            }
        }

        private void DgvZaposleni_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
            => SlikeZaposlenih.PrikaziIkonice(dgvZaposleni, dgvcImaSliku.Name);

        private void DgvZaposleni_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1
                && new int[] { dgvcIme.Index, dgvcPrezime.Index, dgvcJMBG.Index }.Contains(e.ColumnIndex))
            {
                new FrmZaposlenja(dgvZaposleni.CurrDataRow<Ds.ZaposleniRow>()).ShowDialog();
            }
        }

        private void DgvZaposleni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                new FrmZaposlenja(dgvZaposleni.CurrDataRow<Ds.ZaposleniRow>()).ShowDialog();
        }

        public IEnumerable<Ds.ZaposleniRow> SelektovaniZaposleni
            => dgvZaposleni.SelectedDataRows<Ds.ZaposleniRow>();

        private async void BtnKvalifStruktura_Click(object sender, EventArgs e)
        {
            var akcija = btnKvalifStruktura.Text;
            btnKvalifStruktura.Text = "...";
            try
            {
                var fileName = "kvalifikaciona_struktura_"
                        + DateTime.Now.ToString(Utils.DatumVremeFormatFileSec) + ".xlsx";
                var filePath = Utils.GetDownloadsFolder(fileName);
                await WebApi.PostForFile(filePath, "ustanova/VratiCenusIzvestajFajl"
                    , "{'idUstanove':'18976','tipIzvestaja':'kvalifikaciona_struktura'}", false);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, akcija); }
            btnKvalifStruktura.Text = akcija;
        }

        private void FrmZaposleni_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvZaposleni.SaveSettings();
            dgvZaposlenja.SaveSettings();
        }

        private void BtnCsvZaposlenja_Click(object sender, EventArgs e)
        {
            Ds.ZaposleniRow tekuciZaposleni = null;
            try
            {
                var sb = new System.Text.StringBuilder("Zaposleni;Radno mesto;Kategorija;Procenat;Tip ugovora;Dodatni koef.;"
                    + "Svi;Nastavnici;Vaspitači;Ostali;Provera"
                    + Environment.NewLine);
                var uracunataAngazovanja = new[] {
                    "На неодређено",
                    "На одређено - до преузимања односно коначности одлуке о избору кандидата по конкурсу",
                    "На одређено - верска настава",
                    "На одређено - директор установе",
                };

                foreach (var zaposleni in Ds.Zaposleni.Where(it => it.Aktivan).OrderBy(it => it.Ime))
                    foreach (var zap in zaposleni.GetZaposlenjaRows().Where(it => it.Aktivan))
                    {
                        tekuciZaposleni = zaposleni;
                        var uracunato = uracunataAngazovanja.Contains(zap.VrstaAngazovanja)
                            ? "DA" : zap.VrstaAngazovanja;
                        var angs = zap.GetAngazovanjaRows();
                        if (angs.Length > 0)
                        {
                            var fin = angs.First().IzvorFinansiranja;
                            if (fin.Contains("стандард"))
                                uracunato = "US";
                            if (fin.Contains("Сопствена"))
                                uracunato = "SS";
                        }
                        var kat = "";
                        if (zap.RadnoMestoNaziv.Contains("Васпитач") || zap.RadnoMestoNaziv.Contains("васпитач"))
                            kat = "Vaspitač";
                        if (zap.RadnoMestoNaziv.Contains("Наставник") || zap.RadnoMestoNaziv.Contains("наставник"))
                            kat = "Nastavnik";
                        if (zap.RadnoMestoNaziv.Contains("Библиотекар")
                            || zap.RadnoMestoNaziv.Contains("Директор")
                            || zap.RadnoMestoNaziv.Contains("Управник")
                            || zap.RadnoMestoNaziv.Contains("Помоћник дир")
                            || zap.RadnoMestoNaziv.Contains("Организатор")
                            || zap.RadnoMestoNaziv.Contains("Шеф рачуноводства")
                            || zap.RadnoMestoNaziv.Contains("Домар")
                            || zap.RadnoMestoNaziv.Contains("Референт")
                            || zap.RadnoMestoNaziv.Contains("Економ")
                            || zap.RadnoMestoNaziv.Contains("Техничар")
                            || zap.RadnoMestoNaziv.Contains("Медицин")
                            || zap.RadnoMestoNaziv.Contains("Радник")
                            || zap.RadnoMestoNaziv.Contains("арадник") // saradnik, Saradnik
                            || zap.RadnoMestoNaziv.Contains("екретар") // sekretar, Sekretar
                            || zap.RadnoMestoNaziv.Contains("увар") // kuvar, Kuvar
                            || zap.RadnoMestoNaziv.Contains("Чистачица")
                            || zap.RadnoMestoNaziv.Contains("Помоћни наставник")
                            )
                            kat = "Ostali";
                        //var koefOpis = zaposleni.GetObracunZaradaRows().Where
                        //    (it => !it.IsIdZaposlenjaNull() && it.IdZaposlenja == zap.IdZaposlenja)
                        //    .FirstOrDefault()?.KoefSveOpis;

                        var ozs = zaposleni.GetObracunZaradaRows().Where
                            (it => !it.IsIdZaposlenjaNull() && it.IdZaposlenja == zap.IdZaposlenja);
                        var poslednji = ObracunZarada.PoslednjiObracuni(ozs.ToArray(), new int[] { zap.IdZaposlenja });
                        var koefOpis = poslednji.FirstOrDefault()?.KoefSveOpis;
                        if (string.IsNullOrEmpty(koefOpis))
                            throw new Exception("Ne postoji opis koeficijenta OZ. Proveriti ovaj podatak i da li uopšte postoji OZ za svaki aktivan ugovor.");

                        var proc = zap.ProcenatRadnogVremena;
                        var svi = uracunato == "DA" ? proc : 0;
                        var nastavnik = uracunato == "DA" && kat == "Nastavnik" ? proc : 0;
                        var vaspitac = uracunato == "DA" && kat == "Vaspitač" ? proc : 0;
                        var ostali = uracunato == "DA" && kat == "Ostali" ? proc : 0;
                        var provera = koefOpis.Contains("Nast") && kat == "Nastavnik"
                            || koefOpis.Contains("Vasp") && kat == "Vaspitač"
                            || koefOpis.Contains("Zap") && kat == "Ostali";

                        sb.AppendLine($"{zaposleni};{zap.RadnoMestoNaziv};{kat};{proc};{uracunato};{koefOpis}"
                            + $";{svi};{nastavnik};{vaspitac};{ostali};{provera}");
                    }

                Clipboard.SetText(sb.ToString());
                Utils.ShowMbox("CSV podaci su kopirani u klipbord.", BtnCsvZaposlenja.Text);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, BtnCsvZaposlenja.Text + " - " + tekuciZaposleni); }
        }

        private void BtnResenja_Click(object sender, EventArgs e)
        {
            new FrmResenja().ShowDialog();
        }

        private void BtnObrazovanje_Click(object sender, EventArgs e)
        {
            new FrmObrazovanje().ShowDialog();
        }

        private void BtnSistematizacija_Click(object sender, EventArgs e)
        {
            new FrmSistematizacija().Show();
        }

        private void BtnSumaAngazovanja_Click(object sender, EventArgs e)
        {
            try
            {
                var sumUcStandard = 0.0;
                var sumBudzetStalno = 0.0;
                var sumBudzetZamena = 0.0;
                var vrste = new List<string>();
                foreach (var zaposleni in AppData.Ds.Zaposleni.Where(it => it.Aktivan))
                    foreach (var ze in zaposleni.GetZaposlenjaRows().Where(it => it.Aktivan))
                    {
                        var zaStalno = ze.VrstaAngazovanja == "На неодређено"
                            || ze.VrstaAngazovanja == "На одређено - до преузимања односно коначности одлуке о избору кандидата по конкурсу";

                        vrste.Add(ze.VrstaAngazovanja);
                        foreach (var ang in ze.GetAngazovanjaRows()
                            .Where(it => it.SkolskaGodina == AppData.SkolskaGodina.Naziv))
                        {
                            if (ang.IzvorFinansiranja.Contains("стандард"))
                                sumUcStandard += ang.ProcenatAngazovanja;
                            if (ang.IzvorFinansiranja.Contains("ОиС образовање"))
                                if (zaStalno)
                                    sumBudzetStalno += ang.ProcenatAngazovanja;
                                else
                                    sumBudzetZamena += ang.ProcenatAngazovanja;
                        }
                    }

                MessageBox.Show(
                    "Uč. standard:\t" + (sumUcStandard / 100).ToString(Utils.DveObavezneCifreFormat) +
                    "\r\nOiS stalno:\t" + (sumBudzetStalno / 100).ToString(Utils.DveObavezneCifreFormat) +
                    "\r\nOiS zamene" +
                    ":\t" + (sumBudzetZamena / 100).ToString(Utils.DveObavezneCifreFormat)
                    );
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private async void BtnDohvatiPodatke_Click(object sender, EventArgs e)
        {
            var selItem = (string)cmbPodaciZaDohvatanje.SelectedItem;

            if (selItem == CmbDohvatiOpste)
                await (sender as UcButton).RunAsync(async () =>
                {
                    var zaps = await WebApi.GetList<Zaposleni>(WebApi.ReqEnum.Zap_Opste);
                    foreach (var zap in zaps)
                        try
                        {
                            var red = Ds.Zaposleni.FindByIdZaposlenog(zap.Id);
                            if (red == null) // novi zaposleni
                            {
                                red = Ds.Zaposleni.NewZaposleniRow();
                                red.IdZaposlenog = zap.Id;
                                red.Ime = zap.Ime;
                                red.Prezime = zap.Prezime;
                                red.JMBG = zap.JMBG;
                                red.Aktivan = (bool)zap.TrenutnoZaposlen;
                                Ds.Zaposleni.AddZaposleniRow(red);
                            }
                            else // update zaposlenog
                            {
                                if (red.Ime != zap.Ime || red.Prezime != zap.Prezime || red.JMBG != zap.JMBG)
                                {
                                    red.Ime = zap.Ime;
                                    red.Prezime = zap.Prezime;
                                    red.JMBG = zap.JMBG;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            if (Utils.ShowMboxYesNo($"Greška: {ex.Message}\r\nNastavi učitavanje?", selItem)
                                != DialogResult.Yes)
                                break;
                        }
                    Utils.ShowMbox("Gotovo", selItem);
                });

            if (selItem == CmbDohvatiDodatno)
                await (sender as UcButton).RunAsync(async () =>
                {
                    foreach (var zap in SelektovaniZaposleni)
                    {
                        var json = await WebApi.GetJson(WebApi.ReqEnum.Zap_Dodatno, zap.IdZaposlenog.ToString());
                        dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
                        zap.Pol = Utils.Pol((int)obj.pol);
                        zap.Prebivaliste = $"{obj.mestoPrebivalistaNaziv}, {obj.adresaPrebivalistaNaziv}, {obj.adresniKodPrebivalista}";
                        if (obj.elektronskaPosta != null)
                        {
                            var list = new List<string>();
                            foreach (var ep in obj.elektronskaPosta)
                                list.Add((string)ep.elektronskaPosta);
                            zap.Email = string.Join(", ", list);
                        }
                        if (obj.telefon != null)
                        {
                            var list = new List<string>();
                            foreach (var ep in obj.telefon)
                                list.Add((string)ep.telefon);
                            zap.Telefon = string.Join(", ", list);
                        }
                        if (obj.devojackoPrezime != null)
                            zap.DevojackoPrezime = obj.devojackoPrezime;
                    }
                });

            if (selItem == CmbDohvatiSve)
                try
                {
                    var brojeviUgovoraZaNedostajuceZamenjene = new List<string>();
                    foreach (var zap in SelektovaniZaposleni)
                        await (sender as UcButton).RunAsync(async () =>
                        {
                            lblStatus.Text = zap.ZaposleniString;
                            var l = await DataGetter.GetZaposlenjaAsync(zap);
                            if (l.Any())
                                brojeviUgovoraZaNedostajuceZamenjene.Add("   " + zap + "\r\n" + string.Join(", ", l));
                            await DataGetter.GetAngazovanjaAsync(zap.GetZaposlenjaRows().Where(it => it.Aktivan));
                            await DataGetter.GetObracuniZaradaAsync(zap);
                            foreach (var oz in zap.GetObracunZaradaRows()
                                .Where(it => it.Godina == AppData.SkolskaGodina.Start || it.Godina == AppData.SkolskaGodina.Kraj))
                                await DataGetter.GetOzDodatnoAsync(oz);
                            zap.CalcAngazovanja();
                        });
                    lblStatus.Text = "";
                    if (brojeviUgovoraZaNedostajuceZamenjene.Any())
                        Utils.ShowMbox(string.Join("\r\n\r\n", brojeviUgovoraZaNedostajuceZamenjene)
                            , "Zaposleni sa ugovorima za zamenu bez zaposlenog koji je zamenjen", true);

                }
                catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void FrmZaposleni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Control)
            {
                txtFilter.SelectAll();
                txtFilter.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TxtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DgvZaposleni_CellDoubleClick(this,
                    new DataGridViewCellEventArgs(dgvcIme.Index, dgvZaposleni.CurrentRow.Index));
                e.SuppressKeyPress = true; // protiv "kling" zvuka
                e.Handled = true; // protiv prelaska u novi red
            }
        }

        /// <summary>
        /// Izracunavanje podataka za svakog zaposlenog i postavljanje rezultata u StatusAktivnosti2.
        /// </summary>
        private void BtnIzracunajStatuse_Click(object sender, EventArgs e)
        {
            Ds.ZaposleniRow zapProblem = null;
            try
            {
                var selItem = (string)cmbIzracunajStatuse.SelectedItem;

                // racunanje staza u prosveti za svakog zaposlenog na osnovu podataka u StazGodine i StazMeseci
                if (selItem == CmbStatusStaz)
                {
                    var frm = new FrmStaz();
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;
                    AppData.SaveSett(AppData.DatumIzvestajaTrezora, frm.DatumIzvestajaTrezora.ToShortDateString());
                    var krajSkGod = new DateTime(AppData.SkolskaGodina.Kraj, 8, 31);
                    var meseciOdIzvestaja = Utils.DiffMonths(frm.DatumIzvestajaTrezora, krajSkGod);
                    foreach (var zap in AppData.Ds.Zaposleni.Where(it => !it.IsStazGodineNull()))
                    {
                        zapProblem = zap;
                        var stazMeseci = zap.StazGodine * 12 + zap.StazMeseci + meseciOdIzvestaja;
                        zap.StatusAktivnosti2 = (stazMeseci / 12) + " / " + (stazMeseci % 12);
                    }
                }

                if (selItem == CmbStatusBolovanja)
                {
                    foreach (var z in AppData.Ds.Zaposleni)
                    {
                        zapProblem = z;
                        z.StatusAktivnosti2 = "";
                        foreach (var zap in z.GetZaposlenjaRows().Where(it => it.Aktivan))
                            foreach (var r in zap.GetResenjaRows()
                                .Where(it => it.AktivnoResenje && it.TipResenja.Contains("одсуству")))
                                z.StatusAktivnosti2 += "*";
                    }
                }

                if (selItem == CmbStatus40cNedelja)
                {
                    foreach (var z in AppData.Ds.Zaposleni)
                    {
                        zapProblem = z;
                        z.StatusAktivnosti2 = "";
                        foreach (var zap in z.GetZaposlenjaRows().Where(it => it.Aktivan))
                        {
                            var imaResenje = zap.GetResenjaRows().Where(it => it.SkolskaGodina == AppData.SkolskaGodina.Naziv && it.TipResenja.Contains("40")).Any();
                            if (!imaResenje)
                                z.StatusAktivnosti2 += "*";
                        }
                    }
                }

                if (selItem == CmbStatusDokUgovor)
                {
                    foreach (var z in AppData.Ds.Zaposleni)
                    {
                        zapProblem = z;
                        z.StatusAktivnosti2 = "";
                        foreach (var zap in z.GetZaposlenjaRows()
                            .Where(it => it.Aktivan && it.IsDokumentIdNull()))
                            z.StatusAktivnosti2 += "*";
                    }
                }

                if (selItem == CmbStatusDo60DanaIsteklo)
                {
                    //TODO ovo da se automatski pokrene svake nedelje (ili jednom dnevno ili sl) uz mbox obavestenje
                    //TODO mozda bi se mogli izuzeti zaposleni na odsustvu (porodiljsko npr.)
                    var zaps = new HashSet<string>();
                    foreach (var z in AppData.Ds.Zaposleni.Where(it => it.Aktivan))
                    {
                        var nja = z.GetZaposlenjaRows().Where(it => it.Aktivan
                            && !it.IsVrstaAngazovanjaNull() && it.VrstaAngazovanja.Contains("до 60 дана")
                            && !it.IsDatumZaposlenOdNull() && (DateTime.Now - it.DatumZaposlenOd).TotalDays >= 60);
                        z.StatusAktivnosti2 = nja.Any() ? "*" : "";
                    }
                }

                // prikazati ugovore za zamene koji nemaju unete podatke o zamenjenom zaposlenom
                // i to za odabranu skolsku godinu
                if (selItem == CmbStatusBezZamenjenih)
                {
                    foreach (var z in AppData.Ds.Zaposleni)
                    {
                        var nja = z.GetZaposlenjaRows().Where(it =>
                            !it.IsVrstaAngazovanjaNull() && it.NedostajeZamenjeni);
                        z.StatusAktivnosti2 = nja.Any() ? string.Join(", ", nja.Select(it => it.BrojUgovoraORadu)) : "";
                    }
                }

                // Sva zaposlenja u skoli
                //var zaps = new HashSet<string>();
                //foreach (var z in AppData.Ds.Zaposleni.Where(it => it.Aktivan))
                //    foreach (var nja in z.GetZaposlenjaRows().Where(it => it.Aktivan))
                //        zaps.Add(nja.RadnoMestoNaziv);
                //Clipboard.SetText(string.Join(Environment.NewLine, zaps));

                var l = new List<string>();
                foreach (var z in AppData.Ds.Zaposleni.Where(it => it.Aktivan))
                    foreach (var nja in z.GetZaposlenjaRows().Where
                        (it => DatumOko1Nov(it.DatumZaposlenOd) ||
                        !it.IsDatumZaposlenDoNull() && DatumOko1Nov(it.DatumZaposlenDo)))
                    {
                        if (!nja.IsRazlogPrestankaZaposlenjaNull())
                            Console.WriteLine(nja.RazlogPrestankaZaposlenja);
                        l.Add(z.ToString());
                        l.Add($"\t{nja.DatumZaposlenOd.ToShortDateString()} - {(nja.IsDatumZaposlenDoNull() ? "/\t" : nja.DatumZaposlenDo.ToShortDateString())}"
                            + $"\t{nja.VrstaAngazovanja}\t{nja.ProcenatRadnogVremena} %");
                    }
                Clipboard.SetText(string.Join(Environment.NewLine, l));

                bsZaposleni.Sort = "StatusAktivnosti2 DESC, " + dgvZaposleni.StandardSort;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnIzracunajStatuse.Text + " - " + zapProblem); }
        }

        /// <summary>Da li je prosledjeni datum +/-5 dana oko 1. nov 2022</summary>
        static bool DatumOko1Nov(DateTime dt)
        {
            var target = new DateTime(2022, 11, 1);
            return target.AddDays(-5) <= dt && dt <= target.AddDays(5);
        }
    }
}
