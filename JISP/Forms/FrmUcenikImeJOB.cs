using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
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
                txtJOB.Text = ucenik.JOB;
                if (!ucenik.IsPrebivalisteNull())
                    txtPrebivaliste.Text = ucenik.Prebivaliste;
                this.ucenik = ucenik;
            }
            this.FormStandardSettings();
        }

        private readonly Ds.UceniciRow ucenik = null;

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                txtJOB.Text = txtJOB.Text.Trim();
                txtPrebivaliste.Text = txtPrebivaliste.Text.Trim();
                if (txtJOB.Text == "")
                    throw new Exception("Polje JOB se mora popuniti.");
                if (txtJOB.Text.Length != 16)
                    throw new Exception("JOB mora imati tačno 16 karaktera.");

                if (ucenik == null) // dodavanje novog ucenika
                {
                    if (AppData.Ds.Ucenici.Any(it => it.JOB == txtJOB.Text))
                        throw new Exception("Učenik sa datim JOB-om već postoji u evidenciji.");
                    var uc = AppData.Ds.Ucenici.NewUceniciRow();
                    uc.JOB = txtJOB.Text;
                    if (txtPrebivaliste.Text != "")
                        uc.Prebivaliste = txtPrebivaliste.Text;
                    AppData.Ds.Ucenici.AddUceniciRow(uc);
                    Utils.ShowMbox("Učenik je dodat, ali neće biti vidljiv među tekućim"
                        + " dok se ne preuzmu podaci o razredu i odeljenju.", Text);
                }
                else // izmena podataka o uceniku
                {
                    ucenik.JOB = txtJOB.Text;
                    if (txtPrebivaliste.Text != "")
                        ucenik.Prebivaliste = txtPrebivaliste.Text;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }
    }
}
