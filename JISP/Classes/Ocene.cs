using System;
using System.Collections.Generic;
using System.Linq;

namespace JISP
{
    public static class Ocene
    {
        /// <summary>Ocene koje ulaze u prosek.</summary>
        private static readonly Dictionary<string, int> validneOcene =
             new Dictionary<string, int>()
        {
            { "одличан", 5 },
            { "врло добар", 4 },
            { "добар", 3 },
            { "довољан", 2 },
            { "недовољан", 1 },
        };

        /// <summary>Ocene za vladanje.</summary>
        private static readonly Dictionary<string, int> vladanja =
            new Dictionary<string, int>()
            {
            { "примерно (5)", 5 },
            { "врло добро (4)", 4 },
            { "добро (3)", 3 },
            { "задовољавајуће (2)", 2 },
            { "незадовољавајуће (1)", 1 },
            };

        /// <summary>Racunanje proseka ocena na osnovu tekstualnih podataka iz JISPa.</summary>
        public static double Prosek(string clipboard, bool saVladanjem)
        {
            var redovi = clipboard.Split(new string[] { Environment.NewLine }
                , StringSplitOptions.RemoveEmptyEntries);

            var ocene = new List<int>();
            foreach (var red in redovi.Select(it => it.Trim()))
            {
                if (validneOcene.ContainsKey(red))
                    ocene.Add(validneOcene[red]);
                if (saVladanjem && vladanja.ContainsKey(red))
                    ocene.Add(vladanja[red]);
            }
            if (ocene.Any(it => it == 1))
                throw new Exception("Učenik/ca ponavlja razred.");
            if (ocene.Count > 0)
                return Math.Round(ocene.Average(), 2);
            else
                throw new Exception("Nije pronađena nijedna ocena.");
        }

        public static int IzbrojOcene(string json)
        {
            var ocene = Newtonsoft.Json.JsonConvert.DeserializeObject<Data.OceneUcenika>(json);
            return ocene.UkupanBrojOcena;
        }
    }
}
