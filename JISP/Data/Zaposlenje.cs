using System;
using System.Collections.Generic;

namespace JISP.Data
{
    /// <summary>
    /// Zaposlenje u zemlji za jednog zaposlenog.
    /// </summary>
    public class Zaposlenje
    {
        public string BrojUgovoraORadu { get; set; }
        public DateTime? DatumUgovora { get; set; }
        public int? ProcenatRadnogVremena { get; set; }
        public bool? MaticnaUstanova { get; set; }
        public DateTime? DatumZaposlenOd { get; set; }
        public DateTime? DatumZaposlenDo { get; set; }
        public string RadnoMesto { get; set; }
        public string RadnoMestoNaziv { get; set; }
        //"radnoMestoNaziv": "Наставник практичне наставе у посебним условима",
        public string VrstaAngazovanja { get; set; }

        private bool? ugovorJeNeaktivan;
        public bool? UgovorJeNeaktivan
        {
            get => ugovorJeNeaktivan ?? true;
            set => ugovorJeNeaktivan = value;
        }
    }
}
