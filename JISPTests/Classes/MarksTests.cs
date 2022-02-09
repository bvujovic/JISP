using JISP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JISPTests.Classes.Tests
{
    [TestClass]
    public class MarksTests
    {
        [TestMethod]
        public void CalcAverage_1subject()
        {
            var clipboard =
@"Математика
врло добар";
            var expected = 4.0;
            var result = Marks.CalcAverage(clipboard);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("Математика\r\nврло добар", 4.0)]
        [DataRow("Математика\r\nврло добар\r\nТехника и технологија\r\nодличан", 4.5)]
        [DataRow("Мат\r\nврло добар\r\nТех\r\nодличан\r\nтест\r\nодличан", 4.67)]
        public void CalcAverage_MultiSubjects(string clipboard, double expected)
        {
            var result = Marks.CalcAverage(clipboard);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [ExpectedException(typeof(Exception))]
        [DataRow("")]                               // prazan clipboard
        // [DataRow("српски")]                         // nema ocene
        [DataRow("Географија\r\nвеома успешан")]    // "veoma uspesan" ne ulazi u prosek
        public void CalcAverage_Exceptions(string clipboard)
        {
            Marks.CalcAverage(clipboard, true);
        }

        [TestMethod]
        public void CalcAverage_Subsubject()
        {
            var clipboard = 
@"Страни језик
Енглески језик
добар
Историја
довољан";
            var result = Marks.CalcAverage(clipboard);
            Assert.AreEqual(2.5, result);
        }
    }
}
