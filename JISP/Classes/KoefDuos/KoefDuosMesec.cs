using System;
using System.Collections.Generic;

namespace JISP.Classes.KoefDuos
{
    /// <summary>
    /// Mesec za dati koeficijent za zaposlene u DUOSu.
    /// </summary>
    public class KoefDuosMesec
    {
        public KoefDuosMesec(int godina, int mesec)
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
