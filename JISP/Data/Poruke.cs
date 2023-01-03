using System;
using System.Collections.Generic;
using System.Linq;

namespace JISP.Data
{
    /// <summary>
    /// Pomocna klasa za rad sa porukama u vezi sa odbijenim sistematizacijama i CENUSom.
    /// </summary>
    public static class Poruke
    {
        public static int SistematizacijaId { get; set; }
        public static int CenusId { get; set; }

        public static Ds.PorukeRow PoslednjaPoruka(TipPoruke tipPoruke)
        {
            var poruke = AppData.Ds.Poruke.Where(it => it.Tip == tipPoruke.ToString());
            if (!poruke.Any())
                return null;
            var poslednjeDatumVreme = poruke.Max(it => it.DatumVreme);
            return poruke.First(it => it.DatumVreme == poslednjeDatumVreme);
        }
    }

    public enum TipPoruke
    {
        Sistematizacija,
        CENUS
    }
}
