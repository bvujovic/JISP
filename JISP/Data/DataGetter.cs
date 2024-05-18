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

        public static async Task<List<string>> GetZaposlenjaAsync(Ds.ZaposleniRow zaposleni)
        {
            if (AppData.Ds.SifRazloziPrestankaZap.Count == 0)
                await GetRazloziPrestankaZapAsync();

            var body = $"{{'regUstUstanovaId':{WebApi.SV_SAVA_ID},'regZapZaposleniId':{zaposleni.IdZaposlenog}}}";
            var json = await WebApi.PostForJson(WebApi.ReqEnum.Zap_Zaposlenja, body);
            var IDsToRemove = zaposleni.GetZaposlenjaRows().Select(it => it.IdZaposlenja).ToList();
            var zaposlenja = AppData.Ds.Zaposlenja;
            var brojeviUgovoraZaNedostajuceZamenjene = new List<string>();
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
                else
                    z.SetDatumZaposlenDoNull();
                z.ProcenatRadnogVremena = obj.procenatRadnogVremena;
                z.RadnoMestoNaziv = obj.radnoMestoNaziv;
                z.VrstaAngazovanja = obj.vrstaAngazovanjaNaziv;
                if (obj.noksNivo != null)
                    z.NoksNivoNaziv = obj.noksNivo.naziv;
                z.Aktivan = obj.statusUgovora != null && obj.statusUgovora == 19292;
                if (obj.razlogPrestankaZaposlenjaId != null)
                {
                    var r = AppData.Ds.SifRazloziPrestankaZap.FindByIdRazloga((int)obj.razlogPrestankaZaposlenjaId);
                    if (r != null)
                        z.RazlogPrestankaZaposlenja = r.NazivRazloga;
                }
                if (z.NedostajeZamenjeni)
                    brojeviUgovoraZaNedostajuceZamenjene.Add(z.BrojUgovoraORadu);
                if (obj.ugovorORaduDokumentId != null)
                {
                    z.DokumentId = obj.ugovorORaduDokumentId;
                    z.Dokument = obj.ugovorORaduDokumentNaziv;
                }
                if (isNew)
                    zaposlenja.AddZaposlenjaRow(z);
            }
            foreach (var id in IDsToRemove)
                zaposlenja.RemoveZaposlenjaRow(zaposlenja.FindByIdZaposlenja(id));
            return brojeviUgovoraZaNedostajuceZamenjene;
        }

        /// <summary>Učitava podatke u tabelu SifRazloziPrestankaZap.</summary>
        public static async Task GetRazloziPrestankaZapAsync()
        {
            AppData.Ds.SifRazloziPrestankaZap.Clear();
            var json = await WebApi.GetJson(WebApi.ReqEnum.Zap_ZaposlenjaRazloziPrestanka);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            foreach (var item in arr)
            {
                var r = AppData.Ds.SifRazloziPrestankaZap.NewSifRazloziPrestankaZapRow();
                r.IdRazloga = item.id;
                r.NazivRazloga = item.naziv;
                AppData.Ds.SifRazloziPrestankaZap.AddSifRazloziPrestankaZapRow(r);
            }
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
        public static async Task GetOzDodatnoAsync(Ds.ObracunZaradaRow oz)
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
            if (obj.regZapObracunZaradaDouniverzitetskoObrazovanje != null
                && obj.regZapObracunZaradaDouniverzitetskoObrazovanje.ukupanRadniStazTekuceSkolskeGodine != null)
                oz.Staz = (int)obj.regZapObracunZaradaDouniverzitetskoObrazovanje.ukupanRadniStazTekuceSkolskeGodine;
        }

        public static async Task GetResenjaAsync(IEnumerable<Ds.ZaposlenjaRow> zaposlenja)
        {
            foreach (var zap in zaposlenja)
            {
                var idZaposlenja = zap.IdZaposlenja;
                if (idZaposlenja < 0)
                    throw new Exception("IdZaposlenja nije ispravan. Potrebno je ponovo učitati zaposlenja.");
                var json = await WebApi.GetJson(WebApi.ReqEnum.Zap_Resenja, idZaposlenja.ToString());
                var oldRes = zap.GetResenjaRows();
                foreach (var res in oldRes)
                    AppData.Ds.Resenja.RemoveResenjaRow(res);
                dynamic jobj = Newtonsoft.Json.Linq.JObject.Parse(json);
                foreach (var obj in jobj.regZapZaposlenjeResenja)
                {
                    var r = AppData.Ds.Resenja.NewResenjaRow();
                    r.IdResenja = obj.id;
                    r.IdZaposlenja = idZaposlenja;
                    r.BrojResenja = obj.brojResenja;
                    r.SkolskaGodina = obj.skolskaGodinaNaziv;
                    r.TipResenja = obj.tipResenjaNaziv;
                    if (obj.procenatAngazovanjaPoResenju != null)
                        r.ProcenatAngPoRes = obj.procenatAngazovanjaPoResenju;
                    r.DatumPodnosenja = obj.datumPodnosenjaResenja;
                    r.AktivnoResenje = obj.statusResenja ?? false;
                    if (obj.resenjeDokumentId != null)
                    {
                        r.DokumentId = obj.resenjeDokumentId;
                        r.Dokument = obj.resenjeDokumentNaziv;
                    }
                    AppData.Ds.Resenja.AddResenjaRow(r);
                }
            }
        }

        /// <summary>Dohvatanje taberle-sifarnika (Drzave, NoksNivoi...) potrebnih za podatke o obrazovanju.</summary>
        public static async Task GetObrazovanjaTempAsync()
        {
            var ds = AppData.DsTemp;
            var tabele = new[] { "Drzava", "Jezici", "KLASNOKS", "NoksNivoi", "StepenStrucneSpreme" };
            foreach (var tbl in tabele)
            {
                if (ds.Tables[tbl].Rows.Count == 0)
                {
                    var url = tbl != "NoksNivoi"
                        ? "https://jisp.mpn.gov.rs/webapi/api/sifarnik/naziv/"
                        : "https://jisp.mpn.gov.rs/webapi/api/sifarnik/sa-ekstenzijom-po-nazivu-tipa/";
                    var json = await WebApi.GetJson(url + tbl);
                    dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
                    foreach (var obj in arr)
                        ds.Tables[tbl].Rows.Add((int)obj.id, (string)obj.naziv);
                }
            }
            var j = ds.Jezici.FirstOrDefault(it => it.naziv == "Српски језик");
            if (j != null)
                j.naziv = "Српски";
            var d = ds.Drzava.FirstOrDefault(it => it.naziv == "Република Србија");
            if (d != null)
                d.naziv = "Србија";
        }

        /// <summary>Dohvatanje dela podataka u tabelu Obrazovanja.</summary>
        public static async Task GetObrazovanjaAsync(int idZaposlenog)
        {
            var url = "https://jisp.mpn.gov.rs/webapi/api/Zaposleni/VratiStecenaObrazovanjaZaposlenog";
            var json = await WebApi.PostForJson(url, $"{{\"regZapZaposleniId\":{idZaposlenog}}}");
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            var ids = new List<int>();
            foreach (var obj in arr)
            {
                Ds.ObrazovanjaRow o = AppData.Ds.Obrazovanja.FindByIdObrazovanja((int)obj.id);
                bool novo;
                if (novo = o == null)
                    o = AppData.Ds.Obrazovanja.NewObrazovanjaRow();

                o.IdZaposlenog = idZaposlenog;
                o.IdObrazovanja = obj.id;
                ids.Add(o.IdObrazovanja);
                PostaviVrednostZaSifru(obj, o, "NoksNivo", "NoksNivoi");
                PostaviVrednostZaSifru(obj, o, "Klasnoks", "KLASNOKS");
                PostaviVrednostZaSifru(obj, o, "Stepen", "StepenStrucneSpreme");
                o.NazivSteceneKvalifikacije = obj.nazivSteceneKvalifikacije;
                o.StrucniAkademskiNazivIzDiplome = obj.strucniAkademskiNazivIzDiplome;
                o.DatumSticanjaDiplome = obj.datumSticanjaDiplome;
                PostaviVrednostZaSifru(obj, o, "DrzavaZavrseneSkole", "Drzava");
                o.MestoZavrseneSkoleNaziv = obj.mestoZavrseneSkoleSlobodanUnos;
                o.NazivSkole = obj.nazivSkole;
                PostaviVrednostZaSifru(obj, o, "JezikNaKomJeStecenoObrazovanje", "Jezici");
                o.DokumentId = obj.dokumentId;
                o.DokumentNaziv = obj.dokumentNaziv;
                if (novo)
                    AppData.Ds.Obrazovanja.AddObrazovanjaRow(o);
            }
            // brisanje redova koji su ukinuti u JISPu - ako takvih ima
            var zaBrisanje = AppData.Ds.Obrazovanja.Where(it => it.IdZaposlenog == idZaposlenog && !ids.Contains(it.IdObrazovanja)).ToArray();
            foreach (var obr in zaBrisanje)
                AppData.Ds.Obrazovanja.RemoveObrazovanjaRow(obr);
        }

        /// <summary>Tabela u DsTemp se pretražuje po ID-u da bi se dohvatio naziv za taj entitet i dati ID.</summary>
        private static void PostaviVrednostZaSifru(dynamic obj, System.Data.DataRow o, string kolona, string tabela)
        {
            // Ime kolone u DsTemp je npr Naziv a u JSONu je naziv. Zato se ovde prvo slovo naziv akolone smanjuje.
            var objCol = char.ToLower(kolona[0]) + kolona.Substring(1);
            if (obj[objCol] != null)
            {
                var row = AppData.DsTemp.Tables[tabela].Rows.Find((int)obj[objCol]);
                if (row == null)
                    o[kolona] = DBNull.Value;
                else
                    o[kolona] = row["naziv"];
            }
            else
                o[kolona] = DBNull.Value;
        }

        /// <summary>Učitava podatke u tabelu Sistematizacija.</summary>
        public static async Task GetSistematizacijaAsync()
        {
            var json = await WebApi.GetJson(WebApi.ReqEnum.Zap_Sistematizacija);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            AppData.Ds.Sistematizacija.Clear();
            foreach (var item in arr)
            {
                var sis = AppData.Ds.Sistematizacija.NewSistematizacijaRow();
                sis.IdSistematizacije = item.id;
                sis.SkolskaGodinaId = item.skolskaGodina;
                sis.RegUstSisId = item.regUstUstanovaSistematizacijaId;
                sis.IzvorFinansiranja = item.izvorFinansiranjaNaziv;
                sis.RucniUnos = item.rucniUnosSistematizacije != null ? (bool)item.rucniUnosSistematizacije : false;
                sis.RadnoMestoId = item.radnoMestoId;
                sis.RadnoMesto = item.radnoMestoNaziv;
                sis.PredmetId = item.predmetId != null ? (int)item.predmetId : 0;
                sis.PodnivoPredmetaId = item.predmetPodnivoId != null ? (int)item.predmetPodnivoId : 0;
                sis.Predmet = item.predmetNaziv + " " + (item.podnivoPredmetaNaziv ?? "");
                sis.JezikNastaveId = item.jezikNastaveId != null ? (int)item.jezikNastaveId : 0;
                sis.UkupnaNormaPoSistematizaciji = item.ukupnaNormaPoSistematizaciji;
                sis.UkupnaNormaPoRMOsimZamena = item.ukupnaNormaPoRMOsimZamena;
                sis.GreskaUPlaniranojNormi = item.greskaUPlaniranojNormi;
                sis.GreskaUUgovornomAngazovanju = item.greskaUUgovornomAngazovanju;
                sis.UkupnaNormaPoPravilniku = item.ukupnaNormaPoPravilniku;
                AppData.Ds.Sistematizacija.AddSistematizacijaRow(sis);

            }
            if (AppData.Ds.Sistematizacija.Count > 0)
                Poruke.SistematizacijaId = AppData.Ds.Sistematizacija.First().RegUstSisId;
        }

        /// <summary>Učitava poslednju poruku u vezi sa sistematizacijom ili CENUSom.</summary>
        /// <returns>Da li je ucitana nova poruka.</returns>
        public static async Task<bool> GetPorukaAsync(TipPoruke tipPoruke)
        {
            var json = await WebApi.GetJson(
                tipPoruke == TipPoruke.Sistematizacija ? WebApi.ReqEnum.Zap_PorukaOdbijenaSistematizacija : WebApi.ReqEnum.Zap_PorukaOdbijeniCenus
                , tipPoruke == TipPoruke.Sistematizacija ? Poruke.SistematizacijaId.ToString() : Poruke.CenusId.ToString());
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
            if (obj.poruka != null)
            {
                var tekstTekucePoruke = (string)obj.poruka;
                var poslednjaPoruka = Poruke.PoslednjaPoruka(tipPoruke);
                if (poslednjaPoruka == null || poslednjaPoruka.Tekst != tekstTekucePoruke)
                {
                    AppData.Ds.Poruke.AddPorukeRow
                        (tekstTekucePoruke, tipPoruke.ToString(), DateTime.Now);
                    return true;
                }
            }
            return false;
        }

        public static async Task GetCenusAsync()
        {
            var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_Cenus, WebApi.SV_SAVA_ID);
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
            Poruke.CenusId = (int)obj.id;
        }

        /// <summary>Učitava podateke u tabelu SistematizacijaDetalji.</summary>
        public static async Task GetSistematizacijaDetaljiAsync(Ds.SistematizacijaRow sis)
        {
            var body = $"{{\"skolskaGodina\":{sis.SkolskaGodinaId},\"regUstUstanovaId\":{WebApi.SV_SAVA_ID},\"radnoMestoId\":{sis.RadnoMestoId},\"predmetId\":{sis.PredmetId},\"podnivoPredmetaId\":{sis.PodnivoPredmetaId},\"jezikNastaveId\":{sis.JezikNastaveId}}}";
            var json = await WebApi.PostForJson(WebApi.ReqEnum.Zap_SistematizacijaDetalji, body);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);

            foreach (var detalj in sis.GetSistematizacijaDetaljiRows().ToList())
                AppData.Ds.SistematizacijaDetalji.RemoveSistematizacijaDetaljiRow(detalj);

            foreach (var item in arr)
            {
                var det = AppData.Ds.SistematizacijaDetalji.NewSistematizacijaDetaljiRow();
                det.IdSistematizacije = sis.IdSistematizacije;
                det.Zaposleni = item.ime + " " + item.prezime;
                det.TipUgovora = item.tipUgovora;
                det.ProcenatAngazovanja = item.procenatAngazovanja;
                AppData.Ds.SistematizacijaDetalji.AddSistematizacijaDetaljiRow(det);
            }
        }

        /// <summary>Učitava podateke u tabelu IzvoriFinansiranja.</summary>
        public static async Task GetIzvoriFinansiranjaAsync()
        {
            var json = await WebApi.GetJson(WebApi.ReqEnum.Zap_IzvoriFinansiranja);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            AppData.Ds.IzvoriFinansiranja.Clear();
            foreach (var item in arr)
            {
                var izvor = AppData.Ds.IzvoriFinansiranja.NewIzvoriFinansiranjaRow();
                izvor.IdIzvoraFin = item.id;
                izvor.Naziv = item.naziv;
                AppData.Ds.IzvoriFinansiranja.AddIzvoriFinansiranjaRow(izvor);
            }
        }

        /// <summary>Učitavanje liste JOB zahteva u kojoj se mogu pronaći: JMBG, JOB, ime, prezime učenika, ime roditelja.</summary>
        /// <param name="samoPrvaStranica">true - samo prvih 50 stavki/zahteva, false - kompletna lista</param>
        public static async Task GetListaJobZahteva(bool samoPrvaStranica)
        {
            var ucsDatRodj = new List<string>();
            for (int i = 0; ; i++)
            {
                var body = $"{{\"tipZahteva\":0,\"statusZahteva\":0,\"datumOd\":\"\",\"datumDo\":\"\",\"pageIndex\":{i},\"pageSize\":50,\"idUstanove\":{WebApi.SV_SAVA_ID}}}";
                var json = await WebApi.PostForJson(WebApi.ReqEnum.Job_PreuzmiListuZahteva, body);
                dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
                var jobs = new List<string>();
                foreach (var z in obj.zahtevi)
                {
                    if (z.lice != null && z.lice.job != null && (z.lice.jePrivremeniJOB == null || !(bool)z.lice.jePrivremeniJOB)
                        && (z.lice.jeOpozvanJOB == null || !(bool)z.lice.jeOpozvanJOB))
                    {
                        var job = (string)z.lice.job;
                        if (jobs.Contains(job))
                            continue;
                        else
                            jobs.Add(job);

                        var uc = AppData.Ds.Ucenici.FirstOrDefault(it => it.JOB == job);
                        if (uc != null)
                        {
                            uc.JMBG = z.lice.jmbg;
                            if (!uc.IsDatumRodjenjaNull() && JMBG.GetBirthDate(uc.JMBG) != uc.DatumRodjenja)
                                ucsDatRodj.Add(uc.ToString());
                            uc.Ime = z.lice.ime;
                            uc.Prezime = z.lice.prezime;
                            uc.ImeRoditelja = z.lice.imeRoditelja;
                        }
                    }
                }
                if (samoPrvaStranica || obj.zahtevi.Count < 50)
                    break;
            }
            if (ucsDatRodj.Count > 0)
                Utils.ShowMbox(string.Join(Environment.NewLine, ucsDatRodj)
                    , "Spisak učenika čiji se datum rođenja i JMBG se ne slažu");
        }

        /// <summary>Učitava podatke u tabelu Razredi.</summary>
        public static async Task GetRazredi()
        {
            var json = await WebApi.GetJson(WebApi.UrlBase + "Ustanova/VratiSveRazredeUstanove/" + WebApi.SV_SAVA_ID);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            var tbl = AppData.Ds.Razredi;
            var ids = new List<int>();
            foreach (var it in arr)
            {
                var id = (int)it.id;
                ids.Add(id);
                var razred = tbl.FindByIdRazreda(id);
                if (razred == null)
                {
                    razred = tbl.NewRazrediRow();
                    razred.IdRazreda = id;
                    razred.NazivRazreda = Utils.SkratiRazredSS((string)it.razredNaziv);
                    razred.SkolskaGodina = it.skolskaGodinaNaziv;
                    tbl.AddRazrediRow(razred);
                }
                else
                {
                    if (it.razredNaziv != null)
                        razred.NazivRazreda = Utils.SkratiRazredSS((string)it.razredNaziv);
                    if (it.skolskaGodina != null)
                        razred.SkolskaGodina = it.skolskaGodinaNaziv;
                }
            }
            var zaBrisanje = AppData.Ds.Razredi.Where(it => !ids.Contains(it.IdRazreda)).ToArray();
            foreach (var r in zaBrisanje)
                AppData.Ds.Razredi.RemoveRazrediRow(r);
        }

        /// <summary>Učitava podatke u tabelu Odeljenja za dati razred.</summary>
        public static async Task GetOdeljenja(int idRazreda)
        {
            var razred = AppData.Ds.Razredi.FindByIdRazreda(idRazreda);
            if (razred.NazivRazreda == AppData.NazivPppRazreda)
                return;
            if (razred == null)
                throw new Exception($"Razred sa IDem {idRazreda} nije pronadjen.");

            var json = await WebApi.GetJson(WebApi.UrlBase + "Ustanova/VratiOdeljenjaUstanovePoRazredu/" + idRazreda);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            var tbl = AppData.Ds.Odeljenja;
            var ids = new List<int>();
            foreach (var it in arr)
            {
                var id = (int)it.id;
                var od = tbl.FindByIdOdeljenja(id);
                ids.Add(id);
                if (od == null)
                {
                    od = tbl.NewOdeljenjaRow();
                    od.IdOdeljenja = id;
                    od.NazivOdeljenja = it.nazivOdeljenja;
                    od.Staresina = it.odeljenskiStaresinaNaziv;
                    tbl.AddOdeljenjaRow(od);
                    AppData.Ds.OdRaz.AddOdRazRow(razred, od);
                }
                else
                {
                    if (it.nazivOdeljenja != null && od.NazivOdeljenja != (string)it.nazivOdeljenja)
                        od.NazivOdeljenja = it.nazivOdeljenja;
                    if (it.odeljenskiStaresinaNaziv != null && od.Staresina != (string)it.odeljenskiStaresinaNaziv)
                        od.Staresina = it.odeljenskiStaresinaNaziv;
                    var odraz = AppData.Ds.OdRaz.FindByIdRazredaIdOdeljenja(idRazreda, id);
                    if (odraz == null)
                        AppData.Ds.OdRaz.AddOdRazRow(razred, od);
                }
            }
            var odeljenjaRazreda = AppData.Ds.OdRaz.Where(it => it.IdRazreda == idRazreda)
                .Select(it => it.IdOdeljenja);
            var zaBrisanje = AppData.Ds.Odeljenja.Where(it => odeljenjaRazreda.Contains(it.IdOdeljenja)
               && !ids.Contains(it.IdOdeljenja)).ToList();
            foreach (var o in zaBrisanje)
                AppData.Ds.Odeljenja.RemoveOdeljenjaRow(o);
        }

        /// <summary>Dohvata razrede (PPP) i odeljenja (vaspitne grupe) za predskolsko.</summary>
        /// <remarks>
        /// Vaspitne grupe se upisuju kao odeljenja, a PPP razred svake godine za koju postoji
        /// predskolski program dobija sledeci negativan broj od strane aplikacije Nas JISP.
        /// </remarks>
        public static async Task GetVaspitneGrupe(string skGod)
        {
            var PPP = AppData.NazivPppRazreda;
            var json = await WebApi.PostForJson(WebApi.UrlBase + "Ustanova/VratiVaspitneGrupe",
                "{\"radnaGodinaId\":\"\",\"regUstObjekatId\":\"\",\"regUstUstanovaId\":" + WebApi.SV_SAVA_ID
                + ",\"regUstLokacijaId\":\"\",\"regUstVaspitnaGrupaVrstaId\":1}");
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            Ds.RazrediRow pppRazred = null;
            var tblOd = AppData.Ds.Odeljenja;
            var ids = new List<int>();
            foreach (var it in arr)
            {
                if ((string)it.radnaGodinaNaziv != skGod)
                    continue;
                pppRazred = AppData.Ds.Razredi.FirstOrDefault(r => r.NazivRazreda == PPP
                    && r.SkolskaGodina == skGod);
                if (pppRazred == null) // dodavanje PPP razreda ako u toj skGod ima PPP grupa
                {
                    int idPPP;
                    var pretRazredi = AppData.Ds.Razredi.Where(r => r.NazivRazreda == PPP);
                    if (pretRazredi.Any())
                        idPPP = pretRazredi.Min(r => r.IdRazreda) - 1;
                    else
                        idPPP = -1;
                    pppRazred = AppData.Ds.Razredi.AddRazrediRow(idPPP, PPP, skGod, Utils.RazredSortBroj(PPP));
                }

                json = await WebApi.GetJson(WebApi.UrlBase + "Ustanova/VratiVaspitnuGrupu/" + it.id);
                dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);

                var id = (int)it.id;
                ids.Add(id);
                var od = tblOd.FindByIdOdeljenja(id);
                string vaspitacica = (obj.vaspitaci != null && obj.vaspitaci.Count > 0) ?
                    obj.vaspitaci[0].ime + " " + obj.vaspitaci[0].prezime : "/";
                if (od == null) // dodavanje nove PPP grupe kao odeljenja
                {
                    od = tblOd.NewOdeljenjaRow();
                    od.IdOdeljenja = id;
                    od.NazivOdeljenja = obj.nazivGrupe;
                    od.Staresina = vaspitacica;
                    od.SortBroj = Utils.RazredSortBroj(pppRazred.NazivRazreda);
                    tblOd.AddOdeljenjaRow(od);
                    AppData.Ds.OdRaz.AddOdRazRow(pppRazred, od);
                }
                else // izmena podataka: naziv grupe (odeljenja, vaspitacica (od. staresina)
                {
                    if (obj.nazivGrupe != null && od.NazivOdeljenja != (string)obj.nazivGrupe)
                        od.NazivOdeljenja = it.nazivOdeljenja;
                    if (od.Staresina != vaspitacica)
                        od.Staresina = vaspitacica;
                }
            }
            // brisanje PPP grupa koje su uklonjene iz JISPa
            var odeljenjaRazreda = AppData.Ds.OdRaz.Where(it => it.IdRazreda == pppRazred.IdRazreda)
                .Select(it => it.IdOdeljenja);
            var zaBrisanje = tblOd.Where(it => odeljenjaRazreda.Contains(it.IdOdeljenja)
               && !ids.Contains(it.IdOdeljenja)).ToList();
            foreach (var o in zaBrisanje)
                tblOd.RemoveOdeljenjaRow(o);
        }

        #region Lokacije, Objekti, Prostorije

        /// <summary>Učitava podatke u tabelu Lokacije.</summary>
        public static async Task GetLokacijeAsync()
        {
            var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_Lokacije);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            AppData.Ds.Lokacije.Clear();
            foreach (var item in arr)
            {
                var lok = AppData.Ds.Lokacije.NewLokacijeRow();
                lok.IdLokacije = item.id;
                lok.NazivLokacije = item.nazivLokacije;
                lok.Opstina = item.opstinaNaziv;
                lok.Mesto = item.mestoNaziv;
                lok.Ulica = item.ulicaNaziv;
                lok.KucniBroj = item.kucniBroj;
                lok.JeSediste = item.jeSediste;
                AppData.Ds.Lokacije.AddLokacijeRow(lok);
            }
        }

        /// <summary>Učitava podatke u tabelu Objekti.</summary>
        public static async Task GetObjektiAsync()
        {
            AppData.Ds.Objekti.Clear();
            foreach (var lok in AppData.Ds.Lokacije)
            {
                var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_Objekti, lok.IdLokacije.ToString());
                dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
                foreach (var item in arr)
                {
                    var obj = AppData.Ds.Objekti.NewObjektiRow();
                    obj.IdObjekta = item.id;
                    obj.NazivObjekta = item.naziv;
                    obj.IdLokacije = item.idLokacije;
                    obj.GodinaIzgradnje = item.godinaIzgradnje;
                    obj.GodinaOtvaranja = item.godinaOtvaranja;
                    obj.UkupnaPovrsinaZaCiscenje = item.ukupnaPovrsinaZaCiscenje;
                    obj.UkupnaPovrsinaZaGrejanje = item.ukupnaPovrsinaZaGrejanje;
                    obj.Namena = string.Join(", ", item.listaNamena);
                    AppData.Ds.Objekti.AddObjektiRow(obj);
                }
            }
        }

        /// <summary>Dodaje posebne brojcane podatke u tabelu Objekti.</summary>
        public static async Task GetObjektiDodatnoAsync(int idObjekta)
        {
            var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_ObjektiDodatno, idObjekta.ToString());
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
            var o = AppData.Ds.Objekti.FindByIdObjekta(idObjekta);
            if (o != null)
            {
                o.PovrsinaObjekta = obj.povrsinaObjekta;
                o.KorisnaPovrsinaObjekta = obj.korisnaPovrsinaObjekta;
                o.BrojRadnihDanaUNedelji = obj.brojRadnihDanaUNedelji;
                o.BrojRadnihSmena = obj.brojRadnihSmena;
                o.BrojProstorijaUObjektu = obj.brojProstorijaUObjektu;
                o.KapacitetObjekta = obj.kapacitetObjekta;
            }
        }

        /// <summary>Učitava podatke u tabelu Prostorije.</summary>
        public static async Task GetProstorijeOsnovnoAsync()
        {
            var ids = new List<int>();
            foreach (var o in AppData.Ds.Objekti)
            {
                var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_ProstorijeOsnovno, o.IdObjekta.ToString());
                dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
                foreach (var obj in arr)
                {
                    var p = AppData.Ds.Prostorije.FindByIdProstorije((int)obj.id);
                    bool novo;
                    if (novo = p == null)
                        p = AppData.Ds.Prostorije.NewProstorijeRow();

                    //B var p = AppData.Ds.Prostorije.NewProstorijeRow();
                    if (novo || p.IdProstorije != (int)obj.id)
                        p.IdProstorije = obj.id;
                    ids.Add(p.IdProstorije);
                    if (novo || p.NazivProstorije != (string)obj.nazivProstorije)
                        p.NazivProstorije = obj.nazivProstorije;
                    if (novo || p.IdObjekta != (int)obj.idObjekta)
                        p.IdObjekta = obj.idObjekta;
                    if (novo || p.TipProstorije != (string)obj.tipProstorijeNaziv)
                        p.TipProstorije = obj.tipProstorijeNaziv;
                    if (novo || p.Povrsina != (double)obj.povrsina)
                        p.Povrsina = obj.povrsina;
                    if (novo || p.ProsecnaVisinaPlafona != (double)obj.prosecnaVisinaPlafona)
                        p.ProsecnaVisinaPlafona = obj.prosecnaVisinaPlafona;
                    if (novo || p.DostupLicimaSaSpecPotrebama != (bool)obj.dostupnostLicimaSaSpecijalnimPotrebamaNaziv)
                        p.DostupLicimaSaSpecPotrebama = obj.dostupnostLicimaSaSpecijalnimPotrebamaNaziv;
                    if (novo)
                        AppData.Ds.Prostorije.AddProstorijeRow(p);
                }
            }
            // brisanje redova koji su ukinuti u JISPu - ako takvih ima
            var zaBrisanje = AppData.Ds.Prostorije.Where(it => !ids.Contains(it.IdProstorije)).ToArray();
            foreach (var p in zaBrisanje)
                AppData.Ds.Prostorije.RemoveProstorijeRow(p);
        }

        /// <summary>Učitava podatke u tabelu Prostorije.</summary>
        public static async Task GetProstorijeDodatnoAsync(int idProstorije)
        {
            var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_ProstorijeDodatno, idProstorije.ToString());
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
            var p = AppData.Ds.Prostorije.FindByIdProstorije(idProstorije);
            if (p != null)
            {
                if (p.IsIdTipaProstorijeNull() || p.IdTipaProstorije != (int)obj.tipProstorije)
                    p.IdTipaProstorije = (int)obj.tipProstorije;
                if (p.IsIdSprataNull() || p.IdSprata != (int)obj.sprat)
                {
                    p.IdSprata = (int)obj.sprat;
                    p.Sprat = AppData.Ds.SifSpratovi.FindByIdSprata(p.IdSprata).NazivSprata;
                }

                if (p.IsIzvorGrejanjaNull() || p.IzvorGrejanja != (bool)obj.izvorGrejanja)
                    p.IzvorGrejanja = obj.izvorGrejanja;
                if (obj.vrstaIzvoraGrejanja != null)
                {
                    if (p.IsIdVrsteIzvoraGrejanjaNull() || p.IdVrsteIzvoraGrejanja != (int)obj.vrstaIzvoraGrejanja)
                    {
                        p.IdVrsteIzvoraGrejanja = (int)obj.vrstaIzvoraGrejanja;
                        p.VrstaIzvoraGrejanja = AppData.Ds.SifGrejanja.FindByIdGrejanja(p.IdVrsteIzvoraGrejanja).NazivGrejanja;
                    }
                }
                else
                {
                    p.IsIdVrsteIzvoraGrejanjaNull();
                    p.SetVrstaIzvoraGrejanjaNull();
                }

                if (p.IsIzvorHladjenjaNull() || p.IzvorHladjenja != (bool)obj.izvorHladjenja)
                    p.IzvorHladjenja = obj.izvorHladjenja;
                if (obj.vrstaIzvoraHladjenja != null)
                {
                    if (p.IsIdVrsteIzvoraHladjenjaNull() || p.IdVrsteIzvoraHladjenja != (int)obj.vrstaIzvoraHladjenja)
                    {
                        p.IdVrsteIzvoraHladjenja = (int)obj.vrstaIzvoraHladjenja;
                        p.VrstaIzvoraHladjenja = AppData.Ds.SifHladjenja.FindByIdHladjenja((int)obj.vrstaIzvoraHladjenja).NazivHladjenja;
                    }
                }
                else
                {
                    p.IsIdVrsteIzvoraHladjenjaNull();
                    p.SetVrstaIzvoraHladjenjaNull();
                }

                if (p.IsProstorijaSeKoristiNull() || p.ProstorijaSeKoristi != (bool)obj.prostorijaSeKoristi)
                    p.ProstorijaSeKoristi = obj.prostorijaSeKoristi;
                if (p.IsMobilniInternetNull() || p.MobilniInternet != (string)obj.mobilniInternet)
                    p.MobilniInternet = obj.mobilniInternet;
                if (p.IsBrzinaBezicnogInternetaNull() || p.BrzinaBezicnogInterneta != (string)obj.brzinaBezicnogInterneta)
                    p.BrzinaBezicnogInterneta = obj.brzinaBezicnogInterneta;
                if (p.IsBrzinaLanPrikljuckaNull() || p.BrzinaLanPrikljucka != (string)obj.brzinaLanPrikljucka)
                    p.BrzinaLanPrikljucka = obj.brzinaLanPrikljucka;
            }
        }

        /// <summary>Učitava podatke u tabelu SifSpratovi.</summary>
        public static async Task GetSpratoviAsync()
        {
            AppData.Ds.SifSpratovi.Clear();
            var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_Spratovi);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            foreach (var item in arr)
            {
                var sprat = AppData.Ds.SifSpratovi.NewSifSpratoviRow();
                sprat.IdSprata = item.id;
                sprat.NazivSprata = item.naziv;
                AppData.Ds.SifSpratovi.AddSifSpratoviRow(sprat);
            }
        }

        /// <summary>Učitava podatke u tabelu SifGrejanja.</summary>
        public static async Task GetGrejanjaAsync()
        {
            AppData.Ds.SifGrejanja.Clear();
            var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_Grejanje);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            foreach (var item in arr)
            {
                var g = AppData.Ds.SifGrejanja.NewSifGrejanjaRow();
                g.IdGrejanja = item.id;
                g.NazivGrejanja = item.naziv;
                AppData.Ds.SifGrejanja.AddSifGrejanjaRow(g);
            }
        }

        /// <summary>Učitava podatke u tabelu SifHladjenja.</summary>
        public static async Task GetHladjenjaAsync()
        {
            AppData.Ds.SifHladjenja.Clear();
            var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_Hladjenje);
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            foreach (var item in arr)
            {
                var h = AppData.Ds.SifHladjenja.NewSifHladjenjaRow();
                h.IdHladjenja = item.id;
                h.NazivHladjenja = item.naziv;
                AppData.Ds.SifHladjenja.AddSifHladjenjaRow(h);
            }
        }

        /// <summary>Učitava osnovne podatke u tabelu Racunari.</summary>
        public static async Task GetRacunariOsnovnoAsync(int idProstorije)
        {
            var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_Racunari, idProstorije.ToString());
            dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
            var ids = new List<int>();
            foreach (var item in arr)
            {
                var r = AppData.Ds.Racunari.FindByIdRacunara((int)item.id) ?? AppData.Ds.Racunari.NewRacunariRow();
                r.IdRacunara = item.id;
                ids.Add(r.IdRacunara);
                r.NazivRacunara = item.naziv;
                r.IdProstorije = idProstorije;
                r.Status = item.statusNaziv;
                r.Tip = item.tipNaziv;
                if (item.modelProcesora != null)
                    r.Procesor = item.modelProcesora;
                if (item.godinaProizvodnje != null)
                    r.GodinaProizvodnje = item.godinaProizvodnje;
                if (r.RowState == System.Data.DataRowState.Detached) // dodavanje novog racunara
                    AppData.Ds.Racunari.AddRacunariRow(r);
            }
            var zaBrisanje = AppData.Ds.Racunari.Where(it => it.IdProstorije == idProstorije && !ids.Contains(it.IdRacunara)).ToArray();
            foreach (var r in zaBrisanje)
                AppData.Ds.Racunari.RemoveRacunariRow(r);
        }

        //public static async Task GetRacunariDodatnoAsync(int idRacunara)
        //{
        //    var url = "https://jisp.mpn.gov.rs/webapi/api/Ustanova/VratiRacunarITabletZaId/21531"
        //}

        #endregion Lokacije, Objekti, Prostorije
    }
}
