using Microsoft.VisualStudio.TestTools.UnitTesting;
using JISP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JISP.Classes.Tests
{
    [TestClass()]
    public class JMBGTests
    {
        [TestMethod()]
        public void IsValidTestTooShort()
        {
            var s = "123";
            Assert.IsFalse(JMBG.IsValid(s));
        }

        [TestMethod()]
        public void IsValidTestUnderscore()
        {
            var s = "123456789_123";
            Assert.IsFalse(JMBG.IsValid(s));
        }

        [TestMethod()]
        public void IsValidTest13digits()
        {
            var s = "1234567890123";
            Assert.IsTrue(JMBG.IsValid(s));
        }

        [TestMethod()]
        public void GetBirthDateTestOld()
        {
            var s = "1908982511159";
            var exp = new DateTime(1982, 8, 19);
            Assert.AreEqual(exp, JMBG.GetBirthDate(s));
        }

        [TestMethod()]
        public void GetBirthDateTestYoung()
        {
            var s = "1512002511159";
            var exp = new DateTime(2002, 12, 15);
            Assert.AreEqual(exp, JMBG.GetBirthDate(s));
        }

        [TestMethod()]
        public void DaysToBDayTestToday()
        { 
            var dt = new DateTime(2000, DateTime.Today.Month, DateTime.Today.Day);
            var exp = 0;
            Assert.AreEqual(exp, JMBG.DaysToBDay(dt));
        }

        [TestMethod()]
        public void DaysToBDayTestYesterday()
        {
            var dt = new DateTime(2000, DateTime.Today.Month, DateTime.Today.Day - 1);
            var exp = 364; //* ne valja ako je prestupna godina
            Assert.AreEqual(exp, JMBG.DaysToBDay(dt));
        }
    }
}