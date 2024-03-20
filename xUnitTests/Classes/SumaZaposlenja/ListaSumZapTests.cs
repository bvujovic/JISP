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
            Assert.Equal(2, x.SumZaps.Count);
            Assert.Single(x.SumZaps[0].IDs);
            Assert.Single(x.SumZaps[1].IDs);
            Assert.Equal(1, x.SumZaps[0].IDs.First());
            Assert.Equal(2, x.SumZaps[1].IDs.First());
            Assert.Equal(100, x.SumZaps[0].ProcenatAng);
            Assert.Equal(100, x.SumZaps[1].ProcenatAng);
        }
    }
}
