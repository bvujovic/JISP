using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

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

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            Application.OpenForms.OfType<Forms.FrmMain>().First().Close();

            //B
            //var frmMain = Application.OpenForms.OfType<Form>().FirstOrDefault(it => it.Name == "FrmMain");
            //if (frmMain != null)
            //    frmMain.Close();

            //foreach (Form frm in Application.OpenForms)
            //    if (frm.Name == "FrmMain")
            //    {
            //        frm.Close();
            //        break;
            //    }

            //Application.Exit();            

            //// prolaz uz hijerarhiju container kontrola dok neki parent nije forma
            //var p = Parent;
            //do
            //{
            //    if (p is Form form)
            //    {
            //        ExitSignal = true;
            //        form.Close();
            //        break;
            //    }
            //    p = p.Parent;
            //} while (p != null);
        }
    }
}
