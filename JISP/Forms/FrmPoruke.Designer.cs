namespace JISP.Forms
{
    partial class FrmPoruke
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
            this.dgvPoruke = new JISP.Controls.UcDGV();
            this.datumVremeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tekstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPoruke = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPoruke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPoruke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPoruke.AutoGenerateColumns = false;
            this.dgvPoruke.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumVremeDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.tekstDataGridViewTextBoxColumn});
            this.dgvPoruke.ColumnsForCopyOnClick = null;
            this.dgvPoruke.CopyOnCellClick = true;
            this.dgvPoruke.CtrlDisplayPositionRowCount = null;
            this.dgvPoruke.DataSource = this.bsPoruke;
            this.dgvPoruke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPoruke.Location = new System.Drawing.Point(0, 0);
            this.dgvPoruke.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            this.dgvPoruke.RowHeadersWidth = 30;
            this.dgvPoruke.Size = new System.Drawing.Size(909, 235);
            this.dgvPoruke.StandardSort = null;
            this.dgvPoruke.TabIndex = 0;
            // 
            // datumVremeDataGridViewTextBoxColumn
            // 
            this.datumVremeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datumVremeDataGridViewTextBoxColumn.DataPropertyName = "DatumVreme";
            this.datumVremeDataGridViewTextBoxColumn.HeaderText = "Datum/vreme";
            this.datumVremeDataGridViewTextBoxColumn.Name = "datumVremeDataGridViewTextBoxColumn";
            this.datumVremeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumVremeDataGridViewTextBoxColumn.Width = 122;
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipDataGridViewTextBoxColumn.Width = 53;
            // 
            // tekstDataGridViewTextBoxColumn
            // 
            this.tekstDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tekstDataGridViewTextBoxColumn.DataPropertyName = "Tekst";
            this.tekstDataGridViewTextBoxColumn.HeaderText = "Tekst";
            this.tekstDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.tekstDataGridViewTextBoxColumn.Name = "tekstDataGridViewTextBoxColumn";
            this.tekstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPoruke
            // 
            this.bsPoruke.DataMember = "Poruke";
            this.bsPoruke.DataSource = this.ds;
            this.bsPoruke.Sort = "DatumVreme DESC";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmPoruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 235);
            this.Controls.Add(this.dgvPoruke);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPoruke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poruke";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPoruke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDGV dgvPoruke;
        private System.Windows.Forms.BindingSource bsPoruke;
        private Data.Ds ds;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVremeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekstDataGridViewTextBoxColumn;
    }
}