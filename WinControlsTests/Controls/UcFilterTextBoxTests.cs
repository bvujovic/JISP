using Microsoft.VisualStudio.TestTools.UnitTesting;
using JISP.Controls;
using System;

namespace JISP.Controls.Tests
{
    [TestClass()]
    public class UcFilterTextBoxTests
    {
        [DataTestMethod()]
        [DataRow("", "")]
        [DataRow("abc", "(abc)")]
        [DataRow("abc AND 123", "(abc) AND (123)")]
        [DataRow("abc or 123 OR 321", "(abc) OR (123) OR (321)")]
        public void FilterAndOrTest_WoFilterMethod(string s, string expected)
        {
            var txt = new UcFilterTextBox { Text = s };
            var res = txt.FilterAndOr(str => str);
            Assert.AreEqual(expected, res);
        }

        [DataTestMethod()]
        [DataRow("", "x = ''")]
        [DataRow("abc", "(x = 'abc')")]
        [DataRow("abc AND 123", "(x = 'abc') AND (x = '123')")]
        public void FilterAndOrTest_WithFilterMethod(string s, string expected)
        {
            var txt = new UcFilterTextBox { Text = s };
            var res = txt.FilterAndOr(str => $"x = '{str}'");
            Assert.AreEqual(expected, res);
        }

        [DataTestMethod()]
        [DataRow("", "x = ''")]
        [DataRow("abc", "(x = 'абц')")]
        [DataRow("abc AND 123", "(x = 'абц') AND (x = '123')")]
        public void FilterAndOrTest_WithFilterMethod_Cir2Lat(string s, string expected)
        {
            var txt = new UcFilterTextBox { Text = s };
            var res = txt.FilterAndOr(str => $"x = '{str}'", true);
            Assert.AreEqual(expected, res);
        }

        [DataTestMethod()]
        [DataRow("abc", "(x LIKE '%абц%')")]
        [DataRow("abc or 123", "(x LIKE '%абц%') OR (x LIKE '%123%')")]
        public void FilterAndOrTest_WithFilterMethod_Cir2Lat2(string s, string expected)
        {
            var txt = new UcFilterTextBox { Text = s };
            var res = txt.FilterAndOr(str => $"x LIKE '%{str}%'", true);
            Assert.AreEqual(expected, res);
        }
    }
}