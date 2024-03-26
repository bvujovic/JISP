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
        private readonly List<SumZap> sumZaps = new List<SumZap>();

        public List<SumZap> SumZaps { get {  return sumZaps; } }

        public void Dodaj(SumZap novo)
        {
            if (sumZaps.Count == 0)
                sumZaps.Add(novo);
            else
            {
                foreach (var sz in sumZaps)
                {
                    var res = sz.Dodaj(novo);
                    foreach (var r in res.Where(it => !sumZaps.Contains(it)))
                        sumZaps.Add(r); // KOLEKCIJA SE NE MOZE MENJATI U FOREACH
                }
            }
        }
    }
}
