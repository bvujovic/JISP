﻿using System;
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

        public static void AppInit()
        {
            if (Directory.Exists(Properties.Settings.Default.DataFolderHome))
                DataFolder = Properties.Settings.Default.DataFolderHome;
            if (Directory.Exists(Properties.Settings.Default.DataFolderAway))
                DataFolder = Properties.Settings.Default.DataFolderAway;
            if (string.IsNullOrEmpty(DataFolder))
                throw new Exception("AppData.DataFolder nije inicijalizovan.");

            LoadDsData();

            //    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            //    "OneDrive\\Posao\\ProgData");
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

        /// <summary>Ucitavanje podataka u DataSet iz fajla.</summary>
        public static void LoadDsData()
        {
            try { Ds.ReadXml(Path.Combine(DataFolder, "ds.xml")); }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, "Ucitavanje podataka iz XMLa"); }
        }
    }
}
