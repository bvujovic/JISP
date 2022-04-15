using System;
using Xunit;
using JISP.Classes.ObracunZarada;

namespace xUnitTests.Classes.ObracunZarada
{
    public class OzMesecTest
    {
        [Theory]
        [InlineData(2021, 12, 19173)]
        [InlineData(2022, 1, 19162)]
        public void KoefDuosMesec_KreiranjeObjektaProveraInitPodataka(int godina, int mesec, int mesecSifarnik)
        {
            var m = new OzMesec(godina, mesec);
            Assert.Equal(godina, m.Godina);
            Assert.Equal(mesec, m.Mesec);
            Assert.Equal(mesecSifarnik, m.MesecSifarnik);
        }

        //[Theory]
        //[InlineData(2021, 12, 19173)]
        //[InlineData(2022, 1, 19162)]
        //public void KoefDuosMesec_Sledeci(int godina, int mesec)
        //{
        //    var m = new KoefDuosMesec(godina, mesec);
        //}

        // jednakost objekata
    }
}
