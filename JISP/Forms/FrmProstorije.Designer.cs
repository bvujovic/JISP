namespace JISP.Forms
{
    partial class FrmProstorije
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsLokacije = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.bsObjekti = new System.Windows.Forms.BindingSource(this.components);
            this.bsProstorije = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProstorije = new JISP.Controls.UcDGV();
            this.nazivProstorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipProstorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prosecnaVisinaPlafonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvorGrejanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vrstaIzvoraGrejanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvorHladjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vrstaIzvoraHladjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prostorijaSeKoristiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.dgvObjekti = new JISP.Controls.UcDGV();
            this.nazivObjektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcObjGodinaIzgradnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaOtvaranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcObjPZaCiscenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcObjPZaGrejanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcObjNamena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLokacije = new JISP.Controls.UcDGV();
            this.nazivLokacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opstinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kucniBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeSedisteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.btnProstorijeReset = new System.Windows.Forms.Button();
            this.txtProstorijeNaziv = new System.Windows.Forms.TextBox();
            this.txtProstorijeTip = new System.Windows.Forms.TextBox();
            this.cmbProstorijeSprat = new System.Windows.Forms.ComboBox();
            this.lblStatistika = new System.Windows.Forms.Label();
            this.btnRacunari = new JISP.Controls.UcButton();
            this.btnDohvatiPodatke = new JISP.Controls.UcButton();
            this.cmbPodaciZaDohvatanje = new System.Windows.Forms.ComboBox();
            this.ucExitApp1 = new JISP.Controls.UcExitAppButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsLokacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjekti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProstorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 384);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 18);
            label1.TabIndex = 20;
            label1.Text = "Sprat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 354);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 18);
            label2.TabIndex = 20;
            label2.Text = "Tip";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 321);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 18);
            label3.TabIndex = 23;
            label3.Text = "Naziv";
            // 
            // bsLokacije
            // 
            this.bsLokacije.DataMember = "Lokacije";
            this.bsLokacije.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsObjekti
            // 
            this.bsObjekti.DataMember = "Lokacije_Objekti";
            this.bsObjekti.DataSource = this.bsLokacije;
            // 
            // bsProstorije
            // 
            this.bsProstorije.DataMember = "Objekti_Prostorije";
            this.bsProstorije.DataSource = this.bsObjekti;
            // 
            // dgvProstorije
            // 
            this.dgvProstorije.AllowUserToAddRows = false;
            this.dgvProstorije.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProstorije.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProstorije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProstorije.AutoGenerateColumns = false;
            this.dgvProstorije.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProstorije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProstorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProstorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivProstorijeDataGridViewTextBoxColumn,
            this.tipProstorijeDataGridViewTextBoxColumn,
            this.povrsinaDataGridViewTextBoxColumn,
            this.prosecnaVisinaPlafonaDataGridViewTextBoxColumn,
            this.dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn,
            this.spratDataGridViewTextBoxColumn,
            this.izvorGrejanjaDataGridViewTextBoxColumn,
            this.vrstaIzvoraGrejanjaDataGridViewTextBoxColumn,
            this.izvorHladjenjaDataGridViewTextBoxColumn,
            this.vrstaIzvoraHladjenjaDataGridViewTextBoxColumn,
            this.prostorijaSeKoristiDataGridViewCheckBoxColumn});
            this.dgvProstorije.ColumnsForCopyOnClick = null;
            this.dgvProstorije.CopyOnCellClick = false;
            this.dgvProstorije.CtrlDisplayPositionRowCount = this.lblRowCount;
            this.dgvProstorije.DataSource = this.bsProstorije;
            this.dgvProstorije.Location = new System.Drawing.Point(3, 239);
            this.dgvProstorije.Name = "dgvProstorije";
            this.dgvProstorije.RowHeadersWidth = 30;
            this.dgvProstorije.Size = new System.Drawing.Size(1044, 363);
            this.dgvProstorije.StandardSort = null;
            this.dgvProstorije.TabIndex = 2;
            this.dgvProstorije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProstorije_CellClick);
            this.dgvProstorije.SelectionChanged += new System.EventHandler(this.DgvProstorije_SelectionChanged);
            // 
            // nazivProstorijeDataGridViewTextBoxColumn
            // 
            this.nazivProstorijeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivProstorijeDataGridViewTextBoxColumn.DataPropertyName = "NazivProstorije";
            this.nazivProstorijeDataGridViewTextBoxColumn.FillWeight = 417F;
            this.nazivProstorijeDataGridViewTextBoxColumn.HeaderText = "Prostorija";
            this.nazivProstorijeDataGridViewTextBoxColumn.MinimumWidth = 208;
            this.nazivProstorijeDataGridViewTextBoxColumn.Name = "nazivProstorijeDataGridViewTextBoxColumn";
            // 
            // tipProstorijeDataGridViewTextBoxColumn
            // 
            this.tipProstorijeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipProstorijeDataGridViewTextBoxColumn.DataPropertyName = "TipProstorije";
            this.tipProstorijeDataGridViewTextBoxColumn.FillWeight = 263F;
            this.tipProstorijeDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipProstorijeDataGridViewTextBoxColumn.MinimumWidth = 131;
            this.tipProstorijeDataGridViewTextBoxColumn.Name = "tipProstorijeDataGridViewTextBoxColumn";
            // 
            // povrsinaDataGridViewTextBoxColumn
            // 
            this.povrsinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.povrsinaDataGridViewTextBoxColumn.DataPropertyName = "Povrsina";
            this.povrsinaDataGridViewTextBoxColumn.HeaderText = "Površina";
            this.povrsinaDataGridViewTextBoxColumn.Name = "povrsinaDataGridViewTextBoxColumn";
            this.povrsinaDataGridViewTextBoxColumn.Width = 91;
            // 
            // prosecnaVisinaPlafonaDataGridViewTextBoxColumn
            // 
            this.prosecnaVisinaPlafonaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.prosecnaVisinaPlafonaDataGridViewTextBoxColumn.DataPropertyName = "ProsecnaVisinaPlafona";
            this.prosecnaVisinaPlafonaDataGridViewTextBoxColumn.HeaderText = "Avg h plafona";
            this.prosecnaVisinaPlafonaDataGridViewTextBoxColumn.Name = "prosecnaVisinaPlafonaDataGridViewTextBoxColumn";
            this.prosecnaVisinaPlafonaDataGridViewTextBoxColumn.Width = 121;
            // 
            // dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn
            // 
            this.dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn.DataPropertyName = "DostupLicimaSaSpecPotrebama";
            this.dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn.HeaderText = "Dostupnost";
            this.dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn.Name = "dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn";
            this.dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn.ToolTipText = "Dostupnost Licima Sa Specijalnim Potrebama";
            this.dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn.Width = 91;
            // 
            // spratDataGridViewTextBoxColumn
            // 
            this.spratDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.spratDataGridViewTextBoxColumn.DataPropertyName = "Sprat";
            this.spratDataGridViewTextBoxColumn.HeaderText = "Sprat";
            this.spratDataGridViewTextBoxColumn.Name = "spratDataGridViewTextBoxColumn";
            this.spratDataGridViewTextBoxColumn.Width = 68;
            // 
            // izvorGrejanjaDataGridViewTextBoxColumn
            // 
            this.izvorGrejanjaDataGridViewTextBoxColumn.DataPropertyName = "IzvorGrejanja";
            this.izvorGrejanjaDataGridViewTextBoxColumn.HeaderText = "Izvor grejanja";
            this.izvorGrejanjaDataGridViewTextBoxColumn.Name = "izvorGrejanjaDataGridViewTextBoxColumn";
            this.izvorGrejanjaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.izvorGrejanjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.izvorGrejanjaDataGridViewTextBoxColumn.ThreeState = true;
            this.izvorGrejanjaDataGridViewTextBoxColumn.Width = 120;
            // 
            // vrstaIzvoraGrejanjaDataGridViewTextBoxColumn
            // 
            this.vrstaIzvoraGrejanjaDataGridViewTextBoxColumn.DataPropertyName = "VrstaIzvoraGrejanja";
            this.vrstaIzvoraGrejanjaDataGridViewTextBoxColumn.HeaderText = "Vrsta grejanja";
            this.vrstaIzvoraGrejanjaDataGridViewTextBoxColumn.Name = "vrstaIzvoraGrejanjaDataGridViewTextBoxColumn";
            this.vrstaIzvoraGrejanjaDataGridViewTextBoxColumn.Width = 122;
            // 
            // izvorHladjenjaDataGridViewTextBoxColumn
            // 
            this.izvorHladjenjaDataGridViewTextBoxColumn.DataPropertyName = "IzvorHladjenja";
            this.izvorHladjenjaDataGridViewTextBoxColumn.HeaderText = "Izvor hlađenja";
            this.izvorHladjenjaDataGridViewTextBoxColumn.Name = "izvorHladjenjaDataGridViewTextBoxColumn";
            this.izvorHladjenjaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.izvorHladjenjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.izvorHladjenjaDataGridViewTextBoxColumn.ThreeState = true;
            this.izvorHladjenjaDataGridViewTextBoxColumn.Width = 123;
            // 
            // vrstaIzvoraHladjenjaDataGridViewTextBoxColumn
            // 
            this.vrstaIzvoraHladjenjaDataGridViewTextBoxColumn.DataPropertyName = "VrstaIzvoraHladjenja";
            this.vrstaIzvoraHladjenjaDataGridViewTextBoxColumn.HeaderText = "Vrsta hlađenja";
            this.vrstaIzvoraHladjenjaDataGridViewTextBoxColumn.Name = "vrstaIzvoraHladjenjaDataGridViewTextBoxColumn";
            this.vrstaIzvoraHladjenjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // prostorijaSeKoristiDataGridViewCheckBoxColumn
            // 
            this.prostorijaSeKoristiDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prostorijaSeKoristiDataGridViewCheckBoxColumn.DataPropertyName = "ProstorijaSeKoristi";
            this.prostorijaSeKoristiDataGridViewCheckBoxColumn.HeaderText = "Koristi se";
            this.prostorijaSeKoristiDataGridViewCheckBoxColumn.Name = "prostorijaSeKoristiDataGridViewCheckBoxColumn";
            this.prostorijaSeKoristiDataGridViewCheckBoxColumn.ThreeState = true;
            this.prostorijaSeKoristiDataGridViewCheckBoxColumn.Width = 76;
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(13, 593);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(59, 18);
            this.lblRowCount.TabIndex = 18;
            this.lblRowCount.Text = "Redova";
            // 
            // dgvObjekti
            // 
            this.dgvObjekti.AllowUserToAddRows = false;
            this.dgvObjekti.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvObjekti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObjekti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObjekti.AutoGenerateColumns = false;
            this.dgvObjekti.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjekti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvObjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivObjektaDataGridViewTextBoxColumn,
            this.dgvcObjGodinaIzgradnje,
            this.GodinaOtvaranja,
            this.dgvcObjPZaCiscenje,
            this.dgvcObjPZaGrejanje,
            this.dgvcObjNamena});
            this.dgvObjekti.ColumnsForCopyOnClick = null;
            this.dgvObjekti.CopyOnCellClick = false;
            this.dgvObjekti.CtrlDisplayPositionRowCount = null;
            this.dgvObjekti.DataSource = this.bsObjekti;
            this.dgvObjekti.Location = new System.Drawing.Point(3, 121);
            this.dgvObjekti.Name = "dgvObjekti";
            this.dgvObjekti.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjekti.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvObjekti.RowHeadersWidth = 30;
            this.dgvObjekti.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjekti.Size = new System.Drawing.Size(1044, 112);
            this.dgvObjekti.StandardSort = null;
            this.dgvObjekti.TabIndex = 2;
            // 
            // nazivObjektaDataGridViewTextBoxColumn
            // 
            this.nazivObjektaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivObjektaDataGridViewTextBoxColumn.DataPropertyName = "NazivObjekta";
            this.nazivObjektaDataGridViewTextBoxColumn.HeaderText = "Objekat";
            this.nazivObjektaDataGridViewTextBoxColumn.Name = "nazivObjektaDataGridViewTextBoxColumn";
            this.nazivObjektaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvcObjGodinaIzgradnje
            // 
            this.dgvcObjGodinaIzgradnje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcObjGodinaIzgradnje.DataPropertyName = "GodinaIzgradnje";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcObjGodinaIzgradnje.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvcObjGodinaIzgradnje.HeaderText = "Izgrađen";
            this.dgvcObjGodinaIzgradnje.Name = "dgvcObjGodinaIzgradnje";
            this.dgvcObjGodinaIzgradnje.ReadOnly = true;
            this.dgvcObjGodinaIzgradnje.Width = 89;
            // 
            // GodinaOtvaranja
            // 
            this.GodinaOtvaranja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GodinaOtvaranja.DataPropertyName = "GodinaOtvaranja";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GodinaOtvaranja.DefaultCellStyle = dataGridViewCellStyle14;
            this.GodinaOtvaranja.HeaderText = "Otvoren";
            this.GodinaOtvaranja.Name = "GodinaOtvaranja";
            this.GodinaOtvaranja.ReadOnly = true;
            this.GodinaOtvaranja.Width = 86;
            // 
            // dgvcObjPZaCiscenje
            // 
            this.dgvcObjPZaCiscenje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcObjPZaCiscenje.DataPropertyName = "UkupnaPovrsinaZaCiscenje";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcObjPZaCiscenje.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvcObjPZaCiscenje.HeaderText = "P za čišćenje";
            this.dgvcObjPZaCiscenje.Name = "dgvcObjPZaCiscenje";
            this.dgvcObjPZaCiscenje.ReadOnly = true;
            this.dgvcObjPZaCiscenje.Width = 121;
            // 
            // dgvcObjPZaGrejanje
            // 
            this.dgvcObjPZaGrejanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcObjPZaGrejanje.DataPropertyName = "UkupnaPovrsinaZaGrejanje";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcObjPZaGrejanje.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvcObjPZaGrejanje.HeaderText = "P za grejanje";
            this.dgvcObjPZaGrejanje.Name = "dgvcObjPZaGrejanje";
            this.dgvcObjPZaGrejanje.ReadOnly = true;
            this.dgvcObjPZaGrejanje.Width = 118;
            // 
            // dgvcObjNamena
            // 
            this.dgvcObjNamena.DataPropertyName = "Namena";
            this.dgvcObjNamena.HeaderText = "Namena";
            this.dgvcObjNamena.Name = "dgvcObjNamena";
            this.dgvcObjNamena.ReadOnly = true;
            this.dgvcObjNamena.Width = 172;
            // 
            // dgvLokacije
            // 
            this.dgvLokacije.AllowUserToAddRows = false;
            this.dgvLokacije.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLokacije.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLokacije.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLokacije.AutoGenerateColumns = false;
            this.dgvLokacije.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLokacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivLokacijeDataGridViewTextBoxColumn,
            this.opstinaDataGridViewTextBoxColumn,
            this.mestoDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.kucniBrojDataGridViewTextBoxColumn,
            this.jeSedisteDataGridViewCheckBoxColumn});
            this.dgvLokacije.ColumnsForCopyOnClick = null;
            this.dgvLokacije.CopyOnCellClick = false;
            this.dgvLokacije.CtrlDisplayPositionRowCount = null;
            this.dgvLokacije.DataSource = this.bsLokacije;
            this.dgvLokacije.Location = new System.Drawing.Point(3, 3);
            this.dgvLokacije.Name = "dgvLokacije";
            this.dgvLokacije.ReadOnly = true;
            this.dgvLokacije.RowHeadersWidth = 30;
            this.dgvLokacije.Size = new System.Drawing.Size(1044, 112);
            this.dgvLokacije.StandardSort = null;
            this.dgvLokacije.TabIndex = 1;
            // 
            // nazivLokacijeDataGridViewTextBoxColumn
            // 
            this.nazivLokacijeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivLokacijeDataGridViewTextBoxColumn.DataPropertyName = "NazivLokacije";
            this.nazivLokacijeDataGridViewTextBoxColumn.HeaderText = "Lokacija";
            this.nazivLokacijeDataGridViewTextBoxColumn.Name = "nazivLokacijeDataGridViewTextBoxColumn";
            this.nazivLokacijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opstinaDataGridViewTextBoxColumn
            // 
            this.opstinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.opstinaDataGridViewTextBoxColumn.DataPropertyName = "Opstina";
            this.opstinaDataGridViewTextBoxColumn.HeaderText = "Opština";
            this.opstinaDataGridViewTextBoxColumn.Name = "opstinaDataGridViewTextBoxColumn";
            this.opstinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.opstinaDataGridViewTextBoxColumn.Width = 84;
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "Mesto";
            this.mestoDataGridViewTextBoxColumn.HeaderText = "Mesto";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            this.mestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mestoDataGridViewTextBoxColumn.Width = 75;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulicaDataGridViewTextBoxColumn.Width = 66;
            // 
            // kucniBrojDataGridViewTextBoxColumn
            // 
            this.kucniBrojDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kucniBrojDataGridViewTextBoxColumn.DataPropertyName = "KucniBroj";
            this.kucniBrojDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.kucniBrojDataGridViewTextBoxColumn.Name = "kucniBrojDataGridViewTextBoxColumn";
            this.kucniBrojDataGridViewTextBoxColumn.ReadOnly = true;
            this.kucniBrojDataGridViewTextBoxColumn.Width = 60;
            // 
            // jeSedisteDataGridViewCheckBoxColumn
            // 
            this.jeSedisteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.jeSedisteDataGridViewCheckBoxColumn.DataPropertyName = "JeSediste";
            this.jeSedisteDataGridViewCheckBoxColumn.HeaderText = "Sedište";
            this.jeSedisteDataGridViewCheckBoxColumn.Name = "jeSedisteDataGridViewCheckBoxColumn";
            this.jeSedisteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.jeSedisteDataGridViewCheckBoxColumn.Width = 63;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnProstorijeReset);
            this.pnlLeft.Controls.Add(this.txtProstorijeNaziv);
            this.pnlLeft.Controls.Add(label3);
            this.pnlLeft.Controls.Add(this.txtProstorijeTip);
            this.pnlLeft.Controls.Add(this.cmbProstorijeSprat);
            this.pnlLeft.Controls.Add(label2);
            this.pnlLeft.Controls.Add(label1);
            this.pnlLeft.Controls.Add(this.lblStatistika);
            this.pnlLeft.Controls.Add(this.lblRowCount);
            this.pnlLeft.Controls.Add(this.btnRacunari);
            this.pnlLeft.Controls.Add(this.btnDohvatiPodatke);
            this.pnlLeft.Controls.Add(this.cmbPodaciZaDohvatanje);
            this.pnlLeft.Controls.Add(this.ucExitApp1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(150, 623);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnProstorijeReset
            // 
            this.btnProstorijeReset.Location = new System.Drawing.Point(56, 411);
            this.btnProstorijeReset.Name = "btnProstorijeReset";
            this.btnProstorijeReset.Size = new System.Drawing.Size(78, 25);
            this.btnProstorijeReset.TabIndex = 25;
            this.btnProstorijeReset.Text = "Reset";
            this.btnProstorijeReset.UseVisualStyleBackColor = true;
            this.btnProstorijeReset.Click += new System.EventHandler(this.BtnProstorijeReset_Click);
            // 
            // txtProstorijeNaziv
            // 
            this.txtProstorijeNaziv.Location = new System.Drawing.Point(56, 318);
            this.txtProstorijeNaziv.Name = "txtProstorijeNaziv";
            this.txtProstorijeNaziv.Size = new System.Drawing.Size(77, 24);
            this.txtProstorijeNaziv.TabIndex = 21;
            this.txtProstorijeNaziv.TextChanged += new System.EventHandler(this.TxtProstorijeNaziv_TextChanged);
            this.txtProstorijeNaziv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProstorijeFilter_KeyDown);
            // 
            // txtProstorijeTip
            // 
            this.txtProstorijeTip.Location = new System.Drawing.Point(57, 351);
            this.txtProstorijeTip.Name = "txtProstorijeTip";
            this.txtProstorijeTip.Size = new System.Drawing.Size(77, 24);
            this.txtProstorijeTip.TabIndex = 22;
            this.txtProstorijeTip.TextChanged += new System.EventHandler(this.TxtProstorijeTip_TextChanged);
            this.txtProstorijeTip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProstorijeFilter_KeyDown);
            // 
            // cmbProstorijeSprat
            // 
            this.cmbProstorijeSprat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProstorijeSprat.FormattingEnabled = true;
            this.cmbProstorijeSprat.Location = new System.Drawing.Point(56, 381);
            this.cmbProstorijeSprat.Name = "cmbProstorijeSprat";
            this.cmbProstorijeSprat.Size = new System.Drawing.Size(78, 26);
            this.cmbProstorijeSprat.TabIndex = 24;
            this.cmbProstorijeSprat.SelectedIndexChanged += new System.EventHandler(this.CmbSprat_SelectedIndexChanged);
            // 
            // lblStatistika
            // 
            this.lblStatistika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatistika.AutoSize = true;
            this.lblStatistika.Location = new System.Drawing.Point(13, 525);
            this.lblStatistika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatistika.Name = "lblStatistika";
            this.lblStatistika.Size = new System.Drawing.Size(59, 36);
            this.lblStatistika.TabIndex = 19;
            this.lblStatistika.Text = "Broj: /\r\nSuma: /";
            // 
            // btnRacunari
            // 
            this.btnRacunari.Location = new System.Drawing.Point(7, 248);
            this.btnRacunari.Name = "btnRacunari";
            this.btnRacunari.Size = new System.Drawing.Size(127, 30);
            this.btnRacunari.TabIndex = 17;
            this.btnRacunari.Text = "Računari";
            this.btnRacunari.ToolTipText = null;
            this.btnRacunari.UseVisualStyleBackColor = true;
            this.btnRacunari.Click += new System.EventHandler(this.BtnRacunari_Click);
            // 
            // btnDohvatiPodatke
            // 
            this.btnDohvatiPodatke.Location = new System.Drawing.Point(7, 120);
            this.btnDohvatiPodatke.Name = "btnDohvatiPodatke";
            this.btnDohvatiPodatke.Size = new System.Drawing.Size(127, 30);
            this.btnDohvatiPodatke.TabIndex = 16;
            this.btnDohvatiPodatke.Text = "Dohvati podatke";
            this.btnDohvatiPodatke.ToolTipText = null;
            this.btnDohvatiPodatke.UseVisualStyleBackColor = true;
            this.btnDohvatiPodatke.Click += new System.EventHandler(this.BtnDohvatiPodatke_Click);
            // 
            // cmbPodaciZaDohvatanje
            // 
            this.cmbPodaciZaDohvatanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPodaciZaDohvatanje.DropDownWidth = 300;
            this.cmbPodaciZaDohvatanje.FormattingEnabled = true;
            this.cmbPodaciZaDohvatanje.Items.AddRange(new object[] {
            "Opšti podaci (datum rođenja, pol, ...)",
            "Razredi i odeljenja",
            "Smerovi za srednjoškolce",
            "Ocene na polugodištu",
            "Ocene za kraj godine"});
            this.cmbPodaciZaDohvatanje.Location = new System.Drawing.Point(7, 88);
            this.cmbPodaciZaDohvatanje.Name = "cmbPodaciZaDohvatanje";
            this.cmbPodaciZaDohvatanje.Size = new System.Drawing.Size(127, 26);
            this.cmbPodaciZaDohvatanje.TabIndex = 15;
            // 
            // ucExitApp1
            // 
            this.ucExitApp1.BackColor = System.Drawing.Color.Red;
            this.ucExitApp1.ForeColor = System.Drawing.Color.White;
            this.ucExitApp1.Location = new System.Drawing.Point(7, 15);
            this.ucExitApp1.Margin = new System.Windows.Forms.Padding(4);
            this.ucExitApp1.Name = "ucExitApp1";
            this.ucExitApp1.Size = new System.Drawing.Size(127, 34);
            this.ucExitApp1.TabIndex = 1;
            this.ucExitApp1.Text = "Izlaz";
            this.ucExitApp1.ToolTipText = "Izlaz iz aplikacije";
            this.ucExitApp1.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvProstorije);
            this.pnlMain.Controls.Add(this.dgvLokacije);
            this.pnlMain.Controls.Add(this.dgvObjekti);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(150, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1050, 623);
            this.pnlMain.TabIndex = 3;
            // 
            // FrmProstorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProstorije";
            this.Text = "Prostorije";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProstorije_FormClosing);
            this.Load += new System.EventHandler(this.FrmProstorije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLokacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjekti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProstorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcLeftPanel pnlLeft;
        private Controls.UcDGV dgvLokacije;
        private System.Windows.Forms.BindingSource bsLokacije;
        private Data.Ds ds;
        private Controls.UcExitAppButton ucExitApp1;
        private Controls.UcButton btnDohvatiPodatke;
        private System.Windows.Forms.ComboBox cmbPodaciZaDohvatanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivLokacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opstinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kucniBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jeSedisteDataGridViewCheckBoxColumn;
        private Controls.UcDGV dgvObjekti;
        private Controls.UcDGV dgvProstorije;
        private System.Windows.Forms.BindingSource bsObjekti;
        private System.Windows.Forms.BindingSource bsProstorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivObjektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcObjGodinaIzgradnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaOtvaranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcObjPZaCiscenje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcObjPZaGrejanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcObjNamena;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivProstorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipProstorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prosecnaVisinaPlafonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dostupLicimaSaSpecPotrebamaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn izvorGrejanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaIzvoraGrejanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn izvorHladjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaIzvoraHladjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prostorijaSeKoristiDataGridViewCheckBoxColumn;
        private Controls.UcButton btnRacunari;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label lblStatistika;
        private System.Windows.Forms.Button btnProstorijeReset;
        private System.Windows.Forms.TextBox txtProstorijeNaziv;
        private System.Windows.Forms.TextBox txtProstorijeTip;
        private System.Windows.Forms.ComboBox cmbProstorijeSprat;
        private System.Windows.Forms.Panel pnlMain;
    }
}