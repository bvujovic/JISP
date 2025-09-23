using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace JISP.Data.Iskra
{
    /// <summary>
    /// Ucitavanje podataka iz Iskrinog CSV fajla.
    /// </summary>
    public static class CsvLoader
    {
        public static void LoadFromFile(string filePath)
        {
            using (var sr = new StreamReader(filePath))
            {
                Zaps.Clear();
                Columns.Clear();
                Provere.PrijaveClear();
                var headerLineParsed = false;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (!headerLineParsed && line.Contains("Ime") && line.Contains("Prezime") && line.Contains("JMBG"))
                    {
                        ParseHeaderLine(line);
                        headerLineParsed = true;
                    }
                    else if (headerLineParsed && !string.IsNullOrEmpty(line))
                        ParseDataLine(line);
                }
            }
        }

        private static readonly List<string> Columns = new List<string>();

        public static List<Zaposleni> Zaps { get; } = new List<Zaposleni>();

        public static void ParseHeaderLine(string s)
        {
            // "Ime\tPrezime\tJMBG\tNOKS nivo\tE-mail\tDK Direktor\tDK Pomoćnik direktora\tDK Komb. odeljenje 2 razreda\tDK Spec.odeljenje/škola\tDK Org.praktične nastave\tDK Zvanje jednog.specijalizaci\tDK Zvanje magistra\tDK škola sa domom\tSaradnički koef.\tMin.rad G\tMin.rad M\tMin.rad D\tMin.rad za obračun G\tMin.rad za obračun M\tDatum poč.\tDat.zav.\tTip radnje\tRazlog za radnju\tStatus zaposlenja\tVrsta zaposlenja\tPosao\tOsnovni koeficijent\tUkupni koeficijent\tZaposl. %\tUlica i kućni broj"
            var parts = s.Split('\t');
            foreach (var p in parts)
                Columns.Add(p);
        }

        /*
                  public static void ParseDataLine(string s)
        {
            // ci (CultureInfo) se koristi samo za parsiranje brojeva - decimalna tacka vs decimalni zarez
            //var ci = new CultureInfo("sr-Cyrl-CS");
            var ci = CultureInfo.CurrentCulture;
            // "IRENA\tRUDAN\t0305986715210\t71\tIRENARUDAN86@GMAIL.COM\t      0,00\t                0,00\t                       0,00\t                  1,73\t                   0,00\t                         0,00\t             0,00\t            0,00\t           0,00\t 11,0000\t  0,0000\t 17,0000\t            11,0000\t             0,0000\t01.11.2022\t31.12.9999\tRASPOREĐIVANJE (MIGRACIJA)\tRASPOREĐIVANJE (MIGRACIJA)\tAKTIVNO\tNEODREĐENO\tDEFEKTOLOG - VASPITAČ\t             17,32\t            19,05\t  100,00\tDRAGOSLAVA SREJOVIĆA"
            var parts = s.Split('\t');
            //if (parts.Length == Columns.Count)
            //    ;
            var zap = new Zaposleni();
            var nje = new Zaposlenje();
            for (int i = 0; i < parts.Length; i++)
            {
                var p = parts[i].Trim();
                if (Columns.IndexOf(nameof(zap.Ime)) == i)
                    zap.Ime = p;
                if (Columns.IndexOf(nameof(zap.Prezime)) == i)
                    zap.Prezime = p;
                if (Columns.IndexOf(nameof(zap.JMBG)) == i)
                    zap.JMBG = p;
                if (Columns.IndexOf("NOKS nivo") == i)
                {
                    Console.WriteLine(zap);
                    // za 71 -> 7.1
                    //zap.NOKS = string.IsNullOrEmpty(p) ? p : p.Insert(1, ".");
                    // za 71.3 -> 7.1
                    zap.NOKS = string.IsNullOrEmpty(p) || p.Length != 4 ? p : p.Substring(0, 2).Insert(1, ".");
                }
         */

        public static void ParseDataLine(string s)
        {
            var ci = new CultureInfo("sr-Cyrl-CS");
            // "IRENA\tRUDAN\t0305986715210\t71\tIRENARUDAN86@GMAIL.COM\t      0,00\t                0,00\t                       0,00\t                  1,73\t                   0,00\t                         0,00\t             0,00\t            0,00\t           0,00\t 11,0000\t  0,0000\t 17,0000\t            11,0000\t             0,0000\t01.11.2022\t31.12.9999\tRASPOREĐIVANJE (MIGRACIJA)\tRASPOREĐIVANJE (MIGRACIJA)\tAKTIVNO\tNEODREĐENO\tDEFEKTOLOG - VASPITAČ\t             17,32\t            19,05\t  100,00\tDRAGOSLAVA SREJOVIĆA"
            var parts = s.Split('\t');
            //if (parts.Length == Columns.Count)
            //    ;
            var zap = new Zaposleni();
            var nje = new Zaposlenje();
            for (int i = 0; i < parts.Length; i++)
            {
                var p = parts[i].Trim();
                if (Columns.IndexOf(nameof(zap.Ime)) == i)
                    zap.Ime = p;
                if (Columns.IndexOf(nameof(zap.Prezime)) == i)
                    zap.Prezime = p;
                if (Columns.IndexOf(nameof(zap.JMBG)) == i)
                    zap.JMBG = p;
                if (Columns.IndexOf("NOKS nivo") == i)
                    zap.NOKS = string.IsNullOrEmpty(p) ? p : p.Insert(1, ".");
                if (Columns.IndexOf("E-mail") == i)
                    zap.Email = p;
                if (Columns.IndexOf("Min.rad G") == i)
                    zap.MinRadGod = (int)double.Parse(p, ci);
                if (Columns.IndexOf("Min.rad M") == i)
                    zap.MinRadMes = (int)double.Parse(p, ci);
                if (Columns.IndexOf("Min.rad D") == i)
                    zap.MinRadDan = (int)double.Parse(p, ci);

                if (Columns.IndexOf("Ulica i kućni broj") == i)
                    zap.UlicaIBroj = p;

                if (Columns.IndexOf("DK Direktor") == i)
                    nje.DkDir = double.Parse(p, ci);
                if (Columns.IndexOf("DK Pomoćnik direktora") == i)
                    nje.DkPomDir = double.Parse(p, ci);
                if (Columns.IndexOf("DK Komb. odeljenje 2 razreda") == i)
                    nje.DkKomb2 = double.Parse(p, ci);
                if (Columns.IndexOf("DK Org.praktične nastave") == i)
                    nje.DkOrganizator = double.Parse(p, ci);
                if (Columns.IndexOf("DK Zvanje jednog.specijalizaci") == i)
                    nje.Dk1godSpec = double.Parse(p, ci);
                if (Columns.IndexOf("DK Zvanje magistra") == i)
                    nje.DkMagistar = double.Parse(p, ci);
                if (Columns.IndexOf("Osnovni koeficijent") == i)
                    nje.KoefOsnovni = double.Parse(p, ci);
                if (Columns.IndexOf("Ukupni koeficijent") == i)
                    nje.KoefUkupni = double.Parse(p, ci);
                if (Columns.IndexOf("Status zaposlenja") == i)
                    nje.StatusZaposlenja = p;
                if (Columns.IndexOf("Vrsta zaposlenja") == i)
                    nje.VrstaZaposlenja = p;
                if (Columns.IndexOf("Posao") == i)
                    nje.Posao = p;
                if (Columns.IndexOf("Zaposl. %") == i)
                    nje.Procenat = double.Parse(p, ci);
            }
            var z = Zaps.FirstOrDefault(it => it.JMBG == zap.JMBG);
            if (nje.StatusZaposlenja == "AKTIVNO")
            {
                if (z == null) // novi zaposleni - ucitavaju se podaci o zaposlenom i dodaje mu se zaposlenje
                {
                    zap.Zaposlenja.Add(nje);
                    Zaps.Add(zap);
                }
                else // zaposleni je vec ucitan, dodaje se zaposlenje
                {
                    if (!Provere.IdenticniOsnovniPodaci(z, zap, out string svojstvo))
                        Provere.Prijavi(nameof(Provere.IdenticniOsnovniPodaci), z
                            , $"'{svojstvo}' ima različite vrednosti u zaposlenjima za istog zaposlenog");
                    z.Zaposlenja.Add(nje);
                    z.NOKS = string.Compare(zap.NOKS, z.NOKS) == 1 ? zap.NOKS : z.NOKS;
                }
            }
        }
    }
}
