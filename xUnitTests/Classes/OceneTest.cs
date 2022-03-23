using JISP;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace xUnitTests
{
    public class OceneTest : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        [Fact]
        public void TestJednaOcena()
        {
            var clipboard =
@"Математика
врло добар";
            var ocekivano = 4.0;
            var rezultat = Ocene.Prosek(clipboard, true);
            Assert.Equal(ocekivano, rezultat);
        }

        [Theory]
        [InlineData("Математика\r\nврло добар", 4.0)]
        [InlineData("Математика\r\nврло добар\r\nТехника и технологија\r\nодличан", 4.5)]
        [InlineData("Мат\r\nврло добар\r\nТех\r\nодличан\r\nтест\r\nодличан", 4.67)]
        [InlineData("Математика\r\nдобар\r\nИсторија\r\nдовољан\r\nГрађанско\r\nуспешан", 2.5)]
        public void TestVisePredmeta(string clipboard, double ocekivano)
        {
            var rezultat = Ocene.Prosek(clipboard, true);
            Assert.Equal(ocekivano, rezultat);
        }

        [Theory]
        [InlineData("")]
        [InlineData("kojesta")]
        [InlineData("Веронаука\r\nистиче се")]
        public void TestIzuzeci(string clipboard)
        {
            Assert.Throws<Exception>(() => Ocene.Prosek(clipboard, true));
        }

        [Theory]
        [InlineData("Практична настава\r\nдовољан\r\n\r\n*\r\nпримерно (5)\t\r\n Владање", false, 2.0)]
        [InlineData("Практична настава\r\nдовољан\r\n\r\n*\r\nпримерно (5)\t\r\n Владање", true, 3.5)]
        public void TestVladanje(string clipboard, bool saVladanjem, double ocekivano)
        {
            var rezultat = Ocene.Prosek(clipboard, saVladanjem);
            Assert.Equal(ocekivano, rezultat);
        }

        [Theory]
        [InlineData("Српски језик\r\nврло добар\r\n\r\n*\r\nнезадовољавајуће (1)\t\r\n Владање", true)]
        [InlineData("Српски језик\r\nнедовољан\r\n\r\n*\r\nпримерно (5)\t\r\n Владање", true)]
        public void TestPonavljanjeRazreda(string clipboard, bool saVladanjem)
        {
            var exc = Record.Exception(() => Ocene.Prosek(clipboard, saVladanjem));
            Assert.True(string.IsNullOrEmpty(exc.Message)
                || exc.Message.Contains("ponavlja razred"));
        }

        /// <summary>Zaokruzivanje cifre 5 nadole - poslednja cifra ce ostati parna.</summary>
        [Fact]
        public void Round2Dec_TieBreak_Down()
        {
            var res = Math.Round(3.825, 2);
            Assert.Equal(3.82, res);
        }

        /// <summary>Zaokruzivanje cifre 5 nagore - poslednja cifra ce postati parna.</summary>
        [Fact]
        public void Round2Dec_TieBreak_Up()
        {
            var res = Math.Round(3.835, 2);
            Assert.Equal(3.84, res);
        }

        [Fact]
        public void BrojOcena_ImaOcene()
        {
            try
            {
                var json = System.IO.File.ReadAllText("_Data/Ocene/BrojOcena_ImaOcene.json");
                var rezultat = Ocene.IzbrojOcene(json);
                Assert.Equal(8, rezultat);
            }
            catch (Exception ex) { Assert.True(false, ex.Message); }
        }

        [Fact]
        public void BrojOcena_NemaOcene()
        {
            try
            {
                var json = System.IO.File.ReadAllText("_Data/Ocene/BrojOcena_NemaOcene.json");
                var rezultat = Ocene.IzbrojOcene(json);
                Assert.Equal(0, rezultat);
            }
            catch (Exception ex) { Assert.True(false, ex.Message); }
        }
    }
}
