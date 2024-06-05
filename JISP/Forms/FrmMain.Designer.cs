namespace JISP.Forms
{
    partial class FrmMain
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblApiTokenCaption = new System.Windows.Forms.Label();
            this.lblApiToken = new System.Windows.Forms.Label();
            this.ttApiToken = new System.Windows.Forms.ToolTip(this.components);
            this.lblDataFolder = new System.Windows.Forms.Label();
            this.ttDataFolder = new System.Windows.Forms.ToolTip(this.components);
            this.cmbBrowser = new System.Windows.Forms.ComboBox();
            this.cmbSkolskaGodina = new System.Windows.Forms.ComboBox();
            this.btnPrikaziPoruke = new System.Windows.Forms.Button();
            this.numHttpTimeoutShort = new System.Windows.Forms.NumericUpDown();
            this.numHttpTimeoutLong = new System.Windows.Forms.NumericUpDown();
            this.bsRodjZap = new System.Windows.Forms.BindingSource(this.components);
            this.dsTemp = new JISP.Data.DsTemp();
            this.dgvRodjZap = new JISP.Controls.UcDGV();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaDoRodjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLat2Cir = new JISP.Controls.UcButton();
            this.btnCir2Lat = new JISP.Controls.UcButton();
            this.btnFormAutoInput = new JISP.Controls.UcButton();
            this.btnTest = new JISP.Controls.UcButton();
            this.btnProstorije = new JISP.Controls.UcButton();
            this.btnBackup = new JISP.Controls.UcButton();
            this.btnZaposleni = new JISP.Controls.UcButton();
            this.btnUcenici = new JISP.Controls.UcButton();
            this.tcRodjendanci = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucDGV1 = new JISP.Controls.UcDGV();
            this.imePrezimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skolaOdeljenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godineDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaDoRodjDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodjendaniUcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numRodjPre = new System.Windows.Forms.NumericUpDown();
            this.numRodjPosle = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHttpTimeoutShort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHttpTimeoutLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRodjZap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodjZap)).BeginInit();
            this.tcRodjendanci.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodjendaniUcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRodjPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRodjPosle)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(69, 227);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 18);
            label2.TabIndex = 6;
            label2.Text = "Folder sa podacima:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(69, 281);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 18);
            label1.TabIndex = 8;
            label1.Text = "Internet Browser:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(69, 308);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 18);
            label3.TabIndex = 10;
            label3.Text = "Školska Godina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(69, 254);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 18);
            label4.TabIndex = 6;
            label4.Text = "Poruke:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(347, 281);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(158, 18);
            label5.TabIndex = 11;
            label5.Text = "HTTP tajmaut (kratak):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(347, 309);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(141, 18);
            label6.TabIndex = 13;
            label6.Text = "HTTP tajmaut (dug):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(76, 533);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(98, 18);
            label7.TabIndex = 21;
            label7.Text = "Dana pre rođ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(223, 533);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(113, 18);
            label8.TabIndex = 22;
            label8.Text = "Dana posle rođ:";
            // 
            // lblApiTokenCaption
            // 
            this.lblApiTokenCaption.AutoSize = true;
            this.lblApiTokenCaption.Location = new System.Drawing.Point(69, 201);
            this.lblApiTokenCaption.Name = "lblApiTokenCaption";
            this.lblApiTokenCaption.Size = new System.Drawing.Size(80, 18);
            this.lblApiTokenCaption.TabIndex = 4;
            this.lblApiTokenCaption.Text = "API Token:";
            // 
            // lblApiToken
            // 
            this.lblApiToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApiToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblApiToken.Location = new System.Drawing.Point(210, 198);
            this.lblApiToken.Name = "lblApiToken";
            this.lblApiToken.Size = new System.Drawing.Size(338, 24);
            this.lblApiToken.TabIndex = 6;
            this.lblApiToken.Click += new System.EventHandler(this.LblApiToken_Click);
            // 
            // lblDataFolder
            // 
            this.lblDataFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDataFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDataFolder.Location = new System.Drawing.Point(210, 224);
            this.lblDataFolder.Name = "lblDataFolder";
            this.lblDataFolder.Size = new System.Drawing.Size(338, 24);
            this.lblDataFolder.TabIndex = 7;
            this.lblDataFolder.Click += new System.EventHandler(this.LblDataFolder_Click);
            // 
            // cmbBrowser
            // 
            this.cmbBrowser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrowser.FormattingEnabled = true;
            this.cmbBrowser.Items.AddRange(new object[] {
            "Chrome",
            "MS Edge"});
            this.cmbBrowser.Location = new System.Drawing.Point(210, 278);
            this.cmbBrowser.Name = "cmbBrowser";
            this.cmbBrowser.Size = new System.Drawing.Size(121, 25);
            this.cmbBrowser.TabIndex = 9;
            this.cmbBrowser.SelectedIndexChanged += new System.EventHandler(this.CmbBrowser_SelectedIndexChanged);
            // 
            // cmbSkolskaGodina
            // 
            this.cmbSkolskaGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkolskaGodina.FormattingEnabled = true;
            this.cmbSkolskaGodina.Items.AddRange(new object[] {
            "Chrome",
            "MS Edge"});
            this.cmbSkolskaGodina.Location = new System.Drawing.Point(210, 305);
            this.cmbSkolskaGodina.Name = "cmbSkolskaGodina";
            this.cmbSkolskaGodina.Size = new System.Drawing.Size(121, 25);
            this.cmbSkolskaGodina.TabIndex = 10;
            this.cmbSkolskaGodina.SelectedIndexChanged += new System.EventHandler(this.CmbSkolskaGodina_SelectedIndexChanged);
            // 
            // btnPrikaziPoruke
            // 
            this.btnPrikaziPoruke.Location = new System.Drawing.Point(209, 250);
            this.btnPrikaziPoruke.Name = "btnPrikaziPoruke";
            this.btnPrikaziPoruke.Size = new System.Drawing.Size(121, 26);
            this.btnPrikaziPoruke.TabIndex = 8;
            this.btnPrikaziPoruke.Text = "Prikaži poruke";
            this.btnPrikaziPoruke.UseVisualStyleBackColor = true;
            this.btnPrikaziPoruke.Click += new System.EventHandler(this.BtnPrikaziPoruke_Click);
            // 
            // numHttpTimeoutShort
            // 
            this.numHttpTimeoutShort.Location = new System.Drawing.Point(508, 279);
            this.numHttpTimeoutShort.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numHttpTimeoutShort.Name = "numHttpTimeoutShort";
            this.numHttpTimeoutShort.Size = new System.Drawing.Size(40, 24);
            this.numHttpTimeoutShort.TabIndex = 12;
            this.numHttpTimeoutShort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHttpTimeoutShort.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numHttpTimeoutShort.ValueChanged += new System.EventHandler(this.NumHttpTimeoutShort_ValueChanged);
            // 
            // numHttpTimeoutLong
            // 
            this.numHttpTimeoutLong.Location = new System.Drawing.Point(508, 307);
            this.numHttpTimeoutLong.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numHttpTimeoutLong.Name = "numHttpTimeoutLong";
            this.numHttpTimeoutLong.Size = new System.Drawing.Size(40, 24);
            this.numHttpTimeoutLong.TabIndex = 14;
            this.numHttpTimeoutLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHttpTimeoutLong.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numHttpTimeoutLong.ValueChanged += new System.EventHandler(this.NumHttpTimeoutLong_ValueChanged);
            // 
            // bsRodjZap
            // 
            this.bsRodjZap.DataMember = "RodjendaniZap";
            this.bsRodjZap.DataSource = this.dsTemp;
            this.bsRodjZap.Sort = "DanaDoRodj";
            // 
            // dsTemp
            // 
            this.dsTemp.DataSetName = "DsTemp";
            this.dsTemp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvRodjZap
            // 
            this.dgvRodjZap.AllowUserToAddRows = false;
            this.dgvRodjZap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRodjZap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRodjZap.AutoGenerateColumns = false;
            this.dgvRodjZap.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRodjZap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRodjZap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imePrezimeDataGridViewTextBoxColumn,
            this.godineDataGridViewTextBoxColumn,
            this.danaDoRodjDataGridViewTextBoxColumn});
            this.dgvRodjZap.ColumnsForCopyOnClick = null;
            this.dgvRodjZap.CopyOnCellClick = false;
            this.dgvRodjZap.CtrlDisplayPositionRowCount = null;
            this.dgvRodjZap.DataSource = this.bsRodjZap;
            this.dgvRodjZap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRodjZap.Location = new System.Drawing.Point(3, 3);
            this.dgvRodjZap.Name = "dgvRodjZap";
            this.dgvRodjZap.ReadOnly = true;
            this.dgvRodjZap.RowHeadersWidth = 4;
            this.dgvRodjZap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRodjZap.Size = new System.Drawing.Size(462, 138);
            this.dgvRodjZap.StandardSort = null;
            this.dgvRodjZap.TabIndex = 17;
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "Zaposleni";
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            this.imePrezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godineDataGridViewTextBoxColumn
            // 
            this.godineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.godineDataGridViewTextBoxColumn.DataPropertyName = "Godine";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.godineDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.godineDataGridViewTextBoxColumn.HeaderText = "God.";
            this.godineDataGridViewTextBoxColumn.Name = "godineDataGridViewTextBoxColumn";
            this.godineDataGridViewTextBoxColumn.ReadOnly = true;
            this.godineDataGridViewTextBoxColumn.Width = 66;
            // 
            // danaDoRodjDataGridViewTextBoxColumn
            // 
            this.danaDoRodjDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.danaDoRodjDataGridViewTextBoxColumn.DataPropertyName = "DanaDoRodj";
            this.danaDoRodjDataGridViewTextBoxColumn.HeaderText = "Do Rođ.";
            this.danaDoRodjDataGridViewTextBoxColumn.Name = "danaDoRodjDataGridViewTextBoxColumn";
            this.danaDoRodjDataGridViewTextBoxColumn.ReadOnly = true;
            this.danaDoRodjDataGridViewTextBoxColumn.Width = 89;
            // 
            // btnLat2Cir
            // 
            this.btnLat2Cir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLat2Cir.Location = new System.Drawing.Point(413, 113);
            this.btnLat2Cir.Name = "btnLat2Cir";
            this.btnLat2Cir.Size = new System.Drawing.Size(135, 24);
            this.btnLat2Cir.TabIndex = 16;
            this.btnLat2Cir.Text = "Latinica -> Ćirilica";
            this.btnLat2Cir.ToolTipText = "Automatsko, šablonsko popunjavanje formi\r\n";
            this.btnLat2Cir.UseVisualStyleBackColor = true;
            this.btnLat2Cir.Click += new System.EventHandler(this.BtnLat2Cir_Click);
            this.btnLat2Cir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLat2Cir_MouseUp);
            // 
            // btnCir2Lat
            // 
            this.btnCir2Lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCir2Lat.Location = new System.Drawing.Point(413, 90);
            this.btnCir2Lat.Name = "btnCir2Lat";
            this.btnCir2Lat.Size = new System.Drawing.Size(135, 24);
            this.btnCir2Lat.TabIndex = 15;
            this.btnCir2Lat.Text = "Ćirilica -> Latinica";
            this.btnCir2Lat.ToolTipText = "";
            this.btnCir2Lat.UseVisualStyleBackColor = true;
            this.btnCir2Lat.Click += new System.EventHandler(this.BtnCir2Lat_Click);
            this.btnCir2Lat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCir2Lat_MouseUp);
            // 
            // btnFormAutoInput
            // 
            this.btnFormAutoInput.Location = new System.Drawing.Point(241, 90);
            this.btnFormAutoInput.Name = "btnFormAutoInput";
            this.btnFormAutoInput.Size = new System.Drawing.Size(135, 48);
            this.btnFormAutoInput.TabIndex = 3;
            this.btnFormAutoInput.Text = "&Form Auto Input";
            this.btnFormAutoInput.ToolTipText = "Automatsko, šablonsko popunjavanje formi\r\n";
            this.btnFormAutoInput.UseVisualStyleBackColor = true;
            this.btnFormAutoInput.Click += new System.EventHandler(this.BtnFormAutoInput_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(69, 144);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(135, 29);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.ToolTipText = "Čuvanje podataka iz DataSet-a u posebnom XML fajlu.";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // btnProstorije
            // 
            this.btnProstorije.Location = new System.Drawing.Point(241, 36);
            this.btnProstorije.Name = "btnProstorije";
            this.btnProstorije.Size = new System.Drawing.Size(135, 48);
            this.btnProstorije.TabIndex = 2;
            this.btnProstorije.Text = "&Prostorije";
            this.btnProstorije.ToolTipText = null;
            this.btnProstorije.UseVisualStyleBackColor = true;
            this.btnProstorije.Click += new System.EventHandler(this.BtnProstorije_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(413, 36);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(135, 48);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "BackUp";
            this.btnBackup.ToolTipText = "Čuvanje podataka iz DataSet-a u posebnom XML fajlu.";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(69, 36);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(135, 48);
            this.btnZaposleni.TabIndex = 0;
            this.btnZaposleni.Text = "&Zaposleni";
            this.btnZaposleni.ToolTipText = null;
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.BtnZaposleni_Click);
            // 
            // btnUcenici
            // 
            this.btnUcenici.Location = new System.Drawing.Point(69, 90);
            this.btnUcenici.Name = "btnUcenici";
            this.btnUcenici.Size = new System.Drawing.Size(135, 48);
            this.btnUcenici.TabIndex = 1;
            this.btnUcenici.Text = "&Učenici";
            this.btnUcenici.ToolTipText = null;
            this.btnUcenici.UseVisualStyleBackColor = true;
            this.btnUcenici.Click += new System.EventHandler(this.BtnUcenici_Click);
            // 
            // tcRodjendanci
            // 
            this.tcRodjendanci.Controls.Add(this.tabPage1);
            this.tcRodjendanci.Controls.Add(this.tabPage2);
            this.tcRodjendanci.Location = new System.Drawing.Point(72, 356);
            this.tcRodjendanci.Name = "tcRodjendanci";
            this.tcRodjendanci.SelectedIndex = 0;
            this.tcRodjendanci.Size = new System.Drawing.Size(476, 174);
            this.tcRodjendanci.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcRodjendanci.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRodjZap);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 144);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zaposleni";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucDGV1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Učenici";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucDGV1
            // 
            this.ucDGV1.AllowUserToAddRows = false;
            this.ucDGV1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucDGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ucDGV1.AutoGenerateColumns = false;
            this.ucDGV1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ucDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucDGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imePrezimeDataGridViewTextBoxColumn1,
            this.skolaOdeljenjeDataGridViewTextBoxColumn,
            this.godineDataGridViewTextBoxColumn1,
            this.danaDoRodjDataGridViewTextBoxColumn1});
            this.ucDGV1.ColumnsForCopyOnClick = null;
            this.ucDGV1.CopyOnCellClick = false;
            this.ucDGV1.CtrlDisplayPositionRowCount = null;
            this.ucDGV1.DataSource = this.rodjendaniUcBindingSource;
            this.ucDGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDGV1.Location = new System.Drawing.Point(3, 3);
            this.ucDGV1.Name = "ucDGV1";
            this.ucDGV1.ReadOnly = true;
            this.ucDGV1.RowHeadersWidth = 4;
            this.ucDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ucDGV1.Size = new System.Drawing.Size(462, 138);
            this.ucDGV1.StandardSort = null;
            this.ucDGV1.TabIndex = 0;
            // 
            // imePrezimeDataGridViewTextBoxColumn1
            // 
            this.imePrezimeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imePrezimeDataGridViewTextBoxColumn1.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn1.HeaderText = "Učenik";
            this.imePrezimeDataGridViewTextBoxColumn1.Name = "imePrezimeDataGridViewTextBoxColumn1";
            this.imePrezimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // skolaOdeljenjeDataGridViewTextBoxColumn
            // 
            this.skolaOdeljenjeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.skolaOdeljenjeDataGridViewTextBoxColumn.DataPropertyName = "SkolaOdeljenje";
            this.skolaOdeljenjeDataGridViewTextBoxColumn.HeaderText = "Odeljenje";
            this.skolaOdeljenjeDataGridViewTextBoxColumn.Name = "skolaOdeljenjeDataGridViewTextBoxColumn";
            this.skolaOdeljenjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.skolaOdeljenjeDataGridViewTextBoxColumn.Width = 94;
            // 
            // godineDataGridViewTextBoxColumn1
            // 
            this.godineDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.godineDataGridViewTextBoxColumn1.DataPropertyName = "Godine";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.godineDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.godineDataGridViewTextBoxColumn1.HeaderText = "God";
            this.godineDataGridViewTextBoxColumn1.Name = "godineDataGridViewTextBoxColumn1";
            this.godineDataGridViewTextBoxColumn1.ReadOnly = true;
            this.godineDataGridViewTextBoxColumn1.Width = 62;
            // 
            // danaDoRodjDataGridViewTextBoxColumn1
            // 
            this.danaDoRodjDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.danaDoRodjDataGridViewTextBoxColumn1.DataPropertyName = "DanaDoRodj";
            this.danaDoRodjDataGridViewTextBoxColumn1.HeaderText = "Do Rođ";
            this.danaDoRodjDataGridViewTextBoxColumn1.Name = "danaDoRodjDataGridViewTextBoxColumn1";
            this.danaDoRodjDataGridViewTextBoxColumn1.ReadOnly = true;
            this.danaDoRodjDataGridViewTextBoxColumn1.Width = 85;
            // 
            // rodjendaniUcBindingSource
            // 
            this.rodjendaniUcBindingSource.DataMember = "RodjendaniUc";
            this.rodjendaniUcBindingSource.DataSource = this.dsTemp;
            // 
            // numRodjPre
            // 
            this.numRodjPre.Location = new System.Drawing.Point(170, 530);
            this.numRodjPre.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numRodjPre.Name = "numRodjPre";
            this.numRodjPre.Size = new System.Drawing.Size(41, 24);
            this.numRodjPre.TabIndex = 19;
            this.numRodjPre.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numRodjPre.ValueChanged += new System.EventHandler(this.NumRodj_ValueChanged);
            // 
            // numRodjPosle
            // 
            this.numRodjPosle.Location = new System.Drawing.Point(332, 530);
            this.numRodjPosle.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numRodjPosle.Name = "numRodjPosle";
            this.numRodjPosle.Size = new System.Drawing.Size(41, 24);
            this.numRodjPosle.TabIndex = 20;
            this.numRodjPosle.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRodjPosle.ValueChanged += new System.EventHandler(this.NumRodj_ValueChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 578);
            this.Controls.Add(this.numRodjPosle);
            this.Controls.Add(this.numRodjPre);
            this.Controls.Add(label7);
            this.Controls.Add(label8);
            this.Controls.Add(this.tcRodjendanci);
            this.Controls.Add(this.btnLat2Cir);
            this.Controls.Add(this.btnCir2Lat);
            this.Controls.Add(this.numHttpTimeoutLong);
            this.Controls.Add(label6);
            this.Controls.Add(this.numHttpTimeoutShort);
            this.Controls.Add(label5);
            this.Controls.Add(this.btnFormAutoInput);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnPrikaziPoruke);
            this.Controls.Add(this.btnProstorije);
            this.Controls.Add(this.cmbSkolskaGodina);
            this.Controls.Add(label3);
            this.Controls.Add(this.cmbBrowser);
            this.Controls.Add(label1);
            this.Controls.Add(this.lblDataFolder);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(this.lblApiToken);
            this.Controls.Add(this.lblApiTokenCaption);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.btnUcenici);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JISP";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHttpTimeoutShort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHttpTimeoutLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRodjZap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodjZap)).EndInit();
            this.tcRodjendanci.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ucDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodjendaniUcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRodjPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRodjPosle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.UcButton btnUcenici;
        private Controls.UcButton btnZaposleni;
        private Controls.UcButton btnBackup;
        private System.Windows.Forms.Label lblApiTokenCaption;
        private System.Windows.Forms.Label lblApiToken;
        private System.Windows.Forms.ToolTip ttApiToken;
        private System.Windows.Forms.Label lblDataFolder;
        private System.Windows.Forms.ToolTip ttDataFolder;
        private System.Windows.Forms.ComboBox cmbBrowser;
        private System.Windows.Forms.ComboBox cmbSkolskaGodina;
        private Controls.UcButton btnProstorije;
        private System.Windows.Forms.Button btnPrikaziPoruke;
        private Controls.UcButton btnTest;
        private Controls.UcButton btnFormAutoInput;
        private System.Windows.Forms.NumericUpDown numHttpTimeoutShort;
        private System.Windows.Forms.NumericUpDown numHttpTimeoutLong;
        private Controls.UcButton btnCir2Lat;
        private Controls.UcButton btnLat2Cir;
        private Controls.UcDGV dgvRodjZap;
        private System.Windows.Forms.BindingSource bsRodjZap;
        private Data.DsTemp dsTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaDoRodjDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tcRodjendanci;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numRodjPre;
        private System.Windows.Forms.NumericUpDown numRodjPosle;
        private Controls.UcDGV ucDGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolaOdeljenjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godineDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaDoRodjDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource rodjendaniUcBindingSource;
    }
}

