namespace JISP.Forms
{
    partial class FrmUcenici
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
            this.btnTextImport = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.bsUcenici = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.dgv = new JISP.Controls.UcDGV();
            this.dgvcIdUcenika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcJOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnTextImport);
            this.pnlLeft.Controls.Add(this.btnSaveData);
            this.pnlLeft.Controls.Add(this.txtFilter);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(150, 450);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Click += new System.EventHandler(this.PnlLeft_Click);
            // 
            // btnTextImport
            // 
            this.btnTextImport.Location = new System.Drawing.Point(12, 77);
            this.btnTextImport.Name = "btnTextImport";
            this.btnTextImport.Size = new System.Drawing.Size(132, 31);
            this.btnTextImport.TabIndex = 2;
            this.btnTextImport.Text = "Uvoz txt podataka";
            this.btnTextImport.UseVisualStyleBackColor = true;
            this.btnTextImport.Click += new System.EventHandler(this.BtnTextImport_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(12, 40);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(132, 31);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Sacuvaj podatke";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(132, 22);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // bsUcenici
            // 
            this.bsUcenici.DataMember = "Ucenici";
            this.bsUcenici.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIdUcenika,
            this.dgvcIme,
            this.dgvcPrezime,
            this.dgvcJOB});
            this.dgv.DataSource = this.bsUcenici;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(150, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 30;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(650, 450);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // dgvcIdUcenika
            // 
            this.dgvcIdUcenika.DataPropertyName = "IdUcenika";
            this.dgvcIdUcenika.HeaderText = "IdUcenika";
            this.dgvcIdUcenika.MinimumWidth = 6;
            this.dgvcIdUcenika.Name = "dgvcIdUcenika";
            this.dgvcIdUcenika.Visible = false;
            this.dgvcIdUcenika.Width = 125;
            // 
            // dgvcIme
            // 
            this.dgvcIme.DataPropertyName = "Ime";
            this.dgvcIme.HeaderText = "Ime";
            this.dgvcIme.MinimumWidth = 6;
            this.dgvcIme.Name = "dgvcIme";
            this.dgvcIme.Width = 125;
            // 
            // dgvcPrezime
            // 
            this.dgvcPrezime.DataPropertyName = "Prezime";
            this.dgvcPrezime.HeaderText = "Prezime";
            this.dgvcPrezime.MinimumWidth = 6;
            this.dgvcPrezime.Name = "dgvcPrezime";
            this.dgvcPrezime.Width = 125;
            // 
            // dgvcJOB
            // 
            this.dgvcJOB.DataPropertyName = "JOB";
            this.dgvcJOB.HeaderText = "JOB";
            this.dgvcJOB.MinimumWidth = 6;
            this.dgvcJOB.Name = "dgvcJOB";
            this.dgvcJOB.Width = 150;
            // 
            // FrmUcenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUcenici";
            this.Text = "Ucenici";
            this.Load += new System.EventHandler(this.FrmUcenici_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private Controls.UcDGV dgv;
        private System.Windows.Forms.BindingSource bsUcenici;
        private Data.Ds ds;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnTextImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIdUcenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcJOB;
    }
}