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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstSkGod = new System.Windows.Forms.ListBox();
            this.ds = new JISP.Data.Ds();
            this.bsRazredi = new System.Windows.Forms.BindingSource(this.components);
            this.lblRazrediRowCount = new System.Windows.Forms.Label();
            this.lblOdeljenjaRowCount = new System.Windows.Forms.Label();
            this.bsOdeljenja = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOdeljenja = new JISP.Controls.UcDGV();
            this.btnGetOdeljenja = new JISP.Controls.UcButton();
            this.dgvRazredi = new JISP.Controls.UcDGV();
            this.nazivRazredaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skolskaGodinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetRazredi = new JISP.Controls.UcButton();
            this.btnPovezi = new JISP.Controls.UcButton();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.ucExitAppButton1 = new JISP.Controls.UcExitAppButton();
            this.nazivOdeljenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staresinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRazredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOdeljenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeljenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazredi)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(165, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 18);
            label1.TabIndex = 7;
            label1.Text = "Školske godine";
            // 
            // lstSkGod
            // 
            this.lstSkGod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstSkGod.FormattingEnabled = true;
            this.lstSkGod.ItemHeight = 18;
            this.lstSkGod.Location = new System.Drawing.Point(165, 31);
            this.lstSkGod.Name = "lstSkGod";
            this.lstSkGod.Size = new System.Drawing.Size(118, 202);
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
            this.bsRazredi.Sort = "SkolskaGodina DESC";
            // 
            // lblRazrediRowCount
            // 
            this.lblRazrediRowCount.AutoSize = true;
            this.lblRazrediRowCount.Location = new System.Drawing.Point(529, 236);
            this.lblRazrediRowCount.Name = "lblRazrediRowCount";
            this.lblRazrediRowCount.Size = new System.Drawing.Size(12, 18);
            this.lblRazrediRowCount.TabIndex = 8;
            this.lblRazrediRowCount.Text = "/";
            // 
            // lblOdeljenjaRowCount
            // 
            this.lblOdeljenjaRowCount.AutoSize = true;
            this.lblOdeljenjaRowCount.Location = new System.Drawing.Point(529, 460);
            this.lblOdeljenjaRowCount.Name = "lblOdeljenjaRowCount";
            this.lblOdeljenjaRowCount.Size = new System.Drawing.Size(12, 18);
            this.lblOdeljenjaRowCount.TabIndex = 8;
            this.lblOdeljenjaRowCount.Text = "/";
            // 
            // bsOdeljenja
            // 
            this.bsOdeljenja.DataMember = "Odeljenja";
            this.bsOdeljenja.DataSource = this.ds;
            // 
            // dgvOdeljenja
            // 
            this.dgvOdeljenja.AllowUserToAddRows = false;
            this.dgvOdeljenja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOdeljenja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOdeljenja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOdeljenja.AutoGenerateColumns = false;
            this.dgvOdeljenja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOdeljenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdeljenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivOdeljenjaDataGridViewTextBoxColumn,
            this.staresinaDataGridViewTextBoxColumn});
            this.dgvOdeljenja.ColumnsForCopyOnClick = null;
            this.dgvOdeljenja.CopyOnCellClick = false;
            this.dgvOdeljenja.CtrlDisplayPositionRowCount = this.lblOdeljenjaRowCount;
            this.dgvOdeljenja.DataSource = this.bsOdeljenja;
            this.dgvOdeljenja.Location = new System.Drawing.Point(532, 267);
            this.dgvOdeljenja.Name = "dgvOdeljenja";
            this.dgvOdeljenja.ReadOnly = true;
            this.dgvOdeljenja.RowHeadersWidth = 30;
            this.dgvOdeljenja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdeljenja.Size = new System.Drawing.Size(559, 190);
            this.dgvOdeljenja.StandardSort = null;
            this.dgvOdeljenja.TabIndex = 6;
            // 
            // btnGetOdeljenja
            // 
            this.btnGetOdeljenja.Location = new System.Drawing.Point(7, 135);
            this.btnGetOdeljenja.Name = "btnGetOdeljenja";
            this.btnGetOdeljenja.Size = new System.Drawing.Size(127, 34);
            this.btnGetOdeljenja.TabIndex = 5;
            this.btnGetOdeljenja.Text = "Odeljenja";
            this.btnGetOdeljenja.ToolTipText = null;
            this.btnGetOdeljenja.UseVisualStyleBackColor = true;
            this.btnGetOdeljenja.Click += new System.EventHandler(this.BtnGetOdeljenja_Click);
            // 
            // dgvRazredi
            // 
            this.dgvRazredi.AllowUserToAddRows = false;
            this.dgvRazredi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRazredi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRazredi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRazredi.AutoGenerateColumns = false;
            this.dgvRazredi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRazredi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRazredi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivRazredaDataGridViewTextBoxColumn,
            this.skolskaGodinaDataGridViewTextBoxColumn});
            this.dgvRazredi.ColumnsForCopyOnClick = null;
            this.dgvRazredi.CopyOnCellClick = false;
            this.dgvRazredi.CtrlDisplayPositionRowCount = this.lblRazrediRowCount;
            this.dgvRazredi.DataSource = this.bsRazredi;
            this.dgvRazredi.Location = new System.Drawing.Point(532, 12);
            this.dgvRazredi.Name = "dgvRazredi";
            this.dgvRazredi.ReadOnly = true;
            this.dgvRazredi.RowHeadersWidth = 30;
            this.dgvRazredi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRazredi.Size = new System.Drawing.Size(559, 221);
            this.dgvRazredi.StandardSort = null;
            this.dgvRazredi.TabIndex = 4;
            // 
            // nazivRazredaDataGridViewTextBoxColumn
            // 
            this.nazivRazredaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivRazredaDataGridViewTextBoxColumn.DataPropertyName = "NazivRazreda";
            this.nazivRazredaDataGridViewTextBoxColumn.HeaderText = "Razred";
            this.nazivRazredaDataGridViewTextBoxColumn.Name = "nazivRazredaDataGridViewTextBoxColumn";
            this.nazivRazredaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btnGetRazredi
            // 
            this.btnGetRazredi.Location = new System.Drawing.Point(7, 93);
            this.btnGetRazredi.Name = "btnGetRazredi";
            this.btnGetRazredi.Size = new System.Drawing.Size(127, 34);
            this.btnGetRazredi.TabIndex = 3;
            this.btnGetRazredi.Text = "Razredi";
            this.btnGetRazredi.ToolTipText = null;
            this.btnGetRazredi.UseVisualStyleBackColor = true;
            this.btnGetRazredi.Click += new System.EventHandler(this.BtnGetRazredi_Click);
            // 
            // btnPovezi
            // 
            this.btnPovezi.Location = new System.Drawing.Point(7, 177);
            this.btnPovezi.Name = "btnPovezi";
            this.btnPovezi.Size = new System.Drawing.Size(127, 34);
            this.btnPovezi.TabIndex = 9;
            this.btnPovezi.Text = "Poveži od i uč";
            this.btnPovezi.ToolTipText = null;
            this.btnPovezi.UseVisualStyleBackColor = true;
            this.btnPovezi.Click += new System.EventHandler(this.BtnPovezi_Click);
            // 
            // pnlLeft
            // 
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
            // nazivOdeljenjaDataGridViewTextBoxColumn
            // 
            this.nazivOdeljenjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivOdeljenjaDataGridViewTextBoxColumn.DataPropertyName = "NazivOdeljenja";
            this.nazivOdeljenjaDataGridViewTextBoxColumn.HeaderText = "Odeljenje";
            this.nazivOdeljenjaDataGridViewTextBoxColumn.Name = "nazivOdeljenjaDataGridViewTextBoxColumn";
            this.nazivOdeljenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staresinaDataGridViewTextBoxColumn
            // 
            this.staresinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staresinaDataGridViewTextBoxColumn.DataPropertyName = "Staresina";
            this.staresinaDataGridViewTextBoxColumn.HeaderText = "Odelj. starešina";
            this.staresinaDataGridViewTextBoxColumn.Name = "staresinaDataGridViewTextBoxColumn";
            this.staresinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmRazrediOdeljenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 482);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.lblOdeljenjaRowCount);
            this.Controls.Add(this.lblRazrediRowCount);
            this.Controls.Add(label1);
            this.Controls.Add(this.lstSkGod);
            this.Controls.Add(this.dgvOdeljenja);
            this.Controls.Add(this.dgvRazredi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRazrediOdeljenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Razredi, Odeljenja";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRazredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOdeljenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeljenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazredi)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstSkGod;
        private Controls.UcButton btnGetRazredi;
        private Controls.UcDGV dgvRazredi;
        private System.Windows.Forms.BindingSource bsRazredi;
        private Data.Ds ds;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivRazredaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolskaGodinaDataGridViewTextBoxColumn;
        private Controls.UcButton btnGetOdeljenja;
        private Controls.UcDGV dgvOdeljenja;
        private System.Windows.Forms.BindingSource bsOdeljenja;
        private System.Windows.Forms.Label lblRazrediRowCount;
        private System.Windows.Forms.Label lblOdeljenjaRowCount;
        private Controls.UcButton btnPovezi;
        private Controls.UcLeftPanel pnlLeft;
        private Controls.UcExitAppButton ucExitAppButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivOdeljenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staresinaDataGridViewTextBoxColumn;
    }
}