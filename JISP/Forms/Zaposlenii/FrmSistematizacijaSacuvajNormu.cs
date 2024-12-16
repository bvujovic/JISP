using JISP.Classes;
using System;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmSistematizacijaSacuvajNormu : Form
    {
        public FrmSistematizacijaSacuvajNormu(double ukNormaPoSistem, double ukNormaPoRM)
        {
            InitializeComponent();

            numUkNormaPoSistem.Value = (decimal)ukNormaPoSistem;
            lblUkNormaPoRM.Text = ukNormaPoRM.ToString("0.00");
            numUkNormaPoSistem.Select(0, 10);
        }

        public double UkupnaNormaPoSistem => (double)numUkNormaPoSistem.Value;

        private void FrmSistematizacijaSacuvajNormu_Load(object sender, EventArgs e)
        {
            this.FormStandardSettings();
        }

        private void NumUkNormaPoSistem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                e.SuppressKeyPress = true; // protiv "kling" zvuka
            }
        }
    }
}
