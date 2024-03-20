using System;
using System.Collections.Generic;
using System.Linq;

namespace JISP.Classes.SumaZaposlenja
{
    /// <summary>
    /// Sumirano zaposlenje: 1 ili više zaposlenja za jednog zaposlenog u datom vremenskom intervalu.
    /// </summary>
    public class SumZap
    {
        public List<int> IDs { get; set; } = new List<int>();

        public DateTime DatumOd { get; set; }

        public DateTime DatumDo { get; set; }

        public double ProcenatAng { get; set; }

        public SumZap() { }

        public SumZap(int idZaposlenja, DateTime datumOd, DateTime datumDo, double procenatAng)
        {
            IDs.Add(idZaposlenja);
            DatumOd = datumOd;
            DatumDo = datumDo;
            ProcenatAng = procenatAng;
        }

        public List<SumZap> Presek(SumZap that)
        {
            var tackePreseka = new List<DateTime>();
            if (this.DatumOd < that.DatumOd && that.DatumOd < this.DatumDo)
                tackePreseka.Add(that.DatumOd);
            if (this.DatumOd < that.DatumDo && that.DatumDo < this.DatumDo)
                tackePreseka.Add(that.DatumDo);

            if (that.DatumOd < this.DatumOd && this.DatumOd < that.DatumDo)
                tackePreseka.Add(this.DatumOd);
            if (that.DatumOd < this.DatumDo && this.DatumDo < that.DatumDo)
                tackePreseka.Add(this.DatumDo);

            if (tackePreseka.Count == 0)
                //TODO sta ako su zaposlenja na istim intervalima (sa npr 70 i 30%)
                return new List<SumZap> { this, that };
            else
            {
                return null;
                //TODO ...
            }
        }
    }
}
