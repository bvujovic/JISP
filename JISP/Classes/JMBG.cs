using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JISP.Classes
{
    /// <summary>
    /// Standardne operacije nad JMBG stringom.
    /// </summary>
    public static class JMBG
    {
        /// <summary>Da li je jmbg string validan: ima 13 cifara.</summary>
        public static bool IsValid(string jmbg)
        {
            if (jmbg.Length != 13)
                return false;
            foreach (var c in jmbg)
                if (c < '0' || c > '9')
                    return false;
            return true;
        }

        /// <summary>Uzima datum rodjenja iz jmbg stringa.</summary>
        public static DateTime GetBirthDate(string jmbg)
        {
            return new DateTime(int.Parse(jmbg.Substring(4, 3)) + (jmbg[4] < '5' ? 2000 : 1000)
                , int.Parse(jmbg.Substring(2, 2)), int.Parse(jmbg.Substring(0, 2)));
        }

        /// <summary>Koliko je preostalo jos dana do rodjendana osobe ciji je dan rodjenja dat.</summary>
        public static int DaysToBDay(DateTime bdate)
        {
            var bday = new DateTime(DateTime.Today.Year, bdate.Month, bdate.Day);
            if ((DateTime.Today - bday).Ticks > 0) // ako je rodjos prosao ove godine
                bday = new DateTime(bday.Year + 1, bdate.Month, bdate.Day);
            //B return (bday - DateTime.Today).Days;
            return (int)Math.Round((bday - DateTime.Today).TotalDays);
        }

        /// <summary>Koliko je osoba stara u godinama, sa decimalama.</summary>
        public static double YearsOld(DateTime bdate)
            => (DateTime.Today - bdate).TotalDays / 365.25;
    }
}
