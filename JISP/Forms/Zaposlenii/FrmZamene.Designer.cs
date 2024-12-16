namespace JISP.Forms.Zaposlenii
{
    partial class FrmZamene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBottomLeftRes = new JISP.Controls.UcLeftPanel();
            this.btnExit = new JISP.Controls.UcExitAppButton();
            this.lblBrojRedova = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtZamena = new JISP.Controls.UcFilterTextBox();
            this.txtZamenjen = new JISP.Controls.UcFilterTextBox();
            this.chkAktivno = new System.Windows.Forms.CheckBox();
            this.dgvZamene = new JISP.Controls.UcDGV();
            this.bsZaposlenja = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.zamenjeniZaposleniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatRadnogVremenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnoMestoNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZaposlenOdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZaposlenDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noksNivoNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaAngazovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razlogPrestankaZaposlenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojUgovoraORaduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.pnlBottomLeftRes.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 18);
            label1.TabIndex = 12;
            label1.Text = "Zamenjen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 18);
            label2.TabIndex = 13;
            label2.Text = "Zamena";
            // 
            // pnlBottomLeftRes
            // 
            this.pnlBottomLeftRes.Controls.Add(this.btnExit);
            this.pnlBottomLeftRes.Controls.Add(this.lblBrojRedova);
            this.pnlBottomLeftRes.Controls.Add(this.lblStatus);
            this.pnlBottomLeftRes.Controls.Add(this.gbFilter);
            this.pnlBottomLeftRes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottomLeftRes.Location = new System.Drawing.Point(0, 0);
            this.pnlBottomLeftRes.Name = "pnlBottomLeftRes";
            this.pnlBottomLeftRes.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlBottomLeftRes.RightWingWidth = 6;
            this.pnlBottomLeftRes.Size = new System.Drawing.Size(146, 453);
            this.pnlBottomLeftRes.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(8, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Izlaz";
            this.btnExit.ToolTipText = "Izlaz iz aplikacije";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblBrojRedova
            // 
            this.lblBrojRedova.AutoSize = true;
            this.lblBrojRedova.Location = new System.Drawing.Point(8, 64);
            this.lblBrojRedova.Name = "lblBrojRedova";
            this.lblBrojRedova.Size = new System.Drawing.Size(59, 18);
            this.lblBrojRedova.TabIndex = 12;
            this.lblBrojRedova.Text = "Redova";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 426);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 18);
            this.lblStatus.TabIndex = 11;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txtZamena);
            this.gbFilter.Controls.Add(this.txtZamenjen);
            this.gbFilter.Controls.Add(label2);
            this.gbFilter.Controls.Add(label1);
            this.gbFilter.Controls.Add(this.chkAktivno);
            this.gbFilter.Location = new System.Drawing.Point(3, 90);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(135, 154);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filteri";
            // 
            // txtZamena
            // 
            this.txtZamena.BindingSource = null;
            this.txtZamena.Location = new System.Drawing.Point(5, 95);
            this.txtZamena.Name = "txtZamena";
            this.txtZamena.ShouldBeCyrillic = false;
            this.txtZamena.Size = new System.Drawing.Size(123, 24);
            this.txtZamena.TabIndex = 1;
            this.txtZamena.TextChanged += new System.EventHandler(this.TxtZamena_TextChanged);
            // 
            // txtZamenjen
            // 
            this.txtZamenjen.BindingSource = null;
            this.txtZamenjen.Location = new System.Drawing.Point(6, 44);
            this.txtZamenjen.Name = "txtZamenjen";
            this.txtZamenjen.ShouldBeCyrillic = false;
            this.txtZamenjen.Size = new System.Drawing.Size(123, 24);
            this.txtZamenjen.TabIndex = 0;
            this.txtZamenjen.TextChanged += new System.EventHandler(this.TxtZamenjen_TextChanged);
            // 
            // chkAktivno
            // 
            this.chkAktivno.AutoSize = true;
            this.chkAktivno.Location = new System.Drawing.Point(8, 126);
            this.chkAktivno.Name = "chkAktivno";
            this.chkAktivno.Size = new System.Drawing.Size(75, 22);
            this.chkAktivno.TabIndex = 11;
            this.chkAktivno.Text = "Aktivno";
            this.chkAktivno.UseVisualStyleBackColor = true;
            this.chkAktivno.CheckedChanged += new System.EventHandler(this.ChkAktivno_CheckedChanged);
            // 
            // dgvZamene
            // 
            this.dgvZamene.AllowUserToAddRows = false;
            this.dgvZamene.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvZamene.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZamene.AutoGenerateColumns = false;
            this.dgvZamene.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZamene.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZamene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zamenjeniZaposleniDataGridViewTextBoxColumn,
            this.zaposleniDataGridViewTextBoxColumn,
            this.procenatRadnogVremenaDataGridViewTextBoxColumn,
            this.radnoMestoNazivDataGridViewTextBoxColumn,
            this.datumZaposlenOdDataGridViewTextBoxColumn,
            this.datumZaposlenDoDataGridViewTextBoxColumn,
            this.aktivanDataGridViewCheckBoxColumn,
            this.noksNivoNazivDataGridViewTextBoxColumn,
            this.vrstaAngazovanjaDataGridViewTextBoxColumn,
            this.razlogPrestankaZaposlenjaDataGridViewTextBoxColumn,
            this.brojUgovoraORaduDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn});
            this.dgvZamene.ColumnsForCopyOnClick = null;
            this.dgvZamene.CopyOnCellClick = false;
            this.dgvZamene.CtrlDisplayPositionRowCount = this.lblBrojRedova;
            this.dgvZamene.DataSource = this.bsZaposlenja;
            this.dgvZamene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZamene.Location = new System.Drawing.Point(146, 0);
            this.dgvZamene.Name = "dgvZamene";
            this.dgvZamene.ReadOnly = true;
            this.dgvZamene.RowHeadersWidth = 30;
            this.dgvZamene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZamene.Size = new System.Drawing.Size(1215, 453);
            this.dgvZamene.StandardSort = null;
            this.dgvZamene.TabIndex = 0;
            // 
            // bsZaposlenja
            // 
            this.bsZaposlenja.DataMember = "Zaposlenja";
            this.bsZaposlenja.DataSource = this.ds;
            this.bsZaposlenja.Sort = "DatumZaposlenOd DESC";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamenjeniZaposleniDataGridViewTextBoxColumn
            // 
            this.zamenjeniZaposleniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zamenjeniZaposleniDataGridViewTextBoxColumn.DataPropertyName = "_ZamenjeniZaposleni";
            this.zamenjeniZaposleniDataGridViewTextBoxColumn.HeaderText = "Zamenjen";
            this.zamenjeniZaposleniDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.zamenjeniZaposleniDataGridViewTextBoxColumn.Name = "zamenjeniZaposleniDataGridViewTextBoxColumn";
            this.zamenjeniZaposleniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposleniDataGridViewTextBoxColumn
            // 
            this.zaposleniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zaposleniDataGridViewTextBoxColumn.DataPropertyName = "_Zaposleni";
            this.zaposleniDataGridViewTextBoxColumn.HeaderText = "Zamena";
            this.zaposleniDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.zaposleniDataGridViewTextBoxColumn.Name = "zaposleniDataGridViewTextBoxColumn";
            this.zaposleniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procenatRadnogVremenaDataGridViewTextBoxColumn
            // 
            this.procenatRadnogVremenaDataGridViewTextBoxColumn.DataPropertyName = "ProcenatRadnogVremena";
            this.procenatRadnogVremenaDataGridViewTextBoxColumn.HeaderText = "Procenat";
            this.procenatRadnogVremenaDataGridViewTextBoxColumn.Name = "procenatRadnogVremenaDataGridViewTextBoxColumn";
            this.procenatRadnogVremenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radnoMestoNazivDataGridViewTextBoxColumn
            // 
            this.radnoMestoNazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.radnoMestoNazivDataGridViewTextBoxColumn.DataPropertyName = "RadnoMestoNaziv";
            this.radnoMestoNazivDataGridViewTextBoxColumn.HeaderText = "Radno mesto";
            this.radnoMestoNazivDataGridViewTextBoxColumn.Name = "radnoMestoNazivDataGridViewTextBoxColumn";
            this.radnoMestoNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumZaposlenOdDataGridViewTextBoxColumn
            // 
            this.datumZaposlenOdDataGridViewTextBoxColumn.DataPropertyName = "DatumZaposlenOd";
            this.datumZaposlenOdDataGridViewTextBoxColumn.HeaderText = "Zaposlen od";
            this.datumZaposlenOdDataGridViewTextBoxColumn.Name = "datumZaposlenOdDataGridViewTextBoxColumn";
            this.datumZaposlenOdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumZaposlenDoDataGridViewTextBoxColumn
            // 
            this.datumZaposlenDoDataGridViewTextBoxColumn.DataPropertyName = "DatumZaposlenDo";
            this.datumZaposlenDoDataGridViewTextBoxColumn.HeaderText = "Zaposlen do";
            this.datumZaposlenDoDataGridViewTextBoxColumn.Name = "datumZaposlenDoDataGridViewTextBoxColumn";
            this.datumZaposlenDoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            this.aktivanDataGridViewCheckBoxColumn.DataPropertyName = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.HeaderText = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            this.aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // noksNivoNazivDataGridViewTextBoxColumn
            // 
            this.noksNivoNazivDataGridViewTextBoxColumn.DataPropertyName = "NoksNivoNaziv";
            this.noksNivoNazivDataGridViewTextBoxColumn.HeaderText = "NOKS";
            this.noksNivoNazivDataGridViewTextBoxColumn.Name = "noksNivoNazivDataGridViewTextBoxColumn";
            this.noksNivoNazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.noksNivoNazivDataGridViewTextBoxColumn.ToolTipText = "NOKS zamene";
            // 
            // vrstaAngazovanjaDataGridViewTextBoxColumn
            // 
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.DataPropertyName = "VrstaAngazovanja";
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.HeaderText = "Vrsta angažovanja";
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.Name = "vrstaAngazovanjaDataGridViewTextBoxColumn";
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razlogPrestankaZaposlenjaDataGridViewTextBoxColumn
            // 
            this.razlogPrestankaZaposlenjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razlogPrestankaZaposlenjaDataGridViewTextBoxColumn.DataPropertyName = "RazlogPrestankaZaposlenja";
            this.razlogPrestankaZaposlenjaDataGridViewTextBoxColumn.HeaderText = "Razlog prestanka";
            this.razlogPrestankaZaposlenjaDataGridViewTextBoxColumn.Name = "razlogPrestankaZaposlenjaDataGridViewTextBoxColumn";
            this.razlogPrestankaZaposlenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojUgovoraORaduDataGridViewTextBoxColumn
            // 
            this.brojUgovoraORaduDataGridViewTextBoxColumn.DataPropertyName = "BrojUgovoraORadu";
            this.brojUgovoraORaduDataGridViewTextBoxColumn.HeaderText = "Broj ugovora";
            this.brojUgovoraORaduDataGridViewTextBoxColumn.Name = "brojUgovoraORaduDataGridViewTextBoxColumn";
            this.brojUgovoraORaduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dokumentDataGridViewTextBoxColumn
            // 
            this.dokumentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dokumentDataGridViewTextBoxColumn.DataPropertyName = "Dokument";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dokumentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dokumentDataGridViewTextBoxColumn.HeaderText = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.Name = "dokumentDataGridViewTextBoxColumn";
            this.dokumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dokumentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dokumentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dokumentDataGridViewTextBoxColumn.Width = 102;
            // 
            // FrmZamene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 453);
            this.Controls.Add(this.dgvZamene);
            this.Controls.Add(this.pnlBottomLeftRes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZamene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamene";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmZamene_FormClosed);
            this.Load += new System.EventHandler(this.FrmZamene_Load);
            this.pnlBottomLeftRes.ResumeLayout(false);
            this.pnlBottomLeftRes.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcLeftPanel pnlBottomLeftRes;
        private Controls.UcExitAppButton btnExit;
        private System.Windows.Forms.Label lblBrojRedova;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gbFilter;
        private Controls.UcDGV dgvZamene;
        private System.Windows.Forms.BindingSource bsZaposlenja;
        private Data.Ds ds;
        private System.Windows.Forms.CheckBox chkAktivno;
        private Controls.UcFilterTextBox txtZamenjen;
        private Controls.UcFilterTextBox txtZamena;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamenjeniZaposleniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposleniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatRadnogVremenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnoMestoNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZaposlenOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZaposlenDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noksNivoNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaAngazovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razlogPrestankaZaposlenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojUgovoraORaduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dokumentDataGridViewTextBoxColumn;
    }
}