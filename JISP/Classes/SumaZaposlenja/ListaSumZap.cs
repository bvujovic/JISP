using System;
using System.Collections.Generic;
using System.Linq;

namespace JISP.Classes.SumaZaposlenja
{
    /// <summary>
    /// Lista sumiranih zaposlenja jednog zaposlenog.
    /// </summary>
    public class ListaSumZap
    {
        private List<SumZap> sumZaps = new List<SumZap>();

        public List<SumZap> SumZaps => sumZaps;

        /// <remarks>
        /// Metod ne daje sasvim tacne rezultate - padaju testovi: SumZap_Vaspitaci i SumZap_Piramida.
        /// Dobijaju se viskovi SumZap objekata koji bi se mozda mogli izbaciti posebnim metodom koji bi
        /// ih uklanjao ako postoje preklapanja posle poziva Dodaj metoda.
        /// </remarks>
        public void Dodaj(SumZap novo)
        {
            sumZaps.Add(novo);
        }
        //public void Dodaj(SumZap novo)
        //{
        //    if (sumZaps.Count == 0)
        //        sumZaps.Add(novo);
        //    else
        //    {
        //        var novi = new List<SumZap>();
        //        foreach (var sz in sumZaps)
        //        {
        //            var res = sz.Dodaj(novo);
        //            foreach (var x in res.Where(it => !novi.Contains(it)))
        //                novi.Add(x);
        //        }
        //        sumZaps = novi;
        //    }
        //}

        public void Sumiraj()
        {
            //B while (sumZaps.Count < 100) // ako je SumZap-ova 100 ili vise, 
            
            for (int i = 0; i < 100; i++) // ako iz 100 iteracija ovo ne moze da se resi - najverovatnije je greska
            {
                // izdvoj 2 SumZap-a koji se preklapaju (presek)
                var x = SumZap.IzdvojPreklopljene(sumZaps);
                // ponavljaj dok ima preseka. ako nema preseka - kraj
                if (x == null)
                    break;
                // sredi presek sa SumZap.Dodaj...
                var res = x[0].Dodaj(x[1]);
                // ... ukloni objekte koji su bili preklopljeni i rezultat stavi u sumZaps
                sumZaps.Remove(x[0]);
                sumZaps.Remove(x[1]);
                foreach (var sz in res)
                    sumZaps.Add(sz);
            }
        }

        public override string ToString()
            => string.Join(Environment.NewLine, sumZaps);
    }
}
