using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace JISP.Controls
{
    public partial class UcFilterTextBox : TextBox
    {
        /// <summary>
        /// Nadklasa za TextBox kontrole koje sluze za filtriranje podataka.
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
    }
}
