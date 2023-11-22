namespace JISP.Forms
{
    partial class FrmSistematizacija
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
            System.Windows.Forms.Label lblFilterCaption;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvSistematizacija = new JISP.Controls.UcDGV();
            this.lblRedovi = new System.Windows.Forms.Label();
            this.bsSistematizacija = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtFilter = new JISP.Controls.UcFilterTextBox();
            this.btnOsveziPodatke = new JISP.Controls.UcButton();
            this.dgvDetalji = new JISP.Controls.UcDGV();
            this.zaposleniDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipUgovoraDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatAngazovanjaDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBrojRedova = new System.Windows.Forms.Label();
            this.bsDetalji = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.lblBrojeviStat = new System.Windows.Forms.Label();
            this.radnoMestoDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaNormaPoPravilniku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnaNormaPoSistematizacijiDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnaNormaPoRMOsimZamenaDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcRazlika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGreskaUPlaniranojNormi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGreskaUUgovornomAngazovanju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblFilterCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistematizacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSistematizacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalji)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilterCaption
            // 
            lblFilterCaption.AutoSize = true;
            lblFilterCaption.Location = new System.Drawing.Point(316, 9);
            lblFilterCaption.Name = "lblFilterCaption";
            lblFilterCaption.Size = new System.Drawing.Size(43, 17);
            lblFilterCaption.TabIndex = 10;
            lblFilterCaption.Text = "Filter:";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvSistematizacija);
            this.scMain.Panel1.Controls.Add(this.pnlTop);
            this.scMain.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvDetalji);
            this.scMain.Panel2.Controls.Add(this.pnlLeft);
            this.scMain.Size = new System.Drawing.Size(1346, 587);
            this.scMain.SplitterDistance = 415;
            this.scMain.TabIndex = 0;
            // 
            // dgvSistematizacija
            // 
            this.dgvSistematizacija.AllowUserToAddRows = false;
            this.dgvSistematizacija.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSistematizacija.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSistematizacija.AutoGenerateColumns = false;
            this.dgvSistematizacija.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSistematizacija.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSistematizacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSistematizacija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radnoMestoDgvc,
            this.predmetDgvc,
            this.UkupnaNormaPoPravilniku,
            this.ukupnaNormaPoSistematizacijiDgvc,
            this.ukupnaNormaPoRMOsimZamenaDgvc,
            this.dgvcRazlika,
            this.dgvcGreskaUPlaniranojNormi,
            this.dgvcGreskaUUgovornomAngazovanju});
            this.dgvSistematizacija.ColumnsForCopyOnClick = null;
            this.dgvSistematizacija.CopyOnCellClick = false;
            this.dgvSistematizacija.CtrlDisplayPositionRowCount = this.lblRedovi;
            this.dgvSistematizacija.DataSource = this.bsSistematizacija;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSistematizacija.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSistematizacija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSistematizacija.Location = new System.Drawing.Point(0, 40);
            this.dgvSistematizacija.Name = "dgvSistematizacija";
            this.dgvSistematizacija.ReadOnly = true;
            this.dgvSistematizacija.RowHeadersWidth = 30;
            this.dgvSistematizacija.RowTemplate.Height = 24;
            this.dgvSistematizacija.Size = new System.Drawing.Size(1346, 375);
            this.dgvSistematizacija.StandardSort = null;
            this.dgvSistematizacija.TabIndex = 1;
            this.dgvSistematizacija.NumbersSelectionChanged += new System.EventHandler<string>(this.DgvSistematizacija_NumbersSelectionChanged);
            this.dgvSistematizacija.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSistematizacija_CellDoubleClick);
            this.dgvSistematizacija.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvSistematizacija_DataBindingComplete);
            // 
            // lblRedovi
            // 
            this.lblRedovi.AutoSize = true;
            this.lblRedovi.Location = new System.Drawing.Point(172, 10);
            this.lblRedovi.Name = "lblRedovi";
            this.lblRedovi.Size = new System.Drawing.Size(57, 17);
            this.lblRedovi.TabIndex = 9;
            this.lblRedovi.Text = "Redova";
            // 
            // bsSistematizacija
            // 
            this.bsSistematizacija.DataMember = "Sistematizacija";
            this.bsSistematizacija.DataSource = this.ds;
            this.bsSistematizacija.Sort = "UkupnaNormaRazlika DESC, GreskaUPlaniranojNormi DESC, GreskaUUgovornomAngazovanju" +
    " DESC";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(lblFilterCaption);
            this.pnlTop.Controls.Add(this.lblRedovi);
            this.pnlTop.Controls.Add(this.txtFilter);
            this.pnlTop.Controls.Add(this.btnOsveziPodatke);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1346, 40);
            this.pnlTop.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.BindingSource = null;
            this.txtFilter.Location = new System.Drawing.Point(374, 7);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.ShouldBeCyrillic = false;
            this.txtFilter.Size = new System.Drawing.Size(209, 23);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // btnOsveziPodatke
            // 
            this.btnOsveziPodatke.Location = new System.Drawing.Point(5, 5);
            this.btnOsveziPodatke.Name = "btnOsveziPodatke";
            this.btnOsveziPodatke.Size = new System.Drawing.Size(95, 30);
            this.btnOsveziPodatke.TabIndex = 0;
            this.btnOsveziPodatke.Text = "Osveži";
            this.btnOsveziPodatke.ToolTipText = null;
            this.btnOsveziPodatke.UseVisualStyleBackColor = true;
            this.btnOsveziPodatke.Click += new System.EventHandler(this.BtnOsveziPodatke_Click);
            // 
            // dgvDetalji
            // 
            this.dgvDetalji.AllowUserToAddRows = false;
            this.dgvDetalji.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetalji.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalji.AutoGenerateColumns = false;
            this.dgvDetalji.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zaposleniDgvc,
            this.tipUgovoraDgvc,
            this.procenatAngazovanjaDgvc});
            this.dgvDetalji.ColumnsForCopyOnClick = null;
            this.dgvDetalji.CopyOnCellClick = false;
            this.dgvDetalji.CtrlDisplayPositionRowCount = this.lblBrojRedova;
            this.dgvDetalji.DataSource = this.bsDetalji;
            this.dgvDetalji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalji.Location = new System.Drawing.Point(146, 0);
            this.dgvDetalji.Name = "dgvDetalji";
            this.dgvDetalji.ReadOnly = true;
            this.dgvDetalji.RowHeadersWidth = 30;
            this.dgvDetalji.RowTemplate.Height = 24;
            this.dgvDetalji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalji.Size = new System.Drawing.Size(1200, 168);
            this.dgvDetalji.StandardSort = null;
            this.dgvDetalji.TabIndex = 0;
            this.dgvDetalji.NumbersSelectionChanged += new System.EventHandler<string>(this.DgvSistematizacija_NumbersSelectionChanged);
            // 
            // zaposleniDgvc
            // 
            this.zaposleniDgvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zaposleniDgvc.DataPropertyName = "Zaposleni";
            this.zaposleniDgvc.HeaderText = "Zaposleni";
            this.zaposleniDgvc.MinimumWidth = 250;
            this.zaposleniDgvc.Name = "zaposleniDgvc";
            this.zaposleniDgvc.ReadOnly = true;
            this.zaposleniDgvc.Width = 250;
            // 
            // tipUgovoraDgvc
            // 
            this.tipUgovoraDgvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipUgovoraDgvc.DataPropertyName = "TipUgovora";
            this.tipUgovoraDgvc.HeaderText = "Tip Ugovora";
            this.tipUgovoraDgvc.MinimumWidth = 6;
            this.tipUgovoraDgvc.Name = "tipUgovoraDgvc";
            this.tipUgovoraDgvc.ReadOnly = true;
            // 
            // procenatAngazovanjaDgvc
            // 
            this.procenatAngazovanjaDgvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.procenatAngazovanjaDgvc.DataPropertyName = "ProcenatAngazovanja";
            this.procenatAngazovanjaDgvc.HeaderText = "Procenat Angazovanja";
            this.procenatAngazovanjaDgvc.MinimumWidth = 6;
            this.procenatAngazovanjaDgvc.Name = "procenatAngazovanjaDgvc";
            this.procenatAngazovanjaDgvc.ReadOnly = true;
            this.procenatAngazovanjaDgvc.Width = 176;
            // 
            // lblBrojRedova
            // 
            this.lblBrojRedova.AutoSize = true;
            this.lblBrojRedova.Location = new System.Drawing.Point(12, 9);
            this.lblBrojRedova.Name = "lblBrojRedova";
            this.lblBrojRedova.Size = new System.Drawing.Size(57, 17);
            this.lblBrojRedova.TabIndex = 1;
            this.lblBrojRedova.Text = "Redova";
            // 
            // bsDetalji
            // 
            this.bsDetalji.AllowNew = false;
            this.bsDetalji.DataMember = "FK_Sistematizacija_SistematizacijaDetalji";
            this.bsDetalji.DataSource = this.bsSistematizacija;
            this.bsDetalji.Sort = "";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblBrojeviStat);
            this.pnlLeft.Controls.Add(this.lblBrojRedova);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(146, 168);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblBrojeviStat
            // 
            this.lblBrojeviStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrojeviStat.AutoSize = true;
            this.lblBrojeviStat.Location = new System.Drawing.Point(12, 113);
            this.lblBrojeviStat.Name = "lblBrojeviStat";
            this.lblBrojeviStat.Size = new System.Drawing.Size(0, 17);
            this.lblBrojeviStat.TabIndex = 2;
            // 
            // radnoMestoDgvc
            // 
            this.radnoMestoDgvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.radnoMestoDgvc.DataPropertyName = "RadnoMesto";
            this.radnoMestoDgvc.HeaderText = "Radno Mesto";
            this.radnoMestoDgvc.MinimumWidth = 6;
            this.radnoMestoDgvc.Name = "radnoMestoDgvc";
            this.radnoMestoDgvc.ReadOnly = true;
            // 
            // predmetDgvc
            // 
            this.predmetDgvc.DataPropertyName = "Predmet";
            this.predmetDgvc.HeaderText = "Predmet";
            this.predmetDgvc.MinimumWidth = 6;
            this.predmetDgvc.Name = "predmetDgvc";
            this.predmetDgvc.ReadOnly = true;
            this.predmetDgvc.Width = 250;
            // 
            // UkupnaNormaPoPravilniku
            // 
            this.UkupnaNormaPoPravilniku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UkupnaNormaPoPravilniku.DataPropertyName = "UkupnaNormaPoPravilniku";
            this.UkupnaNormaPoPravilniku.HeaderText = "Pravilnik";
            this.UkupnaNormaPoPravilniku.Name = "UkupnaNormaPoPravilniku";
            this.UkupnaNormaPoPravilniku.ReadOnly = true;
            this.UkupnaNormaPoPravilniku.Width = 86;
            // 
            // ukupnaNormaPoSistematizacijiDgvc
            // 
            this.ukupnaNormaPoSistematizacijiDgvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ukupnaNormaPoSistematizacijiDgvc.DataPropertyName = "UkupnaNormaPoSistematizaciji";
            this.ukupnaNormaPoSistematizacijiDgvc.HeaderText = "Sistemat.";
            this.ukupnaNormaPoSistematizacijiDgvc.MinimumWidth = 6;
            this.ukupnaNormaPoSistematizacijiDgvc.Name = "ukupnaNormaPoSistematizacijiDgvc";
            this.ukupnaNormaPoSistematizacijiDgvc.ReadOnly = true;
            this.ukupnaNormaPoSistematizacijiDgvc.ToolTipText = "Ukupna Norma Po Sistematizaciji";
            this.ukupnaNormaPoSistematizacijiDgvc.Width = 91;
            // 
            // ukupnaNormaPoRMOsimZamenaDgvc
            // 
            this.ukupnaNormaPoRMOsimZamenaDgvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ukupnaNormaPoRMOsimZamenaDgvc.DataPropertyName = "UkupnaNormaPoRMOsimZamena";
            this.ukupnaNormaPoRMOsimZamenaDgvc.HeaderText = "Po RM";
            this.ukupnaNormaPoRMOsimZamenaDgvc.MinimumWidth = 6;
            this.ukupnaNormaPoRMOsimZamenaDgvc.Name = "ukupnaNormaPoRMOsimZamenaDgvc";
            this.ukupnaNormaPoRMOsimZamenaDgvc.ReadOnly = true;
            this.ukupnaNormaPoRMOsimZamenaDgvc.ToolTipText = "UkupnaNorma Po RM Osim Zamena";
            this.ukupnaNormaPoRMOsimZamenaDgvc.Width = 75;
            // 
            // dgvcRazlika
            // 
            this.dgvcRazlika.DataPropertyName = "UkupnaNormaRazlika";
            dataGridViewCellStyle3.Format = "#.##";
            this.dgvcRazlika.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcRazlika.HeaderText = "Razlika";
            this.dgvcRazlika.Name = "dgvcRazlika";
            this.dgvcRazlika.ReadOnly = true;
            // 
            // dgvcGreskaUPlaniranojNormi
            // 
            this.dgvcGreskaUPlaniranojNormi.DataPropertyName = "GreskaUPlaniranojNormi";
            this.dgvcGreskaUPlaniranojNormi.HeaderText = "Greška Plan";
            this.dgvcGreskaUPlaniranojNormi.Name = "dgvcGreskaUPlaniranojNormi";
            this.dgvcGreskaUPlaniranojNormi.ReadOnly = true;
            // 
            // dgvcGreskaUUgovornomAngazovanju
            // 
            this.dgvcGreskaUUgovornomAngazovanju.DataPropertyName = "GreskaUUgovornomAngazovanju";
            this.dgvcGreskaUUgovornomAngazovanju.HeaderText = "Greška Ang";
            this.dgvcGreskaUUgovornomAngazovanju.Name = "dgvcGreskaUUgovornomAngazovanju";
            this.dgvcGreskaUUgovornomAngazovanju.ReadOnly = true;
            // 
            // FrmSistematizacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 587);
            this.Controls.Add(this.scMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmSistematizacija";
            this.Text = "Sistematizacija";
            this.Load += new System.EventHandler(this.FrmSistematizacija_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistematizacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSistematizacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalji)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private Controls.UcDGV dgvSistematizacija;
        private System.Windows.Forms.Panel pnlTop;
        private Controls.UcButton btnOsveziPodatke;
        private System.Windows.Forms.BindingSource bsSistematizacija;
        private Data.Ds ds;
        private Controls.UcFilterTextBox txtFilter;
        private System.Windows.Forms.Label lblRedovi;
        private Controls.UcDGV dgvDetalji;
        private System.Windows.Forms.BindingSource bsDetalji;
        private Controls.UcLeftPanel pnlLeft;
        private System.Windows.Forms.Label lblBrojRedova;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposleniDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipUgovoraDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatAngazovanjaDgvc;
        private System.Windows.Forms.Label lblBrojeviStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnoMestoDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaNormaPoPravilniku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnaNormaPoSistematizacijiDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnaNormaPoRMOsimZamenaDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcRazlika;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGreskaUPlaniranojNormi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGreskaUUgovornomAngazovanju;
    }
}