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
        private static string DataFolder { get; set; }

        private static readonly string dataFileName = "ds.xml";

        public static string FilePath()
            => FilePath(dataFileName);

        public static string FilePath(string fileName)
        {
            if (!string.IsNullOrEmpty(DataFolder))
                fileName = Path.Combine(DataFolder, fileName);
            return fileName;
        }

        private static string FolderForAccount(string accName)
            => $"c:/Users/{accName}/OneDrive/x/Posao/JISP/prog_data/";

        public static void AppInit()
        {
            var accounts = new[] { "bvnet", "sosos" };
            foreach (var acc in accounts)
                if (Directory.Exists(FolderForAccount(acc)))
                    DataFolder = FolderForAccount(acc);
            
            if (string.IsNullOrEmpty(DataFolder))
                DataFolder = System.Windows.Forms.Application.StartupPath;
            LoadDsData();

            var os = AddSchool("Основна");
            var ss = AddSchool("Средња");
            var us = AddSchool("Уч. стандард");

            //AddClass("I разред ОШ", os);
            //AddClass("II разред ОШ", os);
            //AddClass("III разред ОШ", os);
            //AddClass("IV разред ОШ", os);
            //AddClass("V разред ОШ", os);
            //AddClass("VI разред ОШ", os);
            //AddClass("VII разред ОШ", os);
            //AddClass("VIII разред ОШ", os);
            //AddClass("I разред СрШ", ss);
            //AddClass("II разред СрШ", ss);
            //AddClass("III разред СрШ", ss);
        }

        /// <summary>Dodavanje razreda ako ne postoji u tabeli.</summary>
        private static void AddClass(string naziv, Ds.SkoleRow skola)
        {
            var c = Ds.Razredi.FirstOrDefault
                (it => it.Naziv == naziv && it.SkoleRow.IdSkole == skola.IdSkole);
            if (c == null)
                Ds.Razredi.AddRazrediRow(naziv, skola);
        }

        /// <summary>Dodavanje skole ako ne postoji u tabeli.</summary>
        private static Ds.SkoleRow AddSchool(string naziv)
        {
            var s = Ds.Skole.FirstOrDefault(it => it.Naziv == naziv);
            return s ?? Ds.Skole.AddSkoleRow(naziv);
        }

        /// <summary>Ucitavanje podataka u DataSet iz fajla.</summary>
        public static void LoadDsData()
        {
            try
            {
                Ds.ReadXml(FilePath());
                Ds.Zaposleni.CalcJmbgBasedCols();
                Ds.AcceptChanges();
                var row = Ds.Settings.FindByName(WebApi.TOKEN_CAPTION);
                if (row != null)
                    WebApi.Token = row.Value;
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, "Ucitavanje podataka iz XMLa"); }
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
