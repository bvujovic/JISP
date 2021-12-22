using System;
using System.Collections.Generic;

namespace JISP.Data
{
    /// <summary>
    /// Zaposleni u skoli.
    /// </summary>
    public class Zaposleni
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }

        private bool? trenutnoZaposlen;
        public bool? TrenutnoZaposlen { 
            get => trenutnoZaposlen ?? false; 
            set => trenutnoZaposlen = value; 
        }

        public List<Zaposlenje> ZaposleniZaposlenje { get; set; }

        public override string ToString()
            => $"{Ime} {Prezime}";
    }
}
