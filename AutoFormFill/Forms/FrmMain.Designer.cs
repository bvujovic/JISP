namespace AutoFormFill
{
    partial class FrmMain
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.gbAdjPositions = new System.Windows.Forms.GroupBox();
            this.btnAdjPosOK = new System.Windows.Forms.Button();
            this.txtAdjPosDY = new System.Windows.Forms.TextBox();
            this.txtAdjPosDX = new System.Windows.Forms.TextBox();
            this.txtDataFolder = new System.Windows.Forms.TextBox();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnPomeriStavkuNadole = new System.Windows.Forms.Button();
            this.btnPomeriStavkuNagore = new System.Windows.Forms.Button();
            this.btnSnimanjeStartStop = new System.Windows.Forms.Button();
            this.chkPrikaziKursor = new System.Windows.Forms.CheckBox();
            this.gbPustanje = new System.Windows.Forms.GroupBox();
            this.btnPustanjeStartStop = new System.Windows.Forms.Button();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvRoutines = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRoutines = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new AutoFormFill.Ds();
            this.dgvActions = new System.Windows.Forms.DataGridView();
            this.bsActions = new System.Windows.Forms.BindingSource(this.components);
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.timAdjustPositions = new System.Windows.Forms.Timer(this.components);
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcActEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.gbAdjPositions.SuspendLayout();
            this.gbPustanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoutines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActions)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(76, 78);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 18);
            label3.TabIndex = 11;
            label3.Text = "ms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 18);
            label2.TabIndex = 10;
            label2.Text = "Trajanje akcije";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 18);
            label1.TabIndex = 13;
            label1.Text = "Snimanje";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(139, 18);
            label4.TabIndex = 19;
            label4.Text = "Folder sa podacima";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label5.Location = new System.Drawing.Point(14, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(21, 16);
            label5.TabIndex = 12;
            label5.Text = "dx";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label6.Location = new System.Drawing.Point(62, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(22, 16);
            label6.TabIndex = 15;
            label6.Text = "dy";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.gbAdjPositions);
            this.pnlLeft.Controls.Add(this.txtDataFolder);
            this.pnlLeft.Controls.Add(label4);
            this.pnlLeft.Controls.Add(this.btnObrisiStavku);
            this.pnlLeft.Controls.Add(this.btnPomeriStavkuNadole);
            this.pnlLeft.Controls.Add(this.btnPomeriStavkuNagore);
            this.pnlLeft.Controls.Add(this.btnSnimanjeStartStop);
            this.pnlLeft.Controls.Add(this.chkPrikaziKursor);
            this.pnlLeft.Controls.Add(this.gbPustanje);
            this.pnlLeft.Controls.Add(label1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(146, 475);
            this.pnlLeft.TabIndex = 0;
            // 
            // gbAdjPositions
            // 
            this.gbAdjPositions.Controls.Add(this.btnAdjPosOK);
            this.gbAdjPositions.Controls.Add(this.txtAdjPosDY);
            this.gbAdjPositions.Controls.Add(label6);
            this.gbAdjPositions.Controls.Add(this.txtAdjPosDX);
            this.gbAdjPositions.Controls.Add(label5);
            this.gbAdjPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAdjPositions.Location = new System.Drawing.Point(7, 273);
            this.gbAdjPositions.Name = "gbAdjPositions";
            this.gbAdjPositions.Size = new System.Drawing.Size(127, 66);
            this.gbAdjPositions.TabIndex = 21;
            this.gbAdjPositions.TabStop = false;
            this.gbAdjPositions.Text = "Podešavanje poz";
            // 
            // btnAdjPosOK
            // 
            this.btnAdjPosOK.Enabled = false;
            this.btnAdjPosOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdjPosOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdjPosOK.Location = new System.Drawing.Point(97, 36);
            this.btnAdjPosOK.Name = "btnAdjPosOK";
            this.btnAdjPosOK.Size = new System.Drawing.Size(27, 24);
            this.btnAdjPosOK.TabIndex = 17;
            this.btnAdjPosOK.Text = "ok";
            this.btnAdjPosOK.UseVisualStyleBackColor = true;
            this.btnAdjPosOK.Click += new System.EventHandler(this.BtnAdjPosOK_Click);
            // 
            // txtAdjPosDY
            // 
            this.txtAdjPosDY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdjPosDY.Location = new System.Drawing.Point(52, 37);
            this.txtAdjPosDY.Name = "txtAdjPosDY";
            this.txtAdjPosDY.ReadOnly = true;
            this.txtAdjPosDY.Size = new System.Drawing.Size(42, 22);
            this.txtAdjPosDY.TabIndex = 16;
            this.txtAdjPosDY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdjPosDX
            // 
            this.txtAdjPosDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdjPosDX.Location = new System.Drawing.Point(4, 37);
            this.txtAdjPosDX.Name = "txtAdjPosDX";
            this.txtAdjPosDX.ReadOnly = true;
            this.txtAdjPosDX.Size = new System.Drawing.Size(42, 22);
            this.txtAdjPosDX.TabIndex = 14;
            this.txtAdjPosDX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataFolder
            // 
            this.txtDataFolder.Location = new System.Drawing.Point(7, 31);
            this.txtDataFolder.Name = "txtDataFolder";
            this.txtDataFolder.Size = new System.Drawing.Size(127, 24);
            this.txtDataFolder.TabIndex = 20;
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObrisiStavku.Location = new System.Drawing.Point(11, 429);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(127, 34);
            this.btnObrisiStavku.TabIndex = 18;
            this.btnObrisiStavku.Text = "Obriši akciju";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.BtnObrisiStavku_Click);
            // 
            // btnPomeriStavkuNadole
            // 
            this.btnPomeriStavkuNadole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPomeriStavkuNadole.Location = new System.Drawing.Point(11, 385);
            this.btnPomeriStavkuNadole.Name = "btnPomeriStavkuNadole";
            this.btnPomeriStavkuNadole.Size = new System.Drawing.Size(127, 34);
            this.btnPomeriStavkuNadole.TabIndex = 17;
            this.btnPomeriStavkuNadole.Text = "Pomeri akciju ↓";
            this.btnPomeriStavkuNadole.UseVisualStyleBackColor = true;
            this.btnPomeriStavkuNadole.Click += new System.EventHandler(this.BtnPomeriStavkuNadole_Click);
            // 
            // btnPomeriStavkuNagore
            // 
            this.btnPomeriStavkuNagore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPomeriStavkuNagore.Location = new System.Drawing.Point(11, 351);
            this.btnPomeriStavkuNagore.Name = "btnPomeriStavkuNagore";
            this.btnPomeriStavkuNagore.Size = new System.Drawing.Size(127, 34);
            this.btnPomeriStavkuNagore.TabIndex = 16;
            this.btnPomeriStavkuNagore.Text = "Pomeri akciju ↑";
            this.btnPomeriStavkuNagore.UseVisualStyleBackColor = true;
            this.btnPomeriStavkuNagore.Click += new System.EventHandler(this.BtnPomeriStavkuNagore_Click);
            // 
            // btnSnimanjeStartStop
            // 
            this.btnSnimanjeStartStop.Location = new System.Drawing.Point(7, 85);
            this.btnSnimanjeStartStop.Name = "btnSnimanjeStartStop";
            this.btnSnimanjeStartStop.Size = new System.Drawing.Size(127, 34);
            this.btnSnimanjeStartStop.TabIndex = 12;
            this.btnSnimanjeStartStop.Text = "Start Rec";
            this.btnSnimanjeStartStop.UseVisualStyleBackColor = true;
            this.btnSnimanjeStartStop.Click += new System.EventHandler(this.BtnSnimanjeStartStop_Click);
            // 
            // chkPrikaziKursor
            // 
            this.chkPrikaziKursor.AutoSize = true;
            this.chkPrikaziKursor.Location = new System.Drawing.Point(7, 245);
            this.chkPrikaziKursor.Name = "chkPrikaziKursor";
            this.chkPrikaziKursor.Size = new System.Drawing.Size(119, 22);
            this.chkPrikaziKursor.TabIndex = 15;
            this.chkPrikaziKursor.Text = "Prikaži kursor";
            this.chkPrikaziKursor.UseVisualStyleBackColor = true;
            // 
            // gbPustanje
            // 
            this.gbPustanje.Controls.Add(this.btnPustanjeStartStop);
            this.gbPustanje.Controls.Add(label3);
            this.gbPustanje.Controls.Add(label2);
            this.gbPustanje.Controls.Add(this.numDelay);
            this.gbPustanje.Location = new System.Drawing.Point(7, 129);
            this.gbPustanje.Name = "gbPustanje";
            this.gbPustanje.Size = new System.Drawing.Size(127, 106);
            this.gbPustanje.TabIndex = 14;
            this.gbPustanje.TabStop = false;
            this.gbPustanje.Text = "Puštanje";
            // 
            // btnPustanjeStartStop
            // 
            this.btnPustanjeStartStop.Location = new System.Drawing.Point(5, 20);
            this.btnPustanjeStartStop.Name = "btnPustanjeStartStop";
            this.btnPustanjeStartStop.Size = new System.Drawing.Size(117, 34);
            this.btnPustanjeStartStop.TabIndex = 12;
            this.btnPustanjeStartStop.Text = "Start Play";
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
            this.numDelay.Location = new System.Drawing.Point(4, 76);
            this.numDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(70, 24);
            this.numDelay.TabIndex = 2;
            this.numDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDelay.ValueChanged += new System.EventHandler(this.NumDelay_ValueChanged);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(146, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvRoutines);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvActions);
            this.scMain.Size = new System.Drawing.Size(475, 475);
            this.scMain.SplitterDistance = 157;
            this.scMain.TabIndex = 1;
            // 
            // dgvRoutines
            // 
            this.dgvRoutines.AutoGenerateColumns = false;
            this.dgvRoutines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvRoutines.DataSource = this.bsRoutines;
            this.dgvRoutines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoutines.Location = new System.Drawing.Point(0, 0);
            this.dgvRoutines.Name = "dgvRoutines";
            this.dgvRoutines.RowHeadersWidth = 30;
            this.dgvRoutines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoutines.Size = new System.Drawing.Size(475, 157);
            this.dgvRoutines.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Rutina";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Komentar";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // bsRoutines
            // 
            this.bsRoutines.DataMember = "Routines";
            this.bsRoutines.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvActions
            // 
            this.dgvActions.AllowUserToDeleteRows = false;
            this.dgvActions.AutoGenerateColumns = false;
            this.dgvActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn1,
            this.dgvcDelay,
            this.dgvcActEnabled});
            this.dgvActions.DataSource = this.bsActions;
            this.dgvActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActions.Location = new System.Drawing.Point(0, 0);
            this.dgvActions.Name = "dgvActions";
            this.dgvActions.RowHeadersWidth = 30;
            this.dgvActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActions.Size = new System.Drawing.Size(475, 314);
            this.dgvActions.TabIndex = 1;
            this.dgvActions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActions_CellDoubleClick);
            this.dgvActions.SelectionChanged += new System.EventHandler(this.DgvActions_SelectionChanged);
            // 
            // bsActions
            // 
            this.bsActions.DataMember = "Routines_Actions";
            this.bsActions.DataSource = this.bsRoutines;
            // 
            // tim
            // 
            this.tim.Interval = 1000;
            this.tim.Tick += new System.EventHandler(this.Tim_Tick);
            // 
            // timAdjustPositions
            // 
            this.timAdjustPositions.Interval = 1000;
            this.timAdjustPositions.Tick += new System.EventHandler(this.TimAdjustPositions_Tick);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.typeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Tekst",
            "Klik",
            "DvoKlik"});
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Sadržaj";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.FillWeight = 200F;
            this.commentDataGridViewTextBoxColumn1.HeaderText = "Komentar";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            // 
            // dgvcDelay
            // 
            this.dgvcDelay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcDelay.DataPropertyName = "Delay";
            this.dgvcDelay.HeaderText = "Delay";
            this.dgvcDelay.Name = "dgvcDelay";
            this.dgvcDelay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcDelay.Width = 51;
            // 
            // dgvcActEnabled
            // 
            this.dgvcActEnabled.DataPropertyName = "Enabled";
            this.dgvcActEnabled.HeaderText = "Enabled";
            this.dgvcActEnabled.Name = "dgvcActEnabled";
            this.dgvcActEnabled.Width = 27;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 475);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Form Fill";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.gbAdjPositions.ResumeLayout(false);
            this.gbAdjPositions.PerformLayout();
            this.gbPustanje.ResumeLayout(false);
            this.gbPustanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoutines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.CheckBox chkPrikaziKursor;
        private System.Windows.Forms.GroupBox gbPustanje;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Button btnSnimanjeStartStop;
        private System.Windows.Forms.Button btnPustanjeStartStop;
        private System.Windows.Forms.Button btnPomeriStavkuNagore;
        private System.Windows.Forms.Button btnPomeriStavkuNadole;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.DataGridView dgvRoutines;
        private System.Windows.Forms.DataGridView dgvActions;
        private System.Windows.Forms.BindingSource bsRoutines;
        private Ds ds;
        private System.Windows.Forms.BindingSource bsActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer tim;
        private System.Windows.Forms.TextBox txtDataFolder;
        private System.Windows.Forms.Timer timAdjustPositions;
        private System.Windows.Forms.GroupBox gbAdjPositions;
        private System.Windows.Forms.TextBox txtAdjPosDY;
        private System.Windows.Forms.TextBox txtAdjPosDX;
        private System.Windows.Forms.Button btnAdjPosOK;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDelay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcActEnabled;
    }
}

