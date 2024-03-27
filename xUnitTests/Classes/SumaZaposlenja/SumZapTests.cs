using JISP.Classes.SumaZaposlenja;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace xUnitTests.Classes.SumaZaposlenja
{
    public class SumZapTests
    {
        [Fact]
        public void SumZap_NemaPreklapanja()
        {
            var a = new SumZap(1, new DateTime(2021, 9, 6), new DateTime(2022, 8, 31), 100);
            var b = new SumZap(2, new DateTime(2022, 9, 1), new DateTime(2023, 8, 31), 100);
            var res = a.Dodaj(b);
            Assert.Equal(2, res.Count);
            Assert.Equal(1, res[0].IDs.First());
            Assert.Equal(2, res[1].IDs.First());
        }

        [Fact]
        public void SumZap_PotpunoPreklapanje()
        {
            var poc = new DateTime(2022, 9, 1);
            var kraj = new DateTime(2023, 8, 31);
            var a = new SumZap(1, poc, kraj, 10);
            var b = new SumZap(2, poc, kraj, 90);
            var res = a.Dodaj(b);
            Assert.Single(res);
            var c = res.First();
            Assert.Equal(100, c.ProcenatAng);
            Assert.Equal(poc, c.DatumOd);
            Assert.Equal(kraj, c.DatumDo);
            Assert.Equivalent(new List<int>() { 1, 2 }, c.IDs);
        }

        [Fact]
        public void SumZap_PotpunoPreklapanje2()
        {
            var poc = new DateTime(2022, 9, 1);
            var kraj = new DateTime(2023, 8, 31);
            var a = new SumZap(1, poc, kraj, 10);
            a.IDs.Add(3);
            var b = new SumZap(2, poc, kraj, 90);
            var res = a.Dodaj(b);
            Assert.Single(res);
            var c = res.First();
            Assert.Equal(100, c.ProcenatAng);
            Assert.Equal(poc, c.DatumOd);
            Assert.Equal(kraj, c.DatumDo);
            Assert.Equivalent(new List<int>() { 1, 2, 3 }, c.IDs);
        }

        [Fact]
        public void SumZap_DesnoPreklapanje()
        {
            var poc1 = new DateTime(2022, 9, 1);
            var poc2 = new DateTime(2022, 10, 1);
            var kraj = new DateTime(2022, 12, 31);
            var a = new SumZap(1, poc1, kraj, 10);
            var b = new SumZap(2, poc2, kraj, 90);
            var res = a.Dodaj(b);

            Assert.Equal(2, res.Count);
            var res1 = res.First();
            Assert.Equivalent(new List<int> { 1 }, res1.IDs);
            Assert.Equal(poc1, res1.DatumOd);
            Assert.Equal(poc2.AddDays(-1), res1.DatumDo);
            Assert.Equal(10, res1.ProcenatAng);

            var res2 = res.Last();
            Assert.Equivalent(new List<int> { 1, 2 }, res2.IDs);
            Assert.Equal(poc2, res2.DatumOd);
            Assert.Equal(kraj, res2.DatumDo);
            Assert.Equal(100, res2.ProcenatAng);
        }

        [Fact]
        public void SumZap_LevoPreklapanje()
        {
            var poc = new DateTime(2022, 10, 15);
            var kraj1 = new DateTime(2023, 02, 05);
            var kraj2 = new DateTime(2023, 03, 31);
            var a = new SumZap(1, poc, kraj1, 70);
            var b = new SumZap(2, poc, kraj2, 20);
            var res = a.Dodaj(b);

            Assert.Equal(2, res.Count);
            var zaj = res.First();
            Assert.Equivalent(new List<int> { 1, 2 }, zaj.IDs);
            Assert.Equal(poc, zaj.DatumOd);
            Assert.Equal(kraj1, zaj.DatumDo);
            Assert.Equal(90, zaj.ProcenatAng);

            var rep = res.Last();
            Assert.Equivalent(new List<int> { 2 }, rep.IDs);
            Assert.Equal(kraj1.AddDays(1), rep.DatumOd);
            Assert.Equal(kraj2, rep.DatumDo);
            Assert.Equal(20, rep.ProcenatAng);
        }

        //    ---
        // ---------
        [Fact]
        public void SumZap_SrednjePreklapanje1()
        {
            var poc1 = new DateTime(2023, 10, 30);
            var kraj1 = new DateTime(2023, 12, 31);
            var poc2 = new DateTime(2023, 9, 15);
            var kraj2 = new DateTime(2024, 02, 29);
            var z1 = new SumZap(1, poc1, kraj1, 50);
            var z2 = new SumZap(2, poc2, kraj2, 100);
            var res = z1.Dodaj(z2);

            Assert.NotNull(res);
            Assert.Equal(3, res.Count);
            var rep1 = res.FirstOrDefault(it => it.DatumOd == poc2);
            Assert.NotNull(rep1);
            Assert.Equivalent(new List<int> { 2 }, rep1.IDs);
            Assert.Equal(poc1.AddDays(-1), rep1.DatumDo);
            Assert.Equal(100, rep1.ProcenatAng);

            var zaj = res.FirstOrDefault(it => it.IDs.Count > 1);
            Assert.NotNull(zaj);
            Assert.Equivalent(new List<int> { 1, 2 }, zaj.IDs);
            Assert.Equal(poc1, zaj.DatumOd);
            Assert.Equal(kraj1.AddDays(-1), zaj.DatumDo);
            Assert.Equal(150, zaj.ProcenatAng);

            var rep2 = res.FirstOrDefault(it => it.DatumDo == kraj2);
            Assert.NotNull(rep2);
            Assert.Equivalent(new List<int> { 2 }, rep2.IDs);
            Assert.Equal(kraj1, rep2.DatumOd);
            Assert.Equal(kraj2, rep2.DatumDo);
            Assert.Equal(100, rep2.ProcenatAng);
        }

        //    ------
        // ------
        [Fact]
        public void SumZap_SrednjePreklapanje2()
        {
            var poc1 = new DateTime(2018, 9, 1);
            var kraj1 = new DateTime(2023, 12, 31);
            var poc2 = new DateTime(2017, 11, 11);
            var kraj2 = new DateTime(2020, 3, 15);
            var z1 = new SumZap(1, poc1, kraj1, 20);
            var z2 = new SumZap(2, poc2, kraj2, 100);
            var res = z1.Dodaj(z2);

            Assert.NotNull(res);
            Assert.Equal(3, res.Count);
            var rep1 = res.FirstOrDefault(it => it.DatumOd == poc2);
            Assert.NotNull(rep1);
            Assert.Equivalent(new List<int> { 2 }, rep1.IDs);
            Assert.Equal(poc1.AddDays(-1), rep1.DatumDo);
            Assert.Equal(100, rep1.ProcenatAng);

            var zaj = res.FirstOrDefault(it => it.IDs.Count > 1);
            Assert.NotNull(zaj);
            Assert.Equivalent(new List<int> { 1, 2 }, zaj.IDs);
            Assert.Equal(poc1, zaj.DatumOd);
            Assert.Equal(kraj2.AddDays(-1), zaj.DatumDo);
            Assert.Equal(120, zaj.ProcenatAng);

            var rep2 = res.FirstOrDefault(it => it.DatumDo == kraj1);
            Assert.NotNull(rep2);
            Assert.Equivalent(new List<int> { 1 }, rep2.IDs);
            Assert.Equal(kraj2, rep2.DatumOd);
            Assert.Equal(kraj1, rep2.DatumDo);
            Assert.Equal(20, rep2.ProcenatAng);
        }
    }
}
