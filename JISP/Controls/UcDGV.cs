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

        /// <summary>Vraca (DataSet) red sa podacima na osnovu tekuceg DataGridView reda.</summary>
        public T CurrDataRow<T>() where T : class
            => DataRow<T>(CurrentRow);

        /// <summary>Vraca (DataSet) red sa podacima na osnovu indeksa DataGridView reda.</summary>
        public T DataRow<T>(int i) where T : class
            => DataRow<T>(Rows[i]);

        /// <summary>Vraca (DataSet) red sa podacima na osnovu DataGridView reda.</summary>
        public T DataRow<T>(DataGridViewRow dgvRow) where T : class
        {
            var drv = dgvRow.DataBoundItem as System.Data.DataRowView;
            return drv.Row as T;
        }

        protected override void OnCellClick(DataGridViewCellEventArgs e)
        {
            base.OnCellClick(e);
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && SelectedCells.Count > 0)
                CopyCellText(SelectedCells[0]);
        }

        /// <summary>Kopiranje teksta celije u klipbord.</summary>
        public void CopyCellText(int idxCol)
        {
            if (idxCol >= 0 && idxCol < CurrentRow.Cells.Count)
                CopyCellText(CurrentRow.Cells[idxCol]);
        }

        /// <summary>Kopiranje teksta celije u klipbord.</summary>
        private void CopyCellText(DataGridViewCell dgvc)
        {
            try
            {
                var val = dgvc.FormattedValue.ToString();
                if (!string.IsNullOrEmpty(val))
                {
                    Clipboard.SetDataObject(val, false, 3, 200); // obican SetText je ponekad fejlovao
                    CellTextCopied?.Invoke(dgvc, EventArgs.Empty);
                }
                else
                    Clipboard.Clear();
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, "CopyCellText"); }
        }

        public event EventHandler CellTextCopied;

        /// <summary>Spisak razlicitih vrednosti i broja njihovih pojavljivanja u koloni.</summary>
        public IDictionary<string, int> ValuesCount(int colIdx)
        {
            var dict = new Dictionary<string, int>();
            if (colIdx < 0 || colIdx >= Columns.Count || Rows.Count == 0)
                return dict;

            foreach (DataGridViewRow row in Rows)
            {
                var val = row.Cells[colIdx].FormattedValue.ToString();
                if (!dict.ContainsKey(val))
                    dict.Add(val, 1);
                else
                    dict[val]++;
            }
            return dict;
        }
    }
}
