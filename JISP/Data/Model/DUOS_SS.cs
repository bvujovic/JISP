using System;
using System.Collections.Generic;

namespace JISP.Data
{
    /// <summary>
    /// Objekat ove klase samo listu DUOS objekata.
    /// Potrebno za ucitavanje DUOS podataka za srednjoskolce.
    /// </summary>
    public class DUOS_SS
    {
        public int TotalCount { get; set; }
        public List<DUOS> UpisSrednje { get; set; }
    }
}
