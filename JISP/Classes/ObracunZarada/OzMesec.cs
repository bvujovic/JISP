using System;

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
    }
}
