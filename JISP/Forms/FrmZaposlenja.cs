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

                chkCopyOnClick.Checked = CheckedCopyOnClick;
                if (CheckStateAktivno.HasValue)
                    chkAktivno.CheckState = CheckStateAktivno.Value;
                if (CheckedIndicesMeseci != null)
                    foreach (var cim in CheckedIndicesMeseci)
                        lstchkMeseci.SetItemChecked((int)cim, true);
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
                numOzGodina.Value = DateTime.Now.Year;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private readonly Ds.ZaposleniRow zaposleni;
        private Ds.ZaposlenjaDataTable Zaposlenja => AppData.Ds.Zaposlenja;

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

        private async void BtnKreirajObracune_Click(object sender, EventArgs e)
        {
            await (sender as UcButton).RunAsync(async () =>
            {
                if (lstchkMeseci.CheckedItems.Count == 0)
                    throw new Exception("Potrebno je čekirati mesece za koje će se generisati novi obračuni.");
                var zaps = dgvZaposlenjaSve.SelectedDataRows<Ds.ZaposlenjaRow>();
                if (zaps.Count() > 1)
                    throw new Exception("Potrebno je selektovati tačno 1 red (zaposlenje) za koje će se dodati novi obračuni zarada.");
                var zap = zaps.First();
                if (!zap.ImaObracunTemplate)
                    throw new Exception("Selektovano zaposlenje nema zapamćen template za obračun zarada - klik na dugme Dodaj OZ Template.");

                var god = (int)numOzGodina.Value;
                var unetiOZovi = AppData.Ds.ObracunZarada.Where(it => it.BrojUgovora == zap.BrojUgovoraORadu
                    && it.Godina == god).ToArray();
                var dupliMeseci = new System.Collections.Generic.List<int>();
                foreach (int idxMesec in lstchkMeseci.CheckedIndices)
                {
                    var mes = idxMesec + 1;
                    //TODO videti sta valja uciniti sa ovom proverom vec unetih OZova
                    //if (unetiOZovi.Where(it => it.MesecNaziv == OzMesec.NazivMeseca(mes)
                    //    && it.Godina == god).Any())
                    //    dupliMeseci.Add(mes);
                    //else
                    {
                        string strNoviUnos = ObracunZarada.KreirajNoviUnos(zap.ObracunTemplate, god, mes);
                        await WebApi.PostForJson(WebApi.ReqEnum.Zap_ObracunZaradaKreiraj, strNoviUnos);
                    }
                }
                if (dupliMeseci.Any())
                    throw new Exception($"Obračuni zarada za mesece ({string.Join(", ", dupliMeseci)}) već postoje.");
            });
            btnUcitajObracunZarada.PerformClick();
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
        private static CheckedListBox.CheckedIndexCollection CheckedIndicesMeseci = null;
        private static int TcBottomSelectedIndex = 0;
        private static Point LastLocation = Point.Empty;
        private static Size LastSize = Size.Empty;

        private void FrmZaposlenja_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckedCopyOnClick = chkCopyOnClick.Checked;
            CheckStateAktivno = chkAktivno.CheckState;
            CheckedIndicesMeseci = lstchkMeseci.CheckedIndices;
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

        private void BtnDodajOZTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                var strBash = Clipboard.GetText();
                ClipboardSadrziString(strBash, "regZapObracunZaradaDouniverzitetskoObrazovanjeMesec");
                ClipboardSadrziString(strBash, "ukupanDodatniKoeficijentPoRM");
                string strJson = ObracunZarada.Bash2Json(strBash);
                dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(strJson);
                string idZaposlenja = obj.idNavigation.id;

                var zap = AppData.Ds.Zaposlenja.FindByIdZaposlenja(int.Parse(idZaposlenja));
                if (zap == null)
                    throw new Exception($"Zaposlenje sa IDem {idZaposlenja} nije pronađeno.");
                if (zap.ZaposleniRow.IdZaposlenog != zaposleni.IdZaposlenog)
                    throw new Exception($"U clipboard-u je OZ template ugovora koji pripada zaposlenom {zap.ZaposleniRow}.");
                zap.ObracunTemplate = strJson;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnDodajOZTemplate.Text); }
        }

        /// <summary>Ako prosledjeni haystack ne sadrzi needle - izbacuje se Exception.</summary>
        private void ClipboardSadrziString(string haystack, string needle)
        {
            if (!haystack.Contains(needle))
                throw new Exception($"Text iz clipboard-a ne sadrži '{needle}' tako da verovatno ne predstavlja JSON telo poruke API metodu SacuvajObracunZarade.");
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

        private void OzGodinaMesec_Changed(object sender, EventArgs e)
        {
            try
            {
                var vanTekuce = false;
                var god = (int)numOzGodina.Value;
                foreach (int idx in lstchkMeseci.CheckedIndices)
                {
                    if (god == AppData.SkolskaGodina.Start && idx < 8)
                        vanTekuce = true;
                    if (god == AppData.SkolskaGodina.Kraj && idx >= 8)
                        vanTekuce = true;
                }
                if (lstchkMeseci.CheckedIndices.Count > 0 && (god < AppData.SkolskaGodina.Start || god > AppData.SkolskaGodina.Start + 1))
                    vanTekuce = true;

                lstchkMeseci.BackColor = vanTekuce ? Color.Salmon : Color.White;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Obračun zarada - izmena godine i meseca"); }
        }
    }
}
