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
            set { token = value; }
        }

        public const string SV_SAVA_ID = "18976";
        public const string TOKEN_MISSING = "???";
        public const string TOKEN_CAPTION = "ApiToken";

        public static string TokenDisplay
            => token == null || token.Length < 100 ? TOKEN_MISSING :
                token.Substring(0, 3) + "..." + token.Substring(token.Length - 3);

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

        /// <summary>Dohvata (GET) JSON podatke od JISP WebAPI-a.</summary>
        /// <see cref="https://stackoverflow.com/questions/14627399/setting-authorization-header-of-httpclient"/>
        public static async Task<string> GetJson(ReqEnum reqEnum, string param = null)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                var url = UrlForReq(reqEnum, param);
                return await client.GetStringAsync(url);
            }
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

        public enum ReqEnum
        {
            Zap_OpstiPodaciOZaposlenima,
            Zap_ZaposlenjaOpste,
            /// <example>body = "{'regUstUstanovaId':18976,'regZapZaposleniId':582792}"</example>
            Zap_ZaposlenjaDetaljno,

            Uc_DuosSrednjoskolci,
            Uc_DuosSrednjoskolciId,

            /// <summary>DUOS osnovna skola: job, razred, odeljenje</summary>
            Uc_DuosOS,
            /// <summary>DUOS srednja skola: job, razred, odeljenje</summary>
            Uc_DuosSS,
            /// <summary>Opsti podaci o jednom uceniku</summary>
            Uc_OpstiPodaci,
        }

        private static string UrlForReq(ReqEnum reqEnum, string param = null)
        {
            var urlBase = "https://jisp.mpn.gov.rs/webapi/api/";
            switch (reqEnum)
            {
                case ReqEnum.Zap_OpstiPodaciOZaposlenima:
                    return urlBase + "zaposleni/VratiOpstePodatkeOZaposlenima/" + SV_SAVA_ID;
                case ReqEnum.Zap_ZaposlenjaOpste:
                    return urlBase + "zaposleni/VratiOpstePodatkeOZaposlenima/" + SV_SAVA_ID;
                case ReqEnum.Zap_ZaposlenjaDetaljno:
                    return urlBase + "zaposleni/VratiZaposlenja";

                case ReqEnum.Uc_DuosSrednjoskolci:
                    return urlBase + "ucenik/VratiUpisSrednjeByUstanovaId/" + SV_SAVA_ID;
                case ReqEnum.Uc_DuosSrednjoskolciId:
                    return urlBase + $"ucenik/VratiUpisSrednjeObrazovanjeById/{param}";

                case ReqEnum.Uc_DuosOS:
                    return urlBase + "ucenik/VratiUpisOsnovnoByUstanovaId/" + SV_SAVA_ID;
                case ReqEnum.Uc_DuosSS:
                    //B return urlBase + "ucenik/VratiUpisSrednjeByUstanovaId/" + SV_SAVA_ID;
                    return urlBase + "ucenik/VratiUpisSrednjeByUstanovaId";

                case ReqEnum.Uc_OpstiPodaci:
                    return urlBase + $"ucenik/OpstiPodaci?Id={param}";
                default:
                    throw new Exception("Nepostojeci reqEnum: " + reqEnum);
            }
        }
    }
}
