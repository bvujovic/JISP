using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JISP.Classes
{
    public static class LatinicaCirilica
    {
        private class Letter
        {
            public string Lat { get; set; }
            public string Cir { get; set; }
            public override string ToString()
                => $"{Lat} - {Cir}";
        }

        private class LetterList : List<Letter>
        {
            public void Add(string lat, string cir)
                => Add(new Letter { Lat = lat, Cir = cir });
        }

        private static readonly LetterList letters = new LetterList
        {
            {"A", "А"}, {"B", "Б"}, {"V", "В"}, {"G", "Г"}, {"D", "Д"},
            {"Đ", "Ђ"}, {"E", "Е"}, {"Ž", "Ж"}, {"Z", "З"}, {"I", "И"},
            {"J", "Ј"}, {"K", "К"}, {"L", "Л"}, {"Lj", "Љ"}, {"M", "М"},
            {"N", "Н"}, {"Nj", "Њ"}, {"O", "О"}, {"P", "П"}, {"R", "Р"},
            {"S", "С"}, {"T", "Т"}, {"Ć", "Ћ"}, {"U", "У"}, {"F", "Ф"},
            {"H", "Х"}, {"C", "Ц"}, {"Č", "Ч"}, {"Dž", "Џ"}, {"Š", "Ш"},

            {"a", "а"}, {"b", "б"}, {"v", "в"}, {"g", "г"}, {"d", "д"},
            {"đ", "ђ"}, {"e", "е"}, {"ž", "ж"}, {"z", "з"}, {"i", "и"},
            {"j", "ј"}, {"k", "к"}, {"l", "л"}, {"lj", "љ"}, {"m", "м"},
            {"n", "н"}, {"nj", "њ"}, {"o", "о"}, {"p", "п"}, {"r", "р"},
            {"s", "с"}, {"t", "т"}, {"ć", "ћ"}, {"u", "у"}, {"f", "ф"},
            {"h", "х"}, {"c", "ц"}, {"č", "ч"}, {"dž", "џ"}, {"š", "ш"},
        };

        public static string Cir2Lat(string s)
            => Convert(s, LetterEnum.Cir);

        private enum LetterEnum { Lat, Cir }

        private static string Convert(string s, LetterEnum letFrom)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;
            var sb = new StringBuilder();
            foreach (var ch in s)
            {
                var strCh = ch.ToString();
                var l = letters.FirstOrDefault(it => strCh == (letFrom == LetterEnum.Cir ? it.Cir : it.Lat));
                sb.Append(l != null ? (letFrom == LetterEnum.Cir ? l.Lat : l.Cir) : strCh);
            }
            return sb.ToString();
        }

        public static string Lat2Cir(string s)
        {
            var cir = Convert(s, LetterEnum.Lat);
            cir = cir.Replace("лј", "љ");
            cir = cir.Replace("Лј", "Љ");
            cir = cir.Replace("нј", "њ");
            cir = cir.Replace("Нј", "Њ");
            return cir;
        }

        /// <summary>Automatska konverzija: svako kopiranje u clipboard povlaci i konverziju u cir/lat.</summary>
        public static LatCirKonverzija AutoKonverzija { get; set; }
    }

    public enum LatCirKonverzija
    {
        /// <summary>Nema konverzije</summary>
        Nista,
        /// <summary>Latinica -> Cirilica</summary>
        Lat2Cir,
        /// <summary>Cirilica -> Latinica</summary>
        Cir2Lat,
    }
}
