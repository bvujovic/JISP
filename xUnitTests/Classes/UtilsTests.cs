using JISP.Classes;
using JISP.Controls;
using System;
using System.Collections.Generic;
using Xunit;

namespace xUnitTests.Classes
{
    public class UtilsTests
    {
        [Theory]
        [InlineData("Буџет Републике Србије - МПНТР - Основно и средње образовање", "Буџет РС, МПНТР: ОиС образовање")]
        [InlineData("Буџет Републике Србије - МПНТР - Ученички и студентски стандард", "Буџет РС, МПНТР: Уч. стандард")]
        public void SkratiIzvorFin(string source, string target)
        {
            var res = Utils.SkratiIzvorFin(source);
            Assert.Equal(target, res);
        }

        [Theory]
        [InlineData("Буџет РС, МПНТР: ОиС образовање", "ОиС образовање")]
        [InlineData("Буџет РС, МПНТР: Уч. стандард", "Уч. стандард")]
        public void SuperSkratiIzvorFin(string source, string target)
        {
            var res = Utils.SuperSkratiIzvorFin(source);
            Assert.Equal(target, res);
        }

        [Theory]
        [InlineData("2022-07-31", "2022-08-31", 1)]
        [InlineData("2022-07-31", "2023-08-31", 13)]
        public void DiffMonths_Test(DateTime start, DateTime end, int expected)
        {
            var res = Utils.DiffMonths(start, end);
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("{\"jeObrisano\":null,\"regUceLiceId\":492755,\"opis\":\"ИОП2\",\"datumZavrsetka\":\"2022-06-30T00:00:00\",\"prilagodavanjeZavrsnogIspita\":true,\"ukupanBrojBodova\":null,\"vukovaDiploma\":null,\"stecenaKvalifikacijaId\":null,\"stecenaKvalifikacijaNaziv\":null,\"regNoksNacionalnaKvalifikacijaId\":31,\"zavrsetakIsprave\":[{\"id\":411,\"jeObrisano\":false,\"regUceLiceOsnovnoObrazovanjeId\":6120233,\"isprava\":19382,\"ispravaNaziv\":\"сведочанство о завршеном основном образовању\"},{\"id\":412,\"jeObrisano\":false,\"regUceLiceOsnovnoObrazovanjeId\":6120233,\"isprava\":19383,\"ispravaNaziv\":\"уверење о обављеном завршном испиту\"}],\"zavrsniIspiti\":[{\"id\":670,\"jeObrisano\":false,\"regUceLiceOsnovnoObrazovanjeId\":6120233,\"testId\":19381,\"testNaziv\":\"комбиновани тест\",\"brojBodova\":19,\"testDodatnoId\":null},{\"id\":671,\"jeObrisano\":false,\"regUceLiceOsnovnoObrazovanjeId\":6120233,\"testId\":19379,\"testNaziv\":\"тест из српског језика\",\"brojBodova\":20,\"testDodatnoId\":null},{\"id\":672,\"jeObrisano\":false,\"regUceLiceOsnovnoObrazovanjeId\":6120233,\"testId\":19380,\"testNaziv\":\" тест из математике\",\"brojBodova\":15,\"testDodatnoId\":null}],\"id\":6120233,\"zahtevId\":null,\"napomena\":null,\"napomenaVerifikacija\":null,\"daLiJeDraft\":false,\"registarId\":0,\"nazivSekcije\":null,\"regUstUstanovaId\":0,\"objekatIdDrugi\":0,\"objekatIdCetvrti\":null,\"objekatIdPeti\":null}"
            , "06/30/2022, 31, сведочанство, уверење, ИОП2, комбиновани: 19, српски: 20, математика: 15")]
        public void RezimeZavrsetkaObrazovanja_Test(string json, string rezime)
        {
            var res = Utils.RezimeZavrsetkaObrazovanja(json);
            Assert.Equal(rezime, res);
        }

        [Theory]
        [InlineData("abc", "abc")]
        [InlineData("abc&123", "(abc) AND (123)")]
        public void FilterAndOr_Test(string s, string expected)
        {
            var res = Utils.FilterAndOr(s, s => s);
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData("I разред", 11)]
        [InlineData("III разред", 13)]
        [InlineData("IV разред", 14)]
        [InlineData("VIII разред", 18)]
        [InlineData("III разред - СШ", 23)]
        [InlineData("I разред - СШ", 21)]
        public void RazredSortBroj_Test(string razred, int sortBroj)
        {
            var res = Utils.RazredSortBroj(razred);
            Assert.Equal(sortBroj, res);
        }
    }
}
