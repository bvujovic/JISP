using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace JISP.Controls
{
    /// <summary>
    /// Dugme za izlaz iz aplikacije bez obzira na kojoj se formi korisnik nalazi.
    /// </summary>
    public partial class UcExitAppButton : UcButton
    {
        public UcExitAppButton()
        {
            InitializeComponent();

            BackColor = System.Drawing.Color.Red;
            ForeColor = System.Drawing.Color.White;
            Text = "Izlaz";
            ToolTipText = "Izlaz iz aplikacije";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Application.OpenForms.OfType<Forms.FrmMain>().FirstOrDefault()?.Close();
        }
    }
}
