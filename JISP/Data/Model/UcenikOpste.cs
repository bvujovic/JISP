using System;
using System.Collections.Generic;

namespace JISP.Data
{
    /// <summary>
    /// Podaci o uceniku dobijeni od /ucenik/OpstiPodaci?Id=1234567
    /// </summary>
    public class UcenikOpste
    {
        public int? Pol { get; set; }
        /// <summary>М - Ж - /</summary>
        public char PolSlovo
        {
            get
            {
                if (Pol.HasValue)
                    return polovi.ContainsKey(Pol.Value) ? polovi[Pol.Value] : '/';
                else
                    return ' ';
            }
        }

        private static readonly Dictionary<int, char> polovi = new Dictionary<int, char>
        {
            { 11157, 'М' },
            { 11159, 'Ж' },
        };

        public DateTime? DatumRodjenja { get; set; }
    }
}
