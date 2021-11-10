using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Classes
{
    public class Utils
    {
        /// <summary>Prikazuje modalni MessageBox.</summary>
        public static DialogResult ShowMbox(string message, string title)
        {
            return MessageBox.Show
            (
              message, title, MessageBoxButtons.OK, MessageBoxIcon.Information
            );
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
        public const string DatumVremeFormatFile = "yyyy.MM.dd_HH.mm";
        public const string DatumVremeSveFormat = "yyyy-MM-dd HH:mm:ss.ff";

        /// <summary>Vraca trenutno vreme u SamoSitno formatu (min:sec.ms).</summary>
        public static string CurrentTimeMS
            => DateTime.Now.ToString(VremeSamoSitnoFormat);

        public static void GoToLink(string url)
        {
            try { System.Diagnostics.Process.Start("chrome.exe", url); }
            catch (Exception ex) { ShowMbox(ex, "Go to Link"); }
        }

        /// <summary>Kreiranje (po potrebi) i prikazivanje forme. Koristi se za sve osim FrmMain.</summary>
        public static void ShowForm(Type typForm)
        {
            var frm = Application.OpenForms.OfType<Form>().FirstOrDefault(it => it.GetType() == typForm);
            if (frm == null || frm.IsDisposed)
            {
                if (typForm == typeof(Forms.FrmZaposleni))
                    frm = new Forms.FrmZaposleni();
                if (typForm == typeof(Forms.FrmUcenici))
                    frm = new Forms.FrmUcenici();
                if (typForm == typeof(Forms.FrmSrednjoskolci))
                    frm = new Forms.FrmSrednjoskolci();
            }
            frm.Show();
            frm.WindowState = FormWindowState.Minimized;
            frm.WindowState = FormWindowState.Normal;
        }
    }
}
