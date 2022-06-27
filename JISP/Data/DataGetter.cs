using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using JISP.Classes;

namespace JISP.Data
{
    public static class DataGetter
    {
        public static async Task GetAngazovanjaAsync(IEnumerable<Ds.ZaposlenjaRow> zaposlenja)
        {
            foreach (var zap in zaposlenja)
            {
                var idZaposlenja = zap.IdZaposlenja;
                if (idZaposlenja < 0)
                    throw new Exception("IdZaposlenja nije ispravan. Potrebno je ponovo učitati zaposlenja.");
                var json = await WebApi.GetJson(WebApi.ReqEnum.Zap_Angazovanja, idZaposlenja.ToString());
                var oldAngs = zap.GetAngazovanjaRows().ToList(); //HACK ToList() ne treba da bude ovde
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
        }

        public static async Task GetObracuniZaradaAsync(Ds.ZaposleniRow zaposleni)
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
                oz.MesecBroj = Classes.ObracunZarada.OzMesec.BrojMeseca(oz.MesecNaziv);
                oz.OsnovniKoef = obj.osnovniKoeficijentZaposlenog;
                if (obj.dodatniKoeficijentZaposlenog != null)
                    oz.DodatniKoef = obj.dodatniKoeficijentZaposlenog;
                if (obj.koeficijentZaStaresinstvo != null)
                    oz.KoefZaStaresinstvo = obj.koeficijentZaStaresinstvo;
                oz.Norma = obj.normaZaposlenog;
                AppData.Ds.ObracunZarada.AddObracunZaradaRow(oz);
            }
        }

        public static async Task GetZaposlenjaAsync(Ds.ZaposleniRow zaposleni)
        {
            var body = $"{{'regUstUstanovaId':{WebApi.SV_SAVA_ID},'regZapZaposleniId':{zaposleni.IdZaposlenog}}}";
            var json = await WebApi.PostForJson(WebApi.ReqEnum.Zap_Zaposlenja, body);
            var IDsToRemove = zaposleni.GetZaposlenjaRows().Select(it => it.IdZaposlenja).ToList();
            var zaposlenja = AppData.Ds.Zaposlenja;
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
                    z = zaposlenja.FindByIdZaposlenja((int)obj.id);
                    isNew = false;
                }
                else
                {
                    z = zaposlenja.NewZaposlenjaRow();
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
                    zaposlenja.AddZaposlenjaRow(z);
            }
            foreach (var id in IDsToRemove)
                zaposlenja.RemoveZaposlenjaRow(zaposlenja.FindByIdZaposlenja(id));
        }

        private class Koef
        {
            public Koef(string naziv, int procenat)
            {
                Naziv = naziv;
                Procenat = procenat;
            }
            public string Naziv { get; set; }
            public int Procenat { get; set; }
            public override string ToString()
                => $"{Naziv} {Procenat}";
        }

        /// <summary>Ucitava i pamti IdZaposlenja i KoefSveOpis za dati OZ.</summary>
        public static async Task GetOzOpisAsync(Ds.ObracunZaradaRow oz)
        {
            var json = await WebApi.GetJson(WebApi.ReqEnum.Zap_ObracunZaradaOpis
                , oz.IdObracuna.ToString());
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);

            var koefMulti = obj.regZapObracunZaradaDouniverzitetskoObrazovanjeDodKoefMulti;
            var koefs = new List<Koef>();
            foreach (var k in koefMulti)
                koefs.Add(new Koef(Utils.SkratiNazivKoef((string)k.nazivOsnovaDodatnogKoeficijenta), (int)k.procenat));

            oz.KoefSveOpis = string.Join(", ", koefs.OrderByDescending(it => it.Procenat));
            oz.IdZaposlenja = (int)obj.regZapObracunZaradaDouniverzitetskoObrazovanje.id;
        }
    }
}
