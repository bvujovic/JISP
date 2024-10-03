using JISP.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace JISP.Data.Iskra
{
    public static class Provere
    {
        public static void IzvrsiSve()
        {
            NedostajuZaposleni();
            UkupnoAngazovanjeVeceOd100();
            JispIskraZaposleniRazlike();
            // JISP vs ISKRA razlike
            //   zaposleni: ime, prezime, NOKS, e-mail adresama, adresama stanovanja, minuli staz
            //   zaposlenja: poslovi, procenti ang...
        }

        /// <summary>Razlike u osnovnim podacima o zaposlenima: ime, prezime, NOKS, e-mail, adresa, min staz</summary>
        private static void JispIskraZaposleniRazlike()
        {
            foreach (var zap in CsvLoader.Zaps)
                try
                {
                    var jispZap = JispZap(zap.JMBG);
                    if (jispZap == null)
                        continue;

                    var jispIme = LatinicaCirilica.Cir2Lat(jispZap.Ime);
                    if (string.Compare(zap.Ime, jispIme, true) != 0)
                        Prijavi(nameof(JispIskraZaposleniRazlike), zap, $"Različito IME, JISP: {jispIme}");

                    var jispPrezime = LatinicaCirilica.Cir2Lat(jispZap.Prezime);
                    if (string.Compare(zap.Prezime, jispPrezime, true) != 0)
                    {
                        // izuzetak: razlika u imenu cir-lat
                        if (!(jispZap.Prezime == "Бечеи" && zap.Prezime == "BECSEI"))
                            Prijavi(nameof(JispIskraZaposleniRazlike), zap, $"Različito PREZIME, JISP: {jispPrezime}");
                    }

                    var jispNOKSovi = jispZap.GetZaposlenjaRows().Where(it => it.Aktivan)
                        .Select(it => it.NoksNivoNaziv).Distinct();
                    if (jispNOKSovi.Count() == 0)
                    {
                        if (!prijave.Any(it => it.Provera == nameof(NedostajuZaposleni) && it.Opis.Contains("ne postoji u JISP-u")))
                            Prijavi(nameof(JispIskraZaposleniRazlike), zap, "JISP: Nema podataka o NOKS-ovima zaposlenog. Možda više nije aktivan.");
                    }
                    else if (jispNOKSovi.Count() > 1)
                        Prijavi(nameof(JispIskraZaposleniRazlike), zap, $"Različiti NOKS-ovi u JISP-u u zaposlenjima");
                    else
                    {
                        var jispNOKS = jispNOKSovi.First();
                        if (jispNOKS.StartsWith("НОКС ")) // NOKSovi 2-5, mozda i 8
                            jispNOKS = $"{jispNOKS[5]}.0";
                        else if (jispNOKS.Contains("Основно образовање"))
                            jispNOKS = "1.0";
                        else
                            jispNOKS = jispNOKS.Substring(0, 3);
                        // JISP nema opcije 4.1 i 4.2
                        var jeNOKS4 = zap.NOKS.StartsWith("4") && jispNOKS.StartsWith("4");
                        if (zap.NOKS != jispNOKS && !jeNOKS4)
                            Prijavi(nameof(JispIskraZaposleniRazlike), zap, $"Različiti NOKS, JISP: {jispNOKS}, ISKRA: {zap.NOKS}");
                    }

                    if (!string.IsNullOrEmpty(zap.Email) && 
                        !jispZap.IsEmailNull() && !string.IsNullOrEmpty(jispZap.Email))
                    {
                        if (string.Compare(zap.Email, jispZap.Email, true) != 0)
                            Prijavi(nameof(JispIskraZaposleniRazlike), zap, $"Različiti E-mail, JISP: {jispZap.Email}, ISKRA: {zap.Email}");
                    }
                    else
                        if (!string.IsNullOrEmpty(zap.Email))
                        Prijavi(nameof(JispIskraZaposleniRazlike), zap, $"JISP nema E-mail, ISKRA: {zap.Email}");
                }
                catch (Exception ex) { Prijavi(nameof(JispIskraZaposleniRazlike), zap, ex.Message); }
        }

        /// <summary>Koji zaposleni imaju ukupno angazovanje > 100%</summary>
        private static void UkupnoAngazovanjeVeceOd100()
        {
            foreach (var zap in CsvLoader.Zaps)
                try
                {
                    var ukupnoAngazovanje = zap.Zaposlenja.Sum(it => it.Procenat);
                    //TODO ukinuti ovaj filter sa NOKSovima kada se resi problem sa dvostrukim vrednostima
                    // za NOKS za nekoliko zaposlenih: Milanka, Jasminka, Ljubica Golubovic, J. Gladovic...
                    var imaRazliciteNOKSove = prijave.Where(it => it.Zaposleni.Equals(zap)
                        && it.Opis.Contains("'NOKS' ima različite vrednosti")
                        && it.Provera == nameof(IdenticniOsnovniPodaci)).Any();
                    if (ukupnoAngazovanje > 100 && !imaRazliciteNOKSove)
                        Prijavi(nameof(UkupnoAngazovanjeVeceOd100), zap, $"Ukupno angazovanje je {ukupnoAngazovanje}");
                }
                catch (Exception ex) { Prijavi(nameof(UkupnoAngazovanjeVeceOd100), zap, ex.Message); }
        }

        private static Ds.ZaposleniRow JispZap(string jmbg)
            => AppData.Ds.Zaposleni.FirstOrDefault(it => it.JMBG == jmbg);

        /// <summary>Da li neki zaposleni nedostaju u Jispu ili u Iskri</summary>
        private static void NedostajuZaposleni()
        {
            foreach (var z in CsvLoader.Zaps)
            {
                if (!AppData.Ds.Zaposleni.Where(it => it.Aktivan).Any(it => it.JMBG == z.JMBG))
                    Prijavi(nameof(NedostajuZaposleni), z, $"ne postoji u JISP-u");
            }
            foreach (var z in AppData.Ds.Zaposleni.Where(it => it.Aktivan))
            {
                if (!CsvLoader.Zaps.Any(it => it.JMBG == z.JMBG))
                    Prijavi(nameof(NedostajuZaposleni), IskraZaposleni(z), $"ne postoji u Iskri");
            }
        }

        private static Zaposleni IskraZaposleni(Ds.ZaposleniRow z)
            => new Zaposleni
            {
                Ime = z.Ime,
                Prezime = z.Prezime,
                JMBG = z.JMBG,
                //Email = z.Email,
            };

        /// <summary>Da li su zaposlenima svi podaci isti ne računajući zaposlenja.</summary>
        /// <param name="svojstvo">Svojstvo/kolona na kojem je došlo do neslaganja.</param>
        public static bool IdenticniOsnovniPodaci(Zaposleni a, Zaposleni b, out string svojstvo)
        {
            if (a.Ime != b.Ime)
                return SvojstvoProblem(nameof(a.Ime), out svojstvo);
            if (a.Prezime != b.Prezime)
                return SvojstvoProblem(nameof(a.Prezime), out svojstvo);
            if (a.JMBG != b.JMBG)
                return SvojstvoProblem(nameof(a.JMBG), out svojstvo);
            if (a.NOKS != b.NOKS)
                return SvojstvoProblem(nameof(a.NOKS), out svojstvo);
            if (a.Email != b.Email)
                return SvojstvoProblem(nameof(a.Email), out svojstvo);

            if (a.MinRadGod != b.MinRadGod)
                return SvojstvoProblem(nameof(a.MinRadGod), out svojstvo);
            if (a.MinRadMes != b.MinRadMes)
                return SvojstvoProblem(nameof(a.MinRadMes), out svojstvo);
            if (a.MinRadDan != b.MinRadDan)
                return SvojstvoProblem(nameof(a.MinRadDan), out svojstvo);
            if (a.UlicaIBroj != b.UlicaIBroj)
                return SvojstvoProblem(nameof(a.UlicaIBroj), out svojstvo);

            svojstvo = null;
            return true;
        }

        private static bool SvojstvoProblem(string svojstvoNaziv, out string svojstvo)
        {
            svojstvo = svojstvoNaziv;
            return false;
        }

        public static string SacuvajIzvestaj(string inputFileName)
        {
            var idxDot = inputFileName.LastIndexOf('.');
            var logFileName = inputFileName.Substring(0, idxDot) + ".log";
            using (var sw = new StreamWriter(logFileName))
            {
                foreach (var p in prijave)
                    sw.WriteLine(p);
            }
            return logFileName;
        }

        class Prijava
        {
            public string Provera { get; set; }
            public Zaposleni Zaposleni { get; set; }
            public string Opis { get; set; }
            public override string ToString()
                => $"{Provera} - Zaposleni: {Zaposleni,-40}Opis: {Opis}";
        }

        private static readonly List<Prijava> prijave = new List<Prijava>();

        public static void PrijaveClear()
            => prijave.Clear();

        public static void Prijavi(string provera, Zaposleni z, string opis)
        {
            prijave.Add(new Prijava() { Provera = provera, Zaposleni = z, Opis = opis });
        }
    }
}
