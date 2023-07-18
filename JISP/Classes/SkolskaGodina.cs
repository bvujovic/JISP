using System;

namespace JISP.Classes
{
    /// <summary>
    /// Skolska godina. 2021 => "2021/2022"
    /// </summary>
    public class SkolskaGodina
    {
        public SkolskaGodina(int start)
        {
            Start = start;
        }

        private int start;
        /// <summary>Kalendarska godina u kojoj pocinje skolska godina.</summary>
        public int Start
        {
            get { return start; }
            set
            {
                start = value;
                Naziv = $"{Start}/{Kraj}";
            }
        }

        /// <summary>Kalendarska godina u kojoj se zavrsava skolska godina.</summary>
        public int Kraj => start + 1;

        /// <summary>Naziv skolske godine. Na primer "2022/2023".</summary>
        public string Naziv { get; private set; }

        public override string ToString()
            => Naziv;

        public override bool Equals(object obj)
        {
            if (!(obj is SkolskaGodina skGod))
                return false;
            return Start == skGod.Start;
        }

        public override int GetHashCode()
            => start.GetHashCode();

        public bool PripadaDatum(DateTime dt)
        {
            return new DateTime(Start, 09, 01) <= dt && dt <= new DateTime(Kraj, 08, 31);
        }
    }
}
