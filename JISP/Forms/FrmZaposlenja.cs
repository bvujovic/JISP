using JISP.Classes;
using JISP.Classes.ObracunZarada;
using JISP.Controls;
using JISP.Data;
using System;
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

                bsZaposlenja.DataSource = AppData.Ds;
                dgvZaposlenjaSve.StandardSort = bsZaposlenja.Sort;
                dgvZaposlenjaSve.LoadSettings();
                SetBsFilter();

                dgvAngazovanja.LoadSettings();

                bsObracunZarada.DataSource = AppData.Ds;
                dgvObracunZarada.LoadSettings();
                bsObracunZarada.Filter = $"IdZaposlenog = {zaposleni.IdZaposlenog}";
                numOzGodina.Value = DateTime.Now.Year;

                //B btnUcitajObracunZarada.Funct = async () => { await BtnUcitajObracunZaradaClick(); };
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private readonly Ds.ZaposleniRow zaposleni;
        private Ds.ZaposlenjaDataTable Zaposlenja => AppData.Ds.Zaposlenja;

        private async void BtnUcitajZaposlenja_Click(object sender, EventArgs e)
        {
            await (sender as UcButton).RunAsync(async () =>
            {
                var body = $"{{'regUstUstanovaId':{WebApi.SV_SAVA_ID},'regZapZaposleniId':{zaposleni.IdZaposlenog}}}";
                var json = await WebApi.PostForJson(WebApi.ReqEnum.Zap_Zaposlenja, body);
                var IDsToRemove = zaposleni.GetZaposlenjaRows().Select(it => it.IdZaposlenja).ToList();

                dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
                foreach (var obj in arr)
                {
                    if (obj.regZapZaposleniUstanova.regUstUstanovaId != WebApi.SV_SAVA_ID)
                        continue;
                    Ds.ZaposlenjaRow z;
                    var isNew = true; // da li je dobijeno zaposlenje novo 
                    if (IDsToRemove.Contains((int)obj.id)) // vec imam dobijeno zaposlenje - treba ga update-ovati
                    {
                        IDsToRemove.Remove((int)obj.id);
                        z = Zaposlenja.FindByIdZaposlenja((int)obj.id);
                        isNew = false;
                    }
                    else
                    {
                        z = Zaposlenja.NewZaposlenjaRow();
                        z.IdZaposlenog = zaposleni.IdZaposlenog;
                        z.IdZaposlenja = obj.id;
                    }
                    z.BrojUgovoraORadu = obj.brojUgovoraORadu ?? "Непознато";
                    z.DatumZaposlenOd = obj.datumZaposlenOd;
                    if (obj.datumZaposlenDo != null)
                        z.DatumZaposlenDo = obj.datumZaposlenDo;
                    z.ProcenatRadnogVremena = obj.procenatRadnogVremena;
                    z.RadnoMestoNaziv = obj.radnoMestoNaziv;
                    z.VrstaAngazovanja = obj.vrstaAngazovanjaNaziv;
                    if (obj.noksNivo != null)
                        z.NoksNivoNaziv = obj.noksNivo.naziv;
                    z.Aktivan = obj.statusUgovora != null && obj.statusUgovora == 19292;
                    if (isNew)
                        AppData.Ds.Zaposlenja.AddZaposlenjaRow(z);
                }
                foreach (var id in IDsToRemove)
                    Zaposlenja.RemoveZaposlenjaRow(Zaposlenja.FindByIdZaposlenja(id));
            });
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
            {
                // dohvatanje podataka
                var json = await WebApi.GetJson(WebApi.ReqEnum.Zap_ObracunZarada
                    , zaposleni.IdZaposlenog.ToString());
                dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
                // brisanje starih obracuna zarada za zaposlenog
                var ozs = zaposleni.GetObracunZaradaRows();
                foreach (var oz in ozs)
                    AppData.Ds.ObracunZarada.RemoveObracunZaradaRow(oz);
                // popunjavanje data seta dobijenim podacima
                foreach (var obj in arr)
                {
                    var oz = AppData.Ds.ObracunZarada.NewObracunZaradaRow();
                    oz.IdZaposlenog = zaposleni.IdZaposlenog;
                    oz.IdObracuna = obj.id;
                    oz.BrojUgovora = obj.brojUgovora;
                    oz.Godina = obj.godinaBroj;
                    oz.MesecNaziv = obj.mesecSifarnikNaziv;
                    oz.MesecBroj = OzMesec.BrojMeseca(oz.MesecNaziv);
                    oz.OsnovniKoef = obj.osnovniKoeficijentZaposlenog;
                    if (obj.dodatniKoeficijentZaposlenog != null)
                        oz.DodatniKoef = obj.dodatniKoeficijentZaposlenog;
                    if (obj.koeficijentZaStaresinstvo != null)
                        oz.KoefZaStaresinstvo = obj.koeficijentZaStaresinstvo;
                    oz.Norma = obj.normaZaposlenog;
                    AppData.Ds.ObracunZarada.AddObracunZaradaRow(oz);
                }
            });
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
                    if (unetiOZovi.Where(it => it.MesecNaziv == OzMesec.NazivMeseca(mes)).Any())
                        dupliMeseci.Add(mes);
                    else
                    {
                        string strNoviUnos = ObracunZarada.KreirajNoviUnos(zap.ObracunTemplate, god, mes);
                        await WebApi.PostForJson(WebApi.ReqEnum.Zap_ObracunZaradaKreiraj, strNoviUnos);
                    }
                }
                if (dupliMeseci.Any())
                    throw new Exception($"Obračuni zarada za mesece ({string.Join(", ", dupliMeseci)}) već postoje.");
            });
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
        }

        private static bool CheckedCopyOnClick = false;
        private static CheckState? CheckStateAktivno = null;
        private static CheckedListBox.CheckedIndexCollection CheckedIndicesMeseci = null;
        private static int TcBottomSelectedIndex = 0;

        private void FrmZaposlenja_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckedCopyOnClick = chkCopyOnClick.Checked;
            CheckStateAktivno = chkAktivno.CheckState;
            CheckedIndicesMeseci = lstchkMeseci.CheckedIndices;
            TcBottomSelectedIndex = tcBottom.SelectedIndex;
            dgvZaposlenjaSve.SaveSettings();
            dgvAngazovanja.SaveSettings();
            dgvObracunZarada.SaveSettings();
        }

        private async void BtnUcitajAngazovanja_Click(object sender, EventArgs e)
        {
            tcBottom.SelectedTab = tpAngazovanja;
            await (sender as UcButton).RunAsync(async () =>
            {
                var zaposlenja = dgvZaposlenjaSve.SelectedDataRows<Ds.ZaposlenjaRow>();
                foreach (var zap in zaposlenja)
                {
                    var idZaposlenja = zap.IdZaposlenja;
                    if (idZaposlenja < 0)
                        throw new Exception("IdZaposlenja nije ispravan. Potrebno je ponovo učitati zaposlenja.");
                    var json = await WebApi.GetJson(WebApi.ReqEnum.Zap_Angazovanja, idZaposlenja.ToString());
                    //B var IDsToRemove = zap.GetAngazovanjaRows().Select(it => it.IdAngazovanja);
                    var oldAngs = zap.GetAngazovanjaRows();
                    Utils.ShowMbox($"Ažuriranje {oldAngs.Length} angažovanja.", "DEBUG poruka");
                    foreach (var ang in oldAngs)
                        AppData.Ds.Angazovanja.RemoveAngazovanjaRow(ang);
                    dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
                    foreach (var obj in arr)
                    {
                        //var ang = AppData.Ds.Angazovanja.FindByIdAngazovanja((int)obj.id);
                        //if (ang != null)
                        //    AppData.Ds.Angazovanja.RemoveAngazovanjaRow(ang);

                        var a = AppData.Ds.Angazovanja.NewAngazovanjaRow();
                        a.IdAngazovanja = obj.id;
                        a.IdZaposlenja = idZaposlenja;
                        a.SkolskaGodina = obj.skolskaGodinaNaziv;
                        a.IzvorFinansiranja = Utils.SkratiIzvorFin((string)obj.izvorFinansiranjaNaziv);
                        a.ProcenatAngazovanja = obj.procenatAngazovanja;
                        a.Predmet = obj.predmetNaziv;
                        a.PodnivoPredmeta = obj.podnivoPredmetaNaziv;
                        AppData.Ds.Angazovanja.AddAngazovanjaRow(a);
                    }
                }
            });
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
    }
}
