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
                dgvZaposlenjaSve.StandardSort = bsZaposlenja.Sort;
                dgvZaposlenjaSve.LoadSettings();
                SetBsFilter();

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

        private void SetBsFilter()
        {
            var s = $"IdZaposlenog = {zaposleni.IdZaposlenog}";
            if (chkAktivno.CheckState != CheckState.Indeterminate)
                s += $" AND Aktivan = {chkAktivno.Checked}";
            bsZaposlenja.Filter = s;
        }

        private void ChkAktivno_CheckStateChanged(object sender, EventArgs e)
            => SetBsFilter();

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

        private static bool CheckedCopyOnClick = false;
        private static CheckState? CheckStateAktivno = null;
        private static int TcBottomSelectedIndex = 0;
        private static Point LastLocation = Point.Empty;
        private static Size LastSize = Size.Empty;

        private void FrmZaposlenja_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckedCopyOnClick = chkCopyOnClick.Checked;
            CheckStateAktivno = chkAktivno.CheckState;
            TcBottomSelectedIndex = tcBottom.SelectedIndex;
            if (this.WindowState == FormWindowState.Normal)
            {
                LastLocation = Location;
                LastSize = Size;
            }
            dgvZaposlenjaSve.SaveSettings();
            dgvAngazovanja.SaveSettings();
            dgvObracunZarada.SaveSettings();
        }

        private async void BtnUcitajAngazovanja_Click(object sender, EventArgs e)
        {
            await (sender as UcButton).RunAsync(async () =>
                await DataGetter.GetAngazovanjaAsync(dgvZaposlenjaSve.SelectedDataRows<Ds.ZaposlenjaRow>())
            );
            zaposleni.CalcAngazovanja();
        }

        private async void DgvZaposlenjaSve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvcZapDokument.Index)
                    await Utils.PreuzmiDokument(dgvZaposlenjaSve, e);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void ChkCopyOnClick_CheckedChanged(object sender, EventArgs e)
            => dgvZaposlenjaSve.CopyOnCellClick = dgvAngazovanja.CopyOnCellClick
            = dgvObracunZarada.CopyOnCellClick = dgvResenja.CopyOnCellClick = chkCopyOnClick.Checked;

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
                await DataGetter.GetResenjaAsync(dgvZaposlenjaSve.SelectedDataRows<Ds.ZaposlenjaRow>())
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
                if (dgvZaposlenjaSve.CurrentRow != null)
                {
                    var z = dgvZaposlenjaSve.CurrDataRow<Ds.ZaposlenjaRow>();
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
                    var z = dgvZaposlenjaSve.CurrDataRow<Ds.ZaposlenjaRow>();
                    var zap = (cmbZamenjeni.SelectedItem as DataRowView).Row as Ds.ZaposleniRow;
                    if (z.IsIdZamenjenogZaposlenogNull() || z.IdZamenjenogZaposlenog != zap.IdZaposlenog)
                        z.IdZamenjenogZaposlenog = zap.IdZaposlenog;
                }
                catch { }
        }

        private void BtnZamenjeniBrisi_Click(object sender, EventArgs e)
        {
            var nje = dgvZaposlenjaSve.CurrDataRow<Ds.ZaposlenjaRow>();
            nje.SetIdZamenjenogZaposlenogNull();
            cmbZamenjeni.SelectedIndex = -1;
        }
    }
}
