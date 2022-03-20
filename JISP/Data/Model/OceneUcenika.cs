using System;
using System.Collections.Generic;
using System.Linq;

namespace JISP.Data
{
    /// <summary>
    /// Kolekcija ocena ucenika na polugodistu ili kraju godine.
    /// </summary>
    /// <remarks>
    /// https://jisp.mpn.gov.rs/webapi/api/ucenik/VratiSrednjeObrazovanjeZavrsetakPolugodistaById/1265923
    /// </remarks>
    public class OceneUcenika
    {
        //* public int SrednjeObrazovanjeId { get; set; }
        public List<OcenaUcenika> ObavezniPredmeti { get; set; }
        public List<OcenaUcenika> IzborniPredmeti { get; set; }

        public int ObavezniPredmetiBroj => ObavezniPredmeti != null ? ObavezniPredmeti.Count : 0;
        public int IzborniPredmetiBroj => IzborniPredmeti != null ? IzborniPredmeti.Count : 0;
        public int UkupanBrojOcena => ObavezniPredmetiBroj + IzborniPredmetiBroj;
    }
}
