using System;
using System.Linq;

namespace JISP.Classes.ObracunZarada
{
    /// <summary>
    /// Podatak koji predstavlja mesec u obracunu zarada za zaposlene.
    /// </summary>
    public class OzMesec
    {
        public OzMesec(int godina, int mesec)
        {
            Godina = godina;
            Mesec = mesec;
            MesecSifarnik = 19161 + mesec;
        }

        public int Godina { get; }
        public int Mesec { get; }
        public int MesecSifarnik { get; }

        public override string ToString()
            => $"{Godina}, {Mesec:00}";

        private static string[] meseci = new[]
        {
            "Јануар",   "Фебруар",  "Март",
            "Април",    "Мај",      "Јун",
            "Јул",      "Август",   "Септембар",
            "Октобар",  "Новембар", "Децембар",
        };

        public static int BrojMeseca(string nazivMeseca)
        {
            for (int i = 0; i < meseci.Length; i++)
                if (meseci[i] == nazivMeseca)
                    return i + 1;
            return 0;
        }

        public static string NazivMeseca(int brojMeseca)
        {
            var idx = brojMeseca - 1;
            if (idx < 0 || idx > meseci.Length - 1)
                throw new Exception($"Ne postoji mesec pod brojem {brojMeseca}.");
            return meseci[idx];
        }
    }
}
