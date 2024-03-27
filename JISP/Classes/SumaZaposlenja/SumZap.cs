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
        public HashSet<int> IDs { get; set; } = new HashSet<int>();

        public DateTime DatumOd { get; set; }

        public DateTime DatumDo { get; set; }

        public double ProcenatAng { get; set; }

        public SumZap() { }

        public SumZap(int idZaposlenja, DateTime datumOd, DateTime datumDo, double procenatAng)
        {
            if (DatumOd > datumDo)
                throw new Exception("SumZap: početni datum zaposlenja dolazi posle krajnjeg.");
            IDs.Add(idZaposlenja);
            DatumOd = datumOd;
            DatumDo = datumDo;
            ProcenatAng = procenatAng;
        }

        public SumZap(HashSet<int> ids, DateTime datumOd, DateTime datumDo, double procenatAng)
        {
            if (DatumOd > datumDo)
                throw new Exception("SumZap: početni datum zaposlenja dolazi posle krajnjeg.");
            AddIDs(ids);
            DatumOd = datumOd;
            DatumDo = datumDo;
            ProcenatAng = procenatAng;
        }

        private void AddIDs(HashSet<int> ids)
        {
            foreach (var id in ids)
                IDs.Add(id);
        }

        public override string ToString()
        {
            return $"IDs: {IDs}, {DatumOd} - {DatumDo}, ang: {ProcenatAng}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is SumZap that))
                return false;
            if (!this.IDs.Equals(that.IDs))
                return false;
            if (this.DatumOd != that.DatumOd || this.DatumDo != that.DatumDo)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 282672717;
            hashCode = hashCode * -1521134295 + EqualityComparer<HashSet<int>>.Default.GetHashCode(IDs);
            hashCode = hashCode * -1521134295 + DatumOd.GetHashCode();
            hashCode = hashCode * -1521134295 + DatumDo.GetHashCode();
            return hashCode;
        }

        public List<SumZap> Dodaj(SumZap that)
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

            if (tackePreseka.Count == 0) // nema tacaka preseka
            {
                // oba datuma su jednaka
                if (this.DatumOd == that.DatumOd && this.DatumDo == that.DatumDo)
                {
                    var x = new SumZap()
                    {
                        DatumDo = this.DatumDo,
                        DatumOd = this.DatumOd,
                        ProcenatAng = this.ProcenatAng + that.ProcenatAng
                    };
                    x.AddIDs(this.IDs);
                    x.AddIDs(that.IDs);
                    return new List<SumZap> { x };
                }
                else
                    return new List<SumZap> { this, that };
            }
            else
            {
                if (tackePreseka.Count == 1) // pocetak ili kraj su jednaki
                {
                    if (this.DatumOd == that.DatumOd)
                    // levo preklapanje - poceci intervala (DatumOd) su jednaki
                    {
                        var kraci = this.DatumDo < that.DatumDo ? this : that;
                        var duzi = kraci == this ? that : this;
                        var zaj = new SumZap()
                        {
                            DatumOd = this.DatumOd,
                            DatumDo = kraci.DatumDo,
                            ProcenatAng = this.ProcenatAng + that.ProcenatAng
                        };
                        zaj.AddIDs(this.IDs);
                        zaj.AddIDs(that.IDs);
                        var rep = new SumZap
                        {
                            IDs = duzi.IDs,
                            DatumOd = kraci.DatumDo.AddDays(1),
                            DatumDo = duzi.DatumDo,
                            ProcenatAng = duzi.ProcenatAng
                        };
                        return new List<SumZap> { zaj, rep };
                    }
                    else
                    // desno preklapanje - krajevi intervala (DatumDo) su jednaki
                    {
                        var prvi = this.DatumOd < that.DatumOd ? this : that;
                        var drugi = prvi == this ? that : this;
                        var a = new SumZap()
                        {
                            IDs = prvi.IDs,
                            DatumOd = prvi.DatumOd,
                            DatumDo = drugi.DatumOd.AddDays(-1),
                            ProcenatAng = this.ProcenatAng
                        };
                        var b = new SumZap()
                        {
                            DatumOd = drugi.DatumOd,
                            DatumDo = this.DatumDo,
                            ProcenatAng = this.ProcenatAng + that.ProcenatAng
                        };
                        b.AddIDs(this.IDs);
                        b.AddIDs(that.IDs);
                        return new List<SumZap> { a, b };
                    }
                }
                else
                {
                    // sredisnje preklapanje - rezultat su 3 intervala, sredisnji je sumiran/preklopljen
                    var prvi = this.DatumOd < that.DatumOd ? this : that;
                    var drugi = prvi == this ? that : this;
                    var a = new SumZap()
                    {
                        IDs = prvi.IDs,
                        DatumOd = prvi.DatumOd,
                        DatumDo = drugi.DatumOd.AddDays(-1),
                        ProcenatAng = prvi.ProcenatAng
                    };

                    var b = new SumZap()
                    {
                        DatumOd = drugi.DatumOd,
                        DatumDo = prvi.DatumDo < drugi.DatumDo ? prvi.DatumDo.AddDays(-1) : drugi.DatumDo.AddDays(-1),
                        ProcenatAng = prvi.ProcenatAng + drugi.ProcenatAng
                    };
                    b.AddIDs(prvi.IDs);
                    b.AddIDs(drugi.IDs);

                    var kraci = this.DatumDo < that.DatumDo ? this : that;
                    var duzi = kraci == this ? that : this;
                    var c = new SumZap
                    {
                        IDs = duzi.IDs,
                        DatumOd = kraci.DatumDo,
                        DatumDo = duzi.DatumDo,
                        ProcenatAng = duzi.ProcenatAng
                    };
                    return new List<SumZap> { a, b, c };
                }
            }
        }
    }
}
