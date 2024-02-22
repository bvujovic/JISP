using System;

namespace JISP.Classes
{
    /// <summary>
    /// Datum (bez vremena) - kreirano zbog racunanja staza.
    /// Moze da sluzi i kao interval (zbir/razlika) dva datuma.
    /// </summary>
    public class Datum
    {
        /// <summary>Podrazumevani datum/interval: 0 god, 0 mes, 0 dan.</summary>
        public Datum() : this(0, 0, 0)
        { }

        public Datum(int god, int mes, int dan)
        {
            God = god;
            Mes = mes;
            Dan = dan;
            if (!Ok(god, mes, dan))
                throw new Exception("Datum nije ispravan.");
        }

        public static Datum IzDateTime(DateTime dt)
        {
            return new Datum(dt.Year, dt.Month, dt.Day);
        }

        public static Datum IzStringa(string str)
        {
            var delovi = str.Split('\t', '-', '.', '/');
            return new Datum(int.Parse(delovi[0]), int.Parse(delovi[1]), int.Parse(delovi[2]));
        }

        /// <summary>Da li je datum/interval ispravan.</summary>
        public static bool Ok(int god, int mes, int dan)
        {
            if (god < 0)
                return false;
            if (mes < 0 || mes > 12)
                return false;
            if (dan < 0 || dan > 31)
                return false;
            return true;
        }

        public int God { get; set; }
        public int Mes { get; set; }
        public int Dan { get; set; }

        //public void Dodaj(Datum d)
        //{
        //    var zbir = Staz.Zbir(this, d);
        //    this.God = zbir.God;
        //    this.Mes = zbir.Mes;
        //    this.Dan = zbir.Dan;
        //}

        public override string ToString()
        {
            return $"{God}-{Mes:00}-{Dan:00}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Datum that))
                return false;
            return this.God == that.God && this.Mes == that.Mes && this.Dan == that.Dan;
        }

        public override int GetHashCode()
        {
            int hashCode = -330283407;
            hashCode = hashCode * -1521134295 + God.GetHashCode();
            hashCode = hashCode * -1521134295 + Mes.GetHashCode();
            hashCode = hashCode * -1521134295 + Dan.GetHashCode();
            return hashCode;
        }
    }

    public static class Staz
    {
        public static Datum Razlika(Datum poc, Datum kraj)
        {
            var god = kraj.God - poc.God;
            if (poc.Mes > kraj.Mes || (poc.Mes == kraj.Mes && poc.Dan > kraj.Dan))
            {
                god--;
                kraj.Mes += 12;
            }
            var mes = kraj.Mes - poc.Mes;
            if (poc.Dan > kraj.Dan)
            {
                mes--;
                kraj.Dan += DateTime.DaysInMonth(poc.God, poc.Mes);
            }
            var dan = kraj.Dan - poc.Dan;
            dan++;
            if (dan >= 30)
            {
                dan = 0;
                mes++;
            }
            if (mes >= 12)
            {
                mes -= 12;
                god++;
            }
            return new Datum(god, mes, dan);
        }

        public static Datum Zbir(Datum d1, Datum d2)
        {
            var god = d1.God + d2.God;
            var mes = d1.Mes + d2.Mes;
            var dan = d1.Dan + d2.Dan;
            if (dan > 30)
            {
                dan -= 30;
                mes++;
            }
            if (mes > 12)
            {
                mes -= 12;
                god++;
            }
            return new Datum(god, mes, dan);
        }
    }
}
