using JISP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTests.Data
{
    public class WebApiTests
    {
        [Fact]
        public void TokenDisplayShortTest()
        {
            WebApi.Token = "123455555555556789";
            var res = WebApi.TokenDisplay;
            Assert.Equal(WebApi.TOKEN_MISSING, res);
        }

        [Fact]
        public void TokenDisplayTest()
        {
            WebApi.Token = "12345555555555555kljhyfythgvjt876tr64cs43v...j9j8htrtdthrdudc545b7t08n7yiu55555555555555555555555555555555555555555555555555555556789";
            var res = WebApi.TokenDisplay;
            Assert.NotNull(res);
            Assert.StartsWith("123", res);
            Assert.EndsWith("789", res);
        }

        [Fact]
        public void TakeApiTokenTest()
        {
            var clipboard = System.IO.File.ReadAllText("_Data/request_headers.txt");
            WebApi.TakeApiToken(clipboard);
            Assert.StartsWith("eyJhbGci", WebApi.Token);
            Assert.EndsWith("tAlWiPE", WebApi.Token);
        }
    }
}
