namespace JISP.Forms
{
    partial class FrmRazrediOdeljenja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstSkGod = new System.Windows.Forms.ListBox();
            this.ds = new JISP.Data.Ds();
            this.bsRazredi = new System.Windows.Forms.BindingSource(this.components);
            this.lblRazrediRowCount = new System.Windows.Forms.Label();
            this.lblOdeljenjaRowCount = new System.Windows.Forms.Label();
            this.bsOdeljenja = new System.Windows.Forms.BindingSource(this.components);
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvRazredi = new JISP.Controls.UcDGV();
            this.skolskaGodinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivRazredaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOdeljenja = new JISP.Controls.UcDGV();
            this.nazivOdeljenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staresinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOdeljenjaSmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOdeljenjaBrUcenika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOdeljenjaBrUcenikaIOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOdeljenjaBrOcenjenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOdeljenjaBrKrajObrazovanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.btnSmerovi = new JISP.Controls.UcButton();
            this.ucExitAppButton1 = new JISP.Controls.UcExitAppButton();
            this.btnPovezi = new JISP.Controls.UcButton();
            this.btnGetRazredi = new JISP.Controls.UcButton();
            this.btnGetOdeljenja = new JISP.Controls.UcButton();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRazredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOdeljenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeljenja)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSkGod
            // 
            this.lstSkGod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSkGod.FormattingEnabled = true;
            this.lstSkGod.ItemHeight = 18;
            this.lstSkGod.Location = new System.Drawing.Point(963, 3);
            this.lstSkGod.Name = "lstSkGod";
            this.lstSkGod.Size = new System.Drawing.Size(109, 184);
            this.lstSkGod.TabIndex = 1;
            this.lstSkGod.SelectedIndexChanged += new System.EventHandler(this.LstSkGod_SelectedIndexChanged);
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsRazredi
            // 
            this.bsRazredi.DataMember = "Razredi";
            this.bsRazredi.DataSource = this.ds;
            this.bsRazredi.Sort = "SkolskaGodina DESC, SortBroj";
            // 
            // lblRazrediRowCount
            // 
            this.lblRazrediRowCount.AutoSize = true;
            this.lblRazrediRowCount.Location = new System.Drawing.Point(6, 190);
            this.lblRazrediRowCount.Name = "lblRazrediRowCount";
            this.lblRazrediRowCount.Size = new System.Drawing.Size(12, 18);
            this.lblRazrediRowCount.TabIndex = 8;
            this.lblRazrediRowCount.Text = "/";
            // 
            // lblOdeljenjaRowCount
            // 
            this.lblOdeljenjaRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOdeljenjaRowCount.AutoSize = true;
            this.lblOdeljenjaRowCount.Location = new System.Drawing.Point(6, 243);
            this.lblOdeljenjaRowCount.Name = "lblOdeljenjaRowCount";
            this.lblOdeljenjaRowCount.Size = new System.Drawing.Size(12, 18);
            this.lblOdeljenjaRowCount.TabIndex = 8;
            this.lblOdeljenjaRowCount.Text = "/";
            // 
            // bsOdeljenja
            // 
            this.bsOdeljenja.DataMember = "Odeljenja";
            this.bsOdeljenja.DataSource = this.ds;
            this.bsOdeljenja.Sort = "SortBroj, NazivOdeljenja";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(150, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lstSkGod);
            this.scMain.Panel1.Controls.Add(this.dgvRazredi);
            this.scMain.Panel1.Controls.Add(this.lblRazrediRowCount);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvOdeljenja);
            this.scMain.Panel2.Controls.Add(this.lblOdeljenjaRowCount);
            this.scMain.Size = new System.Drawing.Size(1075, 482);
            this.scMain.SplitterDistance = 213;
            this.scMain.TabIndex = 11;
            // 
            // dgvRazredi
            // 
            this.dgvRazredi.AllowUserToAddRows = false;
            this.dgvRazredi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRazredi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRazredi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRazredi.AutoGenerateColumns = false;
            this.dgvRazredi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRazredi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRazredi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skolskaGodinaDataGridViewTextBoxColumn,
            this.nazivRazredaDataGridViewTextBoxColumn});
            this.dgvRazredi.ColumnsForCopyOnClick = null;
            this.dgvRazredi.CopyOnCellClick = false;
            this.dgvRazredi.CtrlDisplayPositionRowCount = this.lblRazrediRowCount;
            this.dgvRazredi.DataSource = this.bsRazredi;
            this.dgvRazredi.Location = new System.Drawing.Point(6, 3);
            this.dgvRazredi.Name = "dgvRazredi";
            this.dgvRazredi.ReadOnly = true;
            this.dgvRazredi.RowHeadersWidth = 30;
            this.dgvRazredi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRazredi.Size = new System.Drawing.Size(951, 184);
            this.dgvRazredi.StandardSort = null;
            this.dgvRazredi.TabIndex = 4;
            this.dgvRazredi.SelectionChanged += new System.EventHandler(this.DgvRazredi_SelectionChanged);
            // 
            // skolskaGodinaDataGridViewTextBoxColumn
            // 
            this.skolskaGodinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.skolskaGodinaDataGridViewTextBoxColumn.DataPropertyName = "SkolskaGodina";
            this.skolskaGodinaDataGridViewTextBoxColumn.HeaderText = "Šk. God";
            this.skolskaGodinaDataGridViewTextBoxColumn.Name = "skolskaGodinaDataGridViewTextBoxColumn";
            this.skolskaGodinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.skolskaGodinaDataGridViewTextBoxColumn.Width = 88;
            // 
            // nazivRazredaDataGridViewTextBoxColumn
            // 
            this.nazivRazredaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivRazredaDataGridViewTextBoxColumn.DataPropertyName = "NazivRazreda";
            this.nazivRazredaDataGridViewTextBoxColumn.HeaderText = "Razred";
            this.nazivRazredaDataGridViewTextBoxColumn.Name = "nazivRazredaDataGridViewTextBoxColumn";
            this.nazivRazredaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvOdeljenja
            // 
            this.dgvOdeljenja.AllowUserToAddRows = false;
            this.dgvOdeljenja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOdeljenja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOdeljenja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOdeljenja.AutoGenerateColumns = false;
            this.dgvOdeljenja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOdeljenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOdeljenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdeljenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivOdeljenjaDataGridViewTextBoxColumn,
            this.staresinaDataGridViewTextBoxColumn,
            this.dgvcOdeljenjaSmer,
            this.dgvcOdeljenjaBrUcenika,
            this.dgvcOdeljenjaBrUcenikaIOP,
            this.dgvcOdeljenjaBrOcenjenih,
            this.dgvcOdeljenjaBrKrajObrazovanja,
            this.Razred,
            this.SortBroj});
            this.dgvOdeljenja.ColumnsForCopyOnClick = null;
            this.dgvOdeljenja.CopyOnCellClick = false;
            this.dgvOdeljenja.CtrlDisplayPositionRowCount = this.lblOdeljenjaRowCount;
            this.dgvOdeljenja.DataSource = this.bsOdeljenja;
            this.dgvOdeljenja.Location = new System.Drawing.Point(9, 3);
            this.dgvOdeljenja.Name = "dgvOdeljenja";
            this.dgvOdeljenja.ReadOnly = true;
            this.dgvOdeljenja.RowHeadersWidth = 30;
            this.dgvOdeljenja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdeljenja.Size = new System.Drawing.Size(1063, 237);
            this.dgvOdeljenja.StandardSort = null;
            this.dgvOdeljenja.TabIndex = 6;
            // 
            // nazivOdeljenjaDataGridViewTextBoxColumn
            // 
            this.nazivOdeljenjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nazivOdeljenjaDataGridViewTextBoxColumn.DataPropertyName = "NazivOdeljenja";
            this.nazivOdeljenjaDataGridViewTextBoxColumn.HeaderText = "Odeljenje";
            this.nazivOdeljenjaDataGridViewTextBoxColumn.Name = "nazivOdeljenjaDataGridViewTextBoxColumn";
            this.nazivOdeljenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivOdeljenjaDataGridViewTextBoxColumn.Width = 94;
            // 
            // staresinaDataGridViewTextBoxColumn
            // 
            this.staresinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staresinaDataGridViewTextBoxColumn.DataPropertyName = "Staresina";
            this.staresinaDataGridViewTextBoxColumn.HeaderText = "Odelj. starešina";
            this.staresinaDataGridViewTextBoxColumn.Name = "staresinaDataGridViewTextBoxColumn";
            this.staresinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvcOdeljenjaSmer
            // 
            this.dgvcOdeljenjaSmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcOdeljenjaSmer.DataPropertyName = "Smer";
            this.dgvcOdeljenjaSmer.HeaderText = "Smer";
            this.dgvcOdeljenjaSmer.Name = "dgvcOdeljenjaSmer";
            this.dgvcOdeljenjaSmer.ReadOnly = true;
            this.dgvcOdeljenjaSmer.Width = 69;
            // 
            // dgvcOdeljenjaBrUcenika
            // 
            this.dgvcOdeljenjaBrUcenika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcOdeljenjaBrUcenika.DataPropertyName = "BrUcenika";
            this.dgvcOdeljenjaBrUcenika.HeaderText = "Učenika";
            this.dgvcOdeljenjaBrUcenika.Name = "dgvcOdeljenjaBrUcenika";
            this.dgvcOdeljenjaBrUcenika.ReadOnly = true;
            this.dgvcOdeljenjaBrUcenika.Width = 87;
            // 
            // dgvcOdeljenjaBrUcenikaIOP
            // 
            this.dgvcOdeljenjaBrUcenikaIOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcOdeljenjaBrUcenikaIOP.DataPropertyName = "BrUcenikaIOP";
            this.dgvcOdeljenjaBrUcenikaIOP.HeaderText = "IOP2 Učenika";
            this.dgvcOdeljenjaBrUcenikaIOP.Name = "dgvcOdeljenjaBrUcenikaIOP";
            this.dgvcOdeljenjaBrUcenikaIOP.ReadOnly = true;
            this.dgvcOdeljenjaBrUcenikaIOP.Width = 124;
            // 
            // dgvcOdeljenjaBrOcenjenih
            // 
            this.dgvcOdeljenjaBrOcenjenih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcOdeljenjaBrOcenjenih.DataPropertyName = "BrOcenjenih";
            this.dgvcOdeljenjaBrOcenjenih.HeaderText = "Ocenjenih";
            this.dgvcOdeljenjaBrOcenjenih.Name = "dgvcOdeljenjaBrOcenjenih";
            this.dgvcOdeljenjaBrOcenjenih.ReadOnly = true;
            this.dgvcOdeljenjaBrOcenjenih.Width = 99;
            // 
            // dgvcOdeljenjaBrKrajObrazovanja
            // 
            this.dgvcOdeljenjaBrKrajObrazovanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcOdeljenjaBrKrajObrazovanja.DataPropertyName = "BrKrajObrazovanja";
            this.dgvcOdeljenjaBrKrajObrazovanja.HeaderText = "Kraj Obraz.";
            this.dgvcOdeljenjaBrKrajObrazovanja.Name = "dgvcOdeljenjaBrKrajObrazovanja";
            this.dgvcOdeljenjaBrKrajObrazovanja.ReadOnly = true;
            this.dgvcOdeljenjaBrKrajObrazovanja.Width = 108;
            // 
            // Razred
            // 
            this.Razred.DataPropertyName = "Razred";
            this.Razred.HeaderText = "Razred";
            this.Razred.Name = "Razred";
            this.Razred.ReadOnly = true;
            // 
            // SortBroj
            // 
            this.SortBroj.DataPropertyName = "SortBroj";
            this.SortBroj.HeaderText = "SortBroj";
            this.SortBroj.Name = "SortBroj";
            this.SortBroj.ReadOnly = true;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnSmerovi);
            this.pnlLeft.Controls.Add(this.ucExitAppButton1);
            this.pnlLeft.Controls.Add(this.btnPovezi);
            this.pnlLeft.Controls.Add(this.btnGetRazredi);
            this.pnlLeft.Controls.Add(this.btnGetOdeljenja);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(150, 482);
            this.pnlLeft.TabIndex = 10;
            // 
            // btnSmerovi
            // 
            this.btnSmerovi.Location = new System.Drawing.Point(7, 239);
            this.btnSmerovi.Name = "btnSmerovi";
            this.btnSmerovi.Size = new System.Drawing.Size(127, 34);
            this.btnSmerovi.TabIndex = 10;
            this.btnSmerovi.Text = "Smerovi";
            this.btnSmerovi.ToolTipText = "Preuzmi podatke o odeljenjima za selektovane razrede";
            this.btnSmerovi.UseVisualStyleBackColor = true;
            this.btnSmerovi.Click += new System.EventHandler(this.BtnSmerovi_Click);
            // 
            // ucExitAppButton1
            // 
            this.ucExitAppButton1.BackColor = System.Drawing.Color.Red;
            this.ucExitAppButton1.ForeColor = System.Drawing.Color.White;
            this.ucExitAppButton1.Location = new System.Drawing.Point(7, 15);
            this.ucExitAppButton1.Name = "ucExitAppButton1";
            this.ucExitAppButton1.Size = new System.Drawing.Size(127, 34);
            this.ucExitAppButton1.TabIndex = 1;
            this.ucExitAppButton1.Text = "Izlaz";
            this.ucExitAppButton1.ToolTipText = "Izlaz iz aplikacije";
            this.ucExitAppButton1.UseVisualStyleBackColor = false;
            // 
            // btnPovezi
            // 
            this.btnPovezi.Location = new System.Drawing.Point(7, 177);
            this.btnPovezi.Name = "btnPovezi";
            this.btnPovezi.Size = new System.Drawing.Size(127, 56);
            this.btnPovezi.TabIndex = 9;
            this.btnPovezi.Text = "Poveži odeljenja i učenike";
            this.btnPovezi.ToolTipText = "Poveži odeljenja i učenike";
            this.btnPovezi.UseVisualStyleBackColor = true;
            this.btnPovezi.Click += new System.EventHandler(this.BtnPovezi_Click);
            // 
            // btnGetRazredi
            // 
            this.btnGetRazredi.Location = new System.Drawing.Point(7, 93);
            this.btnGetRazredi.Name = "btnGetRazredi";
            this.btnGetRazredi.Size = new System.Drawing.Size(127, 34);
            this.btnGetRazredi.TabIndex = 3;
            this.btnGetRazredi.Text = "Razredi";
            this.btnGetRazredi.ToolTipText = "Preuzmi podatke o svim razredima za sve školske godine";
            this.btnGetRazredi.UseVisualStyleBackColor = true;
            this.btnGetRazredi.Click += new System.EventHandler(this.BtnGetRazredi_Click);
            // 
            // btnGetOdeljenja
            // 
            this.btnGetOdeljenja.Location = new System.Drawing.Point(7, 135);
            this.btnGetOdeljenja.Name = "btnGetOdeljenja";
            this.btnGetOdeljenja.Size = new System.Drawing.Size(127, 34);
            this.btnGetOdeljenja.TabIndex = 5;
            this.btnGetOdeljenja.Text = "Odeljenja";
            this.btnGetOdeljenja.ToolTipText = "Preuzmi podatke o odeljenjima za selektovane razrede";
            this.btnGetOdeljenja.UseVisualStyleBackColor = true;
            this.btnGetOdeljenja.Click += new System.EventHandler(this.BtnGetOdeljenja_Click);
            // 
            // FrmRazrediOdeljenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 482);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRazrediOdeljenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Razredi, Odeljenja";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRazredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOdeljenja)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeljenja)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstSkGod;
        private Controls.UcButton btnGetRazredi;
        private Controls.UcDGV dgvRazredi;
        private System.Windows.Forms.BindingSource bsRazredi;
        private Data.Ds ds;
        private Controls.UcButton btnGetOdeljenja;
        private Controls.UcDGV dgvOdeljenja;
        private System.Windows.Forms.BindingSource bsOdeljenja;
        private System.Windows.Forms.Label lblRazrediRowCount;
        private System.Windows.Forms.Label lblOdeljenjaRowCount;
        private Controls.UcButton btnPovezi;
        private Controls.UcLeftPanel pnlLeft;
        private Controls.UcExitAppButton ucExitAppButton1;
        private Controls.UcButton btnSmerovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolskaGodinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivRazredaDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivOdeljenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staresinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOdeljenjaSmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOdeljenjaBrUcenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOdeljenjaBrUcenikaIOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOdeljenjaBrOcenjenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOdeljenjaBrKrajObrazovanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razred;
        private System.Windows.Forms.DataGridViewTextBoxColumn SortBroj;
    }
}