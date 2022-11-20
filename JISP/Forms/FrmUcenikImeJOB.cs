using JISP.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmUcenikImeJOB : Form
    {
        public FrmUcenikImeJOB(Ds.UceniciRow ucenik)
        {
            InitializeComponent();

            if (ucenik != null)
            {
                txtUcenik.Text = ucenik.Ime;
                txtJOB.Text = ucenik.JOB;
                if (!ucenik.IsPrebivalisteNull())
                    txtPrebivaliste.Text = ucenik.Prebivaliste;
                this.ucenik = ucenik;
            }
        }

        private readonly Ds.UceniciRow ucenik = null;

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                txtUcenik.Text = txtUcenik.Text.Trim();
                txtJOB.Text = txtJOB.Text.Trim();
                txtPrebivaliste.Text = txtPrebivaliste.Text.Trim();
                if (txtUcenik.Text == "" || txtJOB.Text == "")
                    throw new Exception("Polja Učenik i JOB se moraju popuniti.");
                if (txtJOB.Text.Length != 16)
                    throw new Exception("JOB mora imati tačno 16 karaktera.");

                if (ucenik == null) // dodavanje novog ucenika
                {
                    var uc = AppData.Ds.Ucenici.NewUceniciRow();
                    uc.Ime = txtUcenik.Text;
                    uc.JOB = txtJOB.Text;
                    if (txtPrebivaliste.Text != "")
                        uc.Prebivaliste = txtPrebivaliste.Text;
                    AppData.Ds.Ucenici.AddUceniciRow(uc);
                    Classes.Utils.ShowMbox("Učenik je dodat, ali neće biti vidljiv među tekućim"
                        + " dok se ne preuzmu podaci o razredu i odeljenju.", Text);
                }
                else // izmena podataka o uceniku
                {
                    ucenik.Ime = txtUcenik.Text;
                    ucenik.JOB = txtJOB.Text;
                    if (txtPrebivaliste.Text != "")
                        ucenik.Prebivaliste = txtPrebivaliste.Text;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, Text); }
        }
    }
}
