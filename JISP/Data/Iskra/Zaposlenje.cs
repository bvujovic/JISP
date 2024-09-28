using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JISP.Data.Iskra
{
    public class Zaposlenje
    {
        public double DkDir { get; set; }
        public double DkPomDir { get; set; }
        public double DkOrganizator { get; set; }
        public double DkSpecSkola { get; set; }
        public double Dk1godSpec { get; set; }
        public double DkMagistar { get; set; }
        public double DkKomb2 { get; set; }
        public double DkSkolaSaDomom { get; set; }

        public double DatumPocetka { get; set; }
        public string StatusZaposlenja { get; set; }
        public string VrstaZaposlenja { get; set; }
        public string Posao { get; set; }
        public double KoefOsnovni { get; set; }
        public double KoefUkupni { get; set; }
        public double Procenat { get; set; }

        public override string ToString()
            => $"{Procenat}% {Posao}";
    }
}
