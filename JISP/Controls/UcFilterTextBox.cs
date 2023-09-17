using JISP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JISP.Controls
{
    public partial class UcFilterTextBox : TextBox
    {
        /// <summary>
        /// Potklasa za TextBox kontrole koje sluze za filtriranje podataka.
        /// </summary>
        /// <remarks>Potrebno je postaviti svojstvo BindingSource na odgovarajuci bs.</remarks>
        public UcFilterTextBox()
        {
            InitializeComponent();
        }

        public BindingSource BindingSource { get; set; }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (BindingSource != null)
            {
                if (e.KeyCode == Keys.Down)
                {
                    BindingSource.MoveNext();
                    e.Handled = true;
                }
                if (e.KeyCode == Keys.Up)
                {
                    BindingSource.MovePrevious();
                    e.Handled = true;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                Clear();
                e.SuppressKeyPress = true; // protiv "kling" zvuka
                FilterCleared?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>Esc taster -> brisanje sadrzaja text box-a.</summary>
        public event EventHandler FilterCleared;

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (ShouldBeCyrillic)
                BackColor = IsCyrillic ? System.Drawing.Color.White : System.Drawing.Color.Orange;
        }

        /// <summary>Da li treba prebacivati tastaturu na cirilicu.</summary>
        public bool ShouldBeCyrillic { get; set; }

        private static bool IsCyrillic
            => CurrentCultureName.StartsWith("sr-Cyrl");

        private static string CurrentCultureName
            => InputLanguage.CurrentInputLanguage.Culture.Name;

        /// <summary>Postavljanje layout-a tastature na cirilicu generisanjem Alt+Shift signala.</summary>
        /// <see cref="https://stackoverflow.com/questions/37291533/change-keyboard-layout-from-c-sharp-code-with-net-4-5-2"/>
        private void SetCyrillic()
        {
            //#if !DEBUG
            if (!ShouldBeCyrillic || IsCyrillic)
                return;
            var firstCulture = CurrentCultureName;
            SendKeys.SendWait("%+");
            var i = 10; // max 10 pokusaja
            // ispucavaju se Alt+Shift kombinacije dogod se ne predje na cirilicu ili se izbroji od 10 do 0
            // ili se obrne pun krug ponudjenih tastatura a nema cirilice
            while (CurrentCultureName != firstCulture && !IsCyrillic && i-- > 0)
                SendKeys.SendWait("%+");
            timCyrillic.Tick += Tim_Tick;
            //#endif
        }

        private void Tim_Tick(object sender, EventArgs e)
        {
            SetCyrillic();
            timCyrillic.Stop();
        }

        private readonly Timer timCyrillic = new Timer { Enabled = true, Interval = 1000 };

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            SetCyrillic();
        }

        public delegate string M(string s);

        public string FilterAndOr(M filterMethod, bool lat2cir = false)
        {
            //? ako Text sadrzi ', |, & izbaciti izuzetak
            var sb = new StringBuilder();
            var s = Text.Trim();
            int idxStart = -1;
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (ch == '(' || ch == ')')
                {
                    AppendCondition(filterMethod, lat2cir, sb, s, ref idxStart, i);
                    sb.Append(ch);
                }
                else if (ch == ' ')
                {
                    var operators = new[] { " AND ", " OR " };
                    foreach (var op in operators)
                        if (s.IndexOf(op, i, StringComparison.OrdinalIgnoreCase) == i)
                        {
                            AppendCondition(filterMethod, lat2cir, sb, s, ref idxStart, i);
                            sb.Append(op);
                            i += op.Length - 1;
                            break;
                        }
                }
                //if (ch == ' ' && s.IndexOf(" and ", i, StringComparison.OrdinalIgnoreCase) == i)
                //{
                //    AppendCondition(filterMethod, lat2cir, sb, s, ref idxStart, i);
                //    sb.Append(" AND ");
                //    i += 4;
                //    continue;
                //}
                //if (ch == ' ' && s.IndexOf(" or ", i, StringComparison.OrdinalIgnoreCase) == i)
                //{
                //    AppendCondition(filterMethod, lat2cir, sb, s, ref idxStart, i);
                //    sb.Append(" OR ");
                //    i += 3;
                //    continue;
                //}
                else if (idxStart == -1)
                    idxStart = i;
            }
            AppendCondition(filterMethod, lat2cir, sb, s, ref idxStart, s.Length);
            return sb.ToString();
        }

        private static void AppendCondition(M filterMethod, bool lat2cir, StringBuilder sb, string s, ref int idxStart, int i)
        {
            if (idxStart != -1)
            {
                var str = s.Substring(idxStart, i - idxStart);
                if (lat2cir)
                    str = LatinicaCirilica.Lat2Cir(str);
                sb.Append('(' + filterMethod(str) + ')');
                idxStart = -1;
            }
        }
    }
}
