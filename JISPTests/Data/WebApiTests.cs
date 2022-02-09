using Microsoft.VisualStudio.TestTools.UnitTesting;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JISPTests.Data.Tests
{
    [TestClass()]
    public class WebApiTests
    {
        [TestMethod()]
        public void TokenDisplayShortTest()
        {
            WebApi.Token = "123455555555556789";
            var res = WebApi.TokenDisplay;
            Assert.AreEqual(WebApi.TOKEN_MISSING, res);
        }

        [TestMethod()]
        public void TokenDisplayTest()
        {
            WebApi.Token = "12345555555555555kljhyfythgvjt876tr64cs43v...j9j8htrtdthrdudc545b7t08n7yiu55555555555555555555555555555555555555555555555555555556789";
            var res = WebApi.TokenDisplay;
            Assert.IsNotNull(res);
            Assert.IsTrue(res.StartsWith("123"));
            Assert.IsTrue(res.EndsWith("789"));
        }
    }
}