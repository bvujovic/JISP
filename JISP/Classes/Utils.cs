﻿using JISP.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Classes
{
    public static class Utils
    {
        /// <summary>Prikazuje modalni MessageBox.</summary>
        public static DialogResult ShowMbox(string message, string title)
        {
            return MessageBox.Show
            (
              message, title, MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        public static string SkratiIzvorFin(string s)
        {
            s = s.Replace("Буџет Републике Србије - МПНТР - ", KratakBudzet);
            s = s.Replace("Основно и средње образовање", "ОиС образовање");
            s = s.Replace("Ученички и студентски стандард", "Уч. стандард");
            return s;
        }

        private static readonly string KratakBudzet = "Буџет РС, МПНТР: ";

        /// <summary>Izbacivanje "Budzet..." iz izvora fin. Ostaje samo Obrazovanje ili Standard.</summary>
        public static string SuperSkratiIzvorFin(string s)
        {
            return s.Replace(KratakBudzet, "");
        }

        public static string SkratiNazivKoef(string s)
        {
            switch (s)
            {
                case "Директор школе": return "Dir";
                case "Запослени у школи за ученике са сметњам у развоју": return "Zap";
                case "Помоћник директора школе": return "PDir";
                case "Организатор практичне наставе": return "Org";

                case "Наставник у одељењу за ученике са сметњама у развоју": return "Nast";
                case "Наставник одељенски/разредни старешина": return "Star";
                case "Наставник комбинованог одељења од 2 разреда": return "Komb2";
                case "Наставник комбинованог одељења од 3 разреда": return "Komb3";
                case "Наставник комбинованог одељења од 4 разреда": return "Komb4";

                default:
                    {
                        if (s.EndsWith("докторат"))
                            return "Dokt";
                        if (s.EndsWith("магистратуру"))
                            return "Mag";
                        if (s.EndsWith("двогодишњу специјализацију"))
                            return "Spec2";
                        if (s.EndsWith("једногодишњу специјализацију"))
                            return "Spec1";
                    }
                    return "???";
            }
        }

        public static DialogResult ShowMbox(Exception ex, string title)
        {
            var msg = ex.Message;
            if (ex.InnerException != null)
                msg += Environment.NewLine + ex.InnerException.Message;

            return MessageBox.Show
            (
              msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error
            );
        }

        /// <summary>Prikazuje modalni MessageBox sa Yes/No pitanjem.</summary>
        public static DialogResult ShowMboxYesNo(string question, string title)
        {
            return MessageBox.Show
            (
                question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );
        }

        /// <summary>Prikazuje modalni MessageBox sa Yes/No/Cancel pitanjem.</summary>
        public static DialogResult ShowMboxYesNoCancel(string question, string title)
        {
            return MessageBox.Show
            (
                question, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
            );
        }

        // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
        public const string VremeSamoSitnoFormat = "mm:ss.fff";
        public const string DatumFormat = "yyyy-MM-dd";
        public const string DatumVremeFormat = "yyyy-MM-dd HH:mm";
        public const string DatumVremeFormatFileMin = "yyyy.MM.dd_HH.mm";
        public const string DatumVremeFormatFileSec = "yyyy.MM.dd_HH.mm.ss";
        public const string DatumVremeSveFormat = "yyyy-MM-dd HH:mm:ss.ff";

        /// <summary>Vraca trenutno vreme u SamoSitno formatu (min:sec.ms).</summary>
        public static string CurrentTimeMS
            => DateTime.Now.ToString(VremeSamoSitnoFormat);

        public static void GoToLink(string url)
        {
            var process = Data.AppData.Browser == "Chrome" ? "chrome.exe" : "msedge.exe";
            try { System.Diagnostics.Process.Start(process, url); }
            catch (Exception ex) { ShowMbox(ex, "Go to Link"); }
        }

        /// <summary>Kreiranje (po potrebi) i prikazivanje forme. Koristi se za sve osim FrmMain.</summary>
        public static void ShowForm(Type typForm)
        {
            var frm = Application.OpenForms.OfType<Form>().FirstOrDefault(it => it.GetType() == typForm);
            var frmMain = FrmMain.Instance;
            if (frm == null || frm.IsDisposed)
            {
                if (typForm == typeof(FrmZaposleni))
                    frm = new FrmZaposleni();
                if (typForm == typeof(FrmUcenici))
                    frm = new FrmUcenici();

                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormClosed += frmMain.FrmChild_FormClosed;
                frmMain.ShowInTaskbar = false;
                frmMain.WindowState = FormWindowState.Minimized;
            }
            frm.Show();
            frm.WindowState = FormWindowState.Minimized;
            frm.WindowState = FormWindowState.Normal;
        }

        public static string GetVersion()
        {
            try
            {
                return System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToStringNoZeros();
            }
            catch { return "DEBUG verzija"; }
        }

        /// <summary>String formatiranje verzije (aplikacije) bez kranjih nula.</summary>
        /// <example>0.3.0.0 -> 0.3</example>
        public static string ToStringNoZeros(this Version v)
        {
            if (v.Revision == 0)
                return $"{v.Major}.{v.Minor}" + (v.Build != 0 ? $".{v.Build}" : "");
            else
                return v.ToString();
        }

        /// <summary>Metod vraca slovo/karakter pola (М - Ж - /) na osnovu koda za pol.</summary>
        //TODO resiti problem sa slicnim kodom u UcenikOpste - ovo ovde je verovatno bolje resenje
        public static char Pol(int polKod)
        {
            if (polKod == 11157)
                return 'М';
            if (polKod == 11159)
                return 'Ж';
            return '/';
        }

        /// <summary>Vraca putanju Downloads foldera [za dati file/folder u Downloads-u].</summary>
        public static string GetDownloadsFolder(string item = null)
        {
            var path = System.IO.Path.GetDirectoryName
                (Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            path = System.IO.Path.Combine(path, "Downloads");
            if (item == null)
                return path;
            else
                return System.IO.Path.Combine(path, item);
        }

        /// <summary>Podesavanje sirine kontrole prema najduzem tekstu neke stavke.</summary>
        public static void AdjustWidth(this ComboBox cmb)
        {
            float maxWidth = 0;
            using (var g = cmb.CreateGraphics())
                foreach (string s in cmb.Items)
                {
                    var size = g.MeasureString(s, cmb.Font);
                    if (size.Width > maxWidth)
                        maxWidth = size.Width;
                }
            cmb.DropDownWidth = (int)maxWidth + 5;
        }

        public static async System.Threading.Tasks.Task PreuzmiDokumentResenja(Controls.UcDGV dgv, DataGridViewCellEventArgs e)
        {
            var res = dgv.CurrDataRow<Data.Ds.ResenjaRow>();
            if (res.IsDokumentNull())
                return;
            var cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var originalText = (string)cell.Value;
            cell.Value = "...";
            try
            {
                var filePath = GetDownloadsFolder(originalText);
                await Data.WebApi.PostForFile(filePath, "Upload/PreuzmiDokument"
                    , $"{{'documentId':'{res.DokumentId}'}}", true);
            }
            catch (Exception ex) { ShowMbox(ex, "Preuzimanje rešenja"); }
            cell.Value = originalText;
        }
    }
}
