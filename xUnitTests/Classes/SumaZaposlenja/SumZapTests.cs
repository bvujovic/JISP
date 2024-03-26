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
        public void SumZap_BV1()
        {
            var a = new SumZap(1, new DateTime(2021, 9, 6), new DateTime(2022, 8, 31), 100);
            var b = new SumZap(2, new DateTime(2022, 9, 1), new DateTime(2023, 8, 31), 100);
            var res = a.Dodaj(b);
            Assert.Equal(2, res.Count);
            Assert.Equal(1, res[0].IDs.First());
            Assert.Equal(2, res[1].IDs.First());
        }
    }
}
