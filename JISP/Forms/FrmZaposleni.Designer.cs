
namespace JISP.Forms
{
    partial class FrmZaposleni
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.bsZaposleni = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvZaposleni = new JISP.Controls.UcDGV();
            this.dgvcIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcJMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGodine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDanaDoRodj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDevojackoPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrebivaliste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAngazovanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcImaSliku = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvcZapId = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvcStatusAktivnosti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcStatusAktivnosti2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcStazGodine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcStazMeseci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNapomene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlZaposleniTop = new System.Windows.Forms.Panel();
            this.chkAktivniZap = new System.Windows.Forms.CheckBox();
            this.txtFilter = new JISP.Controls.UcFilterTextBox();
            this.dgvZaposlenja = new JISP.Controls.UcDGV();
            this.bsZaposlenja = new System.Windows.Forms.BindingSource(this.components);
            this.ofdZapSlika = new System.Windows.Forms.OpenFileDialog();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.btnStaz = new JISP.Controls.UcButton();
            this.gbIzvestaji = new System.Windows.Forms.GroupBox();
            this.btnSistematizacija = new JISP.Controls.UcButton();
            this.btnKvalifStruktura = new JISP.Controls.UcButton();
            this.BtnCsvZaposlenja = new JISP.Controls.UcButton();
            this.cmbPodaciZaDohvatanje = new System.Windows.Forms.ComboBox();
            this.btnDohvatiPodatke = new JISP.Controls.UcButton();
            this.btnResenja = new JISP.Controls.UcButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkCopyOnClick = new System.Windows.Forms.CheckBox();
            this.btnSaveData = new JISP.Controls.UcButton();
            this.btnExit = new JISP.Controls.UcExitAppButton();
            this.dgvcNjaAktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcNjaProcenat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNjaZaposlenOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNjaRMNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNjaNoksNivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNjaVrstaAng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblFilterCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposleni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.pnlZaposleniTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.gbIzvestaji.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilterCaption
            // 
            lblFilterCaption.AutoSize = true;
            lblFilterCaption.Location = new System.Drawing.Point(147, 4);
            lblFilterCaption.Name = "lblFilterCaption";
            lblFilterCaption.Size = new System.Drawing.Size(44, 18);
            lblFilterCaption.TabIndex = 8;
            lblFilterCaption.Text = "Filter:";
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(3, 5);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(59, 18);
            this.lblRowCount.TabIndex = 0;
            this.lblRowCount.Text = "Redova";
            // 
            // bsZaposleni
            // 
            this.bsZaposleni.DataMember = "Zaposleni";
            this.bsZaposleni.Sort = "";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(146, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvZaposleni);
            this.splitContainer.Panel1.Controls.Add(this.pnlZaposleniTop);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgvZaposlenja);
            this.splitContainer.Size = new System.Drawing.Size(840, 575);
            this.splitContainer.SplitterDistance = 454;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.AllowUserToAddRows = false;
            this.dgvZaposleni.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvZaposleni.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaposleni.AutoGenerateColumns = false;
            this.dgvZaposleni.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposleni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIme,
            this.dgvcPrezime,
            this.dgvcJMBG,
            this.dgvcGodine,
            this.dgvcDanaDoRodj,
            this.dgvcPol,
            this.dgvcDevojackoPrezime,
            this.dgvcEmail,
            this.dgvcTelefon,
            this.dgvcPrebivaliste,
            this.dgvcAngazovanja,
            this.dgvcImaSliku,
            this.dgvcZapId,
            this.dgvcStatusAktivnosti,
            this.dgvcStatusAktivnosti2,
            this.dgvcStazGodine,
            this.dgvcStazMeseci,
            this.dgvcNapomene});
            this.dgvZaposleni.ColumnsForCopyOnClick = null;
            this.dgvZaposleni.CopyOnCellClick = false;
            this.dgvZaposleni.CtrlDisplayPositionRowCount = this.lblRowCount;
            this.dgvZaposleni.DataSource = this.bsZaposleni;
            this.dgvZaposleni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposleni.Location = new System.Drawing.Point(0, 30);
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.RowHeadersWidth = 30;
            this.dgvZaposleni.RowTemplate.Height = 24;
            this.dgvZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposleni.Size = new System.Drawing.Size(840, 424);
            this.dgvZaposleni.StandardSort = null;
            this.dgvZaposleni.TabIndex = 0;
            this.dgvZaposleni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvZaposleni_CellClick);
            this.dgvZaposleni.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvZaposleni_CellDoubleClick);
            this.dgvZaposleni.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvZaposleni_RowsAdded);
            // 
            // dgvcIme
            // 
            this.dgvcIme.DataPropertyName = "Ime";
            this.dgvcIme.HeaderText = "Ime";
            this.dgvcIme.MinimumWidth = 6;
            this.dgvcIme.Name = "dgvcIme";
            this.dgvcIme.ReadOnly = true;
            this.dgvcIme.Width = 115;
            // 
            // dgvcPrezime
            // 
            this.dgvcPrezime.DataPropertyName = "Prezime";
            this.dgvcPrezime.HeaderText = "Prezime";
            this.dgvcPrezime.MinimumWidth = 6;
            this.dgvcPrezime.Name = "dgvcPrezime";
            this.dgvcPrezime.ReadOnly = true;
            this.dgvcPrezime.Width = 150;
            // 
            // dgvcJMBG
            // 
            this.dgvcJMBG.DataPropertyName = "JMBG";
            this.dgvcJMBG.HeaderText = "JMBG";
            this.dgvcJMBG.MinimumWidth = 6;
            this.dgvcJMBG.Name = "dgvcJMBG";
            this.dgvcJMBG.ReadOnly = true;
            this.dgvcJMBG.Width = 125;
            // 
            // dgvcGodine
            // 
            this.dgvcGodine.DataPropertyName = "Godine";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvcGodine.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcGodine.HeaderText = "Godine";
            this.dgvcGodine.MinimumWidth = 6;
            this.dgvcGodine.Name = "dgvcGodine";
            this.dgvcGodine.ReadOnly = true;
            this.dgvcGodine.Width = 85;
            // 
            // dgvcDanaDoRodj
            // 
            this.dgvcDanaDoRodj.DataPropertyName = "DanaDoRodj";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcDanaDoRodj.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcDanaDoRodj.HeaderText = "Do Rođ.";
            this.dgvcDanaDoRodj.MinimumWidth = 6;
            this.dgvcDanaDoRodj.Name = "dgvcDanaDoRodj";
            this.dgvcDanaDoRodj.ReadOnly = true;
            this.dgvcDanaDoRodj.Width = 90;
            // 
            // dgvcPol
            // 
            this.dgvcPol.DataPropertyName = "Pol";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvcPol.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvcPol.HeaderText = "Pol";
            this.dgvcPol.MinimumWidth = 6;
            this.dgvcPol.Name = "dgvcPol";
            this.dgvcPol.Width = 50;
            // 
            // dgvcDevojackoPrezime
            // 
            this.dgvcDevojackoPrezime.DataPropertyName = "DevojackoPrezime";
            this.dgvcDevojackoPrezime.HeaderText = "Dev prezime";
            this.dgvcDevojackoPrezime.MinimumWidth = 6;
            this.dgvcDevojackoPrezime.Name = "dgvcDevojackoPrezime";
            this.dgvcDevojackoPrezime.ReadOnly = true;
            this.dgvcDevojackoPrezime.Width = 125;
            // 
            // dgvcEmail
            // 
            this.dgvcEmail.DataPropertyName = "Email";
            this.dgvcEmail.HeaderText = "Email";
            this.dgvcEmail.MinimumWidth = 6;
            this.dgvcEmail.Name = "dgvcEmail";
            this.dgvcEmail.ReadOnly = true;
            this.dgvcEmail.Width = 125;
            // 
            // dgvcTelefon
            // 
            this.dgvcTelefon.DataPropertyName = "Telefon";
            this.dgvcTelefon.HeaderText = "Telefon";
            this.dgvcTelefon.MinimumWidth = 6;
            this.dgvcTelefon.Name = "dgvcTelefon";
            this.dgvcTelefon.ReadOnly = true;
            this.dgvcTelefon.Width = 125;
            // 
            // dgvcPrebivaliste
            // 
            this.dgvcPrebivaliste.DataPropertyName = "Prebivaliste";
            this.dgvcPrebivaliste.HeaderText = "Prebivaliste";
            this.dgvcPrebivaliste.MinimumWidth = 6;
            this.dgvcPrebivaliste.Name = "dgvcPrebivaliste";
            this.dgvcPrebivaliste.ReadOnly = true;
            this.dgvcPrebivaliste.Width = 125;
            // 
            // dgvcAngazovanja
            // 
            this.dgvcAngazovanja.DataPropertyName = "Angazovanja";
            this.dgvcAngazovanja.HeaderText = "Angazovanja";
            this.dgvcAngazovanja.MinimumWidth = 6;
            this.dgvcAngazovanja.Name = "dgvcAngazovanja";
            this.dgvcAngazovanja.ReadOnly = true;
            this.dgvcAngazovanja.Width = 190;
            // 
            // dgvcImaSliku
            // 
            this.dgvcImaSliku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvcImaSliku.HeaderText = "";
            this.dgvcImaSliku.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvcImaSliku.MinimumWidth = 25;
            this.dgvcImaSliku.Name = "dgvcImaSliku";
            this.dgvcImaSliku.ReadOnly = true;
            this.dgvcImaSliku.Width = 25;
            // 
            // dgvcZapId
            // 
            this.dgvcZapId.DataPropertyName = "IdZaposlenog";
            this.dgvcZapId.HeaderText = "Id";
            this.dgvcZapId.MinimumWidth = 6;
            this.dgvcZapId.Name = "dgvcZapId";
            this.dgvcZapId.ReadOnly = true;
            this.dgvcZapId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcZapId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcZapId.Width = 80;
            // 
            // dgvcStatusAktivnosti
            // 
            this.dgvcStatusAktivnosti.DataPropertyName = "StatusAktivnosti1";
            this.dgvcStatusAktivnosti.HeaderText = "Status 1";
            this.dgvcStatusAktivnosti.MinimumWidth = 20;
            this.dgvcStatusAktivnosti.Name = "dgvcStatusAktivnosti";
            this.dgvcStatusAktivnosti.Width = 125;
            // 
            // dgvcStatusAktivnosti2
            // 
            this.dgvcStatusAktivnosti2.DataPropertyName = "StatusAktivnosti2";
            this.dgvcStatusAktivnosti2.HeaderText = "Status 2";
            this.dgvcStatusAktivnosti2.MinimumWidth = 20;
            this.dgvcStatusAktivnosti2.Name = "dgvcStatusAktivnosti2";
            this.dgvcStatusAktivnosti2.Width = 125;
            // 
            // dgvcStazGodine
            // 
            this.dgvcStazGodine.DataPropertyName = "StazGodine";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcStazGodine.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvcStazGodine.HeaderText = "god";
            this.dgvcStazGodine.MinimumWidth = 6;
            this.dgvcStazGodine.Name = "dgvcStazGodine";
            this.dgvcStazGodine.ToolTipText = "Godine staža";
            this.dgvcStazGodine.Width = 50;
            // 
            // dgvcStazMeseci
            // 
            this.dgvcStazMeseci.DataPropertyName = "StazMeseci";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcStazMeseci.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvcStazMeseci.HeaderText = "mes";
            this.dgvcStazMeseci.MinimumWidth = 6;
            this.dgvcStazMeseci.Name = "dgvcStazMeseci";
            this.dgvcStazMeseci.ToolTipText = "Meseci staža";
            this.dgvcStazMeseci.Width = 50;
            // 
            // dgvcNapomene
            // 
            this.dgvcNapomene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcNapomene.DataPropertyName = "Napomene";
            this.dgvcNapomene.HeaderText = "Napomene";
            this.dgvcNapomene.MinimumWidth = 88;
            this.dgvcNapomene.Name = "dgvcNapomene";
            // 
            // pnlZaposleniTop
            // 
            this.pnlZaposleniTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZaposleniTop.Controls.Add(lblFilterCaption);
            this.pnlZaposleniTop.Controls.Add(this.chkAktivniZap);
            this.pnlZaposleniTop.Controls.Add(this.txtFilter);
            this.pnlZaposleniTop.Controls.Add(this.lblRowCount);
            this.pnlZaposleniTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlZaposleniTop.Location = new System.Drawing.Point(0, 0);
            this.pnlZaposleniTop.Name = "pnlZaposleniTop";
            this.pnlZaposleniTop.Size = new System.Drawing.Size(840, 30);
            this.pnlZaposleniTop.TabIndex = 1;
            // 
            // chkAktivniZap
            // 
            this.chkAktivniZap.AutoSize = true;
            this.chkAktivniZap.Checked = true;
            this.chkAktivniZap.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkAktivniZap.Location = new System.Drawing.Point(509, 4);
            this.chkAktivniZap.Name = "chkAktivniZap";
            this.chkAktivniZap.Size = new System.Drawing.Size(69, 22);
            this.chkAktivniZap.TabIndex = 1;
            this.chkAktivniZap.Text = "Aktivni";
            this.chkAktivniZap.ThreeState = true;
            this.chkAktivniZap.UseVisualStyleBackColor = true;
            this.chkAktivniZap.CheckStateChanged += new System.EventHandler(this.FilterChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.BindingSource = null;
            this.txtFilter.Location = new System.Drawing.Point(193, 1);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(128, 24);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.FilterChanged);
            // 
            // dgvZaposlenja
            // 
            this.dgvZaposlenja.AllowUserToAddRows = false;
            this.dgvZaposlenja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvZaposlenja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvZaposlenja.AutoGenerateColumns = false;
            this.dgvZaposlenja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposlenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvZaposlenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcNjaAktivan,
            this.dgvcNjaProcenat,
            this.dgvcNjaZaposlenOd,
            this.dgvcNjaRMNaziv,
            this.dgvcNjaNoksNivo,
            this.dgvcNjaVrstaAng});
            this.dgvZaposlenja.ColumnsForCopyOnClick = null;
            this.dgvZaposlenja.CopyOnCellClick = false;
            this.dgvZaposlenja.CtrlDisplayPositionRowCount = null;
            this.dgvZaposlenja.DataSource = this.bsZaposlenja;
            this.dgvZaposlenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposlenja.Location = new System.Drawing.Point(0, 0);
            this.dgvZaposlenja.Name = "dgvZaposlenja";
            this.dgvZaposlenja.RowHeadersWidth = 51;
            this.dgvZaposlenja.Size = new System.Drawing.Size(840, 117);
            this.dgvZaposlenja.StandardSort = null;
            this.dgvZaposlenja.TabIndex = 0;
            // 
            // bsZaposlenja
            // 
            this.bsZaposlenja.DataSource = this.bsZaposleni;
            this.bsZaposlenja.Sort = "";
            // 
            // ofdZapSlika
            // 
            this.ofdZapSlika.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            this.ofdZapSlika.Title = "Odabir slike za zaposlenog";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnStaz);
            this.pnlLeft.Controls.Add(this.gbIzvestaji);
            this.pnlLeft.Controls.Add(this.cmbPodaciZaDohvatanje);
            this.pnlLeft.Controls.Add(this.btnDohvatiPodatke);
            this.pnlLeft.Controls.Add(this.btnResenja);
            this.pnlLeft.Controls.Add(this.lblStatus);
            this.pnlLeft.Controls.Add(this.chkCopyOnClick);
            this.pnlLeft.Controls.Add(this.btnSaveData);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(146, 575);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnStaz
            // 
            this.btnStaz.Location = new System.Drawing.Point(8, 426);
            this.btnStaz.Name = "btnStaz";
            this.btnStaz.Size = new System.Drawing.Size(127, 40);
            this.btnStaz.TabIndex = 10;
            this.btnStaz.Text = "Staž";
            this.btnStaz.ToolTipText = "Sistematizacija radnih mesta";
            this.btnStaz.UseVisualStyleBackColor = true;
            this.btnStaz.Click += new System.EventHandler(this.BtnStaz_Click);
            // 
            // gbIzvestaji
            // 
            this.gbIzvestaji.Controls.Add(this.btnSistematizacija);
            this.gbIzvestaji.Controls.Add(this.btnKvalifStruktura);
            this.gbIzvestaji.Controls.Add(this.BtnCsvZaposlenja);
            this.gbIzvestaji.Location = new System.Drawing.Point(3, 255);
            this.gbIzvestaji.Name = "gbIzvestaji";
            this.gbIzvestaji.Size = new System.Drawing.Size(136, 150);
            this.gbIzvestaji.TabIndex = 15;
            this.gbIzvestaji.TabStop = false;
            this.gbIzvestaji.Text = "Izveštaji";
            // 
            // btnSistematizacija
            // 
            this.btnSistematizacija.Location = new System.Drawing.Point(6, 103);
            this.btnSistematizacija.Name = "btnSistematizacija";
            this.btnSistematizacija.Size = new System.Drawing.Size(127, 40);
            this.btnSistematizacija.TabIndex = 9;
            this.btnSistematizacija.Text = "Sistemat. RM";
            this.btnSistematizacija.ToolTipText = "Sistematizacija radnih mesta";
            this.btnSistematizacija.UseVisualStyleBackColor = true;
            this.btnSistematizacija.Click += new System.EventHandler(this.BtnSistematizacija_Click);
            // 
            // btnKvalifStruktura
            // 
            this.btnKvalifStruktura.Location = new System.Drawing.Point(6, 63);
            this.btnKvalifStruktura.Name = "btnKvalifStruktura";
            this.btnKvalifStruktura.Size = new System.Drawing.Size(128, 40);
            this.btnKvalifStruktura.TabIndex = 5;
            this.btnKvalifStruktura.Text = "Kvalif. struktura";
            this.btnKvalifStruktura.ToolTipText = "Kreiranje izveštaja Kvalifikaciona Struktura";
            this.btnKvalifStruktura.UseVisualStyleBackColor = true;
            this.btnKvalifStruktura.Click += new System.EventHandler(this.BtnKvalifStruktura_Click);
            // 
            // BtnCsvZaposlenja
            // 
            this.BtnCsvZaposlenja.Location = new System.Drawing.Point(6, 23);
            this.BtnCsvZaposlenja.Name = "BtnCsvZaposlenja";
            this.BtnCsvZaposlenja.Size = new System.Drawing.Size(128, 40);
            this.BtnCsvZaposlenja.TabIndex = 8;
            this.BtnCsvZaposlenja.Text = "CSV zaposlenja";
            this.BtnCsvZaposlenja.ToolTipText = "Stavljanje u klipbord podatаkа u CSV formatu o svim zaposlenima radi provere Kval" +
    "ifikacione strukture";
            this.BtnCsvZaposlenja.UseVisualStyleBackColor = true;
            this.BtnCsvZaposlenja.Click += new System.EventHandler(this.BtnCsvZaposlenja_Click);
            // 
            // cmbPodaciZaDohvatanje
            // 
            this.cmbPodaciZaDohvatanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPodaciZaDohvatanje.DropDownWidth = 300;
            this.cmbPodaciZaDohvatanje.FormattingEnabled = true;
            this.cmbPodaciZaDohvatanje.Location = new System.Drawing.Point(9, 138);
            this.cmbPodaciZaDohvatanje.Name = "cmbPodaciZaDohvatanje";
            this.cmbPodaciZaDohvatanje.Size = new System.Drawing.Size(126, 26);
            this.cmbPodaciZaDohvatanje.TabIndex = 14;
            // 
            // btnDohvatiPodatke
            // 
            this.btnDohvatiPodatke.Location = new System.Drawing.Point(8, 165);
            this.btnDohvatiPodatke.Name = "btnDohvatiPodatke";
            this.btnDohvatiPodatke.Size = new System.Drawing.Size(128, 40);
            this.btnDohvatiPodatke.TabIndex = 13;
            this.btnDohvatiPodatke.Text = "Dohvati podatke";
            this.btnDohvatiPodatke.ToolTipText = null;
            this.btnDohvatiPodatke.UseVisualStyleBackColor = true;
            this.btnDohvatiPodatke.Click += new System.EventHandler(this.BtnDohvatiPodatke_Click);
            // 
            // btnResenja
            // 
            this.btnResenja.Location = new System.Drawing.Point(9, 211);
            this.btnResenja.Name = "btnResenja";
            this.btnResenja.Size = new System.Drawing.Size(128, 40);
            this.btnResenja.TabIndex = 10;
            this.btnResenja.Text = "Rešenja";
            this.btnResenja.ToolTipText = "Rešenja svih zaposlenih";
            this.btnResenja.UseVisualStyleBackColor = true;
            this.btnResenja.Click += new System.EventHandler(this.BtnResenja_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(5, 548);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 18);
            this.lblStatus.TabIndex = 7;
            // 
            // chkCopyOnClick
            // 
            this.chkCopyOnClick.AutoSize = true;
            this.chkCopyOnClick.Location = new System.Drawing.Point(8, 64);
            this.chkCopyOnClick.Name = "chkCopyOnClick";
            this.chkCopyOnClick.Size = new System.Drawing.Size(135, 22);
            this.chkCopyOnClick.TabIndex = 1;
            this.chkCopyOnClick.Text = "Kopiranje na klik";
            this.chkCopyOnClick.UseVisualStyleBackColor = true;
            this.chkCopyOnClick.CheckedChanged += new System.EventHandler(this.ChkCopyOnClick_CheckedChanged);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(9, 92);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(127, 40);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.Text = "Sačuvaj podatke";
            this.btnSaveData.ToolTipText = null;
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(8, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Izlaz";
            this.btnExit.ToolTipText = "Izlaz iz aplikacije";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // dgvcNjaAktivan
            // 
            this.dgvcNjaAktivan.DataPropertyName = "Aktivan";
            this.dgvcNjaAktivan.HeaderText = "Aktivan";
            this.dgvcNjaAktivan.MinimumWidth = 6;
            this.dgvcNjaAktivan.Name = "dgvcNjaAktivan";
            this.dgvcNjaAktivan.ReadOnly = true;
            this.dgvcNjaAktivan.Width = 65;
            // 
            // dgvcNjaProcenat
            // 
            this.dgvcNjaProcenat.DataPropertyName = "ProcenatRadnogVremena";
            this.dgvcNjaProcenat.HeaderText = "Procenat";
            this.dgvcNjaProcenat.MinimumWidth = 6;
            this.dgvcNjaProcenat.Name = "dgvcNjaProcenat";
            this.dgvcNjaProcenat.Width = 80;
            // 
            // dgvcNjaZaposlenOd
            // 
            this.dgvcNjaZaposlenOd.DataPropertyName = "DatumZaposlenOd";
            this.dgvcNjaZaposlenOd.HeaderText = "Zaposlen od";
            this.dgvcNjaZaposlenOd.MinimumWidth = 6;
            this.dgvcNjaZaposlenOd.Name = "dgvcNjaZaposlenOd";
            this.dgvcNjaZaposlenOd.Width = 125;
            // 
            // dgvcNjaRMNaziv
            // 
            this.dgvcNjaRMNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcNjaRMNaziv.DataPropertyName = "RadnoMestoNaziv";
            this.dgvcNjaRMNaziv.FillWeight = 200F;
            this.dgvcNjaRMNaziv.HeaderText = "Radno mesto";
            this.dgvcNjaRMNaziv.MinimumWidth = 6;
            this.dgvcNjaRMNaziv.Name = "dgvcNjaRMNaziv";
            this.dgvcNjaRMNaziv.ReadOnly = true;
            // 
            // dgvcNjaNoksNivo
            // 
            this.dgvcNjaNoksNivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcNjaNoksNivo.DataPropertyName = "NoksNivoNaziv";
            this.dgvcNjaNoksNivo.HeaderText = "NOKS";
            this.dgvcNjaNoksNivo.Name = "dgvcNjaNoksNivo";
            this.dgvcNjaNoksNivo.ReadOnly = true;
            this.dgvcNjaNoksNivo.Width = 76;
            // 
            // dgvcNjaVrstaAng
            // 
            this.dgvcNjaVrstaAng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcNjaVrstaAng.DataPropertyName = "VrstaAngazovanja";
            this.dgvcNjaVrstaAng.HeaderText = "Vrsta angažovanja";
            this.dgvcNjaVrstaAng.MinimumWidth = 6;
            this.dgvcNjaVrstaAng.Name = "dgvcNjaVrstaAng";
            this.dgvcNjaVrstaAng.ReadOnly = true;
            // 
            // FrmZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 575);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::JISP.Properties.Resources.grb_srb;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZaposleni";
            this.Text = "Zaposleni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmZaposleni_FormClosed);
            this.Load += new System.EventHandler(this.FrmZaposleni_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmZaposleni_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposleni)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.pnlZaposleniTop.ResumeLayout(false);
            this.pnlZaposleniTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.gbIzvestaji.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private JISP.Controls.UcLeftPanel pnlLeft;
        private Controls.UcDGV dgvZaposleni;
        private System.Windows.Forms.BindingSource bsZaposleni;
        private Controls.UcButton btnSaveData;
        private Controls.UcExitAppButton btnExit;
        private System.Windows.Forms.CheckBox chkCopyOnClick;
        private System.Windows.Forms.Label lblRowCount;
        private Controls.UcFilterTextBox txtFilter;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlZaposleniTop;
        private Controls.UcDGV dgvZaposlenja;
        private System.Windows.Forms.BindingSource bsZaposlenja;
        private System.Windows.Forms.CheckBox chkAktivniZap;
        private System.Windows.Forms.OpenFileDialog ofdZapSlika;
        private Controls.UcButton btnKvalifStruktura;
        private System.Windows.Forms.Label lblStatus;
        private Controls.UcButton BtnCsvZaposlenja;
        private Controls.UcButton btnResenja;
        private Controls.UcButton btnSistematizacija;
        private Controls.UcButton btnDohvatiPodatke;
        private System.Windows.Forms.ComboBox cmbPodaciZaDohvatanje;
        private System.Windows.Forms.GroupBox gbIzvestaji;
        private Controls.UcButton btnStaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcJMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGodine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDanaDoRodj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDevojackoPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrebivaliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAngazovanja;
        private System.Windows.Forms.DataGridViewImageColumn dgvcImaSliku;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcZapId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcStatusAktivnosti;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcStatusAktivnosti2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcStazGodine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcStazMeseci;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNapomene;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcNjaAktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNjaProcenat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNjaZaposlenOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNjaRMNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNjaNoksNivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNjaVrstaAng;
    }
}