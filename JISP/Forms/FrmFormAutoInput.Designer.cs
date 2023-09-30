namespace JISP.Forms
{
    partial class FrmFormAutoInput
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.bsFormAutoFills = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.bsFAFItems = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ttPrikaziKursor = new System.Windows.Forms.ToolTip(this.components);
            this.dgvFAFs = new JISP.Controls.UcDGV();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcFafComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItems = new JISP.Controls.UcDGV();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.chkPrikaziKursor = new System.Windows.Forms.CheckBox();
            this.btnPomeriStavkuNagore = new JISP.Controls.UcButton();
            this.btnPomeriStavkuNadole = new JISP.Controls.UcButton();
            this.gbPustanje = new System.Windows.Forms.GroupBox();
            this.btnPustanjeStartStop = new JISP.Controls.UcButton();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.btnObrisiStavku = new JISP.Controls.UcButton();
            this.ucExitApp1 = new JISP.Controls.UcExitAppButton();
            this.btnSnimanjeStartStop = new JISP.Controls.UcButton();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsFormAutoFills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFAFItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAFs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.gbPustanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // tim
            // 
            this.tim.Interval = 1000;
            this.tim.Tick += new System.EventHandler(this.Tim_Tick);
            // 
            // bsFormAutoFills
            // 
            this.bsFormAutoFills.DataMember = "FormAutoFills";
            this.bsFormAutoFills.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsFAFItems
            // 
            this.bsFAFItems.DataMember = "FormAutoFills_FAF_Items";
            this.bsFAFItems.DataSource = this.bsFormAutoFills;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(146, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvFAFs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvItems);
            this.splitContainer1.Size = new System.Drawing.Size(392, 442);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 8;
            // 
            // ttPrikaziKursor
            // 
            this.ttPrikaziKursor.ToolTipTitle = "Prikazivanje kursora";
            // 
            // dgvFAFs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFAFs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFAFs.AutoGenerateColumns = false;
            this.dgvFAFs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFAFs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFAFs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dgvcFafComment});
            this.dgvFAFs.ColumnsForCopyOnClick = null;
            this.dgvFAFs.CopyOnCellClick = false;
            this.dgvFAFs.CtrlDisplayPositionRowCount = null;
            this.dgvFAFs.DataSource = this.bsFormAutoFills;
            this.dgvFAFs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFAFs.Location = new System.Drawing.Point(0, 0);
            this.dgvFAFs.Name = "dgvFAFs";
            this.dgvFAFs.RowHeadersWidth = 30;
            this.dgvFAFs.Size = new System.Drawing.Size(392, 168);
            this.dgvFAFs.StandardSort = null;
            this.dgvFAFs.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Rutina";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 75;
            // 
            // dgvcFafComment
            // 
            this.dgvcFafComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcFafComment.DataPropertyName = "Comment";
            this.dgvcFafComment.HeaderText = "Komentar";
            this.dgvcFafComment.MinimumWidth = 100;
            this.dgvcFafComment.Name = "dgvcFafComment";
            // 
            // dgvItems
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemTypeDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.Comment});
            this.dgvItems.ColumnsForCopyOnClick = null;
            this.dgvItems.CopyOnCellClick = false;
            this.dgvItems.CtrlDisplayPositionRowCount = null;
            this.dgvItems.DataSource = this.bsFAFItems;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 30;
            this.dgvItems.Size = new System.Drawing.Size(392, 270);
            this.dgvItems.StandardSort = null;
            this.dgvItems.TabIndex = 4;
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItems_CellDoubleClick);
            this.dgvItems.SelectionChanged += new System.EventHandler(this.DgvItems_SelectionChanged);
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.itemTypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Tekst",
            "Klik",
            "DKlik"});
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Sadržaj";
            this.contentDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.FillWeight = 200F;
            this.Comment.HeaderText = "Komentar";
            this.Comment.Name = "Comment";
            this.Comment.ToolTipText = "Objašnjenje stavke, npr: Dugme Izračunaj";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.chkPrikaziKursor);
            this.pnlLeft.Controls.Add(this.btnPomeriStavkuNagore);
            this.pnlLeft.Controls.Add(this.btnPomeriStavkuNadole);
            this.pnlLeft.Controls.Add(this.gbPustanje);
            this.pnlLeft.Controls.Add(label1);
            this.pnlLeft.Controls.Add(this.btnObrisiStavku);
            this.pnlLeft.Controls.Add(this.ucExitApp1);
            this.pnlLeft.Controls.Add(this.btnSnimanjeStartStop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(146, 442);
            this.pnlLeft.TabIndex = 7;
            // 
            // chkPrikaziKursor
            // 
            this.chkPrikaziKursor.AutoSize = true;
            this.chkPrikaziKursor.Location = new System.Drawing.Point(8, 264);
            this.chkPrikaziKursor.Name = "chkPrikaziKursor";
            this.chkPrikaziKursor.Size = new System.Drawing.Size(119, 22);
            this.chkPrikaziKursor.TabIndex = 12;
            this.chkPrikaziKursor.Text = "Prikaži kursor";
            this.chkPrikaziKursor.UseVisualStyleBackColor = true;
            // 
            // btnPomeriStavkuNagore
            // 
            this.btnPomeriStavkuNagore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPomeriStavkuNagore.Location = new System.Drawing.Point(8, 323);
            this.btnPomeriStavkuNagore.Name = "btnPomeriStavkuNagore";
            this.btnPomeriStavkuNagore.Size = new System.Drawing.Size(127, 34);
            this.btnPomeriStavkuNagore.TabIndex = 11;
            this.btnPomeriStavkuNagore.Text = "Pomeri stavku ↑";
            this.btnPomeriStavkuNagore.ToolTipText = "Pomeranje selektovane stavke u listi za 1 poziciju nagore";
            this.btnPomeriStavkuNagore.UseVisualStyleBackColor = true;
            this.btnPomeriStavkuNagore.Click += new System.EventHandler(this.BtnPomeriStavkuNagore_Click);
            // 
            // btnPomeriStavkuNadole
            // 
            this.btnPomeriStavkuNadole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPomeriStavkuNadole.Location = new System.Drawing.Point(8, 356);
            this.btnPomeriStavkuNadole.Name = "btnPomeriStavkuNadole";
            this.btnPomeriStavkuNadole.Size = new System.Drawing.Size(127, 34);
            this.btnPomeriStavkuNadole.TabIndex = 10;
            this.btnPomeriStavkuNadole.Text = "Pomeri stavku ↓";
            this.btnPomeriStavkuNadole.ToolTipText = "Pomeranje selektovane stavke u listi za 1 poziciju nadole";
            this.btnPomeriStavkuNadole.UseVisualStyleBackColor = true;
            this.btnPomeriStavkuNadole.Click += new System.EventHandler(this.BtnPomeriStavkuNadole_Click);
            // 
            // gbPustanje
            // 
            this.gbPustanje.Controls.Add(label3);
            this.gbPustanje.Controls.Add(label2);
            this.gbPustanje.Controls.Add(this.btnPustanjeStartStop);
            this.gbPustanje.Controls.Add(this.numDelay);
            this.gbPustanje.Location = new System.Drawing.Point(8, 142);
            this.gbPustanje.Name = "gbPustanje";
            this.gbPustanje.Size = new System.Drawing.Size(127, 116);
            this.gbPustanje.TabIndex = 9;
            this.gbPustanje.TabStop = false;
            this.gbPustanje.Text = "Puštanje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(76, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 18);
            label3.TabIndex = 11;
            label3.Text = "ms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(107, 18);
            label2.TabIndex = 10;
            label2.Text = "Trajanje stavke";
            // 
            // btnPustanjeStartStop
            // 
            this.btnPustanjeStartStop.Location = new System.Drawing.Point(4, 23);
            this.btnPustanjeStartStop.Name = "btnPustanjeStartStop";
            this.btnPustanjeStartStop.Size = new System.Drawing.Size(117, 34);
            this.btnPustanjeStartStop.TabIndex = 1;
            this.btnPustanjeStartStop.Text = "Start Play";
            this.btnPustanjeStartStop.ToolTipText = "Zaustavljanje ili pokretanje procesa izvršavanja rutine: izvršavaju se sve stavke" +
    " do kraja liste počevši od tekuće";
            this.btnPustanjeStartStop.UseVisualStyleBackColor = true;
            this.btnPustanjeStartStop.Click += new System.EventHandler(this.BtnPustanjeStartStop_Click);
            // 
            // numDelay
            // 
            this.numDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDelay.Location = new System.Drawing.Point(4, 83);
            this.numDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(70, 24);
            this.numDelay.TabIndex = 2;
            this.numDelay.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numDelay.ValueChanged += new System.EventHandler(this.NumDelay_ValueChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 18);
            label1.TabIndex = 7;
            label1.Text = "Snimanje";
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObrisiStavku.Location = new System.Drawing.Point(8, 396);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(127, 34);
            this.btnObrisiStavku.TabIndex = 6;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.ToolTipText = "Brisanje selektovanih stavki";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.BtnObrisiStavku_Click);
            // 
            // ucExitApp1
            // 
            this.ucExitApp1.BackColor = System.Drawing.Color.Red;
            this.ucExitApp1.ForeColor = System.Drawing.Color.White;
            this.ucExitApp1.Location = new System.Drawing.Point(8, 12);
            this.ucExitApp1.Margin = new System.Windows.Forms.Padding(4);
            this.ucExitApp1.Name = "ucExitApp1";
            this.ucExitApp1.Size = new System.Drawing.Size(127, 34);
            this.ucExitApp1.TabIndex = 5;
            this.ucExitApp1.Text = "Izlaz";
            this.ucExitApp1.ToolTipText = "Izlaz iz aplikacije";
            this.ucExitApp1.UseVisualStyleBackColor = false;
            // 
            // btnSnimanjeStartStop
            // 
            this.btnSnimanjeStartStop.Location = new System.Drawing.Point(8, 90);
            this.btnSnimanjeStartStop.Name = "btnSnimanjeStartStop";
            this.btnSnimanjeStartStop.Size = new System.Drawing.Size(127, 34);
            this.btnSnimanjeStartStop.TabIndex = 0;
            this.btnSnimanjeStartStop.Text = "Start Rec";
            this.btnSnimanjeStartStop.ToolTipText = "Zaustavljanje ili pokretanje procesa snimanja tj. dodavanja stavki (klikovi) u ru" +
    "tinu tj. listu";
            this.btnSnimanjeStartStop.UseVisualStyleBackColor = true;
            this.btnSnimanjeStartStop.Click += new System.EventHandler(this.BtnSnimanjeStartStop_Click);
            // 
            // FrmFormAutoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 442);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFormAutoInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Auto Input";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFormAutoInput_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFormAutoInput_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bsFormAutoFills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFAFItems)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAFs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.gbPustanje.ResumeLayout(false);
            this.gbPustanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tim;
        private Controls.UcButton btnSnimanjeStartStop;
        private Controls.UcButton btnPustanjeStartStop;
        private System.Windows.Forms.NumericUpDown numDelay;
        private Controls.UcDGV dgvFAFs;
        private System.Windows.Forms.BindingSource bsFormAutoFills;
        private Data.Ds ds;
        private Controls.UcDGV dgvItems;
        private System.Windows.Forms.BindingSource bsFAFItems;
        private Controls.UcExitAppButton ucExitApp1;
        private Controls.UcButton btnObrisiStavku;
        private Controls.UcLeftPanel pnlLeft;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbPustanje;
        private Controls.UcButton btnPomeriStavkuNagore;
        private Controls.UcButton btnPomeriStavkuNadole;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFafComment;
        private System.Windows.Forms.CheckBox chkPrikaziKursor;
        private System.Windows.Forms.ToolTip ttPrikaziKursor;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}