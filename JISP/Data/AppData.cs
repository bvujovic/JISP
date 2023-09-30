using JISP.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JISP.Data
{
    public static class AppData
    {
        public static Ds Ds { get; private set; } = new Ds();

        /// <summary>DataSet za tabele sifarnike (id, naziv) koje se ne pamte trajno.</summary>
        public static DsTemp DsTemp { get; private set; } = new DsTemp();

        /// <summary>Kratko ime aplikacije bez razmaka i nasih slova.</summary>
        public static string AppNameMachine { get => "NasJISP"; }

        /// <summary>Tekuca/aktivna skolska godina - izabrana na FrmMain.</summary>
        public static SkolskaGodina SkolskaGodina { get; set; }
        //B
        ///// <summary>Tekuća školska godina. Npr: 2021/2022</summary>
        //public static string TekucaSkGodStr => $"{TekucaSkGodStart}/{TekucaSkGodStart + 1}";
        ///// <summary>Godina u kojoj počinje tekuća školska godina. Npr: 2021</summary>
        //public static int TekucaSkGodStart => 2021;

        /// <summary>Internet browser koji se koristi za JISP.</summary>
        public static string Browser { get; set; }

        /// <summary>Vreme u sekundama koliko se ceka odgovor od servera za obicne zahteve (za podatke).</summary>
        public static int HttpTimeoutShort { get; set; }
        
        /// <summary>Vreme u sekundama koliko se ceka odgovor od servera za zahteve za fajlovima (dokumenta).</summary>
        public static int HttpTimeoutLong { get; set; }

        //TODO Sa dodatkom cuvanja DataFolder-a u rigistry-u verovatno je bolje da se napusti cuvanje toga u Settings.
        /// <summary>Folder u kojem ce se cuvati podaci: txt, xml...</summary>
        public static string DataFolder => Properties.Settings.Default.DataFolder;

        private static readonly string dataFileName = "ds.xml";

        public static string FilePath()
            => FilePath(dataFileName);

        public static string FilePath(string fileName)
        {
            if (!string.IsNullOrEmpty(DataFolder))
                fileName = Path.Combine(DataFolder, fileName);
            return fileName;
        }

        /// <summary>Mesto u registry-u na kojem se cuva putanja do DataFolder-a.</summary>
        /// <see cref="Computer\HKEY_CURRENT_USER\SOFTWARE\NasJISP"/>
        private static string RegistryPath => @"SOFTWARE\BV\" + AppNameMachine;

        /// <summary>Ucitava podatke (DataFolder) iz registry-a.</summary>
        public static bool LoadFromRegistry()
        {
            try
            {
                var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegistryPath);
                if (key != null)
                {
                    Properties.Settings.Default.DataFolder = key.GetValue("DataFolder").ToString();
                    key.Close();
                    return true;
                }
                else
                    return false;
            }
            catch { return false; }
        }

        /// <summary>Cuva podatke (DataFolder) u registry.</summary>
        public static void SaveToRegistry()
        {
            var key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryPath);
            key.SetValue("DataFolder", DataFolder);
            key.Close();
        }

        /// <summary>Ucitavanje podataka u DataSet iz fajla.</summary>
        public static void LoadDsData()
        {
            Ds.ReadXml(FilePath());
            //T
            //Ds.Zaposleni.ReadXml(FilePath());
            //Ds.ObracunZarada.ReadXml(FilePath());
            //Ds.Zaposlenja.ReadXml(FilePath());
            //Ds.Angazovanja.ReadXml(FilePath());
            //Ds.Resenja.ReadXml(FilePath());
            //Ds.Ucenici.ReadXml(FilePath());
            //Ds.UcenikSkGod.ReadXml(FilePath());
            //Ds.Settings.ReadXml(FilePath());

            Ds.Zaposleni.CalcJmbgBasedCols();
            Ds.Zaposleni.CalcAktivan();
            Ds.Ucenici.CalcDatRodjBasedCols();
            SlikeZaposlenih.PostaviKoImaSliku();
            Ds.AcceptChanges();
            WebApi.Token = LoadSett(WebApi.TOKEN_CAPTION);
            Browser = LoadSett(BrowserSett, "Chrome");
            var strSkGod = LoadSett(SkGodSett, DateTime.Today.Year.ToString());
            SkolskaGodina = new SkolskaGodina(int.Parse(strSkGod));
            HttpTimeoutShort = int.Parse(LoadSett(HttpTimeoutShortSett, "10"));
            HttpTimeoutLong = int.Parse(LoadSett(HttpTimeoutLongSett, "30"));
        }

        /// <summary>Naziv podesavanja za izabrani internet browser.</summary>
        public static string BrowserSett => "browser";

        /// <summary>Naziv podesavanja za izabranu skolsku godinu. Cuva se godina pocetka (int).</summary>
        public static string SkGodSett => "skGod";

        public static string HttpTimeoutShortSett => "HttpTimeoutShort";

        public static string HttpTimeoutLongSett => "HttpTimeoutLong";

        /// <summary>Datum izvestaja trezora u kojem pisu staz i ostali finansijski podaci.</summary>
        public static string DatumIzvestajaTrezora => nameof(DatumIzvestajaTrezora);

        /// <summary>Cuvanje podataka iz DataSet-a u fajl.</summary>
        public static void SaveDsData()
        {
            try
            {
                ClearTempTables();
                if (WebApi.TokenDisplay != WebApi.TOKEN_MISSING)
                    SaveSett(WebApi.TOKEN_CAPTION, WebApi.Token);
                SaveSett(BrowserSett, Browser);
                SaveSett(SkGodSett, SkolskaGodina.Start.ToString());
                Ds.WriteXml(FilePath());
                Ds.AcceptChanges();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Cuvanje podataka u XML"); }
        }

        /// <summary>Brisanje podataka iz tabela u kojima se podaci ne cuvaju trajno.</summary>
        public static void ClearTempTables()
        {
            Ds.SistematizacijaDetalji.Clear();
            Ds.Sistematizacija.Clear();
            Ds.IzvoriFinansiranja.Clear();
            Ds.SifSpratovi.Clear();
            Ds.SifRazloziPrestankaZap.Clear();
        }

        /// <summary>Cuvanje vrednosti value pod imenom name u Settings tabeli.</summary>
        public static void SaveSett(string name, string value)
        {
            var row = Ds.Settings.FindByName(name);
            if (row != null)
            {
                if (!row.IsValueNull() && row.Value != value)
                    row.Value = value;
            }
            else
                Ds.Settings.AddSettingsRow(name, value);
        }

        /// <summary>Ucitavanje vrednosti iz Settings tabele pod imenom name.</summary>
        public static string LoadSett(string name, string defaultValue = null)
        {
            var row = Ds.Settings.FindByName(name);
            return (row != null) ? row.Value : defaultValue;
        }
    }
}
