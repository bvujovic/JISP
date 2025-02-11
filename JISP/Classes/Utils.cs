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
        public static DialogResult ShowMbox(string message, string title, bool toClipboard = false)
        {
            if (toClipboard)
                Clipboard.SetText(title + Environment.NewLine + message);
            return MessageBox.Show
            (
              message, title, MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        /// <summary>Skracuje naziv razreda srednje skole: umesto "СШ – више нивоа образовања" => "СШ"</summary>
        public static string SkratiRazredSS(string s)
            => s?.Replace("СШ – више нивоа образовања", "СШ");

        public static string SkratiIzvorFin(string s)
        {
            s = s.Replace("Буџет Републике Србије - МП - ", KratakBudzet);
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

                case "За послове руковођења у дому ученика - шеф службе": return "ŠefDom";
                case "Васпитач у дому ученика у посебним условима": return "Vasp";
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

        private static int RomanDigit(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            return -1;
        }

        /// <see cref="https://www.geeksforgeeks.org/converting-roman-numerals-decimal-lying-1-3999/"/>
        private static int RomanToDecimal(string str)
        {
            int res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int s1 = RomanDigit(str[i]);
                if (i + 1 < str.Length)
                {
                    int s2 = RomanDigit(str[i + 1]);
                    if (s1 >= s2)
                        res += s1;
                    else
                    {
                        res = res + s2 - s1;
                        i++;
                    }
                }
                else
                {
                    res += s1;
                    i++;
                }
            }
            return res;
        }

        /// <summary>Na osnovu naziva razreda racuna se broj preko kojeg se razredi mogu sortirati.</summary>
        public static int RazredSortBroj(string razred)
        {
            if (string.IsNullOrEmpty(razred))
                return -1;
            if (razred == "ППП")
                return 1;
            var x = razred.Contains("СШ") ? 20 : 10;
            var rimski = razred.Substring(0, razred.IndexOf(' '));
            return x + RomanToDecimal(rimski);
        }

        public static DialogResult ShowMbox(Exception ex, string title)
        {
            var msg = ex.Message;
            if (ex.InnerException != null)
                msg += Environment.NewLine + Environment.NewLine + ex.InnerException.Message;
            if (ex.StackTrace != null)
                msg += Environment.NewLine + Environment.NewLine + ex.StackTrace;

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
        public const string DveObavezneCifreFormat = "0.00";

        /// <summary>Vraca trenutno vreme u SamoSitno formatu (min:sec.ms).</summary>
        public static string CurrentTimeMS
            => DateTime.Now.ToString(VremeSamoSitnoFormat);

        public static int DiffMonths(DateTime start, DateTime end)
        {
            var y = end.Year - start.Year;
            var m = end.Month - start.Month;
            return 12 * y + m;
        }

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
                if (typForm == typeof(Forms.ZapsForms.FrmZaposleni))
                    frm = new Forms.ZapsForms.FrmZaposleni();
                if (typForm == typeof(FrmUcenici))
                    frm = new FrmUcenici();
                if (typForm == typeof(FrmProstorije))
                    frm = new FrmProstorije();

                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormClosed += frmMain.FrmChild_FormClosed;
                frmMain.ShowInTaskbar = false;
                frmMain.WindowState = FormWindowState.Minimized;
            }
            frm.Show();
            frm.WindowState = FormWindowState.Minimized;
            frm.WindowState = FormWindowState.Normal;
        }

        private static Version appVersion = null;

        /// <summary>Popunjava se polje appVersion. Ima vrednost samo ako je instalirana aplikacija. null - app pokrenuta iz VS.</summary>
        public static void CalcVersion()
        {
            try
            {
#if !DEBUG
                appVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
#endif
            }
            catch { }
        }

        public static string GetVersionName()
        {
            CalcVersion();
            return appVersion == null ? "DEBUG verzija" : appVersion.ToStringNoZeros();
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

        public static async System.Threading.Tasks.Task PreuzmiDokument(Controls.UcDGV dgv, DataGridViewCellEventArgs e)
        {
            var docIdColName = "DokumentId";
            var row = (dgv.CurrentRow.DataBoundItem as System.Data.DataRowView).Row;
            if (row == null || row.IsNull(docIdColName))
                return;
            var hasPrevChanges = row.HasVersion(System.Data.DataRowVersion.Proposed);
            var cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var originalText = (string)cell.Value;
            cell.Value = "...";
            try
            {
                var filePath = GetDownloadsFolder(originalText);
                await Data.WebApi.PostForFile(filePath, "Upload/PreuzmiDokument"
                    , $"{{'documentId':'{row[docIdColName]}'}}", true);
            }
            catch (Exception ex) { ShowMbox(ex, "Preuzimanje dokumenta"); }
            if (hasPrevChanges)
                cell.Value = originalText;
            else
                row.RejectChanges();
        }

        public static string RezimeZavrsetkaObrazovanja(string json)
        {
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
            var stavke = new List<string>();
            string datum = (string)obj.datumZavrsetka;
            stavke.Add(datum.Substring(0, datum.IndexOf(" ")));
            stavke.Add(obj.regNoksNacionalnaKvalifikacijaId.ToString());
            if (obj.zavrsetakIsprave != null)
                foreach (var isprava in obj.zavrsetakIsprave)
                {
                    string naziv = isprava.ispravaNaziv;
                    stavke.Add(naziv.Substring(0, naziv.IndexOf(" ")));
                }
            if (obj.opis != null)
                stavke.Add((string)obj.opis);
            if (obj.zavrsniIspiti != null)
                foreach (var ispit in obj.zavrsniIspiti)
                {
                    if (ispit.testNaziv != null)
                    {
                        string naziv = ispit.testNaziv;
                        naziv = naziv.Contains("комб") ? "комбиновани" : naziv.Contains("матем") ? "математика" : naziv.Contains("српск") ? "српски" : "";
                        stavke.Add(naziv + ": " + ispit.brojBodova);
                    }
                    else if (ispit.predmetRadNaziv != null && ispit.ocenaNaziv != null)
                        stavke.Add((string)ispit.predmetRadNaziv + ": " + ispit.ocenaNaziv);
                }
            if (obj.prosecnaOcenaSrednjegObrazovanja != null)
                stavke.Add("просек: " + obj.prosecnaOcenaSrednjegObrazovanja);

            return string.Join(", ", stavke);
        }

        /// <summary>Ovo valja pozvati na kraju Form_Load-a.</summary>
        /// <remarks>Prebaciti ovaj kôd u baznu klasu za sve forme.</remarks>
        public static void FormStandardSettings(this Form frm)
        {
            frm.Icon = Properties.Resources.grb_srb;
            frm.Text += " - Naš JISP";
        }

        public delegate string M(string s);

        public static string FilterAndOr(string s, M filterMethod)
        {
            var parts = s.Split(new char[] { '&', '|' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
                return filterMethod(s.Trim());
            //* mozda bi trebalo omoguciti vise operatora, eventualno i zagrade
            if (parts.Length > 2)
                throw new Exception("Dozvoljen je samo jedan & ili | operator.");
            char ch = s[parts[0].Length];
            return $"({filterMethod(parts[0].Trim())}) {(ch == '&' ? "AND" : "OR")} ({filterMethod(parts[1].Trim())})";
        }
    }
}
