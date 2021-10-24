using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Controls
{
    public class UcDGV : DataGridView
    {
        public UcDGV()
        {
            RowHeadersWidth = 30;
        }

        protected override void OnCellClick(DataGridViewCellEventArgs e)
        {
            base.OnCellClick(e);
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
                try { Clipboard.SetText(SelectedCells[0].Value.ToString()); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
