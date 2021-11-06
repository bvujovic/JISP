﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace JISP.Data
{
    /// <summary>
    /// 
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

        /// <summary></summary>
        /// <see cref="https://stackoverflow.com/questions/14627399/setting-authorization-header-of-httpclient"/>
        public static async Task<string> GetJson(ReqEnum reqEnum, string param = null)
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                    //T var url = "https://jisp.mpn.gov.rs/webapi/api/zaposleni/VratiOpstePodatkeOZaposlenima/18976";
                    var url = UrlForReq(reqEnum, param);
                    return await client.GetStringAsync(url);
                }
            }
            catch (Exception ex)
            {
                Classes.Logger.AddToLog(ex);
                return null;
            }
        }

        public enum ReqEnum
        {
            Zap_OpstiPodaciOZaposlenima,
            Zap_Zaposlenja
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
                default:
                    throw new Exception("Nepostojeci reqEnum: " + reqEnum);
            }
        }
    }
}
