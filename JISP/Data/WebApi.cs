using System;
using System.Collections.Generic;
using System.Linq;
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

        public const string TOKEN_MISSING = "???";
        public const string TOKEN_CAPTION = "ApiToken";

        public static string TokenDisplay
            => token == null || token.Length < 100 ? TOKEN_MISSING :
                token.Substring(0, 3) + "..." + token.Substring(token.Length - 3);

        /// <summary>Dohvata listu trazenih objekata od JISP WebAPI-a.</summary>
        public async static Task<List<T>> GetList<T>(ReqEnum reqEnum)
        {
            var json = await GetJson(reqEnum);
            //B return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
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

        /// <summary>Dohvata JSON podatke od JISP WebAPI-a.</summary>
        /// <see cref="https://stackoverflow.com/questions/14627399/setting-authorization-header-of-httpclient"/>
        public static async Task<string> GetJson(ReqEnum reqEnum, string param = null)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                var url = UrlForReq(reqEnum, param);
                return await client.GetStringAsync(url);
            }
        }

        public enum ReqEnum
        {
            Zap_OpstiPodaciOZaposlenima,
            Zap_Zaposlenja,

            Uc_DuosSrednjoskolci,
            Uc_DuosSrednjoskolciId,
        }

        private static string UrlForReq(ReqEnum reqEnum, string param = null)
        {
            var urlBase = "https://jisp.mpn.gov.rs/webapi/api/";
            switch (reqEnum)
            {
                case ReqEnum.Zap_OpstiPodaciOZaposlenima:
                    return urlBase + "zaposleni/VratiOpstePodatkeOZaposlenima/18976";
                case ReqEnum.Zap_Zaposlenja:
                    return urlBase + "zaposleni/VratiOpstePodatkeOZaposlenima/18976";

                case ReqEnum.Uc_DuosSrednjoskolci:
                    return urlBase + "ucenik/VratiUpisSrednjeByUstanovaId/18976";
                case ReqEnum.Uc_DuosSrednjoskolciId:
                    return urlBase + $"ucenik/VratiUpisSrednjeObrazovanjeById/{param}";
                default:
                    throw new Exception("Nepostojeci reqEnum: " + reqEnum);
            }
        }
    }
}
