using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using JISP.Classes;
using System.Diagnostics;

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
                z.ImaDokument = obj.ugovorORaduDokumentNaziv != null && obj.ugovorORaduDokumentNaziv != "";
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

        /// <summary>Učitava podateke u tabelu Sistematizacija.</summary>
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
                foreach (var z in obj.zahtevi)
                {
                    if (z.lice != null && z.lice.job != null && (z.lice.jePrivremeniJOB == null || !(bool)z.lice.jePrivremeniJOB)
                        && (z.lice.jeOpozvanJOB == null || !(bool)z.lice.jeOpozvanJOB))
                    {
                        var uc = AppData.Ds.Ucenici.FirstOrDefault(it => it.JOB == (string)z.lice.job);
                        if (uc != null)
                        {
                            uc.JMBG = z.lice.jmbg;
                            if (!uc.IsDatumRodjenjaNull() && JMBG.GetBirthDate(uc.JMBG) != uc.DatumRodjenja)
                                ucsDatRodj.Add(uc.ToString());
                            //? Ovde je moguce ucitati posebno ime, prezime i ime roditelja za svakog ucenika
                            //Console.WriteLine(z.lice.ime);
                            //Console.WriteLine(z.lice.prezime);
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
            AppData.Ds.Prostorije.Clear();
            foreach (var lok in AppData.Ds.Objekti)
            {
                var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_ProstorijeOsnovno, lok.IdObjekta.ToString());
                dynamic arr = Newtonsoft.Json.Linq.JArray.Parse(json);
                foreach (var item in arr)
                {
                    var p = AppData.Ds.Prostorije.NewProstorijeRow();
                    p.IdProstorije = item.id;
                    p.NazivProstorije = item.nazivProstorije;
                    p.IdObjekta = item.idObjekta;
                    p.TipProstorije = item.tipProstorijeNaziv;
                    p.Povrsina = item.povrsina;
                    p.ProsecnaVisinaPlafona = item.prosecnaVisinaPlafona;
                    p.DostupLicimaSaSpecPotrebama = item.dostupnostLicimaSaSpecijalnimPotrebamaNaziv;
                    AppData.Ds.Prostorije.AddProstorijeRow(p);
                }
            }
        }

        /// <summary>Učitava podatke u tabelu Prostorije.</summary>
        public static async Task GetProstorijeDodatnoAsync(int idProstorije)
        {
            var json = await WebApi.GetJson(WebApi.ReqEnum.Ustanova_ProstorijeDodatno, idProstorije.ToString());
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
            var p = AppData.Ds.Prostorije.FindByIdProstorije(idProstorije);
            if (p != null)
            {
                p.IdTipaProstorije = (int)obj.tipProstorije;
                p.IdSprata = (int)obj.sprat;
                p.Sprat = AppData.Ds.SifSpratovi.FindByIdSprata(p.IdSprata).NazivSprata;
                p.IzvorGrejanja = obj.izvorGrejanja;
                if (obj.vrstaIzvoraGrejanja != null)
                {
                    p.IdVrsteIzvoraGrejanja = (int)obj.vrstaIzvoraGrejanja;
                    p.VrstaIzvoraGrejanja = AppData.Ds.SifGrejanja.FindByIdGrejanja(p.IdVrsteIzvoraGrejanja).NazivGrejanja;
                }
                p.IzvorHladjenja = obj.izvorHladjenja;
                if (obj.vrstaIzvoraHladjenja != null)
                {
                    p.IdVrsteIzvoraHladjenja = (int)obj.vrstaIzvoraHladjenja;
                    p.VrstaIzvoraHladjenja = AppData.Ds.SifHladjenja.FindByIdHladjenja((int)obj.vrstaIzvoraHladjenja).NazivHladjenja;
                }
                p.ProstorijaSeKoristi = obj.prostorijaSeKoristi;
                p.MobilniInternet = obj.mobilniInternet;
                p.BrzinaBezicnogInterneta = obj.brzinaBezicnogInterneta;
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
            foreach (var item in arr)
            {
                Ds.RacunariRow r = AppData.Ds.Racunari.FindByIdRacunara((int)item.id);
                if (r == null)
                    r = AppData.Ds.Racunari.NewRacunariRow();
                r.IdRacunara = item.id;
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
        }

        //public static async Task GetRacunariDodatnoAsync(int idRacunara)
        //{
        //    var url = "https://jisp.mpn.gov.rs/webapi/api/Ustanova/VratiRacunarITabletZaId/21531"
        //}

        #endregion Lokacije, Objekti, Prostorije
    }
}
