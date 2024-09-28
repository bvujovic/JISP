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
            // da li je ukupno angazovanje nekih zaposlenih > 100%
            // da li se min staz mnogo razlikuje JISP vs ISKRA
            // razlike u e-mail adresama, adresama stanovanja, NOKS, ime, prezime
        }

        /// <summary>Da li neki zaposleni nedostaju u Jispu ili u Iskri</summary>
        public static void NedostajuZaposleni()
        {
            foreach (var z in CsvLoader.Zaps)
            {
                if (!AppData.Ds.Zaposleni.Any(it => it.JMBG == z.JMBG))
                    Prijavi(nameof(NedostajuZaposleni), z, $"ne postoji u JISP-u");
            }
            foreach (var z in AppData.Ds.Zaposleni.Where(it => it.Aktivan))
            {
                if (!CsvLoader.Zaps.Any(it => it.JMBG == z.JMBG))
                    Prijavi(nameof(NedostajuZaposleni), IskraZaposleni(z), $"ne postoji u Iskri");
            }
        }

        private static Zaposleni IskraZaposleni(Ds.ZaposleniRow z)
            => new Zaposleni { 
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

        private static List<Prijava> prijave = new List<Prijava>();

        public static void Prijavi(string provera, Zaposleni z, string opis)
        {
            prijave.Add(new Prijava() { Provera = provera, Zaposleni = z, Opis = opis });
        }
    }
}
