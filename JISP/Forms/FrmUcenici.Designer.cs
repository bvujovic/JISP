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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsUcenici = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttOceneProvera = new System.Windows.Forms.ToolTip(this.components);
            this.lblRowCount = new System.Windows.Forms.Label();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.btnOdRaz = new JISP.Controls.UcButton();
            this.chkAktivni = new System.Windows.Forms.CheckBox();
            this.chkCopyOnClick = new System.Windows.Forms.CheckBox();
            this.btnDohvatiPodatke = new JISP.Controls.UcButton();
            this.cmbPodaciZaDohvatanje = new System.Windows.Forms.ComboBox();
            this.gbOceneUnos = new System.Windows.Forms.GroupBox();
            this.lblOceneProsek = new System.Windows.Forms.Label();
            this.btnOcenePaste = new System.Windows.Forms.Button();
            this.chkOceneSaVladanjem = new System.Windows.Forms.CheckBox();
            this.btnNoviUcenici = new JISP.Controls.UcButton();
            this.ucExitApp1 = new JISP.Controls.UcExitAppButton();
            this.btnSaveData = new JISP.Controls.UcButton();
            this.txtFilter = new JISP.Controls.UcFilterTextBox();
            this.dgvUcenikSkGod = new JISP.Controls.UcDGV();
            this.bsUcenikSkGod = new System.Windows.Forms.BindingSource(this.components);
            this.ImePrezimeDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrezimeDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeRoditeljaDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcJMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrebivaliste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skGodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odeljenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcStaresina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDomGrupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DanaDoRodj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Godine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenePoluBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oceneKrajBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenePoluJSONDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oceneKrajJSONDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIspisan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ZavrsObrazovanjaRezimeDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomeneDgvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.gbOceneUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenikSkGod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenikSkGod)).BeginInit();
            this.SuspendLayout();
            // 
            // bsUcenici
            // 
            this.bsUcenici.DataMember = "Ucenici";
            this.bsUcenici.DataSource = this.ds;
            this.bsUcenici.Sort = "Skola, Razred, Odeljenje";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 490);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1297, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 17);
            this.lblStatus.Text = "/";
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(4, 122);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(56, 16);
            this.lblRowCount.TabIndex = 1;
            this.lblRowCount.Text = "Redova";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnOdRaz);
            this.pnlLeft.Controls.Add(this.chkAktivni);
            this.pnlLeft.Controls.Add(this.chkCopyOnClick);
            this.pnlLeft.Controls.Add(this.btnDohvatiPodatke);
            this.pnlLeft.Controls.Add(this.cmbPodaciZaDohvatanje);
            this.pnlLeft.Controls.Add(this.gbOceneUnos);
            this.pnlLeft.Controls.Add(this.btnNoviUcenici);
            this.pnlLeft.Controls.Add(this.ucExitApp1);
            this.pnlLeft.Controls.Add(this.lblRowCount);
            this.pnlLeft.Controls.Add(this.btnSaveData);
            this.pnlLeft.Controls.Add(this.txtFilter);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 8;
            this.pnlLeft.Size = new System.Drawing.Size(150, 490);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnOdRaz
            // 
            this.btnOdRaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOdRaz.Location = new System.Drawing.Point(7, 346);
            this.btnOdRaz.Name = "btnOdRaz";
            this.btnOdRaz.Size = new System.Drawing.Size(127, 30);
            this.btnOdRaz.TabIndex = 15;
            this.btnOdRaz.Text = "Razredi, odeljenja";
            this.btnOdRaz.ToolTipText = null;
            this.btnOdRaz.UseVisualStyleBackColor = true;
            this.btnOdRaz.Click += new System.EventHandler(this.BtnOdRaz_Click);
            // 
            // chkAktivni
            // 
            this.chkAktivni.AutoSize = true;
            this.chkAktivni.Checked = true;
            this.chkAktivni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktivni.Location = new System.Drawing.Point(7, 141);
            this.chkAktivni.Name = "chkAktivni";
            this.chkAktivni.Size = new System.Drawing.Size(65, 20);
            this.chkAktivni.TabIndex = 14;
            this.chkAktivni.Text = "Aktivni";
            this.chkAktivni.ThreeState = true;
            this.chkAktivni.UseVisualStyleBackColor = true;
            this.chkAktivni.CheckStateChanged += new System.EventHandler(this.ChkAktivni_CheckStateChanged);
            // 
            // chkCopyOnClick
            // 
            this.chkCopyOnClick.AutoSize = true;
            this.chkCopyOnClick.Location = new System.Drawing.Point(7, 69);
            this.chkCopyOnClick.Name = "chkCopyOnClick";
            this.chkCopyOnClick.Size = new System.Drawing.Size(124, 20);
            this.chkCopyOnClick.TabIndex = 13;
            this.chkCopyOnClick.Text = "Kopiranje na klik";
            this.chkCopyOnClick.UseVisualStyleBackColor = true;
            this.chkCopyOnClick.CheckedChanged += new System.EventHandler(this.ChkCopyOnClick_CheckedChanged);
            // 
            // btnDohvatiPodatke
            // 
            this.btnDohvatiPodatke.Location = new System.Drawing.Point(7, 261);
            this.btnDohvatiPodatke.Name = "btnDohvatiPodatke";
            this.btnDohvatiPodatke.Size = new System.Drawing.Size(127, 30);
            this.btnDohvatiPodatke.TabIndex = 4;
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
            this.cmbPodaciZaDohvatanje.Location = new System.Drawing.Point(7, 236);
            this.cmbPodaciZaDohvatanje.Name = "cmbPodaciZaDohvatanje";
            this.cmbPodaciZaDohvatanje.Size = new System.Drawing.Size(127, 24);
            this.cmbPodaciZaDohvatanje.TabIndex = 3;
            // 
            // gbOceneUnos
            // 
            this.gbOceneUnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbOceneUnos.Controls.Add(this.lblOceneProsek);
            this.gbOceneUnos.Controls.Add(this.btnOcenePaste);
            this.gbOceneUnos.Controls.Add(this.chkOceneSaVladanjem);
            this.gbOceneUnos.Location = new System.Drawing.Point(7, 382);
            this.gbOceneUnos.Name = "gbOceneUnos";
            this.gbOceneUnos.Size = new System.Drawing.Size(127, 65);
            this.gbOceneUnos.TabIndex = 9;
            this.gbOceneUnos.TabStop = false;
            this.gbOceneUnos.Text = "Unos ocena";
            // 
            // lblOceneProsek
            // 
            this.lblOceneProsek.Location = new System.Drawing.Point(52, 45);
            this.lblOceneProsek.Name = "lblOceneProsek";
            this.lblOceneProsek.Size = new System.Drawing.Size(74, 16);
            this.lblOceneProsek.TabIndex = 2;
            this.lblOceneProsek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOcenePaste
            // 
            this.btnOcenePaste.Location = new System.Drawing.Point(6, 16);
            this.btnOcenePaste.Name = "btnOcenePaste";
            this.btnOcenePaste.Size = new System.Drawing.Size(40, 45);
            this.btnOcenePaste.TabIndex = 0;
            this.btnOcenePaste.Text = "ОК";
            this.btnOcenePaste.UseVisualStyleBackColor = true;
            this.btnOcenePaste.Click += new System.EventHandler(this.BtnOcenePaste_Click);
            // 
            // chkOceneSaVladanjem
            // 
            this.chkOceneSaVladanjem.AutoSize = true;
            this.chkOceneSaVladanjem.Checked = true;
            this.chkOceneSaVladanjem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOceneSaVladanjem.Location = new System.Drawing.Point(51, 20);
            this.chkOceneSaVladanjem.Name = "chkOceneSaVladanjem";
            this.chkOceneSaVladanjem.Size = new System.Drawing.Size(80, 20);
            this.chkOceneSaVladanjem.TabIndex = 1;
            this.chkOceneSaVladanjem.Text = "Vladanje";
            this.chkOceneSaVladanjem.UseVisualStyleBackColor = true;
            // 
            // btnNoviUcenici
            // 
            this.btnNoviUcenici.Location = new System.Drawing.Point(7, 179);
            this.btnNoviUcenici.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoviUcenici.Name = "btnNoviUcenici";
            this.btnNoviUcenici.Size = new System.Drawing.Size(127, 38);
            this.btnNoviUcenici.TabIndex = 2;
            this.btnNoviUcenici.Text = "Novi učenik/ci ...";
            this.btnNoviUcenici.ToolTipText = "Dodavanje jednog ili više učenika.";
            this.btnNoviUcenici.UseVisualStyleBackColor = false;
            this.btnNoviUcenici.Click += new System.EventHandler(this.BtnNoviUcenici_Click);
            // 
            // ucExitApp1
            // 
            this.ucExitApp1.BackColor = System.Drawing.Color.Red;
            this.ucExitApp1.ForeColor = System.Drawing.Color.White;
            this.ucExitApp1.Location = new System.Drawing.Point(7, 15);
            this.ucExitApp1.Margin = new System.Windows.Forms.Padding(4);
            this.ucExitApp1.Name = "ucExitApp1";
            this.ucExitApp1.Size = new System.Drawing.Size(127, 34);
            this.ucExitApp1.TabIndex = 6;
            this.ucExitApp1.Text = "Izlaz";
            this.ucExitApp1.ToolTipText = "Izlaz iz aplikacije";
            this.ucExitApp1.UseVisualStyleBackColor = false;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveData.Location = new System.Drawing.Point(7, 448);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(127, 38);
            this.btnSaveData.TabIndex = 5;
            this.btnSaveData.Text = "Sačuvaj podatke";
            this.btnSaveData.ToolTipText = null;
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BindingSource = this.bsUcenici;
            this.txtFilter.Location = new System.Drawing.Point(7, 96);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.ShouldBeCyrillic = false;
            this.txtFilter.Size = new System.Drawing.Size(127, 22);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFilter_KeyDown);
            // 
            // dgvUcenikSkGod
            // 
            this.dgvUcenikSkGod.AllowUserToAddRows = false;
            this.dgvUcenikSkGod.AllowUserToDeleteRows = false;
            this.dgvUcenikSkGod.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUcenikSkGod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUcenikSkGod.AutoGenerateColumns = false;
            this.dgvUcenikSkGod.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUcenikSkGod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUcenikSkGod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenikSkGod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezimeDgvc,
            this.imeDgvc,
            this.PrezimeDgvc,
            this.ImeRoditeljaDgvc,
            this.jobDgvc,
            this.dgvcJMBG,
            this.dgvcPrebivaliste,
            this.skGodDataGridViewTextBoxColumn,
            this.skolaDataGridViewTextBoxColumn,
            this.razredDataGridViewTextBoxColumn,
            this.odeljenjeDataGridViewTextBoxColumn,
            this.dgvcStaresina,
            this.smerDataGridViewTextBoxColumn,
            this.dgvcDomGrupa,
            this._Pol,
            this._DatumRodjenja,
            this._DanaDoRodj,
            this._Godine,
            this.ocenePoluBrojDataGridViewTextBoxColumn,
            this.oceneKrajBrojDataGridViewTextBoxColumn,
            this.ocenePoluJSONDgvc,
            this.oceneKrajJSONDgvc,
            this.dgvcIspisan,
            this.ZavrsObrazovanjaRezimeDgvc,
            this.napomeneDgvc});
            this.dgvUcenikSkGod.ColumnsForCopyOnClick = null;
            this.dgvUcenikSkGod.CopyOnCellClick = false;
            this.dgvUcenikSkGod.CtrlDisplayPositionRowCount = this.lblRowCount;
            this.dgvUcenikSkGod.DataSource = this.bsUcenikSkGod;
            this.dgvUcenikSkGod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUcenikSkGod.Location = new System.Drawing.Point(150, 0);
            this.dgvUcenikSkGod.Name = "dgvUcenikSkGod";
            this.dgvUcenikSkGod.RowHeadersWidth = 30;
            this.dgvUcenikSkGod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcenikSkGod.Size = new System.Drawing.Size(1147, 490);
            this.dgvUcenikSkGod.StandardSort = null;
            this.dgvUcenikSkGod.TabIndex = 2;
            this.dgvUcenikSkGod.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUcenikSkGod_CellDoubleClick);
            // 
            // bsUcenikSkGod
            // 
            this.bsUcenikSkGod.DataMember = "UcenikSkGod";
            this.bsUcenikSkGod.DataSource = this.ds;
            this.bsUcenikSkGod.Sort = "Skola, Razred, Odeljenje";
            // 
            // ImePrezimeDgvc
            // 
            this.ImePrezimeDgvc.DataPropertyName = "_UcenikString";
            this.ImePrezimeDgvc.HeaderText = "Ime i prezime";
            this.ImePrezimeDgvc.Name = "ImePrezimeDgvc";
            this.ImePrezimeDgvc.ReadOnly = true;
            this.ImePrezimeDgvc.Width = 180;
            // 
            // imeDgvc
            // 
            this.imeDgvc.DataPropertyName = "_Ime";
            this.imeDgvc.HeaderText = "Ime";
            this.imeDgvc.Name = "imeDgvc";
            this.imeDgvc.ReadOnly = true;
            this.imeDgvc.Width = 105;
            // 
            // PrezimeDgvc
            // 
            this.PrezimeDgvc.DataPropertyName = "_Prezime";
            this.PrezimeDgvc.HeaderText = "Prezime";
            this.PrezimeDgvc.Name = "PrezimeDgvc";
            this.PrezimeDgvc.ReadOnly = true;
            // 
            // ImeRoditeljaDgvc
            // 
            this.ImeRoditeljaDgvc.DataPropertyName = "_ImeRoditelja";
            this.ImeRoditeljaDgvc.HeaderText = "Roditelj";
            this.ImeRoditeljaDgvc.Name = "ImeRoditeljaDgvc";
            this.ImeRoditeljaDgvc.ReadOnly = true;
            // 
            // jobDgvc
            // 
            this.jobDgvc.DataPropertyName = "_JOB";
            this.jobDgvc.HeaderText = "JOB";
            this.jobDgvc.Name = "jobDgvc";
            this.jobDgvc.ReadOnly = true;
            this.jobDgvc.Width = 165;
            // 
            // dgvcJMBG
            // 
            this.dgvcJMBG.DataPropertyName = "_JMBG";
            this.dgvcJMBG.HeaderText = "JMBG";
            this.dgvcJMBG.Name = "dgvcJMBG";
            this.dgvcJMBG.ReadOnly = true;
            this.dgvcJMBG.Width = 125;
            // 
            // dgvcPrebivaliste
            // 
            this.dgvcPrebivaliste.DataPropertyName = "_Prebivaliste";
            this.dgvcPrebivaliste.HeaderText = "Prebivalište";
            this.dgvcPrebivaliste.Name = "dgvcPrebivaliste";
            this.dgvcPrebivaliste.ReadOnly = true;
            this.dgvcPrebivaliste.Width = 150;
            // 
            // skGodDataGridViewTextBoxColumn
            // 
            this.skGodDataGridViewTextBoxColumn.DataPropertyName = "SkGod";
            this.skGodDataGridViewTextBoxColumn.HeaderText = "SkGod";
            this.skGodDataGridViewTextBoxColumn.Name = "skGodDataGridViewTextBoxColumn";
            this.skGodDataGridViewTextBoxColumn.ReadOnly = true;
            this.skGodDataGridViewTextBoxColumn.Visible = false;
            // 
            // skolaDataGridViewTextBoxColumn
            // 
            this.skolaDataGridViewTextBoxColumn.DataPropertyName = "Skola";
            this.skolaDataGridViewTextBoxColumn.HeaderText = "Skola";
            this.skolaDataGridViewTextBoxColumn.Name = "skolaDataGridViewTextBoxColumn";
            this.skolaDataGridViewTextBoxColumn.ReadOnly = true;
            this.skolaDataGridViewTextBoxColumn.Width = 80;
            // 
            // razredDataGridViewTextBoxColumn
            // 
            this.razredDataGridViewTextBoxColumn.DataPropertyName = "Razred";
            this.razredDataGridViewTextBoxColumn.HeaderText = "Razred";
            this.razredDataGridViewTextBoxColumn.Name = "razredDataGridViewTextBoxColumn";
            this.razredDataGridViewTextBoxColumn.ReadOnly = true;
            this.razredDataGridViewTextBoxColumn.Width = 105;
            // 
            // odeljenjeDataGridViewTextBoxColumn
            // 
            this.odeljenjeDataGridViewTextBoxColumn.DataPropertyName = "Odeljenje";
            this.odeljenjeDataGridViewTextBoxColumn.HeaderText = "Odeljenje";
            this.odeljenjeDataGridViewTextBoxColumn.Name = "odeljenjeDataGridViewTextBoxColumn";
            this.odeljenjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.odeljenjeDataGridViewTextBoxColumn.Width = 95;
            // 
            // dgvcStaresina
            // 
            this.dgvcStaresina.DataPropertyName = "_Staresina";
            this.dgvcStaresina.HeaderText = "Staresina";
            this.dgvcStaresina.Name = "dgvcStaresina";
            this.dgvcStaresina.ReadOnly = true;
            this.dgvcStaresina.Width = 150;
            // 
            // smerDataGridViewTextBoxColumn
            // 
            this.smerDataGridViewTextBoxColumn.DataPropertyName = "Smer";
            this.smerDataGridViewTextBoxColumn.HeaderText = "Smer";
            this.smerDataGridViewTextBoxColumn.Name = "smerDataGridViewTextBoxColumn";
            this.smerDataGridViewTextBoxColumn.ReadOnly = true;
            this.smerDataGridViewTextBoxColumn.Width = 121;
            // 
            // dgvcDomGrupa
            // 
            this.dgvcDomGrupa.DataPropertyName = "DomGrupa";
            this.dgvcDomGrupa.HeaderText = "Dom Grupa";
            this.dgvcDomGrupa.Name = "dgvcDomGrupa";
            this.dgvcDomGrupa.ReadOnly = true;
            // 
            // _Pol
            // 
            this._Pol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this._Pol.DataPropertyName = "_Pol";
            this._Pol.HeaderText = "Pol";
            this._Pol.Name = "_Pol";
            this._Pol.ReadOnly = true;
            this._Pol.Width = 52;
            // 
            // _DatumRodjenja
            // 
            this._DatumRodjenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this._DatumRodjenja.DataPropertyName = "_DatumRodjenja";
            this._DatumRodjenja.HeaderText = "Dat Rođ";
            this._DatumRodjenja.Name = "_DatumRodjenja";
            this._DatumRodjenja.ReadOnly = true;
            this._DatumRodjenja.Width = 82;
            // 
            // _DanaDoRodj
            // 
            this._DanaDoRodj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this._DanaDoRodj.DataPropertyName = "_DanaDoRodj";
            this._DanaDoRodj.HeaderText = "Do Rođ";
            this._DanaDoRodj.Name = "_DanaDoRodj";
            this._DanaDoRodj.ReadOnly = true;
            this._DanaDoRodj.Width = 79;
            // 
            // _Godine
            // 
            this._Godine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this._Godine.DataPropertyName = "_Godine";
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = null;
            this._Godine.DefaultCellStyle = dataGridViewCellStyle3;
            this._Godine.HeaderText = "Godine";
            this._Godine.Name = "_Godine";
            this._Godine.ReadOnly = true;
            this._Godine.Width = 76;
            // 
            // ocenePoluBrojDataGridViewTextBoxColumn
            // 
            this.ocenePoluBrojDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ocenePoluBrojDataGridViewTextBoxColumn.DataPropertyName = "OcenePoluBroj";
            this.ocenePoluBrojDataGridViewTextBoxColumn.HeaderText = "Ocene PG";
            this.ocenePoluBrojDataGridViewTextBoxColumn.Name = "ocenePoluBrojDataGridViewTextBoxColumn";
            this.ocenePoluBrojDataGridViewTextBoxColumn.ReadOnly = true;
            this.ocenePoluBrojDataGridViewTextBoxColumn.Width = 94;
            // 
            // oceneKrajBrojDataGridViewTextBoxColumn
            // 
            this.oceneKrajBrojDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.oceneKrajBrojDataGridViewTextBoxColumn.DataPropertyName = "OceneKrajBroj";
            this.oceneKrajBrojDataGridViewTextBoxColumn.HeaderText = "Ocene Kraj";
            this.oceneKrajBrojDataGridViewTextBoxColumn.Name = "oceneKrajBrojDataGridViewTextBoxColumn";
            this.oceneKrajBrojDataGridViewTextBoxColumn.ReadOnly = true;
            this.oceneKrajBrojDataGridViewTextBoxColumn.Width = 98;
            // 
            // ocenePoluJSONDgvc
            // 
            this.ocenePoluJSONDgvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ocenePoluJSONDgvc.DataPropertyName = "OcenePoluJSON";
            this.ocenePoluJSONDgvc.HeaderText = "Ocene PG JSON";
            this.ocenePoluJSONDgvc.Name = "ocenePoluJSONDgvc";
            this.ocenePoluJSONDgvc.ReadOnly = true;
            this.ocenePoluJSONDgvc.Width = 133;
            // 
            // oceneKrajJSONDgvc
            // 
            this.oceneKrajJSONDgvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.oceneKrajJSONDgvc.DataPropertyName = "OceneKrajJSON";
            this.oceneKrajJSONDgvc.HeaderText = "Ocene Kraj JSON";
            this.oceneKrajJSONDgvc.Name = "oceneKrajJSONDgvc";
            this.oceneKrajJSONDgvc.ReadOnly = true;
            this.oceneKrajJSONDgvc.Width = 137;
            // 
            // dgvcIspisan
            // 
            this.dgvcIspisan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcIspisan.DataPropertyName = "Ispisan";
            this.dgvcIspisan.HeaderText = "Ispisan";
            this.dgvcIspisan.Name = "dgvcIspisan";
            this.dgvcIspisan.ReadOnly = true;
            this.dgvcIspisan.Width = 56;
            // 
            // ZavrsObrazovanjaRezimeDgvc
            // 
            this.ZavrsObrazovanjaRezimeDgvc.DataPropertyName = "ZavrsObrazovanjaRezime";
            this.ZavrsObrazovanjaRezimeDgvc.HeaderText = "Zavrsetak Obraz.";
            this.ZavrsObrazovanjaRezimeDgvc.Name = "ZavrsObrazovanjaRezimeDgvc";
            this.ZavrsObrazovanjaRezimeDgvc.ReadOnly = true;
            this.ZavrsObrazovanjaRezimeDgvc.Width = 135;
            // 
            // napomeneDgvc
            // 
            this.napomeneDgvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.napomeneDgvc.DataPropertyName = "Napomene";
            this.napomeneDgvc.HeaderText = "Napomene";
            this.napomeneDgvc.MinimumWidth = 100;
            this.napomeneDgvc.Name = "napomeneDgvc";
            // 
            // FrmUcenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 512);
            this.Controls.Add(this.dgvUcenikSkGod);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUcenici";
            this.Text = "Učenici";
            this.Activated += new System.EventHandler(this.FrmUcenici_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUcenici_FormClosed);
            this.Load += new System.EventHandler(this.FrmUcenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.gbOceneUnos.ResumeLayout(false);
            this.gbOceneUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenikSkGod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenikSkGod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JISP.Controls.UcLeftPanel pnlLeft;
        private System.Windows.Forms.BindingSource bsUcenici;
        private Data.Ds ds;
        private Controls.UcFilterTextBox txtFilter;
        private Controls.UcButton btnSaveData;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private Controls.UcExitAppButton ucExitApp1;
        private Controls.UcButton btnNoviUcenici;
        private System.Windows.Forms.GroupBox gbOceneUnos;
        private System.Windows.Forms.Label lblOceneProsek;
        private System.Windows.Forms.Button btnOcenePaste;
        private System.Windows.Forms.CheckBox chkOceneSaVladanjem;
        private System.Windows.Forms.ToolTip ttOceneProvera;
        private Controls.UcButton btnDohvatiPodatke;
        private System.Windows.Forms.ComboBox cmbPodaciZaDohvatanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrezime;
        private Controls.UcDGV dgvUcenikSkGod;
        private System.Windows.Forms.BindingSource bsUcenikSkGod;
        private System.Windows.Forms.CheckBox chkCopyOnClick;
        private System.Windows.Forms.CheckBox chkAktivni;
        private Controls.UcButton btnOdRaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrezimeDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeRoditeljaDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcJMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrebivaliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn skGodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeljenjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcStaresina;
        private System.Windows.Forms.DataGridViewTextBoxColumn smerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDomGrupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DanaDoRodj;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Godine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenePoluBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oceneKrajBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenePoluJSONDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn oceneKrajJSONDgvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcIspisan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZavrsObrazovanjaRezimeDgvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomeneDgvc;
    }
}