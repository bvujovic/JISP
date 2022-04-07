using JISP.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmUcenikOsnovno : Form
    {
        public FrmUcenikOsnovno(Ds.UceniciRow ucenik)
        {
            InitializeComponent();

            if (ucenik != null)
            {
                txtUcenik.Text = ucenik.Ime;
                txtJOB.Text = ucenik.JOB;
                this.ucenik = ucenik;
            }
        }

        private readonly Ds.UceniciRow ucenik = null;

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucenik == null) // dodavanje novog ucenika
                {
                    var uc = AppData.Ds.Ucenici.NewUceniciRow();
                    uc.Ime = txtUcenik.Text;
                    uc.JOB = txtJOB.Text;
                    AppData.Ds.Ucenici.AddUceniciRow(uc);
                    Classes.Utils.ShowMbox("Učenik je dodat, ali neće biti vidljiv među tekućim"
                        + " dok se ne preuzmu podaci o razredu i odeljenju.", Text);
                }
                else // izmena podataka o uceniku
                {
                    ucenik.Ime = txtUcenik.Text;
                    ucenik.JOB = txtJOB.Text;
                }
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, Text); }
        }
    }
}
