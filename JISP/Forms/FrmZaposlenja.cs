using JISP.Classes;
using JISP.Classes.ObracunZarada;
using JISP.Controls;
using JISP.Data;
using System;
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
                await DataGetter.GetZaposlenjaAsync(zaposleni)
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

        /// <summary>Klik na checkBox celiju ImaObracunTemplate -> kopiranje OZ template-a u clipboard.</summary>
        private void DgvZaposlenjaSve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;
                var zap = dgvZaposlenjaSve.CurrDataRow<Ds.ZaposlenjaRow>();
                if (zap.ImaObracunTemplate)
                    Clipboard.SetText(zap.ObracunTemplate);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, this.Text); }
        }

        private void ChkCopyOnClick_CheckedChanged(object sender, EventArgs e)
            => dgvZaposlenjaSve.CopyOnCellClick = dgvAngazovanja.CopyOnCellClick
            = dgvObracunZarada.CopyOnCellClick = chkCopyOnClick.Checked;

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
                await Utils.PreuzmiDokumentResenja(dgvResenja, e);
        }
    }
}
