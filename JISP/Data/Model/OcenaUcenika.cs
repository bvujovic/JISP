using System;

namespace JISP.Data
{
    /// <summary>
    /// Ocena ucenika na polugodistu ili kraju godine.
    /// </summary>
    public class OcenaUcenika
    {
        public string Predmet { get; set; }
        public string PosebanPredmetNaziv { get; set; }
        public int? OcenaId { get; set; }
        public string OcenaNaziv { get; set; }
        public bool Polugodiste { get; set; }

        public override string ToString()
            => $"{Predmet} {OcenaNaziv}";
    }
}
