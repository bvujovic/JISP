using JISP.Classes;
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
        public void DiffMonths_Test(DateTime start, DateTime end, int expected)
        {
            var res = Utils.DiffMonths(start, end);
            Assert.Equal(expected, res);
        }
    }
}
