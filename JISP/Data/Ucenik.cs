using System;

namespace JISP.Data
{
    /// <summary>
    /// Ucenik.
    /// </summary>
    /// <remarks>
    /// POST /webapi/api/job/PreuzmiListuZahteva
    /// Veb zahtev ima i neke podatke u telu.
    /// Za deserijalizaciju ostaviti samo niz zahteva (za JOBovima) u JSON fajlu.
    /// </remarks>
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImeRoditelja { get; set; }
        public string JOB { get; set; }
        /// <summary>Ime, ime roditelje i prezime</summary>
        public string NazivUcenika => $"{Ime} {ImeRoditelja} {Prezime}";

        public override string ToString()
            => $"{JOB}\t{NazivUcenika}";

        public override bool Equals(object obj)
            => obj is Ucenik that && this.JOB.Equals(that.JOB);

        public override int GetHashCode()
            => string.IsNullOrEmpty(JOB) ? 0 : JOB.GetHashCode();
    }
}
