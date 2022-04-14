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

            zaposleni = zap;
            Text = $"Zaposlenja ({zap})";
            bsZaposlenja.DataSource = AppData.Ds;
            SetBsFilter();
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
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, btnLoadData.Text); }
        }

        private void SetBsFilter()
        {
            bsZaposlenja.Filter = $"IdZaposlenog = {zaposleni.IdZaposlenog} AND Aktivan = {chkAktivno.Checked}";
        }

        private void ChkAktivno_CheckedChanged(object sender, EventArgs e)
            => SetBsFilter();
    }
}
