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

        [Theory]
        [InlineData(1, "Јануар")]
        [InlineData(6, "Јун")]
        [InlineData(12, "Децембар")]
        public void NazivMesecaTest(int brojMeseca, string tacanNaziv)
        {
            var naziv = OzMesec.NazivMeseca(brojMeseca);
            Assert.Equal(tacanNaziv, naziv);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(13)]
        public void NazivMeseca_Exceptions(int brojMeseca)
        {
            Assert.Throws<Exception>(() => OzMesec.NazivMeseca(brojMeseca));
        }

        [Theory]
        [InlineData("Јануар", 1)]
        [InlineData("Јун", 6)]
        [InlineData("Децембар", 12)]
        public void BrojMesecaTest(string nazivMeseca, int tacanBroj)
        {
            var broj = OzMesec.BrojMeseca(nazivMeseca);
            Assert.Equal(tacanBroj, broj);
        }
    }
}
