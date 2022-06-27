using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
            bsZaposlenja.Sort = "Aktivan DESC";
            chkAktivniZap.CheckState = CheckState.Checked;
            dgvZaposleni.StandardSort = bsZaposleni.Sort = "Ime";
            dgvZaposleni.LoadSettings();
            dgvZaposlenja.LoadSettings();
        }

        private readonly Ds Ds;

        private void ChkCopyOnClick_CheckedChanged(object sender, EventArgs e)
            => dgvZaposleni.CopyOnCellClick = dgvZaposlenja.CopyOnCellClick = chkCopyOnClick.Checked;

        private void BtnSaveData_Click(object sender, EventArgs e)
            => AppData.SaveDsData();

        /// <summary>Za dati naziv radnog mesta ili njegov deo,
        /// vraca skup IDeva zaposlenih sa tim radim mestom.</summary>
        private static IEnumerable<int> FilterZaposleniIDs(string s)
        {
            s = s.ToLower();
            var ids = new HashSet<int>();
            foreach (var zap in AppData.Ds.Zaposlenja.Where
                (it => it.Aktivan && it.RadnoMestoNaziv.ToLower().Contains(s)))
                ids.Add(zap.IdZaposlenog);
            return ids;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            try
            {
                var s = txtFilter.Text;
                // osnovna pretraga: ime, prezime, devPrezime, jmbg
                var filter = $"Ime LIKE '%{s}%' OR Prezime LIKE '%{s}%' OR Angazovanja LIKE '%{s}%' OR JMBG LIKE '%{s}%' ";
                // pretraga po zaposlenjima (radna mesta)
                var ids = FilterZaposleniIDs(s);
                if (ids.Count() > 0)
                    filter += $" OR IdZaposlenog IN ({string.Join(", ", ids)})";
                // da li je zaposleni aktivan ili ne
                if (chkAktivniZap.CheckState != CheckState.Indeterminate)
                    filter = $"({filter}) AND Aktivan = {chkAktivniZap.Checked}";
                bsZaposleni.Filter = filter;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Pretraga zaposlenih"); }
        }

        /// <summary>Dohvatanje podataka o zaposlenima (ime, prezime, JMBG).</summary>
        private async void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
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
                        if (Utils.ShowMboxYesNo($"Greška: {ex.Message}\r\nNastavi učitavanje?", btnLoadData.Text)
                            != DialogResult.Yes)
                            break;
                    }
                Utils.ShowMbox("Gotovo", btnLoadData.Text);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnLoadData.Text); }
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
                var zap = dgvZaposleni.CurrDataRow<Ds.ZaposleniRow>();
                new FrmZaposlenja(zap).ShowDialog();
            }
        }

        private async void BtnLoadDataExtra_Click(object sender, EventArgs e)
        {
            var akcija = btnLoadDataExtra.Text;
            btnLoadDataExtra.Text = "...";
            try
            {
                var zaps = dgvZaposleni.SelectedDataRows<Ds.ZaposleniRow>();
                foreach (var zap in zaps)
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
            }
            catch (Exception ex) { Utils.ShowMbox(ex, akcija); }
            btnLoadDataExtra.Text = akcija;
        }

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
                    , "{'idUstanove':'18976','tipIzvestaja':'kvalifikaciona_struktura'}");
            }
            catch (Exception ex) { Utils.ShowMbox(ex, akcija); }
            btnKvalifStruktura.Text = akcija;
        }

        private void FrmZaposleni_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvZaposleni.SaveSettings();
            dgvZaposlenja.SaveSettings();
        }

        private async void BtnUcitajZaposlenja_Click(object sender, EventArgs e)
        {
            var zaposleni = dgvZaposleni.SelectedDataRows<Ds.ZaposleniRow>();
            foreach (var zap in zaposleni)
                await (sender as Controls.UcButton).RunAsync(async () =>
                {
                    lblStatus.Text = zap.Ime;
                    await DataGetter.GetZaposlenjaAsync(zap);
                    await DataGetter.GetAngazovanjaAsync(zap.GetZaposlenjaRows().Where(it => it.Aktivan));
                    await DataGetter.GetObracuniZaradaAsync(zap);
                    var ozs = Classes.ObracunZarada.ObracunZarada.PoslednjiObracuni(zap.GetObracunZaradaRows());
                    foreach (var oz in ozs)
                        await DataGetter.GetOzOpisAsync(oz);
                    zap.CalcAngazovanja();
                });
            lblStatus.Text = "";
        }

        private void BtnCsvZaposlenja_Click(object sender, EventArgs e)
        {
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
                            )
                            kat = "Ostali";
                        var koefOpis = zaposleni.GetObracunZaradaRows().Where
                            (it => !it.IsIdZaposlenjaNull() && it.IdZaposlenja == zap.IdZaposlenja)
                            .FirstOrDefault()?.KoefSveOpis;

                        var proc = zap.ProcenatRadnogVremena;
                        var svi = uracunato == "DA" ? proc : 0;
                        var nastavnik = uracunato == "DA" && kat == "Nastavnik" ? proc : 0;
                        var vaspitac = uracunato == "DA" && kat == "Vaspitač" ? proc : 0;
                        var ostali = uracunato == "DA" && kat == "Ostali" ? proc : 0;
                        var provera = koefOpis.Contains("Nast") && (kat == "Nastavnik" || kat == "Vaspitač")
                            || koefOpis.Contains("Zap") && kat == "Ostali";

                        sb.AppendLine($"{zaposleni};{zap.RadnoMestoNaziv};{kat};{proc};{uracunato};{koefOpis}"
                            + $";{svi};{nastavnik};{vaspitac};{ostali};{provera}");
                    }

                Clipboard.SetText(sb.ToString());
            }
            catch (Exception ex) { Utils.ShowMbox(ex, BtnCsvZaposlenja.Text); }
        }
    }
}
