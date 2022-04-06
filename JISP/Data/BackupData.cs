using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JISP.Data
{
    /// <summary>
    /// Cuvanje rezervnih podataka na klik i periodicno.
    /// </summary>
    public static class BackupData
    {
        private static readonly string backupFolderName = "backup";
        private static string BackupFolderPath
            => Path.Combine(AppData.DataFolder, backupFolderName);

        private static readonly string filePrefix = "ds_";
        private static readonly string fileExtension = ".xml";

        /// <summary>Kreiranje rezervne kopije podataka u backup folderu.</summary>
        public static bool CreateBackup()
        {
            try
            {
                var originalFileName = AppData.FilePath();
                var folderPath = BackupFolderPath;
                var date = DateTime.Now.ToString(Classes.Utils.DatumVremeFormatFile);
                var fileName = Path.Combine(folderPath, $"{filePrefix}{date}{fileExtension}");
                File.Copy(originalFileName, fileName);
                System.Diagnostics.Process.Start(folderPath);
                return true;
            }
            catch (Exception ex)
            {
                Classes.Utils.ShowMbox(ex, "Backup podataka");
                return false;
            }
        }

        /// <summary>Nova kopija podataka se pravi ako je proslo vise od nedelju dana.</summary>
        private static bool IsNewBackupNeeded(DateTime lastBackup)
        {
            return (DateTime.Now - lastBackup).TotalDays > 7;
        }

        private static string BackupFileNameErrorMessage(string fileName)
            => $"Backup file name '{fileName}' is not in correct format.";

        /// <summary>Kreiranje nove rezervne kopije podataka ako je to potrebno.</summary>
        /// <returns>Da li je backup kreiran (uspesno).</returns>
        public static bool CreateBackupIfNeeded()
        {
            // lista fajlova u backup dir-u -> koji je poslednji napravljen
            var files = Directory.EnumerateFiles(BackupFolderPath);
            var lastBackup = DateTime.MinValue;
            foreach (var file in files.Select(it => new FileInfo(it).Name))
            {
                // example: ds_2022.04.06_15.30.xml
                if (!file.StartsWith(filePrefix) || !file.EndsWith(fileExtension))
                    throw new Exception(BackupFileNameErrorMessage(file));
                var fileName = file.Substring(filePrefix.Length);
                fileName = fileName.Substring(0, fileName.Length - fileExtension.Length);
                var parts = fileName.Split(new char[] { '_', '.' });
                if (parts.Length != 5)
                    throw new Exception(BackupFileNameErrorMessage(file));
                var fileDate = new DateTime(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2])
                    , int.Parse(parts[3]), int.Parse(parts[4]), 0);
                if (fileDate > lastBackup)
                    lastBackup = fileDate;
            }

            // pokretanje backupa ako je potrebno
            var backupCreated = IsNewBackupNeeded(lastBackup);
            if (backupCreated)
                backupCreated = CreateBackup();
            return backupCreated;
        }
    }
}
