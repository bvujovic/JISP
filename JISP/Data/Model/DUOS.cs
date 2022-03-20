using System;

namespace JISP.Data
{
    /// <summary>
    /// Podaci o uceniku: JOB, sk. god, [skola (OS/SS),] razred, odeljenje.
    /// </summary>
    public class DUOS
    {
        public int RegUceLiceId { get; set; }            
        public string JOB { get; set; }
        public string SkolskaGodina { get; set; }
        public string Razred { get; set; }
        public string Odeljenje { get; set; }
        public int Id { get; set; }
        public int RegUceLiceSrednjeObrazovanjeId { get; set; }
        public int RegUceLiceOsnovnoObrazovanjeId { get; set; }

        public static string TekucaSkGod => "2021/2022";

        public override string ToString()
            => $"{JOB}, {RegUceLiceId}: {SkolskaGodina}, {Razred}, {Odeljenje}";
    }
}
