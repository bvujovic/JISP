using JISP.Classes;
using System;
using Xunit;


namespace xUnitTests.Classes
{
    public class SkolskaGodinaTests
    {
        [Fact]
        public void PripadaDatumTest()
        {
            var skGod = new SkolskaGodina(2022);
            Assert.False(skGod.PripadaDatum(new DateTime(2022, 8, 31)));
            Assert.True(skGod.PripadaDatum(new DateTime(2022, 9, 1)));
            Assert.True(skGod.PripadaDatum(new DateTime(2022, 11, 11)));
            Assert.True(skGod.PripadaDatum(new DateTime(2023, 8, 31)));
            Assert.False(skGod.PripadaDatum(new DateTime(2023, 9, 1)));
        }
    }
}
