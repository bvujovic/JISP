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
        }

        private void BtnSaveData_Click(object sender, EventArgs e)
        {
            Data.AppData.SaveDsData();

            //try
            //{

            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnTextImport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sr = new System.IO.StreamReader
                    (System.IO.Path.Combine(Data.AppData.DataFolder, "uc_test.txt")))
                {
                    string line;
                    var cntLine = 0;
                    var cntItems = 7;
                    DataTable tbl = Data.AppData.Ds.Tables["Ucenici"];
                    DataRow row = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cntLine++;
                        line = line.Trim();
                        if (cntLine % cntItems == 5)
                        {
                            row = tbl.NewRow();
                            row["Ime"] = line;
                            tbl.Rows.Add(row);
                        }
                        //if (cntLine % cntItems == 2 && row != null)
                        //    row["Prezime"] = line;
                        if (cntLine % cntItems == 6 && row != null)
                        {
                            var duplicates = tbl.Select($"JOB = '{line}'");
                            if (duplicates.Length > 0)
                            {
                                tbl.Rows.Remove(row);
                                row = null;
                            }
                            else
                                row["JOB"] = line;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { Clipboard.SetText(dgv.SelectedCells[0].Value.ToString()); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
