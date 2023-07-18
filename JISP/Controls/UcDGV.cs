using JISP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Controls
{
    public class UcDGV : DataGridView
    {
        private ContextMenuStrip ctxMenuDGV;
        private IContainer components;
        private ToolStripMenuItem tsmiSort;
        private ToolStripMenuItem tsmiSelekcija;
        private ToolStripMenuItem tsmiSelCeoRed;
        private ToolStripMenuItem tsmiSelCelija;
        private ToolStripMenuItem tsmiPrikazKolona;
        private ToolStripMenuItem tsmiRazliciteVrednosti;
        private ToolStripMenuItem tsmiKopiranjeNaKlik;

        /// <summary>Kolone koje su u dizajneru postavljenje na Visible = true</summary>
        private List<DataGridViewColumn> availableColumns = null;

        public UcDGV()
        {
            RowHeadersWidth = 30;
            InitializeComponent();
            tsmiSort.Click += TsmiSort_Click;
            tsmiRazliciteVrednosti.Click += TsmiRazliciteVrednosti_Click;
            tsmiSelCeoRed.CheckedChanged += TsmiSelelekcija_CheckedChanged;
            tsmiSelCelija.CheckedChanged += TsmiSelelekcija_CheckedChanged;
            tsmiKopiranjeNaKlik.CheckedChanged += TsmiKopiranjeNaKlik_CheckedChanged;

            DisplayPositionRowCount();
            SelectionChanged += (o, ea) => DisplayPositionRowCount();
        }

        /// <summary>Ucitavanje podesavanja (vidljivost kolona...) iz XML fajla.</summary>
        public void LoadSettings()
        {
            availableColumns = Columns.Cast<DataGridViewColumn>().Where(it => it.Visible).ToList();
            var strVisibleColumns = Data.AppData.LoadSett(this.Name);
            string[] visibleColumns = strVisibleColumns?.Split('|');
            foreach (DataGridViewColumn col in availableColumns)
            {
                var tsmi = new ToolStripMenuItem
                {
                    Text = col.HeaderText,
                    CheckOnClick = true,
                    Checked = visibleColumns == null || visibleColumns.Contains(col.Name)
                };
                if (!tsmi.Checked)
                    col.Visible = false;
                tsmi.CheckedChanged += TsmiPrikazKol_CheckedChanged;
                tsmiPrikazKolona.DropDownItems.Add(tsmi);
            }
        }

        private void TsmiPrikazKol_CheckedChanged(object sender, EventArgs e)
        {
            var tsmi = sender as ToolStripMenuItem;
            var col = Columns.Cast<DataGridViewColumn>().FirstOrDefault(it => it.HeaderText == tsmi.Text);
            col.Visible = tsmi.Checked;
        }

        /// <summary>Cuvanje podesavanja (vidljivost kolona...) u XML fajlu.</summary>
        public void SaveSettings()
        {
            if (availableColumns != null)
            {
                var vidljivostDostupnihKolona =
                    string.Join("|", availableColumns.Where(it => it.Visible).Select(it => it.Name));
                Data.AppData.SaveSett(this.Name, vidljivostDostupnihKolona);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctxMenuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPrikazKolona = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSort = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRazliciteVrednosti = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKopiranjeNaKlik = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelekcija = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelCeoRed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelCelija = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxMenuDGV
            // 
            this.ctxMenuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrikazKolona,
            this.tsmiSort,
            this.tsmiRazliciteVrednosti,
            this.tsmiKopiranjeNaKlik,
            this.tsmiSelekcija});
            this.ctxMenuDGV.Name = "ctxMenuDGV";
            this.ctxMenuDGV.Size = new System.Drawing.Size(213, 114);
            // 
            // tsmiPrikazKolona
            // 
            this.tsmiPrikazKolona.Name = "tsmiPrikazKolona";
            this.tsmiPrikazKolona.Size = new System.Drawing.Size(212, 22);
            this.tsmiPrikazKolona.Text = "Prikaz kolona";
            // 
            // tsmiSort
            // 
            this.tsmiSort.Name = "tsmiSort";
            this.tsmiSort.Size = new System.Drawing.Size(212, 22);
            this.tsmiSort.Text = "Podrazumevano sortiranje";
            // 
            // tsmiRazliciteVrednosti
            // 
            this.tsmiRazliciteVrednosti.Name = "tsmiRazliciteVrednosti";
            this.tsmiRazliciteVrednosti.Size = new System.Drawing.Size(212, 22);
            this.tsmiRazliciteVrednosti.Text = "Različite vrednosti";
            // 
            // tsmiKopiranjeNaKlik
            // 
            this.tsmiKopiranjeNaKlik.CheckOnClick = true;
            this.tsmiKopiranjeNaKlik.Name = "tsmiKopiranjeNaKlik";
            this.tsmiKopiranjeNaKlik.Size = new System.Drawing.Size(212, 22);
            this.tsmiKopiranjeNaKlik.Text = "Kopiranje na klik";
            // 
            // tsmiSelekcija
            // 
            this.tsmiSelekcija.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelCeoRed,
            this.tsmiSelCelija});
            this.tsmiSelekcija.Name = "tsmiSelekcija";
            this.tsmiSelekcija.Size = new System.Drawing.Size(212, 22);
            this.tsmiSelekcija.Text = "Selekcija";
            // 
            // tsmiSelCeoRed
            // 
            this.tsmiSelCeoRed.Checked = true;
            this.tsmiSelCeoRed.CheckOnClick = true;
            this.tsmiSelCeoRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiSelCeoRed.Name = "tsmiSelCeoRed";
            this.tsmiSelCeoRed.Size = new System.Drawing.Size(115, 22);
            this.tsmiSelCeoRed.Text = "Ceo red";
            // 
            // tsmiSelCelija
            // 
            this.tsmiSelCelija.CheckOnClick = true;
            this.tsmiSelCelija.Name = "tsmiSelCelija";
            this.tsmiSelCelija.Size = new System.Drawing.Size(115, 22);
            this.tsmiSelCelija.Text = "Ćelija";
            // 
            // UcDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ContextMenuStrip = this.ctxMenuDGV;
            this.ctxMenuDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void TsmiSort_Click(object sender, EventArgs e)
        {
            try { (DataSource as BindingSource).Sort = StandardSort; }
            catch (Exception ex) { Utils.ShowMbox(ex, "Sortiranje"); }
        }

        private void TsmiRazliciteVrednosti_Click(object sender, EventArgs e)
        {
            try
            {
                var idxColumn = SelectedCells[0].ColumnIndex;
                var values = ValuesCount(idxColumn);
                Utils.ShowMbox(string.Join(Environment.NewLine, values.Select(it => it.Value + "\t" + it.Key))
                    , tsmiRazliciteVrednosti.Text + $" ({values.Count})", true);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, tsmiRazliciteVrednosti.Text); }
        }

        private void TsmiSelelekcija_CheckedChanged(object sender, EventArgs e)
        {
            var tsmi = sender as ToolStripMenuItem;

            var selCeoRed = tsmi == tsmiSelCeoRed && tsmi.Checked || tsmi == tsmiSelCelija && !tsmi.Checked;
            SelectionMode = selCeoRed ? DataGridViewSelectionMode.FullRowSelect : DataGridViewSelectionMode.RowHeaderSelect;

            tsmiSelCeoRed.Checked = selCeoRed;
            tsmiSelCelija.Checked = !selCeoRed;
        }

        /// <summary>Postavljanje nacina selektovanja: true - ceo red, false - celija.</summary>
        public void TsmiSelekcija(bool ceoRed)
        {
            var tsmi = ceoRed ? tsmiSelCeoRed : tsmiSelCelija;
            tsmi.Checked = true;
            TsmiSelelekcija_CheckedChanged(tsmi, EventArgs.Empty);
        }

        public string StandardSort { get; set; } = null;

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Controla (Label npr) za prikaz red. br. tekuceg i ukupnog broja redova."), Category("Layout")]
        public Control CtrlDisplayPositionRowCount { get; set; }

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

        /// <summary>Vraca kolekciju selektovanih (DataSet) redova.</summary>
        /// <remarks>Baca izuzetak ako nema selektovanih redova.</remarks>
        public IEnumerable<T> SelectedDataRows<T>() where T : class
        {
            if (SelectedRows.Count == 0)
                throw new Exception("Nije selektovan nijedan red u tabeli.");
            else
                return SelectedRows.Cast<DataGridViewRow>().Select(it => DataRow<T>(it)).Reverse();
        }

        private void TsmiKopiranjeNaKlik_CheckedChanged(object sender, EventArgs e)
        {
            CopyOnCellClick = tsmiKopiranjeNaKlik.Checked;
        }

        private bool copyOnCellClick = false;
        /// <summary>Da li se tekst celije kopira u klipbord pri kliku na celiju.</summary>
        public bool CopyOnCellClick
        {
            get => copyOnCellClick;
            set
            {
                if (copyOnCellClick != value)
                {
                    copyOnCellClick = value;
                    tsmiKopiranjeNaKlik.Checked = value;
                }
            }
        }

        /// <summary>Niz indeksa kolona/celija ciji ce se podaci kopirati na korisnikov klik.</summary>
        public int[] ColumnsForCopyOnClick { get; set; }

        protected override void OnCellClick(DataGridViewCellEventArgs e)
        {
            base.OnCellClick(e);

            // kopiranje sadrzaja celije na klik
            if (CopyOnCellClick
                && e.ColumnIndex != -1 && e.RowIndex != -1 && SelectedCells.Count > 0
                && (ColumnsForCopyOnClick == null || ColumnsForCopyOnClick.Contains(e.ColumnIndex))
                && Columns[e.ColumnIndex].CellType == typeof(DataGridViewTextBoxCell))
            {
                if (SelectedCells.Count == 1)
                    CopyCellText(SelectedCells[0]);
                else
                    CopyCellText(SelectedCells[e.ColumnIndex]);
            }

            // klik na zaglavlje kolone -> sortiranje
            if (e.ColumnIndex != -1 && e.RowIndex == -1 && !string.IsNullOrEmpty(StandardSort))
            {
                try
                {
                    var bs = DataSource as BindingSource;
                    var prevBsSort = bs.Sort;
                    var col = Columns[e.ColumnIndex];
                    var colName = col.DataPropertyName;
                    bs.Sort = colName + $", {StandardSort}";
                    if (prevBsSort == bs.Sort)
                        bs.Sort = colName + $" DESC, {StandardSort}";
                }
                catch (Exception ex) { Utils.ShowMbox(ex, "Sortiranje"); }
            }
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
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "CopyCellText"); }
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

        /// <summary>Postavljanje binding svojstava za dgvc ComboBox tipa.</summary>
        /// <remarks>Poziv ove metode mora da ide iza bsXXX.DataSource = AppData.Ds</remarks>
        public void SetupDgvComboColumn(DataGridViewComboBoxColumn dgvc
            , BindingSource bs, string displayMember, string valueMember, string parentValueMember)
        {
            dgvc.DataSource = bs;
            dgvc.DataPropertyName = parentValueMember;
            dgvc.ValueMember = valueMember;
            dgvc.DisplayMember = displayMember;
            dgvc.DisplayStyleForCurrentCellOnly = true;
            dgvc.FlatStyle = FlatStyle.Flat;
        }

        /// <summary>Prikaz tekuceg reda ili broja selektovanih redova u datoj kontroli (labeli).</summary>
        public void DisplayPositionRowCount()
        {
            if (DataSource is BindingSource bs && CtrlDisplayPositionRowCount != null)
                if (SelectedRows.Count < 2)
                    CtrlDisplayPositionRowCount.Text = $"Red {bs.Position + 1} / {bs.Count}";
                else
                    CtrlDisplayPositionRowCount.Text = $"Redova {SelectedRows.Count}";
        }
    }
}
