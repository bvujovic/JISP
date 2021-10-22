using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JISP.Data
{
    public class Zaposleni
    {
        public string Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }

        public List<Zaposlenje> ZaposleniZaposlenje { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
