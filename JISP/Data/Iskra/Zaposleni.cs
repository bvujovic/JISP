using System;
using System.Collections.Generic;

namespace JISP.Data.Iskra
{
    public class Zaposleni
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        /// <remarks>NOKS bi za istog zaposlenog mogao biti različit kada je za 2 zaposlenja drugačiji max NOKS.</remarks>
        public string NOKS { get; set; }
        public string Email { get; set; }
        public int MinRadGod { get; set; }
        public int MinRadMes { get; set; }
        public int MinRadDan { get; set; }
        public string UlicaIBroj { get; set; }

        public override string ToString()
            => $"{Ime} {Prezime} ({JMBG})";

        public List<Zaposlenje> Zaposlenja { get; set; } = new List<Zaposlenje>();
    }
}
