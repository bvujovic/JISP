
namespace JISP.Forms
{
    partial class FrmZaposleni
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.chkLoadWoMsgs = new System.Windows.Forms.CheckBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.bsZap = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.dgv = new JISP.Controls.UcDGV();
            this.dgvcIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcJMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGodine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDanaDoRodj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsZap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblRowCount);
            this.pnlLeft.Controls.Add(this.txtFilter);
            this.pnlLeft.Controls.Add(this.chkLoadWoMsgs);
            this.pnlLeft.Controls.Add(this.btnLoadData);
            this.pnlLeft.Controls.Add(this.btnSaveData);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(146, 448);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(13, 9);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(59, 18);
            this.lblRowCount.TabIndex = 6;
            this.lblRowCount.Text = "Redova";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(128, 24);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // chkLoadWoMsgs
            // 
            this.chkLoadWoMsgs.AutoSize = true;
            this.chkLoadWoMsgs.Location = new System.Drawing.Point(16, 262);
            this.chkLoadWoMsgs.Name = "chkLoadWoMsgs";
            this.chkLoadWoMsgs.Size = new System.Drawing.Size(101, 22);
            this.chkLoadWoMsgs.TabIndex = 4;
            this.chkLoadWoMsgs.Text = "bez poruka";
            this.chkLoadWoMsgs.UseVisualStyleBackColor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 202);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(128, 59);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Učitaj podatke";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(12, 113);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(128, 59);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.Text = "Sačuvaj podatke";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // bsZap
            // 
            this.bsZap.DataMember = "Zaposleni";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIme,
            this.dgvcPrezime,
            this.dgvcJMBG,
            this.dgvcGodine,
            this.dgvcDanaDoRodj});
            this.dgv.DataSource = this.bsZap;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(146, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 30;
            this.dgv.Size = new System.Drawing.Size(749, 448);
            this.dgv.TabIndex = 1;
            // 
            // dgvcIme
            // 
            this.dgvcIme.DataPropertyName = "Ime";
            this.dgvcIme.HeaderText = "Ime";
            this.dgvcIme.MinimumWidth = 6;
            this.dgvcIme.Name = "dgvcIme";
            this.dgvcIme.Width = 115;
            // 
            // dgvcPrezime
            // 
            this.dgvcPrezime.DataPropertyName = "Prezime";
            this.dgvcPrezime.HeaderText = "Prezime";
            this.dgvcPrezime.MinimumWidth = 6;
            this.dgvcPrezime.Name = "dgvcPrezime";
            this.dgvcPrezime.Width = 150;
            // 
            // dgvcJMBG
            // 
            this.dgvcJMBG.DataPropertyName = "JMBG";
            this.dgvcJMBG.HeaderText = "JMBG";
            this.dgvcJMBG.MinimumWidth = 6;
            this.dgvcJMBG.Name = "dgvcJMBG";
            this.dgvcJMBG.Width = 125;
            // 
            // dgvcGodine
            // 
            this.dgvcGodine.DataPropertyName = "Godine";
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvcGodine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcGodine.HeaderText = "Godine";
            this.dgvcGodine.Name = "dgvcGodine";
            this.dgvcGodine.ReadOnly = true;
            // 
            // dgvcDanaDoRodj
            // 
            this.dgvcDanaDoRodj.DataPropertyName = "DanaDoRodj";
            this.dgvcDanaDoRodj.HeaderText = "Do Rođ.";
            this.dgvcDanaDoRodj.Name = "dgvcDanaDoRodj";
            this.dgvcDanaDoRodj.ReadOnly = true;
            // 
            // FrmZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 448);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZaposleni";
            this.Text = "Zaposleni";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsZap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private Controls.UcDGV dgv;
        private System.Windows.Forms.BindingSource bsZap;
        private System.Windows.Forms.Button btnSaveData;
        private Data.Ds ds;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.CheckBox chkLoadWoMsgs;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcJMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGodine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDanaDoRodj;
    }
}