using JISP.Classes;
using JISP.Controls;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmProstorije : Form
    {
        public FrmProstorije()
        {
            InitializeComponent();
        }

        private void FrmProstorije_Load(object sender, EventArgs e)
        {
            bsLokacije.DataSource = AppData.Ds.Lokacije;
            dgvLokacije.TsmiSelekcija(false);
            dgvObjekti.TsmiSelekcija(false);
            dgvProstorije.TsmiSelekcija(false);
            PodesiCmbProstorijeSprat();
            PodesiCmbPodaciZaDohvatanje();
            lblStatistika.Text = "";
            this.FormStandardSettings();
        }

        private void PodesiCmbProstorijeSprat()
        {
            cmbProstorijeSprat.Items.Clear();
            //B Where(it => !it.IsSpratNull()).
            cmbProstorijeSprat.Items.AddRange(AppData.Ds.Prostorije.Select(it => it.Sprat)
                .Distinct().OrderBy(it => it).ToArray());
            cmbProstorijeSprat.AdjustWidth();
        }

        private void PodesiCmbPodaciZaDohvatanje()
        {
            cmbPodaciZaDohvatanje.Items.Clear();
            cmbPodaciZaDohvatanje.Items.AddRange(new[] {
                CmbDohvatiOsnovno,
                CmbDohvatiProstorijeDodatno,
            });
            cmbPodaciZaDohvatanje.AdjustWidth();
        }

        private const string CmbDohvatiOsnovno = "Osnovno: lokacije, objekti, prostorije";
        private const string CmbDohvatiProstorijeDodatno = "Prostorije dodatno: sprat, grejanje, hlađenje...";

        private async void BtnDohvatiPodatke_Click(object sender, EventArgs e)
        {
            var selItem = (string)cmbPodaciZaDohvatanje.SelectedItem;

            if (selItem == CmbDohvatiOsnovno)
                await (sender as UcButton).RunAsync(async () =>
                {
                    await DataGetter.GetLokacijeAsync();
                    await DataGetter.GetObjektiAsync();
                    await DataGetter.GetProstorijeOsnovnoAsync();
                });

            if (selItem == CmbDohvatiProstorijeDodatno)
                await (sender as UcButton).RunAsync(async () =>
                {
                    if (AppData.Ds.SifSpratovi.Count == 0)
                        await DataGetter.GetSpratoviAsync();
                    if (AppData.Ds.SifGrejanja.Count == 0)
                        await DataGetter.GetGrejanjaAsync();
                    if (AppData.Ds.SifHladjenja.Count == 0)
                        await DataGetter.GetHladjenjaAsync();

                    foreach (var p in DgvProstorijeSelectedRows())
                        await DataGetter.GetProstorijeDodatnoAsync(p.IdProstorije);
                });
        }

        public bool IsDgvProstorijeSelectedRowsEmpty()
            => dgvProstorije.SelectedRows.Count == 0;

        public IEnumerable<Ds.ProstorijeRow> DgvProstorijeSelectedRows()
            => dgvProstorije.SelectedDataRows<Ds.ProstorijeRow>();

        public bool IsDgvProstorijeCurrentRowNull()
            => dgvProstorije.CurrentRow == null;

        public Ds.ProstorijeRow DgvProstorijeCurrentRow()
            => dgvProstorije.CurrDataRow<Ds.ProstorijeRow>();

        private void BtnRacunari_Click(object sender, EventArgs e)
        {
            frmRacunari = new FrmRacunari(this);
            dgvProstorije.CurrentCellChanged += frmRacunari.ProstorijeCurrentRowChanged;
            frmRacunari.Show();
            if (Screen.PrimaryScreen.WorkingArea.Height - Top - Height > FrmRacunari.INIT_HEIGHT)
            {
                frmRacunari.StartPosition = FormStartPosition.Manual;
                frmRacunari.Top = Top + Height + 5;
                frmRacunari.Left = Left + 5;
            }
        }

        private FrmRacunari frmRacunari;

        private void FrmProstorije_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmRacunari != null && !frmRacunari.Disposing && !frmRacunari.IsDisposed)
            {
                dgvProstorije.CurrentCellChanged -= frmRacunari.ProstorijeCurrentRowChanged;
                frmRacunari.Close();
            }
        }

        private void DgvProstorije_SelectionChanged(object sender, EventArgs e)
        {
            var imaPosla = true;
            if (dgvProstorije.SelectedCells.Count <= 1)
                imaPosla = false;
            var cells = dgvProstorije.SelectedCells.Cast<DataGridViewCell>();
            var cols = cells.Select(it => it.ColumnIndex).Distinct();
            if (cols.Count() == 0 || cols.Count() > 1)
                imaPosla = false;
            var numTypes = new Type[] { typeof(int), typeof(float), typeof(double) };
            if (imaPosla && !numTypes.Contains(dgvProstorije.Columns[cols.First()].ValueType))
                imaPosla = false;

            if (imaPosla)
            {
                var sum = cells.Sum(it => (double)it.Value);
                lblStatistika.Text = $"Broj: {cells.Count()}\r\nSuma: {sum}";
            }
            else
                lblStatistika.Text = string.Empty;
        }

        private void TxtProstorijeNaziv_TextChanged(object sender, EventArgs e)
            => ProstorijeFilter();

        private void TxtProstorijeTip_TextChanged(object sender, EventArgs e)
            => ProstorijeFilter();

        private void CmbSprat_SelectedIndexChanged(object sender, EventArgs e)
            => ProstorijeFilter();

        private void ProstorijeFilter()
        {
            try
            {
                var uslovi = new List<string>();
                if (txtProstorijeNaziv.Text != "")
                    uslovi.Add($"NazivProstorije LIKE '%{txtProstorijeNaziv.Text}%'");
                if (txtProstorijeTip.Text != "")
                    uslovi.Add($"TipProstorije LIKE '%{txtProstorijeTip.Text}%'");
                if (cmbProstorijeSprat.SelectedItem != null)
                    uslovi.Add($"Sprat = '{cmbProstorijeSprat.SelectedItem}'");
                bsProstorije.Filter = string.Join(" AND ", uslovi);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Filtriranje prostorija"); }
        }

        private void BtnProstorijeReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtProstorijeNaziv.Text = txtProstorijeTip.Text = "";
                cmbProstorijeSprat.SelectedItem = null;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Filtriranje prostorija"); }
        }

        private void TxtProstorijeFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnProstorijeReset.PerformClick();
        }

        private async void DgvProstorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1 && e.RowIndex != -1)
                // klik na zaglavlje reda: cuvanje izmenjenih podataka tekucoj prostoriji u JISPu
                {
                    var p = dgvProstorije.CurrDataRow<Ds.ProstorijeRow>();
                    if (p.RowState != DataRowState.Unchanged)
                    {
                        var idLokacije = AppData.Ds.Objekti.First(it => it.IdObjekta == p.IdObjekta).IdLokacije;
                        var body = $@"
{{
    ""nazivProstorije"": ""{p.NazivProstorije}"",
    ""sprat"": {p.IdSprata},
    ""povrsina"": ""{p.Povrsina}"",
    ""prosecnaVisinaPlafona"": {p.ProsecnaVisinaPlafona},
    ""tipProstorije"": {p.IdTipaProstorije},
    ""dostupnostLicimaSaSpecijalnimPotrebama"": ""{p.DostupLicimaSaSpecPotrebama.ToString().ToLower()}"",
    ""vrstaIzvoraGrejanja"": {(p.IsIdVrsteIzvoraGrejanjaNull() ? "null" : p.IdVrsteIzvoraGrejanja.ToString())},
    ""vrstaIzvoraHladjenja"": {(p.IsIdVrsteIzvoraHladjenjaNull() ? "null" : p.IdVrsteIzvoraHladjenja.ToString())},
    ""idUstanove"": {WebApi.SV_SAVA_ID},
    ""idLokacije"": {idLokacije},
    ""mobilniInternet"": ""{p.MobilniInternet}"",
    ""brzinaBezicnogInterneta"": ""{p.BrzinaBezicnogInterneta}"",
    ""brzinaLanPrikljucka"": ""{p.BrzinaLanPrikljucka}"",
    ""napomena"": null,
    ""nazivSekcije"": ""Општи подаци о просторији"",
    ""registarId"": 1,
    ""daLiJeDraft"": false,
    ""zahtevId"": 0,
    ""regUstUstanovaId"": {WebApi.SV_SAVA_ID},
    ""objekatIdDrugi"": {p.IdObjekta},
    ""prostorijaSeKoristi"": {p.ProstorijaSeKoristi.ToString().ToLower()},
    ""izvorGrejanja"": {p.IzvorGrejanja.ToString().ToLower()},
    ""izvorHladjenja"": {p.IzvorHladjenja.ToString().ToLower()},
    ""idObjekta"": {p.IdObjekta},
    ""id"": {p.IdProstorije}
}}";
                        var x = await WebApi.PostForJson(WebApi.ReqEnum.Ustanova_ProstorijeAzuriraj, body);
                        Utils.ShowMbox("OK", "Čuvanje podataka o prostoriji");
                    }
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Čuvanje podataka o prostoriji"); }
        }
    }
}
