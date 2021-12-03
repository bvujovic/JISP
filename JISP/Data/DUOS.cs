using System;

namespace JISP.Data
{
    /// <summary>
    /// Podaci o uceniku: JOB, skola (OS/SS), razred, odeljenje.
    /// </summary>
    public class DUOS
    {
        public string JOB { get; set; }
        public string Skola { get; set; }
        public string Razred { get; set; }
        public string Odeljenje { get; set; }

        public override string ToString()
            => $"{JOB}: {Skola}, {Razred}, {Odeljenje}";
    }
}
