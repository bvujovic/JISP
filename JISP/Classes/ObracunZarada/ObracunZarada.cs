using JISP.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Collections.Generic;

namespace JISP.Classes.ObracunZarada
{
    /// <summary>
    /// Rad sa obracunom zarada za zaposlene.
    /// </summary>
    public class ObracunZarada
    {
        /// <summary>
        /// Metoda pravi string u JSON formatu koji ce biti poslat (POST) JISPu radi
        /// kreiranja novog obracuna zarada na osnovu starog i godine i meseca za novi.
        /// </summary>
        public static string KreirajNoviUnos(string strStariUnos, int godina, int mesec)
        {
            dynamic jsonStari = JObject.Parse(strStariUnos);
            var noviPodaci = jsonStari.regZapObracunZaradaDouniverzitetskoObrazovanjeMesec[0];
            var ozm = new OzMesec(godina, mesec);
            noviPodaci.godinaBroj = ozm.Godina;
            noviPodaci.mesecSifarnik = ozm.MesecSifarnik;
            noviPodaci.mesecBroj = ozm.Mesec;
            return jsonStari.ToString();
        }

        /// <summary>
        /// Metoda izvlaci body iz POST request-a.
        /// String request-a je dobijen Copy as cURL (bash) opcijom u DevTools Chrome browser-a.
        /// </summary>
        /// <param name="strBash">POST request dobijen preko Copy as cURL (bash)</param>
        /// <returns>Body POST request-a u JSON formatu.</returns>
        /// <exception cref="Exception">Desava se ako u strBash nije pronadjen "--data-raw".</exception>
        public static string Bash2Json(string strBash)
        {
            var start = "  --data-raw ";
            var idxStart = strBash.IndexOf(start);
            if (idxStart == -1)
                throw new Exception($"Nije pronadjen string: {start}.\r\n"
                    + "Komandu Sačuvaj je potrebno kopirati pomoću opcije: Copy as cURL (bash).");
            idxStart = strBash.IndexOf('\'', idxStart);
            idxStart++;
            var idxEnd = strBash.IndexOf("' \\", idxStart);
            return strBash.Substring(idxStart, idxEnd - idxStart);
        }

        /// <summary>Obracuni zarada u poslednjim mesecu</summary>
        public static IEnumerable<Ds.ObracunZaradaRow> PoslednjiObracuni
            (Ds.ObracunZaradaRow[] ozs, IEnumerable<int> aktivniUgovori)
        {
            if (ozs == null || ozs.Length == 0)
                return Enumerable.Empty<Ds.ObracunZaradaRow>();

            var obracuni = new List<Ds.ObracunZaradaRow>();
            var g = ozs.GroupBy(it => it.IdZaposlenja);
            foreach (var zap in g.Where(it => aktivniUgovori.Contains(it.Key)))
            {
                int mes = zap.Max(it => it.MeseciTotal);
                obracuni.AddRange(zap.Where(it => it.MeseciTotal == mes));
            }
            return obracuni;
        }
    }
}
