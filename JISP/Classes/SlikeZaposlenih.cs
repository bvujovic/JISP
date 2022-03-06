using JISP.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Classes
{
    /// <summary>
    /// Klasa sadrzi metode za rad sa slikama zaposlenih.
    /// </summary>
    public static class SlikeZaposlenih
    {
        /// <summary>Prikaz ikonica (ima/nema sliku) u DGV-u.</summary>
        public static void PrikaziIkonice(DataGridView dgv, string imeKolone)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var cell = row.Cells[imeKolone] as DataGridViewImageCell;
                var zap = (row.DataBoundItem as System.Data.DataRowView).Row as Data.Ds.ZaposleniRow;
                cell.Value = zap.ImaSliku ?
                    Properties.Resources.person_red : Properties.Resources.person_gray;
            }
        }

        private static readonly string imgFolderName = "img\\zap";
        private static string imgFolderPath = null;

        /// <summary>
        /// Postavljanje zap.ImaSliku na true/false u zavisnosti od toga
        /// da li taj zaposleni ima sliku u datom folderu ili ne.
        /// </summary>
        public static void PostaviKoImaSliku()
        {
            // kreiranje img/zap foldera ako on vec ne postoji
            if (imgFolderPath == null)
                imgFolderPath = Path.Combine(Data.AppData.DataFolder, imgFolderName);
            if (!Directory.Exists(imgFolderPath))
                Directory.CreateDirectory(imgFolderPath);

            // postavljenje ImaSliku svojstva
            foreach (var zap in AppData.Ds.Zaposleni)
                zap.ImaSliku = SlikeZaposlenogIzFoldera(zap.IdZaposlenog).Any();
            //B
            //{
            //    var imgs = Directory.GetFiles(imgFolderPath, zap.IdZaposlenog + "_*");
            //    zap.ImaSliku = imgs.Any();
            //}
        }

        private static string[] SlikeZaposlenogIzFoldera(int idZap)
            => Directory.GetFiles(imgFolderPath, idZap + "_*");

        /// <summary>Odabir i kopiranje slike u img/zap folder.</summary>
        public static void SacuvajSlikuZaZap(string filePath, int idZap)
        {
            try
            {
                var idx = filePath.LastIndexOf('\\');
                var fileName = idZap + "_" + filePath.Substring(idx + 1);
                File.Copy(filePath, Path.Combine(imgFolderPath, fileName));
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Čuvanje slike zaposlenog"); }
        }

        private static Forms.FrmSlikaZap frmSlikaZap = null;

        /// <summary>Prikaz slike zaposlenog u prozoru.</summary>
        public static void PrikaziSliku(Ds.ZaposleniRow zap)
        {
            try
            {
                if (frmSlikaZap == null)
                    frmSlikaZap = new Forms.FrmSlikaZap();
                frmSlikaZap.Text = zap.ToString();
                frmSlikaZap.Slika = SlikeZaposlenogIzFoldera(zap.IdZaposlenog).First();
                frmSlikaZap.Show();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Prikaz slike zaposlenog"); }
        }
    }
}
