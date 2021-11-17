namespace JISP.Forms
{
    partial class Form1
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
            this.ucDGV1 = new JISP.Controls.UcDGV();
            this.idUcenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSkoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.skoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.uceniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ucDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDGV1
            // 
            this.ucDGV1.AutoGenerateColumns = false;
            this.ucDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucDGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUcenikaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.jOBDataGridViewTextBoxColumn,
            this.idSkoleDataGridViewTextBoxColumn});
            this.ucDGV1.DataSource = this.uceniciBindingSource;
            this.ucDGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDGV1.Location = new System.Drawing.Point(0, 0);
            this.ucDGV1.Name = "ucDGV1";
            this.ucDGV1.RowHeadersWidth = 30;
            this.ucDGV1.RowTemplate.Height = 24;
            this.ucDGV1.Size = new System.Drawing.Size(800, 450);
            this.ucDGV1.TabIndex = 0;
            // 
            // idUcenikaDataGridViewTextBoxColumn
            // 
            this.idUcenikaDataGridViewTextBoxColumn.DataPropertyName = "IdUcenika";
            this.idUcenikaDataGridViewTextBoxColumn.HeaderText = "IdUcenika";
            this.idUcenikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUcenikaDataGridViewTextBoxColumn.Name = "idUcenikaDataGridViewTextBoxColumn";
            this.idUcenikaDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // jOBDataGridViewTextBoxColumn
            // 
            this.jOBDataGridViewTextBoxColumn.DataPropertyName = "JOB";
            this.jOBDataGridViewTextBoxColumn.HeaderText = "JOB";
            this.jOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jOBDataGridViewTextBoxColumn.Name = "jOBDataGridViewTextBoxColumn";
            this.jOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSkoleDataGridViewTextBoxColumn
            // 
            this.idSkoleDataGridViewTextBoxColumn.DataPropertyName = "IdSkole";
            this.idSkoleDataGridViewTextBoxColumn.DataSource = this.skoleBindingSource;
            this.idSkoleDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.idSkoleDataGridViewTextBoxColumn.HeaderText = "IdSkole";
            this.idSkoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSkoleDataGridViewTextBoxColumn.Name = "idSkoleDataGridViewTextBoxColumn";
            this.idSkoleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSkoleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idSkoleDataGridViewTextBoxColumn.ValueMember = "IdSkole";
            this.idSkoleDataGridViewTextBoxColumn.Width = 125;
            // 
            // skoleBindingSource
            // 
            this.skoleBindingSource.DataMember = "Skole";
            this.skoleBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uceniciBindingSource
            // 
            this.uceniciBindingSource.DataMember = "Ucenici";
            this.uceniciBindingSource.DataSource = this.ds;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucDGV1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDGV ucDGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUcenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idSkoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource skoleBindingSource;
        private Data.Ds ds;
        private System.Windows.Forms.BindingSource uceniciBindingSource;
    }
}