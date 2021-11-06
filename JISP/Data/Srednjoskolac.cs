﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JISP.Data
{
    /// <summary>
    /// Ucenik, srednjoskolac.
    /// </summary>
    /// <remarks>
    /// https://jisp.mpn.gov.rs/webapi/api/ucenik/VratiUpisSrednjeByUstanovaId/18976
    /// https://jisp.mpn.gov.rs/webapi/api/ucenik/VratiUpisSrednjeObrazovanjeById/734505
    /// </remarks>
    public class Srednjoskolac
    {
        public int Id { get; set; }
        public int RegUceLiceSrednjeObrazovanjeId { get; set; }
        public string SkolskaGodinaUpisaNaziv { get; set; }
        public DateTime DatumUpisa { get; set; }
        public int TipUpisa { get; set; } // "na osnovu svedocanstva..."
        public string TrajanjeProgramaObrazovanja { get; set; }
        public string OdeljenjeNaziv { get; set; }
        public string ModelRealizacije { get; set; }
        public string SmerObrazovniProfilNaziv { get; set; }
        public string Razred { get; set; }
        public string JOB { get; set; }
    }
}
