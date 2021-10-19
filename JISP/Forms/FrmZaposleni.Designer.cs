
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.dgv = new JISP.Controls.UcDGV();
            this.bsZap = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.jMBGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIdZap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnSaveData);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(146, 448);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(12, 39);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(128, 31);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.Text = "Sacuvaj podatke";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIdZap,
            this.dgvcIme,
            this.dgvcPrezime,
            this.jMBGDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsZap;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(146, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 30;
            this.dgv.Size = new System.Drawing.Size(749, 448);
            this.dgv.TabIndex = 1;
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
            // jMBGDataGridViewTextBoxColumn
            // 
            this.jMBGDataGridViewTextBoxColumn.DataPropertyName = "JMBG";
            this.jMBGDataGridViewTextBoxColumn.HeaderText = "JMBG";
            this.jMBGDataGridViewTextBoxColumn.Name = "jMBGDataGridViewTextBoxColumn";
            this.jMBGDataGridViewTextBoxColumn.Width = 120;
            // 
            // dgvcPrezime
            // 
            this.dgvcPrezime.DataPropertyName = "Prezime";
            this.dgvcPrezime.HeaderText = "Prezime";
            this.dgvcPrezime.Name = "dgvcPrezime";
            this.dgvcPrezime.Width = 200;
            // 
            // dgvcIme
            // 
            this.dgvcIme.DataPropertyName = "Ime";
            this.dgvcIme.HeaderText = "Ime";
            this.dgvcIme.Name = "dgvcIme";
            this.dgvcIme.Width = 150;
            // 
            // dgvcIdZap
            // 
            this.dgvcIdZap.DataPropertyName = "IdZaposlenog";
            this.dgvcIdZap.HeaderText = "IdZaposlenog";
            this.dgvcIdZap.Name = "dgvcIdZap";
            this.dgvcIdZap.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private Controls.UcDGV dgv;
        private System.Windows.Forms.BindingSource bsZap;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIdZap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn jMBGDataGridViewTextBoxColumn;
        private Data.Ds ds;
    }
}