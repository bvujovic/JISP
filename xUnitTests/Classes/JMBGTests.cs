using JISP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void IsValidTest_YearOutOfRange567()
        {
            var s = "0101567890123";
            Assert.False(JMBG.IsValid(s));
        }

        [Fact]
        public void IsValidTest_LastDigitWrong()
        {
            var s = "1908982710159";
            Assert.False(JMBG.IsValid(s));
        }

        [Fact]
        public void IsValidTest_Konatarevic()
        {
            //var oldJmbg = "2705975271510"; // ovaj JMBG nije ispravan
            //Assert.False(JMBG.IsValid(oldJmbg));
            var newJmbg = "2705972715108";
            Assert.True(JMBG.IsValid(newJmbg));
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
            var dt = DateTime.Now.AddDays(-1).AddYears(-45);
            var exp = 364;
            // dodavanje jednog dana za slucaj prestupne godine
            if (dt.Month <= 2 && DateTime.IsLeapYear(DateTime.Today.Year)
                || dt.Month > 2 && DateTime.IsLeapYear(DateTime.Today.Year + 1))
                exp++;
            Assert.Equal(exp, JMBG.DaysToBDay(dt));
        }
    }
}
