using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmUceniciOcene : Form
    {
        public FrmUceniciOcene()
        {
            InitializeComponent();
            ResetLblMarksAverageText();
        }

        private void ResetLblMarksAverageText()
            => lblMarksAverage.Text = "Prosek: /";

        private void BtnPasteClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                ResetLblMarksAverageText();
                var avg = Marks.CalcAverage(Clipboard.GetText(), chkInvalidMarks.Checked);
                lblMarksAverage.Text = "Prosek: " + avg.ToString("0.00");
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, Text); }
        }
    }
}
