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
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && SelectedCells.Count > 0)
                CopyCellText(SelectedCells[0]);
        }

        /// <summary>Copy current cell's text to clipboard.</summary>
        public void CopyCellText(int idxCol)
        {
            if (idxCol >= 0 && idxCol < CurrentRow.Cells.Count)
                CopyCellText(CurrentRow.Cells[idxCol]);
        }

        private void CopyCellText(DataGridViewCell dgvc)
        {
            try
            {
                var val = dgvc.FormattedValue.ToString();
                if (!string.IsNullOrEmpty(val))
                {
                    Clipboard.SetText(val);
                    CellTextCopied?.Invoke(dgvc, EventArgs.Empty);
                }
                else
                    Clipboard.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public event EventHandler CellTextCopied;
    }
}
