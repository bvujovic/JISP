using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace JISP.Data
{
    /// <summary>
    /// Komunikacija sa Web API-em JISP sistema.
    /// </summary>
    public static class WebApi
    {
        // len:     688
        private static string token;

        public static string Token
        {
            get { return token; }
            set
            {
                if (value != null && IsTokenFormatOk(value))
                    token = value;
            }
        }

        public const string SV_SAVA_ID = "18976";
        public const string TOKEN_MISSING = "???";
        public const string TOKEN_CAPTION = "ApiToken";

        public static bool IsTokenValid()
            => token != null && token.Length >= 100 && IsTokenFormatOk(token);

        public static string TokenDisplay
            => IsTokenValid() ? token.Substring(0, 10) + "..." + token.Substring(token.Length - 10) : TOKEN_MISSING;

        /// <summary>Uzimanje API token-a iz request header-a nekog zahteva.</summary>
        public static void TakeApiToken(string clipboard)
        {
            if (string.IsNullOrEmpty(clipboard))
                throw new ArgumentNullException(nameof(clipboard));
            var start = "Authorization: Bearer ";
            var idxStart = clipboard.IndexOf(start);
            if (idxStart == -1)
                throw new FormatException($"API token ({start}...) nije pronađen u clipboard-u.");
            idxStart += start.Length;
            var idxEnd = clipboard.IndexOf(Environment.NewLine, idxStart);
            Token = clipboard.Substring(idxStart, idxEnd - idxStart);
            if (!IsTokenFormatOk(Token))
                throw new FormatException("Token nije u formatu \"xxxxx.yyyyy.zzzzz\"");
        }

        private static bool IsTokenFormatOk(string token)
        {
            var idxDot = token.IndexOf('.');
            if (idxDot < 1) return false;
            idxDot = token.IndexOf(".", idxDot + 1);
            if (idxDot < 1) return false;
            return true;
        }

        /// <summary>Dohvata listu trazenih objekata od JISP WebAPI-a.</summary>
        public async static Task<List<T>> GetList<T>(ReqEnum reqEnum)
        {
            var json = await GetJson(reqEnum);
            return DeserializeList<T>(json);
        }

        public static List<T> DeserializeList<T>(string json)
            => Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);

        /// <summary>Dohvata trazeni objekat od JISP WebAPI-a.</summary>
        public async static Task<T> GetObject<T>(ReqEnum reqEnum, string param = null)
        {
            var json = await GetJson(reqEnum, param);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>Dohvata trazeni objekat od JISP WebAPI-a.</summary>
        public async static Task<T> GetObject<T>(string url)
        {
            var json = await GetJson(url);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>Dohvata (GET) JSON podatke od JISP WebAPI-a.</summary>
        /// <see cref="https://stackoverflow.com/questions/14627399/setting-authorization-header-of-httpclient"/>
        public static async Task<string> GetJson(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                return await client.GetStringAsync(url);
            }
        }

        /// <summary>Dohvata (GET) JSON podatke od JISP WebAPI-a.</summary>
        /// <see cref="https://stackoverflow.com/questions/14627399/setting-authorization-header-of-httpclient"/>
        public static async Task<string> GetJson(ReqEnum reqEnum, string param = null)
        {
            return await GetJson(UrlForReq(reqEnum, param));
        }

        /// <summary>Dohvata (POST) JSON podatke od JISP WebAPI-a.</summary>
        public static async Task<string> PostForJson(ReqEnum reqEnum, string body, string param = null)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                var url = UrlForReq(reqEnum, param);
                var content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
                var res = await client.PostAsync(url, content);

                if (res.IsSuccessStatusCode)
                    return await res.Content.ReadAsStringAsync();
                else
                    throw new Exception($"POST response error: {res.ReasonPhrase}");
            }
        }

        /// <summary>Dohvata (POST) trazeni objekat od JISP WebAPI-a.</summary>
        public async static Task<T> PostForObject<T>(ReqEnum reqEnum, string param = null)
        {
            var json = await PostForJson(reqEnum, param);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>Dohvata (POST) listu trazenih objekata od JISP WebAPI-a.</summary>
        public async static Task<List<T>> PostForList<T>(ReqEnum reqEnum, string body, string param = null)
        {
            var json = await PostForJson(reqEnum, body, param);
            return DeserializeList<T>(json);
        }

        /// <summary>Preuzimanje fajla od JISPa u Downloads i njegovo pokretanje.</summary>
        public static async Task PostForFile(string filePath, string url, string content, bool isJson)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                url = "https://jisp.mpn.gov.rs/webapi/api/" + url;
                var jsonContent = new StringContent(content, System.Text.Encoding.UTF8, "application/json");
                var res = await client.PostAsync(url, jsonContent);
                if (res.IsSuccessStatusCode)
                {
                    byte[] data = null;
                    if (isJson)
                    {
                        var json = await res.Content.ReadAsStringAsync();
                        dynamic jobj = Newtonsoft.Json.Linq.JObject.Parse(json);
                        data = Convert.FromBase64String((string)jobj.sadrzaj);
                    }
                    else
                    {
                        data = new byte[res.Content.Headers.ContentLength.Value];
                        data = await res.Content.ReadAsByteArrayAsync();
                    }
                    System.IO.File.WriteAllBytes(filePath, data);
                    System.Diagnostics.Process.Start(filePath);
                }
                else
                    throw new Exception($"POST response error: {res.ReasonPhrase}");
            }
        }

        public enum ReqEnum
        {
            /// <summary>Ime, Prezime, JMBG</summary>
            Zap_Opste,
            /// <summary>Telefon, Mejl, Adresa</summary>
            Zap_Dodatno,
            Zap_Zaposlenja,
            Zap_ObracunZarada,
            Zap_ObracunZaradaKreiraj,
            Zap_ObracunZaradaObrisi,
            Zap_ObracunZaradaOpis,
            Zap_Angazovanja,
            Zap_Resenja,
            Zap_Sistematizacija,
            Zap_SistematizacijaDetalji,
            Zap_IzvoriFinansiranja,
            Zap_SistematizacijaSacuvajNormu,

            Zap_PorukaOdbijeniCenus,
            Zap_PorukaOdbijenaSistematizacija,

            Uc_DuosSrednjoskolci,
            Uc_DuosSrednjoskolciId,

            Uc_DuosDeca,
            /// <summary>DUOS osnovna skola: job, razred, odeljenje</summary>
            Uc_DuosOS,
            /// <summary>DUOS srednja skola: job, razred, odeljenje</summary>
            Uc_DuosSS,
            Uc_DuosDomGrupe,
            /// <summary>Opsti podaci o jednom uceniku</summary>
            Uc_OpstiPodaci,

            Job_PreuzmiListuZahteva,

            Ustanova_Lokacije,
            Ustanova_Objekti,
            Ustanova_ObjektiDodatno,
            Ustanova_ProstorijeOsnovno,
            Ustanova_ProstorijeDodatno,
            Ustanova_ProstorijeAzuriraj,
            Ustanova_Spratovi,
            Ustanova_Grejanje,
            Ustanova_Hladjenje,
            Ustanova_Racunari,
            Ustanova_Cenus,
        }

        public static string UrlForReq(ReqEnum reqEnum, string param = null)
        {
            var urlBase = "https://jisp.mpn.gov.rs/webapi/api/";
            switch (reqEnum)
            {
                case ReqEnum.Zap_Opste:
                    return urlBase + "zaposleni/VratiOpstePodatkeOZaposlenima/" + SV_SAVA_ID;
                case ReqEnum.Zap_Dodatno:
                    return urlBase + $"Zaposleni/VratiPodatkeZaposlenogZaId/{param}/";
                case ReqEnum.Zap_Zaposlenja:
                    return urlBase + "zaposleni/VratiZaposlenja";
                case ReqEnum.Zap_ObracunZarada:
                    return urlBase + $"zaposleni/VratiObracuneZradeZaZaposlenog/{param}/" + SV_SAVA_ID;
                case ReqEnum.Zap_ObracunZaradaKreiraj:
                    return urlBase + $"zaposleni/SacuvajObracunZarade/";
                case ReqEnum.Zap_ObracunZaradaObrisi:
                    return urlBase + $"zaposleni/ObrisiObracunZarade/";
                case ReqEnum.Zap_Angazovanja:
                    return urlBase + $"zaposleni/VratiAngazovanjaPoUgovoruNastavnoOsoblje/{param}/0/";
                case ReqEnum.Zap_Resenja:
                    return urlBase + $"zaposleni/VratiZaposlenje/{param}/";
                case ReqEnum.Zap_ObracunZaradaOpis:
                    return urlBase + $"zaposleni/VratiObracunZaradeZaId/{param}";

                case ReqEnum.Zap_Sistematizacija:
                    return urlBase + $"zaposleni/VratiAktivnuSistematizacijuRMZaUstanovu/{SV_SAVA_ID}";
                case ReqEnum.Zap_SistematizacijaDetalji:
                    return urlBase + $"zaposleni/VratiUgovornaAngazovanjaNaRadnomMestu/";
                case ReqEnum.Zap_IzvoriFinansiranja:
                    return urlBase + $"sifarnik/naziv/IzvoriFinansiranja/";
                case ReqEnum.Zap_SistematizacijaSacuvajNormu:
                    return urlBase + $"zaposleni/SacuvajSistematizacijuZaRadnoMesto/";

                case ReqEnum.Uc_DuosSrednjoskolci:
                    return urlBase + "ucenik/VratiUpisSrednjeByUstanovaId/" + SV_SAVA_ID;
                case ReqEnum.Uc_DuosSrednjoskolciId:
                    return urlBase + $"ucenik/VratiUpisSrednjeObrazovanjeById/{param}";

                case ReqEnum.Uc_DuosDeca:
                    return urlBase + "ucenik/vratiPregledDecePredskolsko";
                case ReqEnum.Uc_DuosOS:
                    return urlBase + "ucenik/VratiUpisOsnovnoByUstanovaId/" + SV_SAVA_ID;
                case ReqEnum.Uc_DuosSS:
                    return urlBase + "ucenik/VratiUpisSrednjeByUstanovaId";
                case ReqEnum.Uc_DuosDomGrupe:
                    return urlBase + "ucenik/VratiUpisUcenickiStandardByUstanovaId/" + SV_SAVA_ID;

                case ReqEnum.Uc_OpstiPodaci:
                    return urlBase + $"ucenik/OpstiPodaci?Id={param}";

                case ReqEnum.Job_PreuzmiListuZahteva:
                    return urlBase + $"job/PreuzmiListuZahteva";

                case ReqEnum.Ustanova_Lokacije:
                    return urlBase + $"Ustanova/VratiLokacijeUstanove/" + SV_SAVA_ID;
                case ReqEnum.Ustanova_Objekti:
                    return urlBase + $"Ustanova/VratiObjektePoIdLokacije/{param}";
                case ReqEnum.Ustanova_ObjektiDodatno:
                    return urlBase + $"Ustanova/VratiPosebneBrojcanePodatke/{param}";
                case ReqEnum.Ustanova_ProstorijeOsnovno:
                    return urlBase + $"Ustanova/VratiProstorije/{param}";
                case ReqEnum.Ustanova_ProstorijeDodatno:
                    return urlBase + $"Ustanova/VratiProstorijuZaId/{param}";
                case ReqEnum.Ustanova_ProstorijeAzuriraj:
                    return urlBase + $"Ustanova/DodajOpstePodatkeProstorije/";

                case ReqEnum.Ustanova_Spratovi:
                    return urlBase + $"sifarnik/naziv/Sprat";
                case ReqEnum.Ustanova_Grejanje:
                    return urlBase + $"sifarnik/naziv/IzvorGrejanja";
                case ReqEnum.Ustanova_Hladjenje:
                    return urlBase + $"sifarnik/naziv/VrstaIzvoraHladjenja";
                case ReqEnum.Ustanova_Racunari:
                    return urlBase + $"Ustanova/VratiRacunareITablete/{param}";
                case ReqEnum.Ustanova_Cenus:
                    return urlBase + $"Ustanova/VratiCenusZaUstanovu/{param}";

                case ReqEnum.Zap_PorukaOdbijeniCenus:
                    return urlBase + $"ustanova/VratiPorukuOdVerifikatoraZaOdbijenCenus/{param}";
                case ReqEnum.Zap_PorukaOdbijenaSistematizacija:
                    return urlBase + $"zaposleni/VratiPorukuOdVerifikatoraZaOdbijenuSistematizaciju/{param}";

                default:
                    throw new Exception("Nepostojeci reqEnum: " + reqEnum);
            }
        }
    }
}
