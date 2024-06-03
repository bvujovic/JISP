using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutoFormFill
{
    public static class AppData
    {
        /// <summary>Kratko ime aplikacije bez razmaka i nasih slova.</summary>
        public static string AppNameMachine { get => "NasJISP"; }

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

        private static readonly string dataFileName = "dsAFF.xml";

        //TODO Sa dodatkom cuvanja DataFolder-a u rigistry-u verovatno je bolje da se napusti cuvanje toga u Settings.
        /// <summary>Folder u kojem ce se cuvati podaci: txt, xml...</summary>
        public static string DataFolder => Properties.Settings.Default.DataFolder;

        public static void SaveDataFolder(string folder)
        {
            if (Directory.Exists(folder))
                Properties.Settings.Default.DataFolder = folder;
            else
                throw new Exception($"Folder {folder} ne postoji.");
        }

        public static string FilePath()
            => FilePath(dataFileName);

        public static string FilePath(string fileName)
        {
            if (!string.IsNullOrEmpty(DataFolder))
                fileName = Path.Combine(DataFolder, fileName);
            return fileName;
        }

        /// <summary>Ucitavanje podataka u DataSet iz fajla.</summary>
        public static void LoadDsData(Ds ds)
        {
            ds.ReadXml(FilePath());
        }

        /// <summary>Cuvanje podataka iz DataSet-a u fajl.</summary>
        public static void SaveDsData(Ds ds)
        {
            //ClearTempTables();
            //if (WebApi.TokenDisplay != WebApi.TOKEN_MISSING)
            //    SaveSett(WebApi.TOKEN_CAPTION, WebApi.Token);
            //SaveSett(BrowserSett, Browser);
            //SaveSett(SkGodSett, SkolskaGodina.Start.ToString());
            ds.WriteXml(FilePath());
            ds.AcceptChanges();
        }
    }
}
