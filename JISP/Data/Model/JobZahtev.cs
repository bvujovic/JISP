using System;

namespace JISP.Data
{
    /// <summary>
    /// Objekat ove klase samo sadrzi jedan objekat klase Ucenik kao svoj deo.
    /// Potrebno za ucitavanje JOBova iz JSON-a.
    /// </summary>
    public class JobZahtev
    {
        public Ucenik Lice { get; set; }

        public override string ToString()
            => Lice.ToString();

        public override bool Equals(object obj)
            => obj is JobZahtev that && this.Lice != null && that.Lice != null
                && this.Lice.Equals(that.Lice);

        public override int GetHashCode()
            => Lice.GetHashCode();
    }
}
