using JISP.Classes.SumaZaposlenja;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace xUnitTests.Classes.SumaZaposlenja
{
    public class ListaSumZapTests
    {
        [Fact]
        public void ListaSumZap_BV1()
        {
            var x = new ListaSumZap();
            x.Dodaj(new SumZap(1, new DateTime(2021, 9, 6), new DateTime(2022, 8, 31), 100));
            x.Sumiraj();

            var sz = Assert.Single(x.SumZaps);
            Assert.Equal(new List<int> { 1 }, sz.IDs);
            Assert.Equal(100, sz.ProcenatAng);
        }

        [Fact]
        public void ListaSumZap_BV2()
        {
            var x = new ListaSumZap();
            x.Dodaj(new SumZap(1, new DateTime(2021, 9, 6), new DateTime(2022, 8, 31), 100));
            x.Dodaj(new SumZap(2, new DateTime(2022, 9, 1), new DateTime(2023, 8, 31), 100));
            x.Sumiraj();

            Assert.Equal(2, x.SumZaps.Count);
            Assert.Single(x.SumZaps[0].IDs);
            Assert.Single(x.SumZaps[1].IDs);
            Assert.Equal(1, x.SumZaps[0].IDs.First());
            Assert.Equal(2, x.SumZaps[1].IDs.First());
            Assert.Equal(100, x.SumZaps[0].ProcenatAng);
            Assert.Equal(100, x.SumZaps[1].ProcenatAng);
        }

        [Fact]
        public void ListaSumZap_Andjelka()
        {
            var poc1 = DateTime.Parse("2000-02-01");
            var poc2 = DateTime.Parse("2008-10-09");
            var kraj1 = DateTime.Parse("2018-08-31");
            var kraj2 = DateTime.Parse("2021-08-31");
            var x = new ListaSumZap();
            x.Dodaj(new SumZap(1, poc1, kraj1, 100));
            x.Dodaj(new SumZap(2, poc2, kraj2, 100));
            x.Sumiraj();

            Assert.Equal(3, x.SumZaps.Count);
            var rep1 = x.SumZaps.FirstOrDefault(it => it.DatumOd == poc1);
            Assert.Equivalent(new List<int>() { 1 }, rep1.IDs);
            Assert.Equal(poc2.AddDays(-1), rep1.DatumDo);
            Assert.Equal(100, rep1.ProcenatAng);

            var zaj = x.SumZaps.FirstOrDefault(it => it.DatumOd == poc2);
            Assert.Equivalent(new List<int>() { 1, 2 }, zaj.IDs);
            Assert.Equal(kraj1.AddDays(-1), zaj.DatumDo);
            Assert.Equal(200, zaj.ProcenatAng);

            var rep2 = x.SumZaps.FirstOrDefault(it => it.DatumOd == kraj1);
            Assert.Equivalent(new List<int>() { 2 }, rep2.IDs);
            Assert.Equal(kraj2, rep2.DatumDo);
            Assert.Equal(100, rep2.ProcenatAng);
        }

        [Fact]
        public void SumZap_Vaspitaci()
        {
            var poc = DateTime.Parse("2018-09-01");
            var kraj1 = DateTime.Parse("2020-02-27");
            var kraj2 = DateTime.Parse("2020-07-29");
            var z0 = new SumZap(0, DateTime.Parse("2017-09-01"), DateTime.Parse("2018-08-31"), 100);
            var z1 = new SumZap(1, poc, kraj1, 100);
            var z2 = new SumZap(2, poc, kraj2, 100);
            var x = new ListaSumZap();
            x.Dodaj(z0);
            x.Dodaj(z1);
            x.Dodaj(z2);
            x.Sumiraj();

            Assert.Equal(3, x.SumZaps.Count);

            var zaj = x.SumZaps.FirstOrDefault(it => it.DatumOd == poc);
            Assert.NotNull(zaj);
            Assert.Equivalent(new List<int> { 1, 2 }, zaj.IDs);
            Assert.Equal(kraj1, zaj.DatumDo);
            Assert.Equal(200, zaj.ProcenatAng);

            var rep = x.SumZaps.FirstOrDefault(it => it.DatumDo == kraj2);
            Assert.NotNull(rep);
            Assert.Equivalent(new List<int> { 2 }, rep.IDs);
            Assert.Equal(kraj1.AddDays(1), rep.DatumOd);
            Assert.Equal(100, rep.ProcenatAng);
        }

        [Fact]
        public void SumZap_Piramida()
        {
            var x = new ListaSumZap();
            x.Dodaj(new SumZap(1, DateTime.Parse("2017-01-01"), DateTime.Parse("2022-01-01"), 100));
            x.Dodaj(new SumZap(2, DateTime.Parse("2018-01-01"), DateTime.Parse("2021-01-01"), 100));
            x.Dodaj(new SumZap(3, DateTime.Parse("2019-01-01"), DateTime.Parse("2020-01-01"), 100));
            x.Sumiraj();

            Assert.Equal(5, x.SumZaps.Count);
        }
    }
}
