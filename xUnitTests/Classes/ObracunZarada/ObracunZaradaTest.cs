using Newtonsoft.Json.Linq;
using System;
using Xunit;

namespace xUnitTests.Classes.KoefDuos
{
    public class ObracunZaradaTest
    {
        [Theory]
        [InlineData("Sacuvaj_Bojan_2021-12.json", "Sacuvaj_Bojan_2022-01.json")]
        [InlineData("Sacuvaj_Marija_2021-12a.json", "Sacuvaj_Marija_2022-01a.json")]
        public void KreirajNoviUnosBojan(string imeFajlaStari, string imeFajlaNovi)
        {
            var novaGodina = 2022;
            var noviMesec = 1;
            var strStariUnos = System.IO.File.ReadAllText("_Data/KoefDuos/" + imeFajlaStari);
            var strOcekivaniNoviUnos = System.IO.File.ReadAllText("_Data/KoefDuos/" + imeFajlaNovi);
            string strNoviUnos = JISP.Classes.ObracunZarada.ObracunZarada.KreirajNoviUnos(strStariUnos, novaGodina, noviMesec);
            Assert.Equal(JObject.Parse(strOcekivaniNoviUnos), JObject.Parse(strNoviUnos));
        }

        [Fact]
        public void DobijanjeJsonStringaOdBashKomande()
        {
            var strBash = System.IO.File.ReadAllText("_Data/KoefDuos/SacuvajBash_Marija_2021-12a.txt");
            var strJsonOcekivani = System.IO.File.ReadAllText("_Data/KoefDuos/Sacuvaj_Marija_2021-12a.json");
            string strJson = JISP.Classes.ObracunZarada.ObracunZarada.Bash2Json(strBash);
            Assert.Equal(JObject.Parse(strJsonOcekivani), JObject.Parse(strJson));
        }
    }
}
