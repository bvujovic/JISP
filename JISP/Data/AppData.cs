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

        /// <summary>Ucitavanje podataka u DataSet iz fajla.</summary>
        public static void LoadDsData()
        {
            Ds.ReadXml(FilePath());
            Ds.Zaposleni.CalcJmbgBasedCols();
            Ds.Zaposleni.CalcAktivan();
            Ds.Ucenici.CalcDatRodjBasedCols();
            Ds.AcceptChanges();
            var row = Ds.Settings.FindByName(WebApi.TOKEN_CAPTION);
            if (row != null)
                WebApi.Token = row.Value;
        }

        /// <summary>Cuvanje podataka iz DataSet-a u fajl.</summary>
        public static void SaveDsData()
        {
            try
            {
                if (WebApi.TokenDisplay != WebApi.TOKEN_MISSING)
                {
                    var row = Ds.Settings.FindByName(WebApi.TOKEN_CAPTION);
                    if (row != null)
                    {
                        if (!row.IsValueNull() && row.Value != WebApi.Token)
                            row.Value = WebApi.Token;
                    }
                    else
                        Ds.Settings.AddSettingsRow(WebApi.TOKEN_CAPTION, WebApi.Token);
                }
                Ds.WriteXml(FilePath());
                Ds.AcceptChanges();
                Classes.Utils.ShowMbox("Podaci su sacuvani.", "Cuvanje podataka u XML");
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, "Cuvanje podataka u XML"); }
        }

        public static void BackupData()
        {
            try
            {
                var origDS = FilePath();
                Ds.WriteXml(origDS);
                var backupFolder = "backup";
                if (!string.IsNullOrEmpty(DataFolder))
                    backupFolder = Path.Combine(DataFolder, "backup");
                var date = DateTime.Now.ToString(Classes.Utils.DatumVremeFormatFile);
                var backupDS = Path.Combine(backupFolder, $"ds_{date}.xml");
                File.Copy(origDS, backupDS);
                System.Diagnostics.Process.Start(backupFolder);
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, "Backup podataka"); }
        }
    }
}
