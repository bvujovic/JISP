using System;

namespace JISP.Data
{
    /// <summary>
    /// Podaci o uceniku: JOB, sk. god, [skola (OS/SS),] razred, odeljenje.
    /// </summary>
    public class DUOS
    {
        public string JOB { get; set; }
        public string SkolskaGodina { get; set; }
        //B public string Skola { get; set; }
        public string Razred { get; set; }
        public string Odeljenje { get; set; }

        public static string TekucaSkGod => "2021/2022";

        public override string ToString()
            => $"{JOB}: {SkolskaGodina}, {Razred}, {Odeljenje}";
    }
}
