using JISP.Classes;
using JISP.Classes.ObracunZarada;
using JISP.Controls;
using JISP.Data;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmZaposlenja : Form
    {
        public FrmZaposlenja(Ds.ZaposleniRow zap)
        {
            InitializeComponent();

            try
            {
                zaposleni = zap;
                Text = $"Zaposlenja ({zap})";
                this.FormStandardSettings();

                chkBezTehnGresaka.Checked = CheckedBezTehnGresaka;
                chkCopyOnClick.Checked = CheckedCopyOnClick;
                if (CheckStateAktivno.HasValue)
                    chkAktivno.CheckState = CheckStateAktivno.Value;
                tcBottom.SelectedIndex = TcBottomSelectedIndex;
                if (LastLocation != Point.Empty)
                {
                    StartPosition = FormStartPosition.Manual;
                    Location = LastLocation;
                }
                if (LastSize != Size.Empty)
                    Size = LastSize;

                bsZaposleni.DataSource = AppData.Ds;

                bsZaposlenja.DataSource = AppData.Ds;
                dgvZaposlenjaSvSava.StandardSort = bsZaposlenja.Sort;
                dgvZaposlenjaSvSava.LoadSettings();
                SetBsZaposlenjaFilter();

                // Sumirana tj. sva zaposlenja, staz
                bsTipoviPoslodavaca.DataSource = AppData.Ds;
                bsSvaZaposlenja.DataSource = AppData.Ds;
                dgvSvaZaposlenja.StandardSort = bsSvaZaposlenja.Sort;
                dgvSvaZaposlenja.LoadSettings();
                bsSvaZaposlenja.Filter = $"IdZaposlenog = {zaposleni.IdZaposlenog}";
                dtpStazDatumDo.Value = stazDatumDo;
                dgvSvaZaposlenja.SelectAll();

                dgvAngazovanja.LoadSettings();

                bsObracunZarada.DataSource = AppData.Ds;
                dgvObracunZarada.LoadSettings();
                bsObracunZarada.Filter = $"IdZaposlenog = {zaposleni.IdZaposlenog}";
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private readonly Ds.ZaposleniRow zaposleni;

        private async void BtnUcitajZaposlenja_Click(object sender, EventArgs e)
        {
            await (sender as UcButton).RunAsync(async () =>
                {
                    var l = await DataGetter.GetZaposlenjaAsync(zaposleni);
                    if (l.Any())
                        Utils.ShowMbox(string.Join(Environment.NewLine, l)
                            , "Ugovori za zamene bez podatka o zaposlenom koji je zamenjen", true);
                }
            );
            zaposleni.CalcAngazovanja();
        }

        private void SetBsZaposlenjaFilter()
        {
            var s = $"IdZaposlenog = {zaposleni.IdZaposlenog}";
            if (chkAktivno.CheckState != CheckState.Indeterminate)
                s += $" AND Aktivan = {chkAktivno.Checked}";
            if (chkBezTehnGresaka.Checked)
                s += " AND (RazlogPrestankaZaposlenja IS NULL OR RazlogPrestankaZaposlenja NOT LIKE '%Техничка грешка%')";
            bsZaposlenja.Filter = s;
        }

        private void ChkAktivno_CheckStateChanged(object sender, EventArgs e)
            => SetBsZaposlenjaFilter();

        private void ChkBezTehnGresaka_CheckedChanged(object sender, EventArgs e)
            => SetBsZaposlenjaFilter();

        private async void BtnUcitajObracunZarada_Click(object sender, EventArgs e)
        {
            await (sender as UcButton).RunAsync(async () =>
                await DataGetter.GetObracuniZaradaAsync(zaposleni)
            );
            dgvObracunZarada.DisplayPositionRowCount();
            dgvObracunZarada.SelectAll();
        }

        private async void BtnObrisiObracune_Click(object sender, EventArgs e)
        {
            if (Utils.ShowMboxYesNo("Da li ste sigurni?", btnObrisiObracune.Text) == DialogResult.Yes)
                await (sender as UcButton).RunAsync(async () =>
                {
                    var ozs = dgvObracunZarada.SelectedDataRows<Ds.ObracunZaradaRow>();
                    if (ozs.Any(it => it.IdObracuna < 0))
                        throw new Exception("Id obračuna nije ispravan. Potrebno je ponovo učitati obračune.");
                    foreach (var oz in ozs)
                    {
                        var body = $"{{\"id\":{oz.IdObracuna},\"jeObrisano\":null,\"datumKreiranja\":\"0001-01-01T00:00:00\",\"idSesijeKreiranja\":null,\"idKorisnikaKreiranja\":null,\"datumIzmene\":null,\"idSesijeIzmene\":null,\"idKorisnikaIzmene\":null,\"vremenskiZig\":null,\"regZapObracunZaradaDouniverzitetskoObrazovanjeId\":0,\"godinaSifarnik\":null,\"godinaBroj\":{oz.Godina},\"mesecSifarnik\":null,\"mesecSifarnikNaziv\":\"{oz.MesecNaziv}\",\"mesecBroj\":null,\"osnovniKoeficijentZaposlenog\":{oz.OsnovniKoef:0.00},\"dodatniKoeficijentZaposlenog\":null,\"koeficijentZaStaresinstvo\":null,\"normaZaposlenog\":{oz.Norma:0.00},\"brojUgovora\":\"{oz.BrojUgovora}\",\"dodatniKoeficijentZaPredsednikaSindikataUstanove\":null,\"procenatAngazovanjaNaPlaninskojLokaciji\":null,\"regZapObracunZaradaDouniverzitetskoObrazovanje\":null,\"regZapObracunZaradaDouniverzitetskoObrazovanjeDodatniKoef\":null,\"regZapObracunZaradaDouniverzitetskoObrazovanjeDodKoefMulti\":null,\"regZapObracunZaradaDouniverzitetskoObrazovanjeDodKoefMultiInt\":null}}";
                        await WebApi.PostForJson(WebApi.ReqEnum.Zap_ObracunZaradaObrisi, body);
                    }
                });
            btnUcitajObracunZarada.PerformClick();
        }

        private static DateTime stazDatumDo = DateTime.Today;
        /// <summary>Datum do kog se sumiraju zaposlenja i racuna staz u FrmZaposlenja, tab Sum. Zaposlenja.</summary>
        public static DateTime StazDatumDo => stazDatumDo;

        private static bool CheckedBezTehnGresaka = true;
        private static bool CheckedCopyOnClick = false;
        private static CheckState? CheckStateAktivno = null;
        private static int TcBottomSelectedIndex = 0;
        private static Point LastLocation = Point.Empty;
        private static Size LastSize = Size.Empty;

        private void FrmZaposlenja_FormClosed(object sender, FormClosedEventArgs e)
        {
            stazDatumDo = dtpStazDatumDo.Value;
            CheckedBezTehnGresaka = chkBezTehnGresaka.Checked;
            CheckedCopyOnClick = chkCopyOnClick.Checked;
            CheckStateAktivno = chkAktivno.CheckState;
            TcBottomSelectedIndex = tcBottom.SelectedIndex;
            if (this.WindowState == FormWindowState.Normal)
            {
                LastLocation = Location;
                LastSize = Size;
            }
            dgvZaposlenjaSvSava.SaveSettings();
            dgvSvaZaposlenja.SaveSettings();
            dgvAngazovanja.SaveSettings();
            dgvObracunZarada.SaveSettings();
        }

        private async void BtnUcitajAngazovanja_Click(object sender, EventArgs e)
        {
            await (sender as UcButton).RunAsync(async () =>
                await DataGetter.GetAngazovanjaAsync(dgvZaposlenjaSvSava.SelectedDataRows<Ds.ZaposlenjaRow>())
            );
            zaposleni.CalcAngazovanja();
        }

        private async void DgvZaposlenjaSve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvcZapDokument.Index)
                    await Utils.PreuzmiDokument(dgvZaposlenjaSvSava, e);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void ChkCopyOnClick_CheckedChanged(object sender, EventArgs e)
            => dgvZaposlenjaSvSava.CopyOnCellClick = dgvSvaZaposlenja.CopyOnCellClick
            = dgvAngazovanja.CopyOnCellClick = dgvObracunZarada.CopyOnCellClick = dgvResenja.CopyOnCellClick
            = chkCopyOnClick.Checked;

        private async void BtnUcitajOzOpis_Click(object sender, EventArgs e)
        {
            foreach (var oz in dgvObracunZarada.SelectedDataRows<Ds.ObracunZaradaRow>())
                await (sender as UcButton).RunAsync(async () =>
                    await DataGetter.GetOzDodatnoAsync(oz)
                );
        }

        private async void BtnUcitajResenja_Click(object sender, EventArgs e)
        {
            await (sender as UcButton).RunAsync(async () =>
                await DataGetter.GetResenjaAsync(dgvZaposlenjaSvSava.SelectedDataRows<Ds.ZaposlenjaRow>())
            );
        }

        private async void DgvResenja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvcResDokument.Index)
                await Utils.PreuzmiDokument(dgvResenja, e);
        }

        private void DgvZaposlenjaSve_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var comboVisible = false;
                if (dgvZaposlenjaSvSava.CurrentRow != null)
                {
                    var z = dgvZaposlenjaSvSava.CurrDataRow<Ds.ZaposlenjaRow>();
                    if (!z.IsVrstaAngazovanjaNull() && z.VrstaAngazovanja.Contains("замена"))
                    {
                        comboVisible = true;
                        if (!z.IsIdZamenjenogZaposlenogNull())
                            cmbZamenjeni.SelectedValue = z.IdZamenjenogZaposlenog;
                        else
                            cmbZamenjeni.SelectedIndex = -1;
                    }
                }
                cmbZamenjeni.Visible = lblZamenjeni.Visible = btnZamenjeniBrisi.Visible = comboVisible;
            }
            catch { }
        }

        private void CmbZamenjeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZamenjeni.SelectedItem != null)
                try
                {
                    var z = dgvZaposlenjaSvSava.CurrDataRow<Ds.ZaposlenjaRow>();
                    var zap = (cmbZamenjeni.SelectedItem as DataRowView).Row as Ds.ZaposleniRow;
                    if (z.IsIdZamenjenogZaposlenogNull() || z.IdZamenjenogZaposlenog != zap.IdZaposlenog)
                        z.IdZamenjenogZaposlenog = zap.IdZaposlenog;
                }
                catch { }
        }

        private void BtnZamenjeniBrisi_Click(object sender, EventArgs e)
        {
            var nje = dgvZaposlenjaSvSava.CurrDataRow<Ds.ZaposlenjaRow>();
            nje.SetIdZamenjenogZaposlenogNull();
            cmbZamenjeni.SelectedIndex = -1;
        }

        private void FrmZaposlenja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void DgvSvaZaposlenja_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var ukStaz = new Datum();
                if (dgvSvaZaposlenja.SelectedRows.Count > 0)
                {
                    foreach (var z in dgvSvaZaposlenja.SelectedDataRows<Ds.SumZaposlenjaRow>())
                        ukStaz = Staz.Zbir(ukStaz, Datum.IzStringa(z.Staz));
                }
                lblUkupanStaz.Text = "Ukupan staž: " + ukStaz;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Sva Zaposlenja"); }
        }

        private void DtpStazDatumDo_ValueChanged(object sender, EventArgs e)
        {
            AppData.Ds.SumZaposlenja.SumZaposlenjaUSkoli(zaposleni, dtpStazDatumDo.Value);
            if (tcZaposlenja.SelectedTab == tpZaposSva)
            {
                timSvaZapSelectAll.Stop();
                timSvaZapSelectAll.Start();
            }
        }

        private void TimSvaZapSelectAll_Tick(object sender, EventArgs e)
        {
            timSvaZapSelectAll.Stop();
            dgvSvaZaposlenja.SelectAll();
        }

        private bool prvoPrebacivanjeNaTpZaposSva = true;
        private void TcZaposlenja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prvoPrebacivanjeNaTpZaposSva && tcZaposlenja.SelectedTab == tpZaposSva)
                timSvaZapSelectAll.Start();
            prvoPrebacivanjeNaTpZaposSva = false;
        }

        private void BtnNovoEkstZaposlenje_Click(object sender, EventArgs e)
        {
            var frm = new FrmNovoEksternoZaposlenje();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var z = AppData.Ds.SumZaposlenja.NewSumZaposlenjaRow();
                    z.ZaposleniRow = zaposleni;
                    z.ProcenatAngazovanja = frm.Procenat;
                    z.DatumOd = frm.DatumOd;
                    z.DatumDo = frm.DatumDo;
                    z.Staz = frm.Staz;
                    z.IdTipaPoslodavca = frm.IdTipaPoslodavca;
                    if (!string.IsNullOrEmpty(frm.NazivPoslodavca))
                        z.NazivPoslodavca = frm.NazivPoslodavca;
                    if (!string.IsNullOrEmpty(frm.Napomene))
                        z.Napomene = frm.Napomene;
                    AppData.Ds.SumZaposlenja.AddSumZaposlenjaRow(z);
                    dgvSvaZaposlenja.SelectAll();
                }
                catch (Exception ex) { Utils.ShowMbox(ex, frm.Text); }
            }
        }

        private void DgvSvaZaposlenja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var sz = dgvSvaZaposlenja.CurrDataRow<Ds.SumZaposlenjaRow>();
                chkAktivno.CheckState = CheckState.Indeterminate;
                tcZaposlenja.SelectedTab = tpZaposSvetiSava;
                var zapIDs = sz.GetSumZapDetaljiRows().Select(it => it.IdZaposlenja);
                foreach (DataGridViewRow row in dgvZaposlenjaSvSava.Rows)
                    row.Selected = zapIDs.Contains(dgvZaposlenjaSvSava.DataRow<Ds.ZaposlenjaRow>(row.Index).IdZaposlenja);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Sumarno zaposlenje"); }
        }
    }
}
