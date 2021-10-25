using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JISP.Data
{
    public class Zaposleni
    {
        private bool? trenutnoZaposlen;

        //private string prezime;
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        //public string Prezime
        //{
        //    get => prezime;
        //    set
        //    {
        //        if (string.IsNullOrEmpty(prezime) || !string.IsNullOrEmpty(value))
        //            prezime = value;
        //    }
        //}
        public string JMBG { get; set; }

        public bool? TrenutnoZaposlen { 
            get => trenutnoZaposlen ?? false; 
            set => trenutnoZaposlen = value; 
        }

        public List<Zaposlenje> ZaposleniZaposlenje { get; set; }

        public override string ToString()
            => $"{Ime} {Prezime}";
    }
}
