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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsUcenici = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttOceneProvera = new System.Windows.Forms.ToolTip(this.components);
            this.dgvUcenici = new JISP.Controls.UcDGV();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.btnDohvatiPodatke = new JISP.Controls.UcButton();
            this.cmbPodaciZaDohvatanje = new System.Windows.Forms.ComboBox();
            this.chkSamoTekuci = new System.Windows.Forms.CheckBox();
            this.gbOceneUnos = new System.Windows.Forms.GroupBox();
            this.lblOceneProsek = new System.Windows.Forms.Label();
            this.btnOcenePaste = new System.Windows.Forms.Button();
            this.chkOceneSaVladanjem = new System.Windows.Forms.CheckBox();
            this.btnNoviUcenici = new JISP.Controls.UcButton();
            this.ucExitApp1 = new JISP.Controls.UcExitAppButton();
            this.btnSaveData = new JISP.Controls.UcButton();
            this.txtFilter = new JISP.Controls.UcFilterTextBox();
            this.dgvcIdUcenika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcJOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSkola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcRazred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOdeljenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNapomene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDatRodj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDanaDoRodj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGodine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcBrojOcenaPolu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOcenePgJson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojOcenaKraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOceneKrajJson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcZavrsObrazovanjaJSON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.gbOceneUnos.SuspendLayout();
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
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 17);
            this.lblStatus.Text = "/";
            // 
            // dgvUcenici
            // 
            this.dgvUcenici.AllowUserToAddRows = false;
            this.dgvUcenici.AllowUserToDeleteRows = false;
            this.dgvUcenici.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUcenici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUcenici.AutoGenerateColumns = false;
            this.dgvUcenici.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUcenici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIdUcenika,
            this.dgvcIme,
            this.dgvcPrezime,
            this.dgvcJOB,
            this.dgvcSkola,
            this.dgvcRazred,
            this.dgvcOdeljenje,
            this.dgvcNapomene,
            this.dgvcPol,
            this.dgvcDatRodj,
            this.dgvcDanaDoRodj,
            this.dgvcGodine,
            this.dgvcBrojOcenaPolu,
            this.dgvcOcenePgJson,
            this.BrojOcenaKraj,
            this.dgvcOceneKrajJson,
            this.dgvcZavrsObrazovanjaJSON,
            this.dgvcSmer});
            this.dgvUcenici.ColumnsForCopyOnClick = null;
            this.dgvUcenici.CopyOnCellClick = false;
            this.dgvUcenici.CtrlDisplayPositionRowCount = this.lblRowCount;
            this.dgvUcenici.DataSource = this.bsUcenici;
            this.dgvUcenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUcenici.Location = new System.Drawing.Point(150, 0);
            this.dgvUcenici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.RowHeadersWidth = 30;
            this.dgvUcenici.RowTemplate.Height = 24;
            this.dgvUcenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcenici.Size = new System.Drawing.Size(1147, 490);
            this.dgvUcenici.StandardSort = null;
            this.dgvUcenici.StandardTab = true;
            this.dgvUcenici.TabIndex = 1;
            this.dgvUcenici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUcenici_CellDoubleClick);
            this.dgvUcenici.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dgv_DataError);
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(4, 66);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(56, 16);
            this.lblRowCount.TabIndex = 1;
            this.lblRowCount.Text = "Redova";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnDohvatiPodatke);
            this.pnlLeft.Controls.Add(this.cmbPodaciZaDohvatanje);
            this.pnlLeft.Controls.Add(this.chkSamoTekuci);
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
            // btnDohvatiPodatke
            // 
            this.btnDohvatiPodatke.Location = new System.Drawing.Point(7, 245);
            this.btnDohvatiPodatke.Name = "btnDohvatiPodatke";
            this.btnDohvatiPodatke.Size = new System.Drawing.Size(127, 30);
            this.btnDohvatiPodatke.TabIndex = 12;
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
            this.cmbPodaciZaDohvatanje.Location = new System.Drawing.Point(7, 220);
            this.cmbPodaciZaDohvatanje.Name = "cmbPodaciZaDohvatanje";
            this.cmbPodaciZaDohvatanje.Size = new System.Drawing.Size(127, 24);
            this.cmbPodaciZaDohvatanje.TabIndex = 11;
            // 
            // chkSamoTekuci
            // 
            this.chkSamoTekuci.AutoSize = true;
            this.chkSamoTekuci.Checked = true;
            this.chkSamoTekuci.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSamoTekuci.Location = new System.Drawing.Point(7, 115);
            this.chkSamoTekuci.Name = "chkSamoTekuci";
            this.chkSamoTekuci.Size = new System.Drawing.Size(100, 20);
            this.chkSamoTekuci.TabIndex = 3;
            this.chkSamoTekuci.Text = "Samo tekući";
            this.chkSamoTekuci.UseVisualStyleBackColor = true;
            this.chkSamoTekuci.CheckedChanged += new System.EventHandler(this.ChkSamoTekuci_CheckedChanged);
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
            this.btnNoviUcenici.Location = new System.Drawing.Point(7, 142);
            this.btnNoviUcenici.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoviUcenici.Name = "btnNoviUcenici";
            this.btnNoviUcenici.Size = new System.Drawing.Size(127, 38);
            this.btnNoviUcenici.TabIndex = 5;
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
            this.ucExitApp1.TabIndex = 0;
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
            this.btnSaveData.TabIndex = 10;
            this.btnSaveData.Text = "Sačuvaj podatke";
            this.btnSaveData.ToolTipText = null;
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BindingSource = this.bsUcenici;
            this.txtFilter.Location = new System.Drawing.Point(7, 86);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(127, 22);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFilter_KeyDown);
            // 
            // dgvcIdUcenika
            // 
            this.dgvcIdUcenika.DataPropertyName = "IdUcenika";
            this.dgvcIdUcenika.HeaderText = "IdUcenika";
            this.dgvcIdUcenika.MinimumWidth = 6;
            this.dgvcIdUcenika.Name = "dgvcIdUcenika";
            this.dgvcIdUcenika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcIdUcenika.Visible = false;
            this.dgvcIdUcenika.Width = 125;
            // 
            // dgvcIme
            // 
            this.dgvcIme.DataPropertyName = "Ime";
            this.dgvcIme.HeaderText = "Učenik";
            this.dgvcIme.MinimumWidth = 6;
            this.dgvcIme.Name = "dgvcIme";
            this.dgvcIme.ReadOnly = true;
            this.dgvcIme.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcIme.Width = 225;
            // 
            // dgvcPrezime
            // 
            this.dgvcPrezime.DataPropertyName = "Prezime";
            this.dgvcPrezime.HeaderText = "Prezime";
            this.dgvcPrezime.MinimumWidth = 6;
            this.dgvcPrezime.Name = "dgvcPrezime";
            this.dgvcPrezime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcPrezime.Visible = false;
            this.dgvcPrezime.Width = 125;
            // 
            // dgvcJOB
            // 
            this.dgvcJOB.DataPropertyName = "JOB";
            this.dgvcJOB.HeaderText = "JOB";
            this.dgvcJOB.MinimumWidth = 6;
            this.dgvcJOB.Name = "dgvcJOB";
            this.dgvcJOB.ReadOnly = true;
            this.dgvcJOB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcJOB.Width = 165;
            // 
            // dgvcSkola
            // 
            this.dgvcSkola.DataPropertyName = "Skola";
            this.dgvcSkola.HeaderText = "Škola";
            this.dgvcSkola.MinimumWidth = 6;
            this.dgvcSkola.Name = "dgvcSkola";
            this.dgvcSkola.ReadOnly = true;
            this.dgvcSkola.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcSkola.Width = 80;
            // 
            // dgvcRazred
            // 
            this.dgvcRazred.DataPropertyName = "Razred";
            this.dgvcRazred.HeaderText = "Razred";
            this.dgvcRazred.MinimumWidth = 6;
            this.dgvcRazred.Name = "dgvcRazred";
            this.dgvcRazred.ReadOnly = true;
            this.dgvcRazred.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcRazred.Width = 85;
            // 
            // dgvcOdeljenje
            // 
            this.dgvcOdeljenje.DataPropertyName = "Odeljenje";
            this.dgvcOdeljenje.HeaderText = "Odeljenje";
            this.dgvcOdeljenje.MinimumWidth = 6;
            this.dgvcOdeljenje.Name = "dgvcOdeljenje";
            this.dgvcOdeljenje.ReadOnly = true;
            this.dgvcOdeljenje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcOdeljenje.Width = 95;
            // 
            // dgvcNapomene
            // 
            this.dgvcNapomene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcNapomene.DataPropertyName = "Napomene";
            this.dgvcNapomene.HeaderText = "Napomene";
            this.dgvcNapomene.MinimumWidth = 100;
            this.dgvcNapomene.Name = "dgvcNapomene";
            this.dgvcNapomene.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcPol
            // 
            this.dgvcPol.DataPropertyName = "Pol";
            this.dgvcPol.HeaderText = "Pol";
            this.dgvcPol.MinimumWidth = 6;
            this.dgvcPol.Name = "dgvcPol";
            this.dgvcPol.ReadOnly = true;
            this.dgvcPol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcPol.Width = 56;
            // 
            // dgvcDatRodj
            // 
            this.dgvcDatRodj.DataPropertyName = "DatumRodjenja";
            this.dgvcDatRodj.HeaderText = "Dat Rođ";
            this.dgvcDatRodj.MinimumWidth = 6;
            this.dgvcDatRodj.Name = "dgvcDatRodj";
            this.dgvcDatRodj.ReadOnly = true;
            this.dgvcDatRodj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDatRodj.ToolTipText = "Datum rođenja";
            this.dgvcDatRodj.Width = 90;
            // 
            // dgvcDanaDoRodj
            // 
            this.dgvcDanaDoRodj.DataPropertyName = "DanaDoRodj";
            this.dgvcDanaDoRodj.HeaderText = "Do Rođ";
            this.dgvcDanaDoRodj.MinimumWidth = 6;
            this.dgvcDanaDoRodj.Name = "dgvcDanaDoRodj";
            this.dgvcDanaDoRodj.ReadOnly = true;
            this.dgvcDanaDoRodj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDanaDoRodj.ToolTipText = "Broj dana do rođendana";
            this.dgvcDanaDoRodj.Width = 85;
            // 
            // dgvcGodine
            // 
            this.dgvcGodine.DataPropertyName = "Godine";
            dataGridViewCellStyle3.Format = "N1";
            this.dgvcGodine.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcGodine.HeaderText = "Godine";
            this.dgvcGodine.MinimumWidth = 6;
            this.dgvcGodine.Name = "dgvcGodine";
            this.dgvcGodine.ReadOnly = true;
            this.dgvcGodine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcGodine.ToolTipText = "Starost učenika";
            this.dgvcGodine.Width = 80;
            // 
            // dgvcBrojOcenaPolu
            // 
            this.dgvcBrojOcenaPolu.DataPropertyName = "BrojOcenaPolu";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcBrojOcenaPolu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcBrojOcenaPolu.HeaderText = "oc PG";
            this.dgvcBrojOcenaPolu.Name = "dgvcBrojOcenaPolu";
            this.dgvcBrojOcenaPolu.ReadOnly = true;
            this.dgvcBrojOcenaPolu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcBrojOcenaPolu.ToolTipText = "Broj ocena na polugodištu";
            this.dgvcBrojOcenaPolu.Width = 70;
            // 
            // dgvcOcenePgJson
            // 
            this.dgvcOcenePgJson.DataPropertyName = "OcenePG";
            this.dgvcOcenePgJson.HeaderText = "OcenePG";
            this.dgvcOcenePgJson.Name = "dgvcOcenePgJson";
            this.dgvcOcenePgJson.ReadOnly = true;
            // 
            // BrojOcenaKraj
            // 
            this.BrojOcenaKraj.DataPropertyName = "BrojOcenaKraj";
            this.BrojOcenaKraj.HeaderText = "oc kraj";
            this.BrojOcenaKraj.Name = "BrojOcenaKraj";
            this.BrojOcenaKraj.ReadOnly = true;
            // 
            // dgvcOceneKrajJson
            // 
            this.dgvcOceneKrajJson.DataPropertyName = "OceneKraj";
            this.dgvcOceneKrajJson.HeaderText = "OceneKraj";
            this.dgvcOceneKrajJson.Name = "dgvcOceneKrajJson";
            this.dgvcOceneKrajJson.ReadOnly = true;
            // 
            // dgvcZavrsObrazovanjaJSON
            // 
            this.dgvcZavrsObrazovanjaJSON.DataPropertyName = "ZavrsObrazovanjaJSON";
            this.dgvcZavrsObrazovanjaJSON.HeaderText = "Zavrs Obraz";
            this.dgvcZavrsObrazovanjaJSON.Name = "dgvcZavrsObrazovanjaJSON";
            this.dgvcZavrsObrazovanjaJSON.ReadOnly = true;
            // 
            // dgvcSmer
            // 
            this.dgvcSmer.DataPropertyName = "Smer";
            this.dgvcSmer.HeaderText = "Smer";
            this.dgvcSmer.Name = "dgvcSmer";
            this.dgvcSmer.ReadOnly = true;
            this.dgvcSmer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcSmer.Width = 110;
            // 
            // FrmUcenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 512);
            this.Controls.Add(this.dgvUcenici);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::JISP.Properties.Resources.grb_srb;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.gbOceneUnos.ResumeLayout(false);
            this.gbOceneUnos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JISP.Controls.UcLeftPanel pnlLeft;
        private Controls.UcDGV dgvUcenici;
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
        private System.Windows.Forms.CheckBox chkSamoTekuci;
        private Controls.UcButton btnDohvatiPodatke;
        private System.Windows.Forms.ComboBox cmbPodaciZaDohvatanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIdUcenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcJOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSkola;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcRazred;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOdeljenje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNapomene;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDatRodj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDanaDoRodj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGodine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcBrojOcenaPolu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOcenePgJson;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojOcenaKraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOceneKrajJson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcZavrsObrazovanjaJSON;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSmer;
    }
}