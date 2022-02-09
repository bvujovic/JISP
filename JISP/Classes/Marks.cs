using System;
using System.Collections.Generic;

namespace JISP
{
    public class Marks
    {
        /// <summary>Ocene koje NE ulaze u prosek.</summary>
        private static readonly List<string> invalidMarkNames = new List<string>
        {
            "веома успешан",
            "задовољава",
            "истиче се",
            "неоцењен",
            "ослобођен",
            "успешан"
        };

        /// <summary>Ocene koje ULAZE u prosek.</summary>
        private static readonly Dictionary<string, int> validMarkNames
            = new Dictionary<string, int>()
            {
                { "одличан", 5},
                { "врло добар", 4},
                { "добар", 3},
                { "довољан", 2},
                { "недовољан", 1},
            };

        /// <summary>Racuna se prosek ocena na osnovu select/copy podataka iz JISPa.</summary>
        public static double CalcAverage(string clipboard, bool checkInvalidMarks = false)
        {
            if (string.IsNullOrEmpty(clipboard))
                throw new Exception("Clipboard je prazan.");
            clipboard = clipboard.Trim();
            var lines = clipboard.Split(new string[] { Environment.NewLine }
                , StringSplitOptions.RemoveEmptyEntries);

            var sum = 0.0;
            var count = 0;
            //var jeOcena = false; // red moze predstavljati naziv predmeta ili ocenu
            for (int i = 0; i < lines.Length; i++)
            {
                var strMark = lines[i].Trim();
                if (checkInvalidMarks && invalidMarkNames.Contains(strMark))
                    throw new Exception($"Ocena '{strMark}' NE ulazi u prosek.");

                if (validMarkNames.TryGetValue(strMark, out int val))
                {
                    sum += val;
                    count++;
                }
                //else
                //    ;
            }
            var avg = sum / count;
            return Math.Round(avg, 2);
        }
    }
}