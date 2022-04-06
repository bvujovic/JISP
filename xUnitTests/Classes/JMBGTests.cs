using JISP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTests.Classes
{
    public class JMBGTests
    {
        [Fact]
        public void IsValidTestTooShort()
        {
            var s = "123";
            Assert.False(JMBG.IsValid(s));
        }

        [Fact]
        public void IsValidTestUnderscore()
        {
            var s = "123456789_123";
            Assert.False(JMBG.IsValid(s));
        }

        [Fact]
        public void IsValidTest13digits()
        {
            var s = "1234567890123";
            Assert.True(JMBG.IsValid(s));
        }

        [Fact]
        public void GetBirthDateTestOld()
        {
            var s = "1908982511159";
            var exp = new DateTime(1982, 8, 19);
            Assert.Equal(exp, JMBG.GetBirthDate(s));
        }

        [Fact]
        public void GetBirthDateTestYoung()
        {
            var s = "1512002511159";
            var exp = new DateTime(2002, 12, 15);
            Assert.Equal(exp, JMBG.GetBirthDate(s));
        }

        [Fact]
        public void DaysToBDayTestToday()
        {
            var dt = new DateTime(2000, DateTime.Today.Month, DateTime.Today.Day);
            var exp = 0;
            Assert.Equal(exp, JMBG.DaysToBDay(dt));
        }

        [Fact]
        public void DaysToBDayTestYesterday()
        {
            var dt = new DateTime(2000, DateTime.Today.Month, DateTime.Today.Day - 1);
            var exp = 364; //* ne valja ako je prestupna godina
            Assert.Equal(exp, JMBG.DaysToBDay(dt));
        }
    }
}
