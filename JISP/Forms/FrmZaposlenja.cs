using JISP.Classes;
using JISP.Data;
using System;
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

                bsZaposlenja.DataSource = AppData.Ds;
                dgvZaposlenjaSve.StandardSort = bsZaposlenja.Sort;
                dgvZaposlenjaSve.LoadSettings();
                SetBsFilter();

                bsObracunZarada.DataSource = AppData.Ds;
                dgvObracunZarada.LoadSettings();
                bsObracunZarada.Filter = $"IdZaposlenog = {zaposleni.IdZaposlenog}";
                numOzGodina.Value = DateTime.Now.Year;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private readonly Ds.ZaposleniRow zaposleni;

        private async void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                var body = $"{{'regUstUstanovaId':{WebApi.SV_SAVA_ID},'regZapZaposleniId':{zaposleni.IdZaposlenog}}}";
                var json = await WebApi.PostForJson(WebApi.ReqEnum.Zap_Zaposlenja, body);

                var zaps = zaposleni.GetZaposlenjaRows();
                foreach (var z in zaps)
                    AppData.Ds.Zaposlenja.RemoveZaposlenjaRow(z);

                dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
                foreach (var obj in arr)
                {
                    if (obj.regZapZaposleniUstanova.regUstUstanovaId != WebApi.SV_SAVA_ID)
                        continue;
                    var z = AppData.Ds.Zaposlenja.NewZaposlenjaRow();
                    z.IdZaposlenog = zaposleni.IdZaposlenog;
                    z.BrojUgovoraORadu = obj.brojUgovoraORadu;
                    z.DatumZaposlenOd = obj.datumZaposlenOd;
                    if (obj.datumZaposlenDo != null)
                        z.DatumZaposlenDo = obj.datumZaposlenDo;
                    z.ProcenatRadnogVremena = obj.procenatRadnogVremena;
                    z.RadnoMestoNaziv = obj.radnoMestoNaziv;
                    z.VrstaAngazovanja = obj.vrstaAngazovanjaNaziv;
                    if (obj.noksNivo != null)
                        z.NoksNivoNaziv = obj.noksNivo.naziv;
                    z.Aktivan = obj.statusUgovora != null && obj.statusUgovora == 19292;
                    AppData.Ds.Zaposlenja.AddZaposlenjaRow(z);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnLoadData.Text); }
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
            try
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
                    oz.BrojUgovora = obj.brojUgovora;
                    oz.Godina = obj.godinaBroj;
                    oz.MesecNaziv = obj.mesecSifarnikNaziv;
                    oz.OsnovniKoef = obj.osnovniKoeficijentZaposlenog;
                    if (obj.dodatniKoeficijentZaposlenog != null)
                        oz.DodatniKoef = obj.dodatniKoeficijentZaposlenog;
                    oz.Norma = obj.normaZaposlenog;
                    AppData.Ds.ObracunZarada.AddObracunZaradaRow(oz);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnUcitajObracunZarada.Text); }
        }

        private void BtnKreirajObracune_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstchkMeseci.CheckedItems.Count == 0)
                {
                    MessageBox.Show("0");
                    return;
                }
                var strStariOZ = "...";
                var god = (int)numOzGodina.Value;
                foreach (int idxMesec in lstchkMeseci.CheckedIndices)
                {
                    var mes = idxMesec + 1;
                    string strNoviUnos = Classes.ObracunZarada.ObracunZarada.KreirajNoviUnos(strStariOZ, god, mes);
                    MessageBox.Show(strNoviUnos);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnKreirajObracune.Text); }
        }
    }
}
