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
            BackColor = InputLanguage.CurrentInputLanguage.LayoutName.Contains("Cyrillic")
                ? System.Drawing.Color.White : System.Drawing.Color.Orange;
        }
    }
}
