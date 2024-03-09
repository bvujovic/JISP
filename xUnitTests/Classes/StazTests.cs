
using JISP.Classes;
using System;
using Xunit;

namespace xUnitTests.Classes
{
    public class StazTests
    {
        [Theory]
        [InlineData(1989, 2, 3, "1989-02-03")]
        [InlineData(2023, 12, 31, "2023-12-31")]
        public void Datum_Test(int god, int mes, int dan, string str)
        {
            var rez = new Datum(god, mes, dan).ToString();
            Assert.Equal(str, rez);
        }

        [Theory]
        [InlineData(1, -2, 3, false)]
        [InlineData(0, 0, 0, true)]
        [InlineData(1, 2, 0, true)]
        [InlineData(2020, 2, 20, true)]
        [InlineData(2020, 20, 20, false)]
        [InlineData(12, 13, 14, false)]
        public void Datum_Ok(int god, int mes, int dan, bool ok)
        {
            var rez = Datum.Ok(god, mes, dan);
            Assert.Equal(ok, rez);
        }

        [Theory]
        [InlineData("1995-12-01", 1995, 12, 1)]
        [InlineData("2024-02-29", 2024, 2, 29)]
        [InlineData("2024/02/29", 2024, 2, 29)]
        [InlineData("2024.02.29", 2024, 2, 29)]
        public void Datum_IzDateTime(string str, int god, int mes, int dan)
        {
            var datum = Datum.IzDateTime(DateTime.Parse(str));
            Assert.Equal(god, datum.God);
            Assert.Equal(mes, datum.Mes);
            Assert.Equal(dan, datum.Dan);
        }

        [Theory]
        [InlineData("1995-12-01", 1995, 12, 1)]
        [InlineData("2024-02-29", 2024, 2, 29)]
        [InlineData("2024\t02\t29", 2024, 2, 29)]
        public void Datum_IzStringa(string str, int god, int mes, int dan)
        {
            var datum = Datum.IzStringa(str);
            Assert.Equal(god, datum.God);
            Assert.Equal(mes, datum.Mes);
            Assert.Equal(dan, datum.Dan);
        }

        [Theory]
        [InlineData("1995-12-01", "1995-12-01", true)]
        [InlineData("2023-12-01", "1995-12-01", false)]
        [InlineData("2-3-4", "2\t3\t4", true)]
        [InlineData("0-0-1", "0\t0\t1", true)]
        public void Datum_Equals(string d1, string d2, bool isti)
        {
            var rez = Datum.IzStringa(d1).Equals(Datum.IzStringa(d2));
            Assert.Equal(isti, rez);
        }

        // 1995-02-01	1995-02-02	1	2
        // 1995-02-01	1995-02-26	25	26
        // 1988-12-20	1989-01-20	31	32
        [Theory]
        [InlineData("1995-02-01", "1995-02-28", "0-1-00")]
        [InlineData("1995-03-01", "1995-03-28", "0-0-28")]
        [InlineData("1995-03-01", "1995-03-31", "0-1-00")]
        [InlineData("1995-02-01", "1995-04-26", "0-2-26")]
        //[InlineData("1988-12-20", "1989-01-20", "0-1-01")] // M. Zivkovic
        //[InlineData("2021-09-06", "2023-12-31", "2-3-26")] // BV
        [InlineData("2024-02-29", "2024-03-01", "0-0-02")]
        [InlineData("2024-03-31", "2024-04-01", "0-0-02")]
        [InlineData("2024-04-30", "2024-05-01", "0-0-02")]
        [InlineData("2024-04-30", "2024-06-01", "0-1-02")]
        [InlineData("2024-05-31", "2024-07-01", "0-1-02")]
        [InlineData("2022-09-01", "2023-08-31", "1-0-00")]
        [InlineData("2023-09-01", "2023-12-31", "0-4-00")]
        [InlineData("2020-09-01", "2020-09-01", "0-0-01")]
        [InlineData("2021-09-06", "2021-09-30", "0-0-25")]
        [InlineData("2021-09-06", "2021-12-31", "0-3-25")]
        [InlineData("2021-09-06", "2022-01-01", "0-3-26")]
        [InlineData("2021-09-06", "2021-10-03", "0-0-28")]

        public void Staz_Razlika(string poc, string kraj, string razlika)
        {
            var datum = Staz.Razlika(Datum.IzStringa(poc), Datum.IzStringa(kraj));
            Assert.Equal(Datum.IzStringa(razlika), datum);
        }

        [Theory]
        [InlineData("0-02-26", "0-01-0", "0-03-26")]
        [InlineData("0-02-26", "0-00-5", "0-03-01")]
        [InlineData("0-06-01", "0-06-0", "1-00-01")]
        public void Staz_Zbir(string poc, string kraj, string zbir)
        {
            var datum = Staz.Zbir(Datum.IzStringa(poc), Datum.IzStringa(kraj));
            Assert.Equal(Datum.IzStringa(zbir), datum);
        }

        [Fact]
        public void Staz_BojanV()
        {
            var datum = Staz.Razlika("2021-09-06", "2022-08-31");
            Assert.Equal(Datum.IzStringa("00-11-25"), datum);
            //var datum = Staz.Razlika("2022-09-01", "2023-08-31");
            //Assert.Equal(Datum.IzStringa("01-00-00"), datum);
            //var datum = Staz.Razlika("2023-09-01", "2023-12-31");
            //Assert.Equal(Datum.IzStringa("00-04-00"), datum);
        }
    }
}
