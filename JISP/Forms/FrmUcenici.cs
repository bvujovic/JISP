using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmUcenici : Form
    {
        public FrmUcenici()
        {
            InitializeComponent();

            pnlLeftMaxWidth = pnlLeft.Width;
        }

        private readonly int pnlLeftMaxWidth;
        private readonly int pnlLeftMinWidth = 10;

        private void FrmUcenici_Load(object sender, EventArgs e)
        {
            bsUcenici.DataSource = Data.AppData.Ds;
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

        /// <summary>Show/Hide levog panela sa kontrolama.</summary>
        private void PnlLeft_Click(object sender, EventArgs e)
            => pnlLeft.Width = pnlLeft.Width == pnlLeftMaxWidth ? pnlLeftMinWidth : pnlLeftMaxWidth;

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

        private static bool IsJobValid(string job)
        {
            if (job.Length != 16)
                return false;
            if (job.Contains(' '))
                return false;
            return true;
        }

        private void BtnTextImport_Click(object sender, EventArgs e)
        {
            dgv.SuspendLayout();
            try
            {
                //B var fileName = System.IO.Path.Combine(Data.AppData.DataFolder, txtFileName.Text);
                var fileName = Data.AppData.FilePath(txtFileName.Text);
                if (!System.IO.File.Exists(fileName))
                    throw new Exception($"'{fileName}' ne postoji.");

                using (var sr = new System.IO.StreamReader(fileName))
                {
                    var tbl = Data.AppData.Ds.Tables["Ucenici"];
                    var theEnd = false;
                    var line = "";
                    var block = new List<string>();
                    while (!theEnd)
                    {
                        while ((line = sr.ReadLine()) != null && line != "")
                            block.Add(line.Trim());
                        //Console.WriteLine(block);
                        //Console.WriteLine(cntLine);

                        if (block.Count > 5 && IsJobValid(block[5]))
                            try
                            {
                                var row = tbl.NewRow();
                                row["Ime"] = block[4];
                                row["JOB"] = block[5];
                                tbl.Rows.Add(row);
                            }
                            catch (Exception ex)
                            {
                                var msg = ex.Message;
                                if (!msg.Contains("'JOB' is constrained to be unique"))
                                    if (Classes.Utils.ShowMboxYesNo($"Greska: {msg}" + Environment.NewLine +
                                        "Da li zelite da nastavite sa uvozom tekst podataka?", "Uvoz txt podataka") == DialogResult.No)
                                        theEnd = true;
                            }

                        block.Clear();
                        if (line == null)
                            theEnd = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            dgv.ResumeLayout();
            DisplayRowCount();
        }

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
                dgv.CopyCellText(dgvcJOB.Index);
        }
    }
}
