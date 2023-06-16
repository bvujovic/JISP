namespace JISP.Forms
{
    partial class FrmObrazovanje
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
            System.Windows.Forms.Label lblFilterZaposleni;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.lblIzvorSelZaposlenih = new System.Windows.Forms.Label();
            this.cmbPodaciZaDohvatanje = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExit = new JISP.Controls.UcExitAppButton();
            this.lblBrojRedova = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtFilterZaposleni = new JISP.Controls.UcFilterTextBox();
            this.btnDohvatiPodatke = new JISP.Controls.UcButton();
            this.dgvObrazovanja = new JISP.Controls.UcDGV();
            this.bsObrazovanja = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.zaposleniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noksNivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcKlasnoks = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stepenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NazivSteceneKvalifikacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrucniAkademskiNazivIzDiplome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDatumSticanjaDiplome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrzavaZavrseneSkole = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MestoZavrseneSkoleNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivSkole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JezikNaKomJeStecenoObrazovanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcDokument = new System.Windows.Forms.DataGridViewButtonColumn();
            lblFilterZaposleni = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrazovanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObrazovanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilterZaposleni
            // 
            lblFilterZaposleni.AutoSize = true;
            lblFilterZaposleni.Location = new System.Drawing.Point(5, 32);
            lblFilterZaposleni.Name = "lblFilterZaposleni";
            lblFilterZaposleni.Size = new System.Drawing.Size(72, 18);
            lblFilterZaposleni.TabIndex = 1;
            lblFilterZaposleni.Text = "Zaposleni";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblIzvorSelZaposlenih);
            this.pnlLeft.Controls.Add(this.cmbPodaciZaDohvatanje);
            this.pnlLeft.Controls.Add(this.lblStatus);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Controls.Add(this.lblBrojRedova);
            this.pnlLeft.Controls.Add(this.gbFilter);
            this.pnlLeft.Controls.Add(this.btnDohvatiPodatke);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 9;
            this.pnlLeft.Size = new System.Drawing.Size(150, 347);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblIzvorSelZaposlenih
            // 
            this.lblIzvorSelZaposlenih.AutoSize = true;
            this.lblIzvorSelZaposlenih.Location = new System.Drawing.Point(8, 233);
            this.lblIzvorSelZaposlenih.Name = "lblIzvorSelZaposlenih";
            this.lblIzvorSelZaposlenih.Size = new System.Drawing.Size(124, 18);
            this.lblIzvorSelZaposlenih.TabIndex = 21;
            this.lblIzvorSelZaposlenih.Text = "Sel. zaposleni sa:";
            // 
            // cmbPodaciZaDohvatanje
            // 
            this.cmbPodaciZaDohvatanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPodaciZaDohvatanje.DropDownWidth = 300;
            this.cmbPodaciZaDohvatanje.FormattingEnabled = true;
            this.cmbPodaciZaDohvatanje.Location = new System.Drawing.Point(8, 254);
            this.cmbPodaciZaDohvatanje.Name = "cmbPodaciZaDohvatanje";
            this.cmbPodaciZaDohvatanje.Size = new System.Drawing.Size(126, 26);
            this.cmbPodaciZaDohvatanje.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 318);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 18);
            this.lblStatus.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(8, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Izlaz";
            this.btnExit.ToolTipText = "Izlaz iz aplikacije";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblBrojRedova
            // 
            this.lblBrojRedova.AutoSize = true;
            this.lblBrojRedova.Location = new System.Drawing.Point(8, 64);
            this.lblBrojRedova.Name = "lblBrojRedova";
            this.lblBrojRedova.Size = new System.Drawing.Size(59, 18);
            this.lblBrojRedova.TabIndex = 17;
            this.lblBrojRedova.Text = "Redova";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txtFilterZaposleni);
            this.gbFilter.Controls.Add(lblFilterZaposleni);
            this.gbFilter.Location = new System.Drawing.Point(3, 90);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(135, 87);
            this.gbFilter.TabIndex = 16;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filteri";
            // 
            // txtFilterZaposleni
            // 
            this.txtFilterZaposleni.BindingSource = null;
            this.txtFilterZaposleni.Location = new System.Drawing.Point(7, 54);
            this.txtFilterZaposleni.Name = "txtFilterZaposleni";
            this.txtFilterZaposleni.ShouldBeCyrillic = false;
            this.txtFilterZaposleni.Size = new System.Drawing.Size(122, 24);
            this.txtFilterZaposleni.TabIndex = 2;
            this.txtFilterZaposleni.TextChanged += new System.EventHandler(this.TxtFilterZaposleni_TextChanged);
            // 
            // btnDohvatiPodatke
            // 
            this.btnDohvatiPodatke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDohvatiPodatke.Location = new System.Drawing.Point(8, 201);
            this.btnDohvatiPodatke.Name = "btnDohvatiPodatke";
            this.btnDohvatiPodatke.Size = new System.Drawing.Size(126, 30);
            this.btnDohvatiPodatke.TabIndex = 15;
            this.btnDohvatiPodatke.Text = "Dohvati podatke";
            this.btnDohvatiPodatke.ToolTipText = "Dohvatanje rešenja za selekto";
            this.btnDohvatiPodatke.UseVisualStyleBackColor = true;
            this.btnDohvatiPodatke.Click += new System.EventHandler(this.BtnDohvatiPodatke_Click);
            // 
            // dgvObrazovanja
            // 
            this.dgvObrazovanja.AllowUserToAddRows = false;
            this.dgvObrazovanja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvObrazovanja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObrazovanja.AutoGenerateColumns = false;
            this.dgvObrazovanja.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObrazovanja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvObrazovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObrazovanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zaposleniDataGridViewTextBoxColumn,
            this.noksNivoDataGridViewCheckBoxColumn,
            this.dgvcKlasnoks,
            this.stepenDataGridViewCheckBoxColumn,
            this.NazivSteceneKvalifikacije,
            this.StrucniAkademskiNazivIzDiplome,
            this.dgvcDatumSticanjaDiplome,
            this.DrzavaZavrseneSkole,
            this.MestoZavrseneSkoleNaziv,
            this.NazivSkole,
            this.JezikNaKomJeStecenoObrazovanje,
            this.dgvcDokument});
            this.dgvObrazovanja.ColumnsForCopyOnClick = null;
            this.dgvObrazovanja.CopyOnCellClick = false;
            this.dgvObrazovanja.CtrlDisplayPositionRowCount = this.lblBrojRedova;
            this.dgvObrazovanja.DataSource = this.bsObrazovanja;
            this.dgvObrazovanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObrazovanja.Location = new System.Drawing.Point(150, 0);
            this.dgvObrazovanja.Name = "dgvObrazovanja";
            this.dgvObrazovanja.ReadOnly = true;
            this.dgvObrazovanja.RowHeadersWidth = 30;
            this.dgvObrazovanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObrazovanja.Size = new System.Drawing.Size(1310, 347);
            this.dgvObrazovanja.StandardSort = null;
            this.dgvObrazovanja.TabIndex = 1;
            this.dgvObrazovanja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvObrazovanja_CellClick);
            // 
            // bsObrazovanja
            // 
            this.bsObrazovanja.DataMember = "Obrazovanja";
            this.bsObrazovanja.DataSource = this.ds;
            this.bsObrazovanja.Sort = "_Zaposleni";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposleniDataGridViewTextBoxColumn
            // 
            this.zaposleniDataGridViewTextBoxColumn.DataPropertyName = "_Zaposleni";
            this.zaposleniDataGridViewTextBoxColumn.HeaderText = "Zaposleni";
            this.zaposleniDataGridViewTextBoxColumn.Name = "zaposleniDataGridViewTextBoxColumn";
            this.zaposleniDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposleniDataGridViewTextBoxColumn.Width = 185;
            // 
            // noksNivoDataGridViewCheckBoxColumn
            // 
            this.noksNivoDataGridViewCheckBoxColumn.DataPropertyName = "NoksNivo";
            this.noksNivoDataGridViewCheckBoxColumn.HeaderText = "NOKS nivo";
            this.noksNivoDataGridViewCheckBoxColumn.Name = "noksNivoDataGridViewCheckBoxColumn";
            this.noksNivoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.noksNivoDataGridViewCheckBoxColumn.ToolTipText = "Unet NOKS nivo";
            // 
            // dgvcKlasnoks
            // 
            this.dgvcKlasnoks.DataPropertyName = "Klasnoks";
            this.dgvcKlasnoks.HeaderText = "Klasa NOKS";
            this.dgvcKlasnoks.Name = "dgvcKlasnoks";
            this.dgvcKlasnoks.ReadOnly = true;
            this.dgvcKlasnoks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcKlasnoks.ToolTipText = "Uneta Klasa NOKS";
            // 
            // stepenDataGridViewCheckBoxColumn
            // 
            this.stepenDataGridViewCheckBoxColumn.DataPropertyName = "Stepen";
            this.stepenDataGridViewCheckBoxColumn.HeaderText = "Stepen";
            this.stepenDataGridViewCheckBoxColumn.Name = "stepenDataGridViewCheckBoxColumn";
            this.stepenDataGridViewCheckBoxColumn.ReadOnly = true;
            this.stepenDataGridViewCheckBoxColumn.ToolTipText = "Unet Stepen";
            // 
            // NazivSteceneKvalifikacije
            // 
            this.NazivSteceneKvalifikacije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivSteceneKvalifikacije.DataPropertyName = "NazivSteceneKvalifikacije";
            this.NazivSteceneKvalifikacije.HeaderText = "Kvalifikacija";
            this.NazivSteceneKvalifikacije.MinimumWidth = 100;
            this.NazivSteceneKvalifikacije.Name = "NazivSteceneKvalifikacije";
            this.NazivSteceneKvalifikacije.ReadOnly = true;
            // 
            // StrucniAkademskiNazivIzDiplome
            // 
            this.StrucniAkademskiNazivIzDiplome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StrucniAkademskiNazivIzDiplome.DataPropertyName = "StrucniAkademskiNazivIzDiplome";
            this.StrucniAkademskiNazivIzDiplome.HeaderText = "Stručni ak. naziv";
            this.StrucniAkademskiNazivIzDiplome.MinimumWidth = 100;
            this.StrucniAkademskiNazivIzDiplome.Name = "StrucniAkademskiNazivIzDiplome";
            this.StrucniAkademskiNazivIzDiplome.ReadOnly = true;
            // 
            // dgvcDatumSticanjaDiplome
            // 
            this.dgvcDatumSticanjaDiplome.DataPropertyName = "DatumSticanjaDiplome";
            this.dgvcDatumSticanjaDiplome.HeaderText = "Datum";
            this.dgvcDatumSticanjaDiplome.Name = "dgvcDatumSticanjaDiplome";
            this.dgvcDatumSticanjaDiplome.ReadOnly = true;
            // 
            // DrzavaZavrseneSkole
            // 
            this.DrzavaZavrseneSkole.DataPropertyName = "DrzavaZavrseneSkole";
            this.DrzavaZavrseneSkole.HeaderText = "Država";
            this.DrzavaZavrseneSkole.Name = "DrzavaZavrseneSkole";
            this.DrzavaZavrseneSkole.ReadOnly = true;
            this.DrzavaZavrseneSkole.ToolTipText = "Uneta Država";
            // 
            // MestoZavrseneSkoleNaziv
            // 
            this.MestoZavrseneSkoleNaziv.DataPropertyName = "MestoZavrseneSkoleNaziv";
            this.MestoZavrseneSkoleNaziv.HeaderText = "Mesto";
            this.MestoZavrseneSkoleNaziv.Name = "MestoZavrseneSkoleNaziv";
            this.MestoZavrseneSkoleNaziv.ReadOnly = true;
            this.MestoZavrseneSkoleNaziv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NazivSkole
            // 
            this.NazivSkole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivSkole.DataPropertyName = "NazivSkole";
            this.NazivSkole.HeaderText = "Škola";
            this.NazivSkole.MinimumWidth = 100;
            this.NazivSkole.Name = "NazivSkole";
            this.NazivSkole.ReadOnly = true;
            // 
            // JezikNaKomJeStecenoObrazovanje
            // 
            this.JezikNaKomJeStecenoObrazovanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.JezikNaKomJeStecenoObrazovanje.DataPropertyName = "JezikNaKomJeStecenoObrazovanje";
            this.JezikNaKomJeStecenoObrazovanje.HeaderText = "Jezik";
            this.JezikNaKomJeStecenoObrazovanje.Name = "JezikNaKomJeStecenoObrazovanje";
            this.JezikNaKomJeStecenoObrazovanje.ReadOnly = true;
            this.JezikNaKomJeStecenoObrazovanje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JezikNaKomJeStecenoObrazovanje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.JezikNaKomJeStecenoObrazovanje.ToolTipText = "Unet Jezik";
            this.JezikNaKomJeStecenoObrazovanje.Width = 68;
            // 
            // dgvcDokument
            // 
            this.dgvcDokument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDokument.DataPropertyName = "DokumentNaziv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvcDokument.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcDokument.HeaderText = "Dokument";
            this.dgvcDokument.MinimumWidth = 100;
            this.dgvcDokument.Name = "dgvcDokument";
            this.dgvcDokument.ReadOnly = true;
            // 
            // FrmObrazovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 347);
            this.Controls.Add(this.dgvObrazovanja);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmObrazovanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obrazovanje";
            this.Load += new System.EventHandler(this.FrmObrazovanje_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrazovanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObrazovanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcLeftPanel pnlLeft;
        private Controls.UcDGV dgvObrazovanja;
        private Controls.UcButton btnDohvatiPodatke;
        private Controls.UcExitAppButton btnExit;
        private System.Windows.Forms.Label lblBrojRedova;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivSteceneKvalifikacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucniAkademskiNazivIzDiplomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsObrazovanja;
        private Data.Ds ds;
        private Controls.UcFilterTextBox txtFilterZaposleni;
        private System.Windows.Forms.ComboBox cmbPodaciZaDohvatanje;
        private System.Windows.Forms.Label lblIzvorSelZaposlenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposleniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn noksNivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcKlasnoks;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stepenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivSteceneKvalifikacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrucniAkademskiNazivIzDiplome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDatumSticanjaDiplome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DrzavaZavrseneSkole;
        private System.Windows.Forms.DataGridViewTextBoxColumn MestoZavrseneSkoleNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivSkole;
        private System.Windows.Forms.DataGridViewCheckBoxColumn JezikNaKomJeStecenoObrazovanje;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcDokument;
    }
}