using Xunit;
using JISP.Classes;

namespace xUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void FineJMBG()
        {
            var res = JMBG.IsValid("1234567890123");
            Assert.True(res);
        }

        [Fact]
        public void BadJMBG()
        {
            var res = JMBG.IsValid("pera");
            Assert.False(res);
        }
    }
}