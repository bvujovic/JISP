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
            System.Windows.Forms.Label lblOzGodina;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.btnUcitajAngazovanja = new JISP.Controls.UcButton();
            this.btnLoadData = new JISP.Controls.UcButton();
            this.btnExit = new JISP.Controls.UcExitAppButton();
            this.pnlZaposleniTop = new System.Windows.Forms.Panel();
            this.chkAktivno = new System.Windows.Forms.CheckBox();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.dgvZaposlenjaSve = new JISP.Controls.UcDGV();
            this.aktivanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.brojUgovoraORaduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnoMestoNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatRadnogVremenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZaposlenOdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZaposlenDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noksNivoNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaAngazovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsZaposlenja = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tcBottom = new System.Windows.Forms.TabControl();
            this.tpAngazovanja = new System.Windows.Forms.TabPage();
            this.ucDGV1 = new JISP.Controls.UcDGV();
            this.skolskaGodinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvorFinansiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatAngazovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podnivoPredmetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAngazovanja = new System.Windows.Forms.BindingSource(this.components);
            this.tpObracunZarada = new System.Windows.Forms.TabPage();
            this.dgvObracunZarada = new JISP.Controls.UcDGV();
            this.brojUgovoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesecNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osnovniKoefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatniKoefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsObracunZarada = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottomLeft = new JISP.Controls.UcLeftPanel();
            this.lstchkMeseci = new System.Windows.Forms.CheckedListBox();
            this.numOzGodina = new System.Windows.Forms.NumericUpDown();
            this.btnKreirajObracune = new JISP.Controls.UcButton();
            this.btnUcitajObracunZarada = new JISP.Controls.UcButton();
            lblOzGodina = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlZaposleniTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenjaSve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tcBottom.SuspendLayout();
            this.tpAngazovanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAngazovanja)).BeginInit();
            this.tpObracunZarada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObracunZarada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObracunZarada)).BeginInit();
            this.pnlBottomLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOzGodina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOzGodina
            // 
            lblOzGodina.AutoSize = true;
            lblOzGodina.Location = new System.Drawing.Point(0, 97);
            lblOzGodina.Name = "lblOzGodina";
            lblOzGodina.Size = new System.Drawing.Size(56, 18);
            lblOzGodina.TabIndex = 4;
            lblOzGodina.Text = "Godina";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnUcitajAngazovanja);
            this.pnlLeft.Controls.Add(this.btnLoadData);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(146, 511);
            this.pnlLeft.TabIndex = 2;
            // 
            // btnUcitajAngazovanja
            // 
            this.btnUcitajAngazovanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajAngazovanja.Location = new System.Drawing.Point(8, 104);
            this.btnUcitajAngazovanja.Name = "btnUcitajAngazovanja";
            this.btnUcitajAngazovanja.Size = new System.Drawing.Size(128, 54);
            this.btnUcitajAngazovanja.TabIndex = 4;
            this.btnUcitajAngazovanja.Text = "Učitaj angažovanja";
            this.btnUcitajAngazovanja.ToolTipText = "Dohvatanje podataka o zaposlenjima";
            this.btnUcitajAngazovanja.UseVisualStyleBackColor = true;
            this.btnUcitajAngazovanja.Click += new System.EventHandler(this.BtnUcitajAngazovanja_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(8, 58);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(128, 40);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Učitaj zaposlenja";
            this.btnLoadData.ToolTipText = "Dohvatanje podataka o zaposlenjima";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
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
            // pnlZaposleniTop
            // 
            this.pnlZaposleniTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZaposleniTop.Controls.Add(this.chkAktivno);
            this.pnlZaposleniTop.Controls.Add(this.lblRowCount);
            this.pnlZaposleniTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlZaposleniTop.Location = new System.Drawing.Point(0, 0);
            this.pnlZaposleniTop.Name = "pnlZaposleniTop";
            this.pnlZaposleniTop.Size = new System.Drawing.Size(893, 30);
            this.pnlZaposleniTop.TabIndex = 3;
            // 
            // chkAktivno
            // 
            this.chkAktivno.AutoSize = true;
            this.chkAktivno.Checked = true;
            this.chkAktivno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktivno.Location = new System.Drawing.Point(237, 4);
            this.chkAktivno.Name = "chkAktivno";
            this.chkAktivno.Size = new System.Drawing.Size(75, 22);
            this.chkAktivno.TabIndex = 1;
            this.chkAktivno.Text = "Aktivno";
            this.chkAktivno.ThreeState = true;
            this.chkAktivno.UseVisualStyleBackColor = true;
            this.chkAktivno.CheckStateChanged += new System.EventHandler(this.ChkAktivno_CheckStateChanged);
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(3, 5);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(59, 18);
            this.lblRowCount.TabIndex = 6;
            this.lblRowCount.Text = "Redova";
            // 
            // dgvZaposlenjaSve
            // 
            this.dgvZaposlenjaSve.AllowUserToAddRows = false;
            this.dgvZaposlenjaSve.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvZaposlenjaSve.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaposlenjaSve.AutoGenerateColumns = false;
            this.dgvZaposlenjaSve.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposlenjaSve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZaposlenjaSve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenjaSve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aktivanDataGridViewCheckBoxColumn,
            this.brojUgovoraORaduDataGridViewTextBoxColumn,
            this.radnoMestoNazivDataGridViewTextBoxColumn,
            this.procenatRadnogVremenaDataGridViewTextBoxColumn,
            this.datumZaposlenOdDataGridViewTextBoxColumn,
            this.datumZaposlenDoDataGridViewTextBoxColumn,
            this.noksNivoNazivDataGridViewTextBoxColumn,
            this.vrstaAngazovanjaDataGridViewTextBoxColumn});
            this.dgvZaposlenjaSve.ColumnsForCopyOnClick = null;
            this.dgvZaposlenjaSve.CopyOnCellClick = true;
            this.dgvZaposlenjaSve.CtrlDisplayPositionRowCount = this.lblRowCount;
            this.dgvZaposlenjaSve.DataSource = this.bsZaposlenja;
            this.dgvZaposlenjaSve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposlenjaSve.Location = new System.Drawing.Point(0, 30);
            this.dgvZaposlenjaSve.Name = "dgvZaposlenjaSve";
            this.dgvZaposlenjaSve.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvZaposlenjaSve.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZaposlenjaSve.RowHeadersWidth = 30;
            this.dgvZaposlenjaSve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenjaSve.Size = new System.Drawing.Size(893, 211);
            this.dgvZaposlenjaSve.StandardSort = null;
            this.dgvZaposlenjaSve.TabIndex = 4;
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            this.aktivanDataGridViewCheckBoxColumn.DataPropertyName = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.HeaderText = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            this.aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktivanDataGridViewCheckBoxColumn.Width = 65;
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
            // noksNivoNazivDataGridViewTextBoxColumn
            // 
            this.noksNivoNazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noksNivoNazivDataGridViewTextBoxColumn.DataPropertyName = "NoksNivoNaziv";
            this.noksNivoNazivDataGridViewTextBoxColumn.HeaderText = "NOKS";
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
            // bsZaposlenja
            // 
            this.bsZaposlenja.DataMember = "Zaposlenja";
            this.bsZaposlenja.DataSource = this.ds;
            this.bsZaposlenja.Sort = "Aktivan DESC, DatumZaposlenOd DESC";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(146, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvZaposlenjaSve);
            this.scMain.Panel1.Controls.Add(this.pnlZaposleniTop);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tcBottom);
            this.scMain.Size = new System.Drawing.Size(893, 511);
            this.scMain.SplitterDistance = 241;
            this.scMain.TabIndex = 5;
            // 
            // tcBottom
            // 
            this.tcBottom.Controls.Add(this.tpAngazovanja);
            this.tcBottom.Controls.Add(this.tpObracunZarada);
            this.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBottom.Location = new System.Drawing.Point(0, 0);
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.SelectedIndex = 0;
            this.tcBottom.Size = new System.Drawing.Size(893, 266);
            this.tcBottom.TabIndex = 0;
            // 
            // tpAngazovanja
            // 
            this.tpAngazovanja.BackColor = System.Drawing.SystemColors.Control;
            this.tpAngazovanja.Controls.Add(this.ucDGV1);
            this.tpAngazovanja.Location = new System.Drawing.Point(4, 27);
            this.tpAngazovanja.Name = "tpAngazovanja";
            this.tpAngazovanja.Padding = new System.Windows.Forms.Padding(3);
            this.tpAngazovanja.Size = new System.Drawing.Size(885, 235);
            this.tpAngazovanja.TabIndex = 1;
            this.tpAngazovanja.Text = "Angažovanja";
            // 
            // ucDGV1
            // 
            this.ucDGV1.AllowUserToAddRows = false;
            this.ucDGV1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucDGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ucDGV1.AutoGenerateColumns = false;
            this.ucDGV1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ucDGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ucDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucDGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skolskaGodinaDataGridViewTextBoxColumn,
            this.izvorFinansiranjaDataGridViewTextBoxColumn,
            this.procenatAngazovanjaDataGridViewTextBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.podnivoPredmetaDataGridViewTextBoxColumn});
            this.ucDGV1.ColumnsForCopyOnClick = null;
            this.ucDGV1.CopyOnCellClick = false;
            this.ucDGV1.CtrlDisplayPositionRowCount = null;
            this.ucDGV1.DataSource = this.bsAngazovanja;
            this.ucDGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDGV1.Location = new System.Drawing.Point(3, 3);
            this.ucDGV1.Name = "ucDGV1";
            this.ucDGV1.ReadOnly = true;
            this.ucDGV1.RowHeadersWidth = 30;
            this.ucDGV1.Size = new System.Drawing.Size(879, 229);
            this.ucDGV1.StandardSort = null;
            this.ucDGV1.TabIndex = 0;
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
            // tpObracunZarada
            // 
            this.tpObracunZarada.BackColor = System.Drawing.SystemColors.Control;
            this.tpObracunZarada.Controls.Add(this.dgvObracunZarada);
            this.tpObracunZarada.Controls.Add(this.pnlBottomLeft);
            this.tpObracunZarada.Location = new System.Drawing.Point(4, 22);
            this.tpObracunZarada.Name = "tpObracunZarada";
            this.tpObracunZarada.Padding = new System.Windows.Forms.Padding(3);
            this.tpObracunZarada.Size = new System.Drawing.Size(885, 240);
            this.tpObracunZarada.TabIndex = 0;
            this.tpObracunZarada.Text = "Obračun zarada";
            // 
            // dgvObracunZarada
            // 
            this.dgvObracunZarada.AllowUserToAddRows = false;
            this.dgvObracunZarada.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvObracunZarada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvObracunZarada.AutoGenerateColumns = false;
            this.dgvObracunZarada.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObracunZarada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvObracunZarada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObracunZarada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojUgovoraDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.mesecNazivDataGridViewTextBoxColumn,
            this.osnovniKoefDataGridViewTextBoxColumn,
            this.dodatniKoefDataGridViewTextBoxColumn,
            this.normaDataGridViewTextBoxColumn});
            this.dgvObracunZarada.ColumnsForCopyOnClick = null;
            this.dgvObracunZarada.CopyOnCellClick = false;
            this.dgvObracunZarada.CtrlDisplayPositionRowCount = null;
            this.dgvObracunZarada.DataSource = this.bsObracunZarada;
            this.dgvObracunZarada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObracunZarada.Location = new System.Drawing.Point(149, 3);
            this.dgvObracunZarada.Name = "dgvObracunZarada";
            this.dgvObracunZarada.ReadOnly = true;
            this.dgvObracunZarada.RowHeadersWidth = 30;
            this.dgvObracunZarada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObracunZarada.Size = new System.Drawing.Size(733, 234);
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
            // normaDataGridViewTextBoxColumn
            // 
            this.normaDataGridViewTextBoxColumn.DataPropertyName = "Norma";
            this.normaDataGridViewTextBoxColumn.HeaderText = "Norma";
            this.normaDataGridViewTextBoxColumn.Name = "normaDataGridViewTextBoxColumn";
            this.normaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsObracunZarada
            // 
            this.bsObracunZarada.DataMember = "ObracunZarada";
            this.bsObracunZarada.DataSource = this.ds;
            // 
            // pnlBottomLeft
            // 
            this.pnlBottomLeft.Controls.Add(this.lstchkMeseci);
            this.pnlBottomLeft.Controls.Add(this.numOzGodina);
            this.pnlBottomLeft.Controls.Add(lblOzGodina);
            this.pnlBottomLeft.Controls.Add(this.btnKreirajObracune);
            this.pnlBottomLeft.Controls.Add(this.btnUcitajObracunZarada);
            this.pnlBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottomLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlBottomLeft.Name = "pnlBottomLeft";
            this.pnlBottomLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlBottomLeft.RightWingWidth = 6;
            this.pnlBottomLeft.Size = new System.Drawing.Size(146, 234);
            this.pnlBottomLeft.TabIndex = 0;
            // 
            // lstchkMeseci
            // 
            this.lstchkMeseci.CheckOnClick = true;
            this.lstchkMeseci.FormattingEnabled = true;
            this.lstchkMeseci.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Mart",
            "April",
            "Maj",
            "Jun",
            "Jul",
            "Avgust",
            "Septembar",
            "Oktobar",
            "Novembar",
            "Decembar"});
            this.lstchkMeseci.Location = new System.Drawing.Point(3, 125);
            this.lstchkMeseci.Name = "lstchkMeseci";
            this.lstchkMeseci.Size = new System.Drawing.Size(135, 99);
            this.lstchkMeseci.TabIndex = 6;
            // 
            // numOzGodina
            // 
            this.numOzGodina.Location = new System.Drawing.Point(62, 95);
            this.numOzGodina.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numOzGodina.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numOzGodina.Name = "numOzGodina";
            this.numOzGodina.Size = new System.Drawing.Size(76, 24);
            this.numOzGodina.TabIndex = 5;
            this.numOzGodina.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // btnKreirajObracune
            // 
            this.btnKreirajObracune.Location = new System.Drawing.Point(3, 49);
            this.btnKreirajObracune.Name = "btnKreirajObracune";
            this.btnKreirajObracune.Size = new System.Drawing.Size(135, 40);
            this.btnKreirajObracune.TabIndex = 3;
            this.btnKreirajObracune.Text = "Kreiraj obračune";
            this.btnKreirajObracune.ToolTipText = "Kreiranje novih obračuna zarada za selektovane mesece na osnovu starog obračuna";
            this.btnKreirajObracune.UseVisualStyleBackColor = true;
            this.btnKreirajObracune.Click += new System.EventHandler(this.BtnKreirajObracune_Click);
            // 
            // btnUcitajObracunZarada
            // 
            this.btnUcitajObracunZarada.Location = new System.Drawing.Point(3, 3);
            this.btnUcitajObracunZarada.Name = "btnUcitajObracunZarada";
            this.btnUcitajObracunZarada.Size = new System.Drawing.Size(135, 40);
            this.btnUcitajObracunZarada.TabIndex = 2;
            this.btnUcitajObracunZarada.Text = "Učitaj podatke";
            this.btnUcitajObracunZarada.ToolTipText = "Dohvatanje podataka o obračunima zarada za zaposlenog";
            this.btnUcitajObracunZarada.UseVisualStyleBackColor = true;
            this.btnUcitajObracunZarada.Click += new System.EventHandler(this.BtnUcitajObracunZarada_Click);
            // 
            // FrmZaposlenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 511);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Icon = global::JISP.Properties.Resources.grb_srb;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZaposlenja";
            this.Text = "Zaposlenja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmZaposlenja_FormClosed);
            this.pnlLeft.ResumeLayout(false);
            this.pnlZaposleniTop.ResumeLayout(false);
            this.pnlZaposleniTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenjaSve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tcBottom.ResumeLayout(false);
            this.tpAngazovanja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ucDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAngazovanja)).EndInit();
            this.tpObracunZarada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObracunZarada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObracunZarada)).EndInit();
            this.pnlBottomLeft.ResumeLayout(false);
            this.pnlBottomLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOzGodina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcLeftPanel pnlLeft;
        private Controls.UcButton btnLoadData;
        private Controls.UcExitAppButton btnExit;
        private System.Windows.Forms.Panel pnlZaposleniTop;
        private System.Windows.Forms.CheckBox chkAktivno;
        private System.Windows.Forms.Label lblRowCount;
        private Controls.UcDGV dgvZaposlenjaSve;
        private System.Windows.Forms.BindingSource bsZaposlenja;
        private Data.Ds ds;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojUgovoraORaduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnoMestoNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatRadnogVremenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZaposlenOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZaposlenDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noksNivoNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaAngazovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TabControl tcBottom;
        private System.Windows.Forms.TabPage tpObracunZarada;
        private Controls.UcDGV dgvObracunZarada;
        private Controls.UcLeftPanel pnlBottomLeft;
        private Controls.UcButton btnUcitajObracunZarada;
        private System.Windows.Forms.BindingSource bsObracunZarada;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojUgovoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesecNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osnovniKoefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatniKoefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normaDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numOzGodina;
        private Controls.UcButton btnKreirajObracune;
        private System.Windows.Forms.CheckedListBox lstchkMeseci;
        private Controls.UcButton btnUcitajAngazovanja;
        private System.Windows.Forms.TabPage tpAngazovanja;
        private Controls.UcDGV ucDGV1;
        private System.Windows.Forms.BindingSource bsAngazovanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolskaGodinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izvorFinansiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatAngazovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podnivoPredmetaDataGridViewTextBoxColumn;
    }
}