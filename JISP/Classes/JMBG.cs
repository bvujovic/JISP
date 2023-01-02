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
        /// <summary>Provera tacnosti JMBG-a.</summary>
        /// <see cref="https://www.telegraf.rs/vesti/2814591-otkrivamo-misteriju-poslednjih-6-cifara-jmbg-evo-sta-one-govore-o-vama"/>
        public static bool IsValid(string jmbg)
        {
            if (string.IsNullOrEmpty(jmbg))
                return false;
            if (jmbg.Length != 13)
                return false;
            try
            {
                var d = jmbg.Substring(0, 2);
                var m = jmbg.Substring(2, 2);
                var y = jmbg.Substring(4, 3);
                if (y[0] != '9' && y[0] != '0')
                    return false;
                y = (y[0] == '9' ? "1" : "2") + y;
                new DateTime(int.Parse(y), int.Parse(m), int.Parse(d));
            }
            catch (ArgumentOutOfRangeException) { return false; }

            // 11 – (( 7*(A+E) + 6*(B+Ž) + 5*(V+Z) + 4*(G+I) + 3*(D+J) + 2*(Đ+K) ) % 11)
            // ABVGDĐEŽZIJKL
            // 0123456789012
            // ( 7*(A+E) + 6*(B+Ž) + 5*(V+Z) + 4*(G+I) + 3*(D+J) + 2*(Đ+K)
            // ( 7*(0+6) + 6*(1+7) + 5*(2+8) + 4*(3+9) + 3*(4+10) + 2*(5+11)
            var x =
                7 * (C(jmbg, 0) + C(jmbg, 6)) +
                6 * (C(jmbg, 1) + C(jmbg, 7)) +
                5 * (C(jmbg, 2) + C(jmbg, 8)) +
                4 * (C(jmbg, 3) + C(jmbg, 9)) +
                3 * (C(jmbg, 4) + C(jmbg, 10)) +
                2 * (C(jmbg, 5) + C(jmbg, 11));
            x = 11 - x % 11;
            if (x > 9)
                x = 0;
            return x == C(jmbg, 12);
        }

        private static int C(string s, int pos)
            => s[pos] - '0';

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
            return (int)Math.Round((bday - DateTime.Today).TotalDays);
        }

        /// <summary>Koliko je osoba stara u godinama, sa decimalama.</summary>
        public static double YearsOld(DateTime bdate)
            => (DateTime.Today - bdate).TotalDays / 365.25;
    }
}
