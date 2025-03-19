using JISP.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;

namespace JISP.Data.Iskra
{
    public static class Provere
    {
        public static void IzvrsiSve()
        {
            NedostajuZaposleni();
            UkupnoAngazovanjeVeceOd100();
            JispIskraZaposleniRazlike();
            JispIskraZaposlenjaRazlike();
            // JISP vs ISKRA razlike
            //   zaposleni: ime, prezime, NOKS, e-mail adresama, adresama stanovanja, minuli staz
            //   zaposlenja: poslovi, procenti ang...
        }

        /// <summary>Prikaz podataka koji se nece automatski porediti JISP vs ISKRA: adresa, minuli staz, koeficijenti...</summary>
        public static void SacuvajOstalo()
        {
            using (var sw = new StreamWriter(fileNameBase + "_ostalo.log"))
                foreach (var zap in CsvLoader.Zaps)
                    try
                    {
                        var jispZap = JispZap(zap.JMBG);
                        if (jispZap == null)
                            continue;

                        sw.Write($"{zap}");
                        //sw.Write($"\t{zap.UlicaIBroj}\t{jispZap.Prebivaliste}");
                        sw.WriteLine();
                        foreach (var nja in zap.Zaposlenja)
                        {
                            sw.Write($"{nja.Procenat,8:0.##}% {nja.Posao,45},   Osn koef:{nja.KoefOsnovni,6:0.00},   Uk koef:{nja.KoefUkupni,6:0.00}");
                            if (nja.DkDir != 0)
                                sw.Write($",\tDir koef: {nja.DkDir}");
                            if (nja.DkPomDir != 0)
                                sw.Write($",\tPomdir koef: {nja.DkPomDir}");
                            if (nja.DkOrganizator != 0)
                                sw.Write($",\tOrg koef: {nja.DkOrganizator}");
                            if (nja.DkMagistar != 0)
                                sw.Write($",\tMag koef: {nja.DkMagistar}");
                            if (nja.Dk1godSpec != 0)
                                sw.Write($",\tSpec1 koef: {nja.Dk1godSpec}");
                            if (nja.DkKomb2 != 0)
                                sw.Write($",\tKomb koef: {nja.DkKomb2}");
                            sw.WriteLine();
                        }
                    }
                    catch (Exception ex) { Utils.ShowMbox(ex, nameof(SacuvajOstalo)); }
        }

        private static void JispIskraZaposlenjaRazlike()
        {
            foreach (var zap in CsvLoader.Zaps)
                try
                {
                    var jispZap = JispZap(zap.JMBG);
                    if (jispZap == null)
                        continue;

                    // broj (count) zaposlenja, radno mesto
                    var zapsIskra = zap.Zaposlenja;
                    var zapsJisp = jispZap.GetZaposlenjaRows()
                        .Where(it => it.Aktivan && it.Valid_NemaGreske).ToList();
                    if (zapsJisp.Any(it => it.RadnoMestoNaziv.StartsWith("Директор")))
                        zapsJisp.RemoveAll(it => !it.RadnoMestoNaziv.StartsWith("Директор"));
                    if (zapsJisp.Any(it => it.RadnoMestoNaziv.StartsWith("Помоћник директора")))
                        zapsJisp.RemoveAll(it => !it.RadnoMestoNaziv.StartsWith("Помоћник директора"));
                    if (zapsIskra.Count == zapsJisp.Count && zapsIskra.Count == 1)
                    {
                        var zapIskra = zapsIskra.First().Posao;
                        var zapJisp = zapsJisp.First().RadnoMestoNaziv;
                        if (!IstoRM(zapIskra, zapJisp))
                            Prijavi(nameof(JispIskraZaposlenjaRazlike), zap
                                , $"Različita radna mesta: ISKRA ({zapIskra}), JISP ({zapJisp})");
                    }
                    else
                    {
                        var iskra = string.Join("\r\n", zapsIskra.Select(it => $"\t{it.Procenat:0.##}% {it.Posao}"));
                        var jisp = string.Join("\r\n", zapsJisp.Select(it => $"\t{it.ProcenatRadnogVremena:0.##}% {it.RadnoMestoNaziv}"));
                        Prijavi(nameof(JispIskraZaposlenjaRazlike), zap
                            , $"Različita zaposlenja\r\nISKRA{iskra}\r\nJISP{jisp}");
                    }
                }
                catch (Exception ex) { Prijavi(nameof(JispIskraZaposlenjaRazlike), zap, ex.Message); }
        }

        private static bool IstoRM(string zapIskra, string zapJisp)
        {
            zapJisp = LatinicaCirilica.Cir2Lat(zapJisp).ToUpper();
            if (zapIskra.Contains("DEFEKTOLOG - VASPITAČ") && zapJisp.Contains("DEFEKTOLOG - VASPITAČ"))
                return true;
            if (zapIskra.Contains("NASTAVNIK PREDMETNE NASTAVE U POS.USL") && zapJisp.Contains("NASTAVNIK PREDMETNE NASTAVE U POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("NASTAVNIK PREDM.NASTAVE SA OD.ST.U P.USL") && zapJisp.Contains("NASTAVNIK PREDMETNE NASTAVE SA ODELJENJSKIM STAREŠINSTVOM U   POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("NASTAVNIK RAZREDNE NASTAVE U POS.USLOV.") && zapJisp.Contains("NASTAVNIK RAZREDNE NASTAVE U POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("NASTAVNIK PRAKTIČNE NASTAVE U POS.USL.") && zapJisp.Contains("NASTAVNIK PRAKTIČNE NASTAVE U POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("NASTAVNIK PRAKT.NASTAVE SA OD.ST.U P.USL") && zapJisp.Contains("NASTAVNIK PRAKTIČNE NASTAVE SA ODELJENJSKIM STAREŠINSTVOM U POSEBNIM USLOVIMA"))
                return true;

            if (zapIskra.Contains("DIREKTOR USTANOVE U POSEBNIM USLOVIMA") && zapJisp.Contains("DIREKTOR USTANOVE U POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("POMOĆNIK DIREKTORA USTANOVE U POS.USL") && zapJisp.Contains("POMOĆNIK DIREKTORA USTANOVE U POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("SEKRETAR USTANOVE U POSEBNIM USLOVIMA") && zapJisp.Contains("SEKRETAR USTANOVE U POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("DOMAR/MAJSTOR ODRŽAVANJA U POS.USLOVIMA") && zapJisp.Contains("DOMAR/MAJSTOR"))
                return true;
            if (zapIskra.Contains("MEDICINSKI TEHNIČAR U POSEBNIM USLOVIMA") && zapJisp.Contains("MEDICINSKI TEHNIČAR"))
                return true;
            if (zapIskra.Contains("ČISTAČICA U POSEBNIM USLOVIMA RADA") && zapJisp.Contains("ČISTAČICA U POSEBNIM USLOVIMA RADA"))
                return true;
            if (zapIskra.Contains("RADNIK ZA ODRŽAVANJE ODEĆE") && zapJisp.Contains("RADNIK ZA ODRŽAVANJE ODEĆE"))
                return true;
            if (zapIskra.Contains("REFERENT ZA FIN-RAČUN.POSLOVE U POS.USL") && zapJisp.Contains("REFERENT ZA FINANSIJSKO - RAČUNOVODSTVENE POSLOVE U POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("STR.S.-BIBLIOTEKAR/NOTOTEK./MEDIJAT.U PU") && zapJisp.Contains("STRUČNI SARADNIK - BIBLIOTEKAR / NOTOTEKAR / MEDIJATEKAR U POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("TEHNIČKI SEKRETAR") && zapJisp.Contains("TEHNIČKI SEKRETAR"))
                return true;
            if (zapIskra.Contains("KUVAR/POSLASTIČAR U POSEBNIM USLOVIMA") && zapJisp.Contains("KUVAR/POSLASTIČAR U POSEBNIM USLOVIMA"))
                return true;
            if (zapIskra.Contains("POMOĆNI NASTAVNIK U POSEBNIM USLOVIMA") && zapJisp.Contains("POMOĆNI NASTAVNIK U POSEBNIM USLOVIMA"))
                return true;

            return false;
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

                    var oz = jispZap.GetObracunZaradaRows().LastOrDefault();
                    if (oz == null || oz.IsStazNull())
                        Prijavi(nameof(JispIskraZaposleniRazlike), zap, "JISP nema podatke o stažu");
                    else
                    {
                        if (zap.MinRadGod != oz.Staz && zap.MinRadGod + 1 != oz.Staz)
                            Prijavi(nameof(JispIskraZaposleniRazlike), zap
                                , $"Neslaganje u podacima o radnom stažu: ISKRA ({zap.MinRadGod}-{zap.MinRadMes}), JISP ({oz.Staz})");
                    }
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

        private static string fileNameBase;

        public static string SacuvajIzvestaj(string inputFileName)
        {
            var idxDot = inputFileName.LastIndexOf('.');
            fileNameBase = inputFileName.Substring(0, idxDot);
            var logFileName = fileNameBase + ".log";
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
