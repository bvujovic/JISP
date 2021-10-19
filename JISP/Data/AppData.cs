using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JISP.Data
{
    public static class AppData
    {
        public static Ds Ds { get; private set; } = new Ds();

        public static string AppName { get => "JISP"; }

        /// <summary>Folder u kojem ce se cuvati podaci: txt, xml...</summary>
        public static string DataFolder { get; set; }

        private static string FolderForAccound(string accName)
            => $"c:/Users/{accName}/OneDrive/x/Posao/JISP/prog_data/";

        public static void AppInit()
        {
            var accounts = new[] { "bvnet", "sosos" };
            foreach (var acc in accounts)
                if (Directory.Exists(FolderForAccound(acc)))
                    DataFolder = FolderForAccound(acc);
            if (string.IsNullOrEmpty(DataFolder))
                throw new Exception("AppData.DataFolder nije inicijalizovan.");

            LoadDsData();
        }

        /// <summary>Ucitavanje podataka u DataSet iz fajla.</summary>
        public static void LoadDsData()
        {
            try { Ds.ReadXml(Path.Combine(DataFolder, "ds.xml")); }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, "Ucitavanje podataka iz XMLa"); }
        }

        /// <summary>Cuvanje podataka iz DataSet-a u fajl.</summary>
        public static void SaveDsData()
        {
            try
            {
                Ds.WriteXml(Path.Combine(DataFolder, "ds.xml"));
                Classes.Utils.ShowMbox("Podaci su sacuvani.", "Cuvanje podataka u XML");
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, "Cuvanje podataka u XML"); }
        }

        public static void BackupData()
        {
            try
            {
                var origDS = Path.Combine(DataFolder, "ds.xml");
                Ds.WriteXml(origDS);
                var backupFolder = Path.Combine(DataFolder, "backup");
                var date = DateTime.Now.ToString(Classes.Utils.DatumVremeFormatFile);
                var backupDS = Path.Combine(backupFolder, $"ds_{date}.xml");
                File.Copy(origDS, backupDS);
                System.Diagnostics.Process.Start(backupFolder);
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, "Backup podataka"); }
        }
    }
}
