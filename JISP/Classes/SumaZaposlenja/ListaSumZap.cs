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

        public List<SumZap> SumZaps { get { return sumZaps; } }

        public void Dodaj(SumZap novo)
        {
            if (sumZaps.Count == 0)
                sumZaps.Add(novo);
            else
            {
                var novi = new List<SumZap>();
                foreach (var sz in sumZaps)
                {
                    var res = sz.Dodaj(novo);
                    foreach (var x in res.Where(it => !novi.Contains(it)))
                        novi.Add(x);
                }
                sumZaps = novi;
            }
        }
    }
}
