using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmUcenici : Form
    {
        public FrmUcenici()
        {
            InitializeComponent();
        }

        private void FrmUcenici_Load(object sender, EventArgs e)
        {
            bsUcenici.DataSource = Data.AppData.Ds;
            bsSkole.DataSource = Data.AppData.Ds;
            dgv.SetupDgvComboColumn(dgvcSkola, bsSkole, "Naziv", "IdSkole", "IdSkole");

            DisplayRowCount();
            colOriginal = lblStatus.BackColor;
            dgv.CellTextCopied += Dgv_CellTextCopied;
            lblStatus.TextChanged += LblStatus_TextChanged;
            timStatus.Tick += TimStatus_Tick;
        }

        private void Dgv_CellTextCopied(object sender, EventArgs e)
        {
            lblStatus.Text = "Kopiran tekst: " + Clipboard.GetText();
        }

        private void LblStatus_TextChanged(object sender, EventArgs e)
        {
            lblStatus.BackColor = Color.Green;
            timStatus.Start();
        }

        private Color colOriginal;
        private readonly Timer timStatus = new Timer { Interval = 250 };

        private void TimStatus_Tick(object sender, EventArgs e)
        {
            timStatus.Stop();
            lblStatus.BackColor = colOriginal;
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var s = txtFilter.Text;
                bsUcenici.Filter = $"Ime LIKE '%{s}%' OR Prezime LIKE '%{s}%' OR JOB LIKE '%{s}%' ";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            DisplayRowCount();
        }

        private void DisplayRowCount()
            => lblRowCount.Text = $"Redova: {bsUcenici.Count}";

        private void BtnSaveData_Click(object sender, EventArgs e)
            => Data.AppData.SaveDsData();

        private void TxtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                bsUcenici.MoveNext();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                bsUcenici.MovePrevious();
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                dgv.CopyCellText(dgvcJOB.Index);
                e.SuppressKeyPress = true; // protiv "kling" zvuka
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtFilter.Clear();
                e.SuppressKeyPress = true; // protiv "kling" zvuka
            }
        }

        private void BtnSrednjoskolci_Click(object sender, EventArgs e)
        {
            Classes.Utils.ShowForm(typeof(FrmSrednjoskolci));
        }

        private void ChkAllowNew_CheckedChanged(object sender, EventArgs e)
        {
            dgv.AllowUserToAddRows = chkAllowNew.Checked;
            if (chkAllowNew.Checked)
                bsUcenici.MoveLast();
        }
    }
}
