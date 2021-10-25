using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JISP.Controls
{
    /// <summary>
    /// Dugme za izlaz iz aplikacije bez obzira na kojoj se formi korisnik nalazi.
    /// </summary>
    public partial class UcExitApp : Button
    {
        public UcExitApp()
        {
            InitializeComponent();

            BackColor = System.Drawing.Color.Red;
            ForeColor = System.Drawing.Color.White;
            Text = "Izlaz";
        }

        /// <summary>true ako je korisnik kliknuo na neko UcExitApp dugme.</summary>
        public static bool ExitSignal { get; private set; } = false;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            // prolaz uz hijerarhiju container kontrola dok neki parent nije forma
            var p = Parent;
            do
            {
                if (p is Form form)
                {
                    ExitSignal = true;
                    form.Close();
                    break;
                }
                p = p.Parent;
            } while (p != null);
        }
    }
}
