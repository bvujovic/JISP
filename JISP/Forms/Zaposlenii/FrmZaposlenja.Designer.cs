namespace JISP.Forms
{
    partial class FrmZaposlenja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.chkCopyOnClick = new System.Windows.Forms.CheckBox();
            this.btnUcitajZaposlenja = new JISP.Controls.UcButton();
            this.btnExit = new JISP.Controls.UcExitAppButton();
            this.cmbZamenjeni = new System.Windows.Forms.ComboBox();
            this.bsZaposleni = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.btnUcitajAngazovanja = new JISP.Controls.UcButton();
            this.pnlZaposleniTop = new System.Windows.Forms.Panel();
            this.chkBezTehnGresaka = new System.Windows.Forms.CheckBox();
            this.btnZamenjeniBrisi = new System.Windows.Forms.Button();
            this.lblZamenjeni = new System.Windows.Forms.Label();
            this.chkAktivno = new System.Windows.Forms.CheckBox();
            this.lblBrojRedovaZaposlenja = new System.Windows.Forms.Label();
            this.dgvZaposlenjaSvSava = new JISP.Controls.UcDGV();
            this.bsZaposlenja = new System.Windows.Forms.BindingSource(this.components);
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tcZaposlenja = new System.Windows.Forms.TabControl();
            this.tpZaposSvetiSava = new System.Windows.Forms.TabPage();
            this.tpZaposSva = new System.Windows.Forms.TabPage();
            this.dgvSvaZaposlenja = new JISP.Controls.UcDGV();
            this.procenatAngazovanjaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipaPoslodavcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsTipoviPoslodavaca = new System.Windows.Forms.BindingSource(this.components);
            this.nazivPoslodavcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcZaposSvaNapomene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblZaposSvaBrojRedova = new System.Windows.Forms.Label();
            this.bsSvaZaposlenja = new System.Windows.Forms.BindingSource(this.components);
            this.pnlZaposSvaTop = new System.Windows.Forms.Panel();
            this.btnNovoEkstZaposlenje = new JISP.Controls.UcButton();
            this.dtpStazDatumDo = new System.Windows.Forms.DateTimePicker();
            this.lblStazDatumDo = new System.Windows.Forms.Label();
            this.lblUkupanStaz = new System.Windows.Forms.Label();
            this.tcBottom = new System.Windows.Forms.TabControl();
            this.tpObracunZarada = new System.Windows.Forms.TabPage();
            this.dgvObracunZarada = new JISP.Controls.UcDGV();
            this.brojUgovoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesecNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osnovniKoefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatniKoefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOzKoefZaStaresinstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoefSveOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOzStaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBrojRedovaOZ = new System.Windows.Forms.Label();
            this.bsObracunZarada = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottomLeftOZ = new JISP.Controls.UcLeftPanel();
            this.btnUcitajOzOpis = new JISP.Controls.UcButton();
            this.btnObrisiObracune = new JISP.Controls.UcButton();
            this.btnUcitajObracunZarada = new JISP.Controls.UcButton();
            this.tpAngazovanja = new System.Windows.Forms.TabPage();
            this.dgvAngazovanja = new JISP.Controls.UcDGV();
            this.skolskaGodinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvorFinansiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatAngazovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podnivoPredmetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAngazovanja = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottomLeftAng = new JISP.Controls.UcLeftPanel();
            this.tpResenja = new System.Windows.Forms.TabPage();
            this.dgvResenja = new JISP.Controls.UcDGV();
            this.brojResenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkolskaGodina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipResenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatAngPoResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPodnosenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcResDokument = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvcResAktivnoResenje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsResenja = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottomLeftRes = new JISP.Controls.UcLeftPanel();
            this.btnUcitajResenja = new JISP.Controls.UcButton();
            this.timSvaZapSelectAll = new System.Windows.Forms.Timer(this.components);
            this.aktivanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojUgovoraORaduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnoMestoNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatRadnogVremenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZaposlenOdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZaposlenDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcZapRazlogPrestanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noksNivoNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaAngazovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcZapZamenjeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcZapDokument = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposleni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.pnlZaposleniTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenjaSvSava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tcZaposlenja.SuspendLayout();
            this.tpZaposSvetiSava.SuspendLayout();
            this.tpZaposSva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvaZaposlenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoviPoslodavaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSvaZaposlenja)).BeginInit();
            this.pnlZaposSvaTop.SuspendLayout();
            this.tcBottom.SuspendLayout();
            this.tpObracunZarada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObracunZarada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObracunZarada)).BeginInit();
            this.pnlBottomLeftOZ.SuspendLayout();
            this.tpAngazovanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAngazovanja)).BeginInit();
            this.pnlBottomLeftAng.SuspendLayout();
            this.tpResenja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResenja)).BeginInit();
            this.pnlBottomLeftRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.chkCopyOnClick);
            this.pnlLeft.Controls.Add(this.btnUcitajZaposlenja);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(146, 652);
            this.pnlLeft.TabIndex = 2;
            // 
            // chkCopyOnClick
            // 
            this.chkCopyOnClick.AutoSize = true;
            this.chkCopyOnClick.Location = new System.Drawing.Point(8, 64);
            this.chkCopyOnClick.Name = "chkCopyOnClick";
            this.chkCopyOnClick.Size = new System.Drawing.Size(135, 22);
            this.chkCopyOnClick.TabIndex = 6;
            this.chkCopyOnClick.Text = "Kopiranje na klik";
            this.chkCopyOnClick.UseVisualStyleBackColor = true;
            this.chkCopyOnClick.CheckedChanged += new System.EventHandler(this.ChkCopyOnClick_CheckedChanged);
            // 
            // btnUcitajZaposlenja
            // 
            this.btnUcitajZaposlenja.Location = new System.Drawing.Point(8, 92);
            this.btnUcitajZaposlenja.Name = "btnUcitajZaposlenja";
            this.btnUcitajZaposlenja.Size = new System.Drawing.Size(128, 40);
            this.btnUcitajZaposlenja.TabIndex = 1;
            this.btnUcitajZaposlenja.Text = "Učitaj zaposlenja";
            this.btnUcitajZaposlenja.ToolTipText = "Dohvatanje podataka o zaposlenjima";
            this.btnUcitajZaposlenja.UseVisualStyleBackColor = true;
            this.btnUcitajZaposlenja.Click += new System.EventHandler(this.BtnUcitajZaposlenja_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(8, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Izlaz";
            this.btnExit.ToolTipText = "Izlaz iz aplikacije";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // cmbZamenjeni
            // 
            this.cmbZamenjeni.DataSource = this.bsZaposleni;
            this.cmbZamenjeni.DisplayMember = "ZaposleniString";
            this.cmbZamenjeni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZamenjeni.FormattingEnabled = true;
            this.cmbZamenjeni.Location = new System.Drawing.Point(526, 1);
            this.cmbZamenjeni.Name = "cmbZamenjeni";
            this.cmbZamenjeni.Size = new System.Drawing.Size(255, 26);
            this.cmbZamenjeni.TabIndex = 7;
            this.cmbZamenjeni.ValueMember = "IdZaposlenog";
            this.cmbZamenjeni.Visible = false;
            this.cmbZamenjeni.SelectedIndexChanged += new System.EventHandler(this.CmbZamenjeni_SelectedIndexChanged);
            // 
            // bsZaposleni
            // 
            this.bsZaposleni.DataMember = "Zaposleni";
            this.bsZaposleni.DataSource = this.ds;
            this.bsZaposleni.Sort = "Ime, Prezime";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUcitajAngazovanja
            // 
            this.btnUcitajAngazovanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajAngazovanja.Location = new System.Drawing.Point(3, 3);
            this.btnUcitajAngazovanja.Name = "btnUcitajAngazovanja";
            this.btnUcitajAngazovanja.Size = new System.Drawing.Size(135, 45);
            this.btnUcitajAngazovanja.TabIndex = 4;
            this.btnUcitajAngazovanja.Text = "Učitaj angažovanja";
            this.btnUcitajAngazovanja.ToolTipText = "Dohvatanje podataka o zaposlenjima";
            this.btnUcitajAngazovanja.UseVisualStyleBackColor = true;
            this.btnUcitajAngazovanja.Click += new System.EventHandler(this.BtnUcitajAngazovanja_Click);
            // 
            // pnlZaposleniTop
            // 
            this.pnlZaposleniTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZaposleniTop.Controls.Add(this.chkBezTehnGresaka);
            this.pnlZaposleniTop.Controls.Add(this.btnZamenjeniBrisi);
            this.pnlZaposleniTop.Controls.Add(this.lblZamenjeni);
            this.pnlZaposleniTop.Controls.Add(this.chkAktivno);
            this.pnlZaposleniTop.Controls.Add(this.cmbZamenjeni);
            this.pnlZaposleniTop.Controls.Add(this.lblBrojRedovaZaposlenja);
            this.pnlZaposleniTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlZaposleniTop.Location = new System.Drawing.Point(3, 3);
            this.pnlZaposleniTop.Name = "pnlZaposleniTop";
            this.pnlZaposleniTop.Size = new System.Drawing.Size(1135, 30);
            this.pnlZaposleniTop.TabIndex = 3;
            // 
            // chkBezTehnGresaka
            // 
            this.chkBezTehnGresaka.AutoSize = true;
            this.chkBezTehnGresaka.Checked = true;
            this.chkBezTehnGresaka.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBezTehnGresaka.Location = new System.Drawing.Point(279, 4);
            this.chkBezTehnGresaka.Name = "chkBezTehnGresaka";
            this.chkBezTehnGresaka.Size = new System.Drawing.Size(146, 22);
            this.chkBezTehnGresaka.TabIndex = 10;
            this.chkBezTehnGresaka.Text = "Bez tehn. grešaka";
            this.chkBezTehnGresaka.UseVisualStyleBackColor = true;
            this.chkBezTehnGresaka.CheckedChanged += new System.EventHandler(this.ChkBezTehnGresaka_CheckedChanged);
            // 
            // btnZamenjeniBrisi
            // 
            this.btnZamenjeniBrisi.Location = new System.Drawing.Point(780, 0);
            this.btnZamenjeniBrisi.Name = "btnZamenjeniBrisi";
            this.btnZamenjeniBrisi.Size = new System.Drawing.Size(28, 28);
            this.btnZamenjeniBrisi.TabIndex = 9;
            this.btnZamenjeniBrisi.Text = "X";
            this.btnZamenjeniBrisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamenjeniBrisi.UseVisualStyleBackColor = true;
            this.btnZamenjeniBrisi.Visible = false;
            this.btnZamenjeniBrisi.Click += new System.EventHandler(this.BtnZamenjeniBrisi_Click);
            // 
            // lblZamenjeni
            // 
            this.lblZamenjeni.AutoSize = true;
            this.lblZamenjeni.Location = new System.Drawing.Point(442, 5);
            this.lblZamenjeni.Name = "lblZamenjeni";
            this.lblZamenjeni.Size = new System.Drawing.Size(82, 18);
            this.lblZamenjeni.TabIndex = 8;
            this.lblZamenjeni.Text = "Zamena za";
            this.lblZamenjeni.Visible = false;
            // 
            // chkAktivno
            // 
            this.chkAktivno.AutoSize = true;
            this.chkAktivno.Checked = true;
            this.chkAktivno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktivno.Location = new System.Drawing.Point(197, 4);
            this.chkAktivno.Name = "chkAktivno";
            this.chkAktivno.Size = new System.Drawing.Size(75, 22);
            this.chkAktivno.TabIndex = 1;
            this.chkAktivno.Text = "Aktivno";
            this.chkAktivno.ThreeState = true;
            this.chkAktivno.UseVisualStyleBackColor = true;
            this.chkAktivno.CheckStateChanged += new System.EventHandler(this.ChkAktivno_CheckStateChanged);
            // 
            // lblBrojRedovaZaposlenja
            // 
            this.lblBrojRedovaZaposlenja.AutoSize = true;
            this.lblBrojRedovaZaposlenja.Location = new System.Drawing.Point(3, 5);
            this.lblBrojRedovaZaposlenja.Name = "lblBrojRedovaZaposlenja";
            this.lblBrojRedovaZaposlenja.Size = new System.Drawing.Size(59, 18);
            this.lblBrojRedovaZaposlenja.TabIndex = 6;
            this.lblBrojRedovaZaposlenja.Text = "Redova";
            // 
            // dgvZaposlenjaSvSava
            // 
            this.dgvZaposlenjaSvSava.AllowUserToAddRows = false;
            this.dgvZaposlenjaSvSava.AllowUserToDeleteRows = false;
            this.dgvZaposlenjaSvSava.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvZaposlenjaSvSava.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaposlenjaSvSava.AutoGenerateColumns = false;
            this.dgvZaposlenjaSvSava.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposlenjaSvSava.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZaposlenjaSvSava.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenjaSvSava.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aktivanDataGridViewCheckBoxColumn,
            this.Column1,
            this.brojUgovoraORaduDataGridViewTextBoxColumn,
            this.radnoMestoNazivDataGridViewTextBoxColumn,
            this.procenatRadnogVremenaDataGridViewTextBoxColumn,
            this.datumZaposlenOdDataGridViewTextBoxColumn,
            this.datumZaposlenDoDataGridViewTextBoxColumn,
            this.dgvcZapRazlogPrestanka,
            this.noksNivoNazivDataGridViewTextBoxColumn,
            this.vrstaAngazovanjaDataGridViewTextBoxColumn,
            this.dgvcZapZamenjeni,
            this.dgvcZapDokument});
            this.dgvZaposlenjaSvSava.ColumnsForCopyOnClick = null;
            this.dgvZaposlenjaSvSava.CopyOnCellClick = false;
            this.dgvZaposlenjaSvSava.CtrlDisplayPositionRowCount = this.lblBrojRedovaZaposlenja;
            this.dgvZaposlenjaSvSava.DataSource = this.bsZaposlenja;
            this.dgvZaposlenjaSvSava.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposlenjaSvSava.Location = new System.Drawing.Point(3, 33);
            this.dgvZaposlenjaSvSava.Name = "dgvZaposlenjaSvSava";
            this.dgvZaposlenjaSvSava.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvZaposlenjaSvSava.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvZaposlenjaSvSava.RowHeadersWidth = 30;
            this.dgvZaposlenjaSvSava.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenjaSvSava.Size = new System.Drawing.Size(1135, 257);
            this.dgvZaposlenjaSvSava.StandardSort = null;
            this.dgvZaposlenjaSvSava.TabIndex = 4;
            this.dgvZaposlenjaSvSava.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvZaposlenjaSve_CellClick);
            this.dgvZaposlenjaSvSava.SelectionChanged += new System.EventHandler(this.DgvZaposlenjaSve_SelectionChanged);
            // 
            // bsZaposlenja
            // 
            this.bsZaposlenja.DataMember = "Zaposlenja";
            this.bsZaposlenja.DataSource = this.ds;
            this.bsZaposlenja.Sort = "Aktivan DESC, DatumZaposlenOd DESC, DatumZaposlenDo DESC";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Location = new System.Drawing.Point(146, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tcZaposlenja);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tcBottom);
            this.scMain.Size = new System.Drawing.Size(1149, 652);
            this.scMain.SplitterDistance = 324;
            this.scMain.TabIndex = 5;
            // 
            // tcZaposlenja
            // 
            this.tcZaposlenja.Controls.Add(this.tpZaposSvetiSava);
            this.tcZaposlenja.Controls.Add(this.tpZaposSva);
            this.tcZaposlenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcZaposlenja.Location = new System.Drawing.Point(0, 0);
            this.tcZaposlenja.Name = "tcZaposlenja";
            this.tcZaposlenja.SelectedIndex = 0;
            this.tcZaposlenja.Size = new System.Drawing.Size(1149, 324);
            this.tcZaposlenja.TabIndex = 5;
            this.tcZaposlenja.SelectedIndexChanged += new System.EventHandler(this.TcZaposlenja_SelectedIndexChanged);
            // 
            // tpZaposSvetiSava
            // 
            this.tpZaposSvetiSava.BackColor = System.Drawing.SystemColors.Control;
            this.tpZaposSvetiSava.Controls.Add(this.dgvZaposlenjaSvSava);
            this.tpZaposSvetiSava.Controls.Add(this.pnlZaposleniTop);
            this.tpZaposSvetiSava.Location = new System.Drawing.Point(4, 27);
            this.tpZaposSvetiSava.Name = "tpZaposSvetiSava";
            this.tpZaposSvetiSava.Padding = new System.Windows.Forms.Padding(3);
            this.tpZaposSvetiSava.Size = new System.Drawing.Size(1141, 293);
            this.tpZaposSvetiSava.TabIndex = 0;
            this.tpZaposSvetiSava.Text = "ŠOSO Sveti Sava";
            // 
            // tpZaposSva
            // 
            this.tpZaposSva.BackColor = System.Drawing.SystemColors.Control;
            this.tpZaposSva.Controls.Add(this.dgvSvaZaposlenja);
            this.tpZaposSva.Controls.Add(this.pnlZaposSvaTop);
            this.tpZaposSva.Location = new System.Drawing.Point(4, 22);
            this.tpZaposSva.Name = "tpZaposSva";
            this.tpZaposSva.Padding = new System.Windows.Forms.Padding(3);
            this.tpZaposSva.Size = new System.Drawing.Size(1141, 298);
            this.tpZaposSva.TabIndex = 1;
            this.tpZaposSva.Text = "Sumarna Zaposlenja";
            // 
            // dgvSvaZaposlenja
            // 
            this.dgvSvaZaposlenja.AllowUserToAddRows = false;
            this.dgvSvaZaposlenja.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSvaZaposlenja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSvaZaposlenja.AutoGenerateColumns = false;
            this.dgvSvaZaposlenja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSvaZaposlenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSvaZaposlenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSvaZaposlenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procenatAngazovanjaDataGridViewTextBoxColumn1,
            this.datumOdDataGridViewTextBoxColumn,
            this.datumDoDataGridViewTextBoxColumn,
            this.stazDataGridViewTextBoxColumn,
            this.idTipaPoslodavcaDataGridViewTextBoxColumn,
            this.nazivPoslodavcaDataGridViewTextBoxColumn,
            this.dgvcZaposSvaNapomene});
            this.dgvSvaZaposlenja.ColumnsForCopyOnClick = null;
            this.dgvSvaZaposlenja.CopyOnCellClick = false;
            this.dgvSvaZaposlenja.CtrlDisplayPositionRowCount = this.lblZaposSvaBrojRedova;
            this.dgvSvaZaposlenja.DataSource = this.bsSvaZaposlenja;
            this.dgvSvaZaposlenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSvaZaposlenja.Location = new System.Drawing.Point(3, 33);
            this.dgvSvaZaposlenja.Name = "dgvSvaZaposlenja";
            this.dgvSvaZaposlenja.RowHeadersWidth = 30;
            this.dgvSvaZaposlenja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSvaZaposlenja.Size = new System.Drawing.Size(1135, 262);
            this.dgvSvaZaposlenja.StandardSort = null;
            this.dgvSvaZaposlenja.TabIndex = 1;
            this.dgvSvaZaposlenja.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSvaZaposlenja_CellDoubleClick);
            this.dgvSvaZaposlenja.SelectionChanged += new System.EventHandler(this.DgvSvaZaposlenja_SelectionChanged);
            // 
            // procenatAngazovanjaDataGridViewTextBoxColumn1
            // 
            this.procenatAngazovanjaDataGridViewTextBoxColumn1.DataPropertyName = "ProcenatAngazovanja";
            this.procenatAngazovanjaDataGridViewTextBoxColumn1.HeaderText = "Procenat";
            this.procenatAngazovanjaDataGridViewTextBoxColumn1.Name = "procenatAngazovanjaDataGridViewTextBoxColumn1";
            this.procenatAngazovanjaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datumOdDataGridViewTextBoxColumn
            // 
            this.datumOdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.datumOdDataGridViewTextBoxColumn.DataPropertyName = "DatumOd";
            this.datumOdDataGridViewTextBoxColumn.HeaderText = "Zaposlen Od";
            this.datumOdDataGridViewTextBoxColumn.Name = "datumOdDataGridViewTextBoxColumn";
            this.datumOdDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumOdDataGridViewTextBoxColumn.Width = 118;
            // 
            // datumDoDataGridViewTextBoxColumn
            // 
            this.datumDoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.datumDoDataGridViewTextBoxColumn.DataPropertyName = "DatumDo";
            this.datumDoDataGridViewTextBoxColumn.HeaderText = "Zaposlen Do";
            this.datumDoDataGridViewTextBoxColumn.Name = "datumDoDataGridViewTextBoxColumn";
            this.datumDoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumDoDataGridViewTextBoxColumn.Width = 118;
            // 
            // stazDataGridViewTextBoxColumn
            // 
            this.stazDataGridViewTextBoxColumn.DataPropertyName = "Staz";
            this.stazDataGridViewTextBoxColumn.HeaderText = "Staž";
            this.stazDataGridViewTextBoxColumn.Name = "stazDataGridViewTextBoxColumn";
            this.stazDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTipaPoslodavcaDataGridViewTextBoxColumn
            // 
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.DataPropertyName = "IdTipaPoslodavca";
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.DataSource = this.bsTipoviPoslodavaca;
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.DisplayMember = "NazivTipaPosl";
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.HeaderText = "Tip Poslodavca";
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.Name = "idTipaPoslodavcaDataGridViewTextBoxColumn";
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.ValueMember = "IdTipaPosl";
            this.idTipaPoslodavcaDataGridViewTextBoxColumn.Width = 200;
            // 
            // bsTipoviPoslodavaca
            // 
            this.bsTipoviPoslodavaca.DataMember = "TipoviPoslodavaca";
            this.bsTipoviPoslodavaca.DataSource = this.ds;
            // 
            // nazivPoslodavcaDataGridViewTextBoxColumn
            // 
            this.nazivPoslodavcaDataGridViewTextBoxColumn.DataPropertyName = "NazivPoslodavca";
            this.nazivPoslodavcaDataGridViewTextBoxColumn.HeaderText = "Naziv Poslodavca";
            this.nazivPoslodavcaDataGridViewTextBoxColumn.Name = "nazivPoslodavcaDataGridViewTextBoxColumn";
            this.nazivPoslodavcaDataGridViewTextBoxColumn.Width = 200;
            // 
            // dgvcZaposSvaNapomene
            // 
            this.dgvcZaposSvaNapomene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcZaposSvaNapomene.DataPropertyName = "Napomene";
            this.dgvcZaposSvaNapomene.HeaderText = "Napomene";
            this.dgvcZaposSvaNapomene.Name = "dgvcZaposSvaNapomene";
            // 
            // lblZaposSvaBrojRedova
            // 
            this.lblZaposSvaBrojRedova.AutoSize = true;
            this.lblZaposSvaBrojRedova.Location = new System.Drawing.Point(3, 5);
            this.lblZaposSvaBrojRedova.Name = "lblZaposSvaBrojRedova";
            this.lblZaposSvaBrojRedova.Size = new System.Drawing.Size(59, 18);
            this.lblZaposSvaBrojRedova.TabIndex = 7;
            this.lblZaposSvaBrojRedova.Text = "Redova";
            // 
            // bsSvaZaposlenja
            // 
            this.bsSvaZaposlenja.DataMember = "SumZaposlenja";
            this.bsSvaZaposlenja.DataSource = this.ds;
            this.bsSvaZaposlenja.Sort = "DatumOd DESC, DatumDo DESC, ProcenatAngazovanja";
            // 
            // pnlZaposSvaTop
            // 
            this.pnlZaposSvaTop.Controls.Add(this.btnNovoEkstZaposlenje);
            this.pnlZaposSvaTop.Controls.Add(this.dtpStazDatumDo);
            this.pnlZaposSvaTop.Controls.Add(this.lblStazDatumDo);
            this.pnlZaposSvaTop.Controls.Add(this.lblUkupanStaz);
            this.pnlZaposSvaTop.Controls.Add(this.lblZaposSvaBrojRedova);
            this.pnlZaposSvaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlZaposSvaTop.Location = new System.Drawing.Point(3, 3);
            this.pnlZaposSvaTop.Name = "pnlZaposSvaTop";
            this.pnlZaposSvaTop.Size = new System.Drawing.Size(1135, 30);
            this.pnlZaposSvaTop.TabIndex = 0;
            // 
            // btnNovoEkstZaposlenje
            // 
            this.btnNovoEkstZaposlenje.Location = new System.Drawing.Point(796, 2);
            this.btnNovoEkstZaposlenje.Name = "btnNovoEkstZaposlenje";
            this.btnNovoEkstZaposlenje.Size = new System.Drawing.Size(163, 26);
            this.btnNovoEkstZaposlenje.TabIndex = 11;
            this.btnNovoEkstZaposlenje.Text = "Novo ekst. zaposlenje";
            this.btnNovoEkstZaposlenje.ToolTipText = "Novo Eksterno Zaposlenje";
            this.btnNovoEkstZaposlenje.UseVisualStyleBackColor = true;
            this.btnNovoEkstZaposlenje.Click += new System.EventHandler(this.BtnNovoEkstZaposlenje_Click);
            // 
            // dtpStazDatumDo
            // 
            this.dtpStazDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStazDatumDo.Location = new System.Drawing.Point(624, 3);
            this.dtpStazDatumDo.Name = "dtpStazDatumDo";
            this.dtpStazDatumDo.Size = new System.Drawing.Size(122, 24);
            this.dtpStazDatumDo.TabIndex = 10;
            this.dtpStazDatumDo.Value = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpStazDatumDo.ValueChanged += new System.EventHandler(this.DtpStazDatumDo_ValueChanged);
            // 
            // lblStazDatumDo
            // 
            this.lblStazDatumDo.AutoSize = true;
            this.lblStazDatumDo.Location = new System.Drawing.Point(521, 6);
            this.lblStazDatumDo.Name = "lblStazDatumDo";
            this.lblStazDatumDo.Size = new System.Drawing.Size(99, 18);
            this.lblStazDatumDo.TabIndex = 9;
            this.lblStazDatumDo.Text = "Presek staža:";
            // 
            // lblUkupanStaz
            // 
            this.lblUkupanStaz.AutoSize = true;
            this.lblUkupanStaz.Location = new System.Drawing.Point(239, 5);
            this.lblUkupanStaz.Name = "lblUkupanStaz";
            this.lblUkupanStaz.Size = new System.Drawing.Size(91, 18);
            this.lblUkupanStaz.TabIndex = 8;
            this.lblUkupanStaz.Text = "Ukupan staž";
            // 
            // tcBottom
            // 
            this.tcBottom.Controls.Add(this.tpObracunZarada);
            this.tcBottom.Controls.Add(this.tpAngazovanja);
            this.tcBottom.Controls.Add(this.tpResenja);
            this.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBottom.Location = new System.Drawing.Point(0, 0);
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.SelectedIndex = 0;
            this.tcBottom.Size = new System.Drawing.Size(1149, 324);
            this.tcBottom.TabIndex = 0;
            // 
            // tpObracunZarada
            // 
            this.tpObracunZarada.BackColor = System.Drawing.SystemColors.Control;
            this.tpObracunZarada.Controls.Add(this.dgvObracunZarada);
            this.tpObracunZarada.Controls.Add(this.pnlBottomLeftOZ);
            this.tpObracunZarada.Location = new System.Drawing.Point(4, 27);
            this.tpObracunZarada.Name = "tpObracunZarada";
            this.tpObracunZarada.Padding = new System.Windows.Forms.Padding(3);
            this.tpObracunZarada.Size = new System.Drawing.Size(1141, 293);
            this.tpObracunZarada.TabIndex = 0;
            this.tpObracunZarada.Text = "Obračun zarada";
            // 
            // dgvObracunZarada
            // 
            this.dgvObracunZarada.AllowUserToAddRows = false;
            this.dgvObracunZarada.AllowUserToDeleteRows = false;
            this.dgvObracunZarada.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvObracunZarada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvObracunZarada.AutoGenerateColumns = false;
            this.dgvObracunZarada.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObracunZarada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvObracunZarada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObracunZarada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojUgovoraDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.mesecNazivDataGridViewTextBoxColumn,
            this.osnovniKoefDataGridViewTextBoxColumn,
            this.dodatniKoefDataGridViewTextBoxColumn,
            this.dgvcOzKoefZaStaresinstvo,
            this.normaDataGridViewTextBoxColumn,
            this.KoefSveOpis,
            this.dgvcOzStaz});
            this.dgvObracunZarada.ColumnsForCopyOnClick = null;
            this.dgvObracunZarada.CopyOnCellClick = false;
            this.dgvObracunZarada.CtrlDisplayPositionRowCount = this.lblBrojRedovaOZ;
            this.dgvObracunZarada.DataSource = this.bsObracunZarada;
            this.dgvObracunZarada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObracunZarada.Location = new System.Drawing.Point(149, 3);
            this.dgvObracunZarada.Name = "dgvObracunZarada";
            this.dgvObracunZarada.ReadOnly = true;
            this.dgvObracunZarada.RowHeadersWidth = 30;
            this.dgvObracunZarada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObracunZarada.Size = new System.Drawing.Size(989, 287);
            this.dgvObracunZarada.StandardSort = null;
            this.dgvObracunZarada.TabIndex = 1;
            // 
            // brojUgovoraDataGridViewTextBoxColumn
            // 
            this.brojUgovoraDataGridViewTextBoxColumn.DataPropertyName = "BrojUgovora";
            this.brojUgovoraDataGridViewTextBoxColumn.HeaderText = "Broj ugovora";
            this.brojUgovoraDataGridViewTextBoxColumn.Name = "brojUgovoraDataGridViewTextBoxColumn";
            this.brojUgovoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godinaDataGridViewTextBoxColumn
            // 
            this.godinaDataGridViewTextBoxColumn.DataPropertyName = "Godina";
            this.godinaDataGridViewTextBoxColumn.HeaderText = "Godina";
            this.godinaDataGridViewTextBoxColumn.Name = "godinaDataGridViewTextBoxColumn";
            this.godinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.godinaDataGridViewTextBoxColumn.Width = 80;
            // 
            // mesecNazivDataGridViewTextBoxColumn
            // 
            this.mesecNazivDataGridViewTextBoxColumn.DataPropertyName = "MesecNaziv";
            this.mesecNazivDataGridViewTextBoxColumn.HeaderText = "Mesec";
            this.mesecNazivDataGridViewTextBoxColumn.Name = "mesecNazivDataGridViewTextBoxColumn";
            this.mesecNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // osnovniKoefDataGridViewTextBoxColumn
            // 
            this.osnovniKoefDataGridViewTextBoxColumn.DataPropertyName = "OsnovniKoef";
            this.osnovniKoefDataGridViewTextBoxColumn.HeaderText = "Osnovni koef";
            this.osnovniKoefDataGridViewTextBoxColumn.Name = "osnovniKoefDataGridViewTextBoxColumn";
            this.osnovniKoefDataGridViewTextBoxColumn.ReadOnly = true;
            this.osnovniKoefDataGridViewTextBoxColumn.Width = 110;
            // 
            // dodatniKoefDataGridViewTextBoxColumn
            // 
            this.dodatniKoefDataGridViewTextBoxColumn.DataPropertyName = "DodatniKoef";
            this.dodatniKoefDataGridViewTextBoxColumn.HeaderText = "Dodatni koef";
            this.dodatniKoefDataGridViewTextBoxColumn.Name = "dodatniKoefDataGridViewTextBoxColumn";
            this.dodatniKoefDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvcOzKoefZaStaresinstvo
            // 
            this.dgvcOzKoefZaStaresinstvo.DataPropertyName = "KoefZaStaresinstvo";
            this.dgvcOzKoefZaStaresinstvo.HeaderText = "Starešinstvo";
            this.dgvcOzKoefZaStaresinstvo.Name = "dgvcOzKoefZaStaresinstvo";
            this.dgvcOzKoefZaStaresinstvo.ReadOnly = true;
            // 
            // normaDataGridViewTextBoxColumn
            // 
            this.normaDataGridViewTextBoxColumn.DataPropertyName = "Norma";
            this.normaDataGridViewTextBoxColumn.HeaderText = "Norma";
            this.normaDataGridViewTextBoxColumn.Name = "normaDataGridViewTextBoxColumn";
            this.normaDataGridViewTextBoxColumn.ReadOnly = true;
            this.normaDataGridViewTextBoxColumn.Width = 80;
            // 
            // KoefSveOpis
            // 
            this.KoefSveOpis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KoefSveOpis.DataPropertyName = "KoefSveOpis";
            this.KoefSveOpis.HeaderText = "Koef opis";
            this.KoefSveOpis.MinimumWidth = 50;
            this.KoefSveOpis.Name = "KoefSveOpis";
            this.KoefSveOpis.ReadOnly = true;
            // 
            // dgvcOzStaz
            // 
            this.dgvcOzStaz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcOzStaz.DataPropertyName = "Staz";
            this.dgvcOzStaz.HeaderText = "Staž";
            this.dgvcOzStaz.Name = "dgvcOzStaz";
            this.dgvcOzStaz.ReadOnly = true;
            this.dgvcOzStaz.Width = 63;
            // 
            // lblBrojRedovaOZ
            // 
            this.lblBrojRedovaOZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrojRedovaOZ.AutoSize = true;
            this.lblBrojRedovaOZ.Location = new System.Drawing.Point(4, 265);
            this.lblBrojRedovaOZ.Name = "lblBrojRedovaOZ";
            this.lblBrojRedovaOZ.Size = new System.Drawing.Size(59, 18);
            this.lblBrojRedovaOZ.TabIndex = 8;
            this.lblBrojRedovaOZ.Text = "Redova";
            // 
            // bsObracunZarada
            // 
            this.bsObracunZarada.DataMember = "ObracunZarada";
            this.bsObracunZarada.DataSource = this.ds;
            this.bsObracunZarada.Sort = "Godina, MesecBroj, BrojUgovora";
            // 
            // pnlBottomLeftOZ
            // 
            this.pnlBottomLeftOZ.Controls.Add(this.btnUcitajOzOpis);
            this.pnlBottomLeftOZ.Controls.Add(this.lblBrojRedovaOZ);
            this.pnlBottomLeftOZ.Controls.Add(this.btnObrisiObracune);
            this.pnlBottomLeftOZ.Controls.Add(this.btnUcitajObracunZarada);
            this.pnlBottomLeftOZ.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottomLeftOZ.Location = new System.Drawing.Point(3, 3);
            this.pnlBottomLeftOZ.Name = "pnlBottomLeftOZ";
            this.pnlBottomLeftOZ.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlBottomLeftOZ.RightWingWidth = 6;
            this.pnlBottomLeftOZ.Size = new System.Drawing.Size(146, 287);
            this.pnlBottomLeftOZ.TabIndex = 0;
            // 
            // btnUcitajOzOpis
            // 
            this.btnUcitajOzOpis.Location = new System.Drawing.Point(3, 33);
            this.btnUcitajOzOpis.Name = "btnUcitajOzOpis";
            this.btnUcitajOzOpis.Size = new System.Drawing.Size(135, 30);
            this.btnUcitajOzOpis.TabIndex = 5;
            this.btnUcitajOzOpis.Text = "Učitaj opise";
            this.btnUcitajOzOpis.ToolTipText = "Učitavanje detalja/opisa za selektovane obračune";
            this.btnUcitajOzOpis.UseVisualStyleBackColor = true;
            this.btnUcitajOzOpis.Click += new System.EventHandler(this.BtnUcitajOzOpis_Click);
            // 
            // btnObrisiObracune
            // 
            this.btnObrisiObracune.Location = new System.Drawing.Point(3, 63);
            this.btnObrisiObracune.Name = "btnObrisiObracune";
            this.btnObrisiObracune.Size = new System.Drawing.Size(135, 30);
            this.btnObrisiObracune.TabIndex = 7;
            this.btnObrisiObracune.Text = "Obriši obračune";
            this.btnObrisiObracune.ToolTipText = "Brisanje selekovanih obračuna zarada";
            this.btnObrisiObracune.UseVisualStyleBackColor = true;
            this.btnObrisiObracune.Click += new System.EventHandler(this.BtnObrisiObracune_Click);
            // 
            // btnUcitajObracunZarada
            // 
            this.btnUcitajObracunZarada.Location = new System.Drawing.Point(3, 3);
            this.btnUcitajObracunZarada.Name = "btnUcitajObracunZarada";
            this.btnUcitajObracunZarada.Size = new System.Drawing.Size(135, 30);
            this.btnUcitajObracunZarada.TabIndex = 2;
            this.btnUcitajObracunZarada.Text = "Učitaj obračune";
            this.btnUcitajObracunZarada.ToolTipText = "Dohvatanje podataka o obračunima zarada za zaposlenog";
            this.btnUcitajObracunZarada.UseVisualStyleBackColor = true;
            this.btnUcitajObracunZarada.Click += new System.EventHandler(this.BtnUcitajObracunZarada_Click);
            // 
            // tpAngazovanja
            // 
            this.tpAngazovanja.BackColor = System.Drawing.SystemColors.Control;
            this.tpAngazovanja.Controls.Add(this.dgvAngazovanja);
            this.tpAngazovanja.Controls.Add(this.pnlBottomLeftAng);
            this.tpAngazovanja.Location = new System.Drawing.Point(4, 22);
            this.tpAngazovanja.Name = "tpAngazovanja";
            this.tpAngazovanja.Padding = new System.Windows.Forms.Padding(3);
            this.tpAngazovanja.Size = new System.Drawing.Size(1141, 298);
            this.tpAngazovanja.TabIndex = 1;
            this.tpAngazovanja.Text = "Angažovanja";
            // 
            // dgvAngazovanja
            // 
            this.dgvAngazovanja.AllowUserToAddRows = false;
            this.dgvAngazovanja.AllowUserToDeleteRows = false;
            this.dgvAngazovanja.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAngazovanja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAngazovanja.AutoGenerateColumns = false;
            this.dgvAngazovanja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAngazovanja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAngazovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngazovanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skolskaGodinaDataGridViewTextBoxColumn,
            this.izvorFinansiranjaDataGridViewTextBoxColumn,
            this.procenatAngazovanjaDataGridViewTextBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.podnivoPredmetaDataGridViewTextBoxColumn});
            this.dgvAngazovanja.ColumnsForCopyOnClick = null;
            this.dgvAngazovanja.CopyOnCellClick = false;
            this.dgvAngazovanja.CtrlDisplayPositionRowCount = null;
            this.dgvAngazovanja.DataSource = this.bsAngazovanja;
            this.dgvAngazovanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAngazovanja.Location = new System.Drawing.Point(149, 3);
            this.dgvAngazovanja.Name = "dgvAngazovanja";
            this.dgvAngazovanja.ReadOnly = true;
            this.dgvAngazovanja.RowHeadersWidth = 30;
            this.dgvAngazovanja.Size = new System.Drawing.Size(989, 292);
            this.dgvAngazovanja.StandardSort = null;
            this.dgvAngazovanja.TabIndex = 0;
            // 
            // skolskaGodinaDataGridViewTextBoxColumn
            // 
            this.skolskaGodinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.skolskaGodinaDataGridViewTextBoxColumn.DataPropertyName = "SkolskaGodina";
            this.skolskaGodinaDataGridViewTextBoxColumn.HeaderText = "Šk. godina";
            this.skolskaGodinaDataGridViewTextBoxColumn.Name = "skolskaGodinaDataGridViewTextBoxColumn";
            this.skolskaGodinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.skolskaGodinaDataGridViewTextBoxColumn.Width = 103;
            // 
            // izvorFinansiranjaDataGridViewTextBoxColumn
            // 
            this.izvorFinansiranjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.izvorFinansiranjaDataGridViewTextBoxColumn.DataPropertyName = "IzvorFinansiranja";
            this.izvorFinansiranjaDataGridViewTextBoxColumn.FillWeight = 150F;
            this.izvorFinansiranjaDataGridViewTextBoxColumn.HeaderText = "Izvor finansiranja";
            this.izvorFinansiranjaDataGridViewTextBoxColumn.Name = "izvorFinansiranjaDataGridViewTextBoxColumn";
            this.izvorFinansiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procenatAngazovanjaDataGridViewTextBoxColumn
            // 
            this.procenatAngazovanjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.procenatAngazovanjaDataGridViewTextBoxColumn.DataPropertyName = "ProcenatAngazovanja";
            this.procenatAngazovanjaDataGridViewTextBoxColumn.HeaderText = "Procenat";
            this.procenatAngazovanjaDataGridViewTextBoxColumn.Name = "procenatAngazovanjaDataGridViewTextBoxColumn";
            this.procenatAngazovanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.procenatAngazovanjaDataGridViewTextBoxColumn.Width = 93;
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            this.predmetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podnivoPredmetaDataGridViewTextBoxColumn
            // 
            this.podnivoPredmetaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.podnivoPredmetaDataGridViewTextBoxColumn.DataPropertyName = "PodnivoPredmeta";
            this.podnivoPredmetaDataGridViewTextBoxColumn.HeaderText = "Predmet - podnivo";
            this.podnivoPredmetaDataGridViewTextBoxColumn.Name = "podnivoPredmetaDataGridViewTextBoxColumn";
            this.podnivoPredmetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsAngazovanja
            // 
            this.bsAngazovanja.DataMember = "Zaposlenja_Angazovanja";
            this.bsAngazovanja.DataSource = this.bsZaposlenja;
            // 
            // pnlBottomLeftAng
            // 
            this.pnlBottomLeftAng.Controls.Add(this.btnUcitajAngazovanja);
            this.pnlBottomLeftAng.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottomLeftAng.Location = new System.Drawing.Point(3, 3);
            this.pnlBottomLeftAng.Name = "pnlBottomLeftAng";
            this.pnlBottomLeftAng.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlBottomLeftAng.RightWingWidth = 6;
            this.pnlBottomLeftAng.Size = new System.Drawing.Size(146, 292);
            this.pnlBottomLeftAng.TabIndex = 1;
            // 
            // tpResenja
            // 
            this.tpResenja.BackColor = System.Drawing.SystemColors.Control;
            this.tpResenja.Controls.Add(this.dgvResenja);
            this.tpResenja.Controls.Add(this.pnlBottomLeftRes);
            this.tpResenja.Location = new System.Drawing.Point(4, 22);
            this.tpResenja.Name = "tpResenja";
            this.tpResenja.Padding = new System.Windows.Forms.Padding(3);
            this.tpResenja.Size = new System.Drawing.Size(1141, 298);
            this.tpResenja.TabIndex = 2;
            this.tpResenja.Text = "Rešenja";
            // 
            // dgvResenja
            // 
            this.dgvResenja.AllowUserToAddRows = false;
            this.dgvResenja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvResenja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvResenja.AutoGenerateColumns = false;
            this.dgvResenja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvResenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojResenjaDataGridViewTextBoxColumn,
            this.SkolskaGodina,
            this.tipResenjaDataGridViewTextBoxColumn,
            this.procenatAngPoResDataGridViewTextBoxColumn,
            this.DatumPodnosenja,
            this.dgvcResDokument,
            this.dgvcResAktivnoResenje});
            this.dgvResenja.ColumnsForCopyOnClick = null;
            this.dgvResenja.CopyOnCellClick = false;
            this.dgvResenja.CtrlDisplayPositionRowCount = null;
            this.dgvResenja.DataSource = this.bsResenja;
            this.dgvResenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResenja.Location = new System.Drawing.Point(149, 3);
            this.dgvResenja.Name = "dgvResenja";
            this.dgvResenja.ReadOnly = true;
            this.dgvResenja.RowHeadersWidth = 30;
            this.dgvResenja.Size = new System.Drawing.Size(989, 292);
            this.dgvResenja.StandardSort = null;
            this.dgvResenja.TabIndex = 1;
            this.dgvResenja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResenja_CellClick);
            // 
            // brojResenjaDataGridViewTextBoxColumn
            // 
            this.brojResenjaDataGridViewTextBoxColumn.DataPropertyName = "BrojResenja";
            this.brojResenjaDataGridViewTextBoxColumn.HeaderText = "Broj Rešenja";
            this.brojResenjaDataGridViewTextBoxColumn.Name = "brojResenjaDataGridViewTextBoxColumn";
            this.brojResenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SkolskaGodina
            // 
            this.SkolskaGodina.DataPropertyName = "SkolskaGodina";
            this.SkolskaGodina.HeaderText = "Šk. God";
            this.SkolskaGodina.Name = "SkolskaGodina";
            this.SkolskaGodina.ReadOnly = true;
            // 
            // tipResenjaDataGridViewTextBoxColumn
            // 
            this.tipResenjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipResenjaDataGridViewTextBoxColumn.DataPropertyName = "TipResenja";
            this.tipResenjaDataGridViewTextBoxColumn.HeaderText = "Tip Rešenja";
            this.tipResenjaDataGridViewTextBoxColumn.Name = "tipResenjaDataGridViewTextBoxColumn";
            this.tipResenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procenatAngPoResDataGridViewTextBoxColumn
            // 
            this.procenatAngPoResDataGridViewTextBoxColumn.DataPropertyName = "ProcenatAngPoRes";
            this.procenatAngPoResDataGridViewTextBoxColumn.HeaderText = "Procenat";
            this.procenatAngPoResDataGridViewTextBoxColumn.Name = "procenatAngPoResDataGridViewTextBoxColumn";
            this.procenatAngPoResDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DatumPodnosenja
            // 
            this.DatumPodnosenja.DataPropertyName = "DatumPodnosenja";
            this.DatumPodnosenja.HeaderText = "Podneto";
            this.DatumPodnosenja.Name = "DatumPodnosenja";
            this.DatumPodnosenja.ReadOnly = true;
            // 
            // dgvcResDokument
            // 
            this.dgvcResDokument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcResDokument.DataPropertyName = "Dokument";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvcResDokument.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvcResDokument.HeaderText = "Dokument";
            this.dgvcResDokument.Name = "dgvcResDokument";
            this.dgvcResDokument.ReadOnly = true;
            this.dgvcResDokument.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcResDokument.Width = 83;
            // 
            // dgvcResAktivnoResenje
            // 
            this.dgvcResAktivnoResenje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcResAktivnoResenje.DataPropertyName = "AktivnoResenje";
            this.dgvcResAktivnoResenje.HeaderText = "Aktivno";
            this.dgvcResAktivnoResenje.Name = "dgvcResAktivnoResenje";
            this.dgvcResAktivnoResenje.ReadOnly = true;
            this.dgvcResAktivnoResenje.Width = 62;
            // 
            // bsResenja
            // 
            this.bsResenja.DataMember = "Zaposlenja_Resenja";
            this.bsResenja.DataSource = this.bsZaposlenja;
            // 
            // pnlBottomLeftRes
            // 
            this.pnlBottomLeftRes.Controls.Add(this.btnUcitajResenja);
            this.pnlBottomLeftRes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottomLeftRes.Location = new System.Drawing.Point(3, 3);
            this.pnlBottomLeftRes.Name = "pnlBottomLeftRes";
            this.pnlBottomLeftRes.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlBottomLeftRes.RightWingWidth = 6;
            this.pnlBottomLeftRes.Size = new System.Drawing.Size(146, 292);
            this.pnlBottomLeftRes.TabIndex = 0;
            // 
            // btnUcitajResenja
            // 
            this.btnUcitajResenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajResenja.Location = new System.Drawing.Point(3, 3);
            this.btnUcitajResenja.Name = "btnUcitajResenja";
            this.btnUcitajResenja.Size = new System.Drawing.Size(135, 30);
            this.btnUcitajResenja.TabIndex = 5;
            this.btnUcitajResenja.Text = "Učitaj rešenja";
            this.btnUcitajResenja.ToolTipText = "Dohvatanje podataka o zaposlenjima";
            this.btnUcitajResenja.UseVisualStyleBackColor = true;
            this.btnUcitajResenja.Click += new System.EventHandler(this.BtnUcitajResenja_Click);
            // 
            // timSvaZapSelectAll
            // 
            this.timSvaZapSelectAll.Interval = 500;
            this.timSvaZapSelectAll.Tick += new System.EventHandler(this.TimSvaZapSelectAll_Tick);
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            this.aktivanDataGridViewCheckBoxColumn.DataPropertyName = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.HeaderText = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            this.aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktivanDataGridViewCheckBoxColumn.Width = 65;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column1.DataPropertyName = "IdZaposlenja";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // brojUgovoraORaduDataGridViewTextBoxColumn
            // 
            this.brojUgovoraORaduDataGridViewTextBoxColumn.DataPropertyName = "BrojUgovoraORadu";
            this.brojUgovoraORaduDataGridViewTextBoxColumn.HeaderText = "Broj ugovora";
            this.brojUgovoraORaduDataGridViewTextBoxColumn.Name = "brojUgovoraORaduDataGridViewTextBoxColumn";
            this.brojUgovoraORaduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radnoMestoNazivDataGridViewTextBoxColumn
            // 
            this.radnoMestoNazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.radnoMestoNazivDataGridViewTextBoxColumn.DataPropertyName = "RadnoMestoNaziv";
            this.radnoMestoNazivDataGridViewTextBoxColumn.FillWeight = 200F;
            this.radnoMestoNazivDataGridViewTextBoxColumn.HeaderText = "Radno mesto";
            this.radnoMestoNazivDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.radnoMestoNazivDataGridViewTextBoxColumn.Name = "radnoMestoNazivDataGridViewTextBoxColumn";
            this.radnoMestoNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procenatRadnogVremenaDataGridViewTextBoxColumn
            // 
            this.procenatRadnogVremenaDataGridViewTextBoxColumn.DataPropertyName = "ProcenatRadnogVremena";
            this.procenatRadnogVremenaDataGridViewTextBoxColumn.HeaderText = "Procenat";
            this.procenatRadnogVremenaDataGridViewTextBoxColumn.Name = "procenatRadnogVremenaDataGridViewTextBoxColumn";
            this.procenatRadnogVremenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.procenatRadnogVremenaDataGridViewTextBoxColumn.Width = 80;
            // 
            // datumZaposlenOdDataGridViewTextBoxColumn
            // 
            this.datumZaposlenOdDataGridViewTextBoxColumn.DataPropertyName = "DatumZaposlenOd";
            this.datumZaposlenOdDataGridViewTextBoxColumn.HeaderText = "Zaposlen od";
            this.datumZaposlenOdDataGridViewTextBoxColumn.Name = "datumZaposlenOdDataGridViewTextBoxColumn";
            this.datumZaposlenOdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumZaposlenDoDataGridViewTextBoxColumn
            // 
            this.datumZaposlenDoDataGridViewTextBoxColumn.DataPropertyName = "DatumZaposlenDo";
            this.datumZaposlenDoDataGridViewTextBoxColumn.HeaderText = "Zaposlen do";
            this.datumZaposlenDoDataGridViewTextBoxColumn.Name = "datumZaposlenDoDataGridViewTextBoxColumn";
            this.datumZaposlenDoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvcZapRazlogPrestanka
            // 
            this.dgvcZapRazlogPrestanka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcZapRazlogPrestanka.DataPropertyName = "RazlogPrestankaZaposlenja";
            this.dgvcZapRazlogPrestanka.HeaderText = "Razlog Prestanka";
            this.dgvcZapRazlogPrestanka.Name = "dgvcZapRazlogPrestanka";
            this.dgvcZapRazlogPrestanka.ReadOnly = true;
            this.dgvcZapRazlogPrestanka.Width = 151;
            // 
            // noksNivoNazivDataGridViewTextBoxColumn
            // 
            this.noksNivoNazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noksNivoNazivDataGridViewTextBoxColumn.DataPropertyName = "NoksNivoNaziv";
            this.noksNivoNazivDataGridViewTextBoxColumn.HeaderText = "NOKS";
            this.noksNivoNazivDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.noksNivoNazivDataGridViewTextBoxColumn.Name = "noksNivoNazivDataGridViewTextBoxColumn";
            this.noksNivoNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaAngazovanjaDataGridViewTextBoxColumn
            // 
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.DataPropertyName = "VrstaAngazovanja";
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.HeaderText = "Vrsta angažovanja";
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.Name = "vrstaAngazovanjaDataGridViewTextBoxColumn";
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaAngazovanjaDataGridViewTextBoxColumn.Width = 135;
            // 
            // dgvcZapZamenjeni
            // 
            this.dgvcZapZamenjeni.DataPropertyName = "_ZamenjeniZaposleni";
            this.dgvcZapZamenjeni.HeaderText = "Zamena za";
            this.dgvcZapZamenjeni.Name = "dgvcZapZamenjeni";
            this.dgvcZapZamenjeni.ReadOnly = true;
            this.dgvcZapZamenjeni.Width = 125;
            // 
            // dgvcZapDokument
            // 
            this.dgvcZapDokument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcZapDokument.DataPropertyName = "Dokument";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvcZapDokument.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcZapDokument.HeaderText = "Dokument";
            this.dgvcZapDokument.Name = "dgvcZapDokument";
            this.dgvcZapDokument.ReadOnly = true;
            this.dgvcZapDokument.Width = 83;
            // 
            // FrmZaposlenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 652);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZaposlenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmZaposlenja_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmZaposlenja_KeyDown);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposleni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.pnlZaposleniTop.ResumeLayout(false);
            this.pnlZaposleniTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenjaSvSava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tcZaposlenja.ResumeLayout(false);
            this.tpZaposSvetiSava.ResumeLayout(false);
            this.tpZaposSva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvaZaposlenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoviPoslodavaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSvaZaposlenja)).EndInit();
            this.pnlZaposSvaTop.ResumeLayout(false);
            this.pnlZaposSvaTop.PerformLayout();
            this.tcBottom.ResumeLayout(false);
            this.tpObracunZarada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObracunZarada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObracunZarada)).EndInit();
            this.pnlBottomLeftOZ.ResumeLayout(false);
            this.pnlBottomLeftOZ.PerformLayout();
            this.tpAngazovanja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAngazovanja)).EndInit();
            this.pnlBottomLeftAng.ResumeLayout(false);
            this.tpResenja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResenja)).EndInit();
            this.pnlBottomLeftRes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcLeftPanel pnlLeft;
        private Controls.UcButton btnUcitajZaposlenja;
        private Controls.UcExitAppButton btnExit;
        private System.Windows.Forms.Panel pnlZaposleniTop;
        private System.Windows.Forms.CheckBox chkAktivno;
        private System.Windows.Forms.Label lblBrojRedovaZaposlenja;
        private Controls.UcDGV dgvZaposlenjaSvSava;
        private System.Windows.Forms.BindingSource bsZaposlenja;
        private Data.Ds ds;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TabControl tcBottom;
        private System.Windows.Forms.TabPage tpObracunZarada;
        private Controls.UcDGV dgvObracunZarada;
        private Controls.UcLeftPanel pnlBottomLeftOZ;
        private Controls.UcButton btnUcitajObracunZarada;
        private System.Windows.Forms.BindingSource bsObracunZarada;
        private Controls.UcButton btnUcitajAngazovanja;
        private System.Windows.Forms.TabPage tpAngazovanja;
        private Controls.UcDGV dgvAngazovanja;
        private System.Windows.Forms.BindingSource bsAngazovanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolskaGodinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvorFinansiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatAngazovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podnivoPredmetaDataGridViewTextBoxColumn;
        private Controls.UcButton btnObrisiObracune;
        private System.Windows.Forms.CheckBox chkCopyOnClick;
        private System.Windows.Forms.Label lblBrojRedovaOZ;
        private Controls.UcLeftPanel pnlBottomLeftAng;
        private Controls.UcButton btnUcitajOzOpis;
        private System.Windows.Forms.TabPage tpResenja;
        private Controls.UcLeftPanel pnlBottomLeftRes;
        private Controls.UcButton btnUcitajResenja;
        private Controls.UcDGV dgvResenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn skGodDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsResenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojUgovoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesecNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osnovniKoefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatniKoefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOzKoefZaStaresinstvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn normaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoefSveOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOzStaz;
        private System.Windows.Forms.ComboBox cmbZamenjeni;
        private System.Windows.Forms.BindingSource bsZaposleni;
        private System.Windows.Forms.Label lblZamenjeni;
        private System.Windows.Forms.Button btnZamenjeniBrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojResenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkolskaGodina;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipResenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatAngPoResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPodnosenja;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcResDokument;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcResAktivnoResenje;
        private System.Windows.Forms.CheckBox chkBezTehnGresaka;
        private System.Windows.Forms.TabControl tcZaposlenja;
        private System.Windows.Forms.TabPage tpZaposSvetiSava;
        private System.Windows.Forms.TabPage tpZaposSva;
        private System.Windows.Forms.Panel pnlZaposSvaTop;
        private System.Windows.Forms.Label lblZaposSvaBrojRedova;
        private Controls.UcDGV dgvSvaZaposlenja;
        private System.Windows.Forms.BindingSource bsSvaZaposlenja;
        private System.Windows.Forms.BindingSource bsTipoviPoslodavaca;
        private System.Windows.Forms.Label lblUkupanStaz;
        private System.Windows.Forms.Label lblStazDatumDo;
        private System.Windows.Forms.DateTimePicker dtpStazDatumDo;
        private Controls.UcButton btnNovoEkstZaposlenje;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatAngazovanjaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTipaPoslodavcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPoslodavcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcZaposSvaNapomene;
        private System.Windows.Forms.Timer timSvaZapSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojUgovoraORaduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnoMestoNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatRadnogVremenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZaposlenOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZaposlenDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcZapRazlogPrestanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn noksNivoNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaAngazovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcZapZamenjeni;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcZapDokument;
    }
}