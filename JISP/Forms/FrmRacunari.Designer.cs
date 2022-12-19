namespace JISP.Forms
{
    partial class FrmRacunari
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
            this.bsRacunari = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.dgvRacunari = new JISP.Controls.UcDGV();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.plnLeft = new JISP.Controls.UcLeftPanel();
            this.txtFilter = new JISP.Controls.UcFilterTextBox();
            this.btnDohvatiPodatke = new JISP.Controls.UcButton();
            this.rbPrikazSvi = new System.Windows.Forms.RadioButton();
            this.rbPrikazIzProstorije = new System.Windows.Forms.RadioButton();
            this.dgvcProstorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivRacunaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcProcesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGodinaProizvodnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNapomene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsRacunari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacunari)).BeginInit();
            this.plnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsRacunari
            // 
            this.bsRacunari.DataMember = "Racunari";
            this.bsRacunari.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvRacunari
            // 
            this.dgvRacunari.AllowUserToAddRows = false;
            this.dgvRacunari.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRacunari.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRacunari.AutoGenerateColumns = false;
            this.dgvRacunari.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRacunari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacunari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcProstorija,
            this.statusDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.nazivRacunaraDataGridViewTextBoxColumn,
            this.dgvcProcesor,
            this.dgvcGodinaProizvodnje,
            this.dgvcNapomene});
            this.dgvRacunari.ColumnsForCopyOnClick = null;
            this.dgvRacunari.CopyOnCellClick = false;
            this.dgvRacunari.CtrlDisplayPositionRowCount = this.lblRowCount;
            this.dgvRacunari.DataSource = this.bsRacunari;
            this.dgvRacunari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacunari.Location = new System.Drawing.Point(150, 0);
            this.dgvRacunari.Name = "dgvRacunari";
            this.dgvRacunari.RowHeadersWidth = 30;
            this.dgvRacunari.Size = new System.Drawing.Size(1044, 251);
            this.dgvRacunari.StandardSort = null;
            this.dgvRacunari.TabIndex = 1;
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(13, 224);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(59, 18);
            this.lblRowCount.TabIndex = 2;
            this.lblRowCount.Text = "Redova";
            // 
            // plnLeft
            // 
            this.plnLeft.Controls.Add(this.txtFilter);
            this.plnLeft.Controls.Add(this.lblRowCount);
            this.plnLeft.Controls.Add(this.btnDohvatiPodatke);
            this.plnLeft.Controls.Add(this.rbPrikazSvi);
            this.plnLeft.Controls.Add(this.rbPrikazIzProstorije);
            this.plnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnLeft.Location = new System.Drawing.Point(0, 0);
            this.plnLeft.Name = "plnLeft";
            this.plnLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.plnLeft.RightWingWidth = 6;
            this.plnLeft.Size = new System.Drawing.Size(150, 251);
            this.plnLeft.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.BindingSource = this.bsRacunari;
            this.txtFilter.Location = new System.Drawing.Point(12, 153);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.ShouldBeCyrillic = false;
            this.txtFilter.Size = new System.Drawing.Size(127, 24);
            this.txtFilter.TabIndex = 18;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // btnDohvatiPodatke
            // 
            this.btnDohvatiPodatke.Location = new System.Drawing.Point(12, 94);
            this.btnDohvatiPodatke.Name = "btnDohvatiPodatke";
            this.btnDohvatiPodatke.Size = new System.Drawing.Size(127, 30);
            this.btnDohvatiPodatke.TabIndex = 17;
            this.btnDohvatiPodatke.Text = "Dohvati podatke";
            this.btnDohvatiPodatke.ToolTipText = "Dohvati podatke o računarima za selektovane prostorije";
            this.btnDohvatiPodatke.UseVisualStyleBackColor = true;
            this.btnDohvatiPodatke.Click += new System.EventHandler(this.BtnDohvatiPodatke_Click);
            // 
            // rbPrikazSvi
            // 
            this.rbPrikazSvi.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPrikazSvi.Location = new System.Drawing.Point(12, 39);
            this.rbPrikazSvi.Name = "rbPrikazSvi";
            this.rbPrikazSvi.Size = new System.Drawing.Size(127, 28);
            this.rbPrikazSvi.TabIndex = 2;
            this.rbPrikazSvi.TabStop = true;
            this.rbPrikazSvi.Text = "Svi u školi";
            this.rbPrikazSvi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPrikazSvi.UseVisualStyleBackColor = true;
            this.rbPrikazSvi.CheckedChanged += new System.EventHandler(this.RbPrikaz_CheckedChanged);
            // 
            // rbPrikazIzProstorije
            // 
            this.rbPrikazIzProstorije.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPrikazIzProstorije.Checked = true;
            this.rbPrikazIzProstorije.Location = new System.Drawing.Point(12, 12);
            this.rbPrikazIzProstorije.Name = "rbPrikazIzProstorije";
            this.rbPrikazIzProstorije.Size = new System.Drawing.Size(127, 28);
            this.rbPrikazIzProstorije.TabIndex = 1;
            this.rbPrikazIzProstorije.TabStop = true;
            this.rbPrikazIzProstorije.Text = "Iz prostorije";
            this.rbPrikazIzProstorije.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPrikazIzProstorije.UseVisualStyleBackColor = true;
            this.rbPrikazIzProstorije.CheckedChanged += new System.EventHandler(this.RbPrikaz_CheckedChanged);
            // 
            // dgvcProstorija
            // 
            this.dgvcProstorija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcProstorija.DataPropertyName = "_Prostorija";
            this.dgvcProstorija.HeaderText = "Prostorija";
            this.dgvcProstorija.Name = "dgvcProstorija";
            this.dgvcProstorija.ReadOnly = true;
            this.dgvcProstorija.Visible = false;
            this.dgvcProstorija.Width = 97;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivRacunaraDataGridViewTextBoxColumn
            // 
            this.nazivRacunaraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivRacunaraDataGridViewTextBoxColumn.DataPropertyName = "NazivRacunara";
            this.nazivRacunaraDataGridViewTextBoxColumn.HeaderText = "Računar";
            this.nazivRacunaraDataGridViewTextBoxColumn.Name = "nazivRacunaraDataGridViewTextBoxColumn";
            this.nazivRacunaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvcProcesor
            // 
            this.dgvcProcesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcProcesor.DataPropertyName = "Procesor";
            this.dgvcProcesor.HeaderText = "Procesor";
            this.dgvcProcesor.Name = "dgvcProcesor";
            this.dgvcProcesor.ReadOnly = true;
            // 
            // dgvcGodinaProizvodnje
            // 
            this.dgvcGodinaProizvodnje.DataPropertyName = "GodinaProizvodnje";
            this.dgvcGodinaProizvodnje.HeaderText = "Godina";
            this.dgvcGodinaProizvodnje.Name = "dgvcGodinaProizvodnje";
            this.dgvcGodinaProizvodnje.ReadOnly = true;
            this.dgvcGodinaProizvodnje.ToolTipText = "Godina proizvodnje";
            // 
            // dgvcNapomene
            // 
            this.dgvcNapomene.DataPropertyName = "Napomene";
            this.dgvcNapomene.HeaderText = "Napomene";
            this.dgvcNapomene.Name = "dgvcNapomene";
            this.dgvcNapomene.Width = 200;
            // 
            // FrmRacunari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 251);
            this.Controls.Add(this.dgvRacunari);
            this.Controls.Add(this.plnLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::JISP.Properties.Resources.grb_srb;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRacunari";
            this.Text = "Računari";
            this.Load += new System.EventHandler(this.FrmRacunari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRacunari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacunari)).EndInit();
            this.plnLeft.ResumeLayout(false);
            this.plnLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcLeftPanel plnLeft;
        private Controls.UcDGV dgvRacunari;
        private System.Windows.Forms.BindingSource bsRacunari;
        private Data.Ds ds;
        private System.Windows.Forms.RadioButton rbPrikazSvi;
        private System.Windows.Forms.RadioButton rbPrikazIzProstorije;
        private Controls.UcButton btnDohvatiPodatke;
        private System.Windows.Forms.Label lblRowCount;
        private Controls.UcFilterTextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcProstorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivRacunaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcProcesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGodinaProizvodnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNapomene;
    }
}