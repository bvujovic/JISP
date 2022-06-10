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
                    //B Utils.GoToLink(url);
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
    }
}
