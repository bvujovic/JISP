using Newtonsoft.Json.Linq;
using System;

namespace JISP.Classes.KoefDuos
{
    /// <summary>
    /// Rad sa koeficijentima zaposlenih u DUOSu.
    /// </summary>
    public class KoefDuos
    {
        /// <summary>
        /// Metoda pravi string u JSON formatu koji ce biti poslat (POST) JISPu radi
        /// kreiranja novog koef. zap. u DUOSu na osnovu starog i godine i meseca za novi.
        /// </summary>
        public static string KreirajNoviUnos(string strStariUnos, int godina, int mesec)
        {
            dynamic jsonStari = JObject.Parse(strStariUnos);
            var noviPodaci = jsonStari.regZapObracunZaradaDouniverzitetskoObrazovanjeMesec[0];
            var kdm = new KoefDuosMesec(godina, mesec);
            noviPodaci.godinaBroj = kdm.Godina;
            noviPodaci.mesecSifarnik = kdm.MesecSifarnik;
            noviPodaci.mesecBroj = kdm.Mesec;
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
            var start = "  --data-raw '";
            var idxStart = strBash.IndexOf(start);
            if (idxStart == -1)
                throw new Exception($"Nije pronadjen string: {start}.\r\n"
                    + "Komandu Sačuvaj je potrebno kopirati pomoću opcije: Copy as cURL (bash).");
            idxStart += start.Length;
            var idxEnd = strBash.IndexOf("' \\", idxStart);
            return strBash.Substring(idxStart, idxEnd- idxStart);
        }
    }
}
