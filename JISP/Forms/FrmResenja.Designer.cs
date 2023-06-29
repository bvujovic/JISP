namespace JISP.Forms
{
    partial class FrmResenja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsResenja = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.dgvResenjaSva = new JISP.Controls.UcDGV();
            this.dgvcZaposleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojResenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skolskaGodinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipResenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procenatAngPoResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPodnosenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAktivnoResenje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcDokument = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblBrojRedova = new System.Windows.Forms.Label();
            this.pnlBottomLeftRes = new JISP.Controls.UcLeftPanel();
            this.chkSamoAktivnaZaposlenja = new System.Windows.Forms.CheckBox();
            this.gbAkcije = new System.Windows.Forms.GroupBox();
            this.cmbAkcije = new System.Windows.Forms.ComboBox();
            this.btnAkcijaPokreni = new JISP.Controls.UcButton();
            this.btnExit = new JISP.Controls.UcExitAppButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.chkAktivniUgovori = new System.Windows.Forms.CheckBox();
            this.cmbSkGod = new System.Windows.Forms.ComboBox();
            this.cmbTipoviResenja = new System.Windows.Forms.ComboBox();
            this.btnUcitajResenja = new JISP.Controls.UcButton();
            this.ttSamoAktivnaZaposlenja = new System.Windows.Forms.ToolTip(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsResenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResenjaSva)).BeginInit();
            this.pnlBottomLeftRes.SuspendLayout();
            this.gbAkcije.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 18);
            label1.TabIndex = 7;
            label1.Text = "Školska godina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 18);
            label2.TabIndex = 9;
            label2.Text = "Tip rešenja";
            // 
            // bsResenja
            // 
            this.bsResenja.DataMember = "Resenja";
            this.bsResenja.DataSource = this.ds;
            this.bsResenja.Sort = "_Zaposleni, SkolskaGodina";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvResenjaSva
            // 
            this.dgvResenjaSva.AllowUserToAddRows = false;
            this.dgvResenjaSva.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvResenjaSva.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResenjaSva.AutoGenerateColumns = false;
            this.dgvResenjaSva.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResenjaSva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResenjaSva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResenjaSva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcZaposleni,
            this.brojResenjaDataGridViewTextBoxColumn,
            this.skolskaGodinaDataGridViewTextBoxColumn,
            this.tipResenjaDataGridViewTextBoxColumn,
            this.procenatAngPoResDataGridViewTextBoxColumn,
            this.datumPodnosenjaDataGridViewTextBoxColumn,
            this.dgvcAktivnoResenje,
            this.dgvcDokument});
            this.dgvResenjaSva.ColumnsForCopyOnClick = null;
            this.dgvResenjaSva.CopyOnCellClick = false;
            this.dgvResenjaSva.CtrlDisplayPositionRowCount = this.lblBrojRedova;
            this.dgvResenjaSva.DataSource = this.bsResenja;
            this.dgvResenjaSva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResenjaSva.Location = new System.Drawing.Point(146, 0);
            this.dgvResenjaSva.Name = "dgvResenjaSva";
            this.dgvResenjaSva.ReadOnly = true;
            this.dgvResenjaSva.RowHeadersWidth = 30;
            this.dgvResenjaSva.RowTemplate.Height = 24;
            this.dgvResenjaSva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResenjaSva.Size = new System.Drawing.Size(962, 450);
            this.dgvResenjaSva.StandardSort = null;
            this.dgvResenjaSva.TabIndex = 2;
            this.dgvResenjaSva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResenjaSva_CellClick);
            // 
            // dgvcZaposleni
            // 
            this.dgvcZaposleni.DataPropertyName = "_Zaposleni";
            this.dgvcZaposleni.HeaderText = "Zaposleni";
            this.dgvcZaposleni.Name = "dgvcZaposleni";
            this.dgvcZaposleni.ReadOnly = true;
            this.dgvcZaposleni.Width = 175;
            // 
            // brojResenjaDataGridViewTextBoxColumn
            // 
            this.brojResenjaDataGridViewTextBoxColumn.DataPropertyName = "BrojResenja";
            this.brojResenjaDataGridViewTextBoxColumn.HeaderText = "Broj Rešenja";
            this.brojResenjaDataGridViewTextBoxColumn.Name = "brojResenjaDataGridViewTextBoxColumn";
            this.brojResenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojResenjaDataGridViewTextBoxColumn.Width = 115;
            // 
            // skolskaGodinaDataGridViewTextBoxColumn
            // 
            this.skolskaGodinaDataGridViewTextBoxColumn.DataPropertyName = "SkolskaGodina";
            this.skolskaGodinaDataGridViewTextBoxColumn.HeaderText = "Šk. God";
            this.skolskaGodinaDataGridViewTextBoxColumn.Name = "skolskaGodinaDataGridViewTextBoxColumn";
            this.skolskaGodinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipResenjaDataGridViewTextBoxColumn
            // 
            this.tipResenjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipResenjaDataGridViewTextBoxColumn.DataPropertyName = "TipResenja";
            this.tipResenjaDataGridViewTextBoxColumn.FillWeight = 250F;
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
            // datumPodnosenjaDataGridViewTextBoxColumn
            // 
            this.datumPodnosenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumPodnosenja";
            this.datumPodnosenjaDataGridViewTextBoxColumn.HeaderText = "Podneto";
            this.datumPodnosenjaDataGridViewTextBoxColumn.Name = "datumPodnosenjaDataGridViewTextBoxColumn";
            this.datumPodnosenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvcAktivnoResenje
            // 
            this.dgvcAktivnoResenje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcAktivnoResenje.DataPropertyName = "AktivnoResenje";
            this.dgvcAktivnoResenje.HeaderText = "Aktivno";
            this.dgvcAktivnoResenje.Name = "dgvcAktivnoResenje";
            this.dgvcAktivnoResenje.ReadOnly = true;
            this.dgvcAktivnoResenje.Width = 62;
            // 
            // dgvcDokument
            // 
            this.dgvcDokument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDokument.DataPropertyName = "Dokument";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvcDokument.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcDokument.HeaderText = "Dokument";
            this.dgvcDokument.Name = "dgvcDokument";
            this.dgvcDokument.ReadOnly = true;
            this.dgvcDokument.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcDokument.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblBrojRedova
            // 
            this.lblBrojRedova.AutoSize = true;
            this.lblBrojRedova.Location = new System.Drawing.Point(8, 64);
            this.lblBrojRedova.Name = "lblBrojRedova";
            this.lblBrojRedova.Size = new System.Drawing.Size(59, 18);
            this.lblBrojRedova.TabIndex = 12;
            this.lblBrojRedova.Text = "Redova";
            // 
            // pnlBottomLeftRes
            // 
            this.pnlBottomLeftRes.Controls.Add(this.chkSamoAktivnaZaposlenja);
            this.pnlBottomLeftRes.Controls.Add(this.gbAkcije);
            this.pnlBottomLeftRes.Controls.Add(this.btnExit);
            this.pnlBottomLeftRes.Controls.Add(this.lblBrojRedova);
            this.pnlBottomLeftRes.Controls.Add(this.lblStatus);
            this.pnlBottomLeftRes.Controls.Add(this.gbFilter);
            this.pnlBottomLeftRes.Controls.Add(this.btnUcitajResenja);
            this.pnlBottomLeftRes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottomLeftRes.Location = new System.Drawing.Point(0, 0);
            this.pnlBottomLeftRes.Name = "pnlBottomLeftRes";
            this.pnlBottomLeftRes.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlBottomLeftRes.RightWingWidth = 6;
            this.pnlBottomLeftRes.Size = new System.Drawing.Size(146, 450);
            this.pnlBottomLeftRes.TabIndex = 1;
            // 
            // chkSamoAktivnaZaposlenja
            // 
            this.chkSamoAktivnaZaposlenja.AutoSize = true;
            this.chkSamoAktivnaZaposlenja.Checked = true;
            this.chkSamoAktivnaZaposlenja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSamoAktivnaZaposlenja.Location = new System.Drawing.Point(8, 399);
            this.chkSamoAktivnaZaposlenja.Name = "chkSamoAktivnaZaposlenja";
            this.chkSamoAktivnaZaposlenja.Size = new System.Drawing.Size(118, 22);
            this.chkSamoAktivnaZaposlenja.TabIndex = 17;
            this.chkSamoAktivnaZaposlenja.Text = "Samo aktivno";
            this.chkSamoAktivnaZaposlenja.UseVisualStyleBackColor = true;
            // 
            // gbAkcije
            // 
            this.gbAkcije.Controls.Add(this.cmbAkcije);
            this.gbAkcije.Controls.Add(this.btnAkcijaPokreni);
            this.gbAkcije.Location = new System.Drawing.Point(3, 254);
            this.gbAkcije.Name = "gbAkcije";
            this.gbAkcije.Size = new System.Drawing.Size(135, 96);
            this.gbAkcije.TabIndex = 16;
            this.gbAkcije.TabStop = false;
            this.gbAkcije.Text = "Akcije";
            // 
            // cmbAkcije
            // 
            this.cmbAkcije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAkcije.FormattingEnabled = true;
            this.cmbAkcije.Location = new System.Drawing.Point(6, 23);
            this.cmbAkcije.Name = "cmbAkcije";
            this.cmbAkcije.Size = new System.Drawing.Size(121, 26);
            this.cmbAkcije.TabIndex = 13;
            // 
            // btnAkcijaPokreni
            // 
            this.btnAkcijaPokreni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAkcijaPokreni.Location = new System.Drawing.Point(6, 55);
            this.btnAkcijaPokreni.Name = "btnAkcijaPokreni";
            this.btnAkcijaPokreni.Size = new System.Drawing.Size(121, 30);
            this.btnAkcijaPokreni.TabIndex = 14;
            this.btnAkcijaPokreni.Text = "OK";
            this.btnAkcijaPokreni.ToolTipText = "Dohvatanje rešenja za selekto";
            this.btnAkcijaPokreni.UseVisualStyleBackColor = true;
            this.btnAkcijaPokreni.Click += new System.EventHandler(this.BtnAkcijaPokreni_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(8, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 28);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Izlaz";
            this.btnExit.ToolTipText = "Izlaz iz aplikacije";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 423);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 18);
            this.lblStatus.TabIndex = 11;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.chkAktivniUgovori);
            this.gbFilter.Controls.Add(this.cmbSkGod);
            this.gbFilter.Controls.Add(label1);
            this.gbFilter.Controls.Add(label2);
            this.gbFilter.Controls.Add(this.cmbTipoviResenja);
            this.gbFilter.Location = new System.Drawing.Point(3, 90);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(135, 154);
            this.gbFilter.TabIndex = 10;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filteri";
            // 
            // chkAktivniUgovori
            // 
            this.chkAktivniUgovori.AutoSize = true;
            this.chkAktivniUgovori.Location = new System.Drawing.Point(6, 121);
            this.chkAktivniUgovori.Name = "chkAktivniUgovori";
            this.chkAktivniUgovori.Size = new System.Drawing.Size(122, 22);
            this.chkAktivniUgovori.TabIndex = 10;
            this.chkAktivniUgovori.Text = "Aktivni ugovori";
            this.chkAktivniUgovori.UseVisualStyleBackColor = true;
            this.chkAktivniUgovori.CheckedChanged += new System.EventHandler(this.ChkAktivniUgovori_CheckedChanged);
            // 
            // cmbSkGod
            // 
            this.cmbSkGod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkGod.FormattingEnabled = true;
            this.cmbSkGod.Location = new System.Drawing.Point(6, 41);
            this.cmbSkGod.Name = "cmbSkGod";
            this.cmbSkGod.Size = new System.Drawing.Size(121, 26);
            this.cmbSkGod.TabIndex = 6;
            this.cmbSkGod.SelectedIndexChanged += new System.EventHandler(this.CmbSkGod_SelectedIndexChanged);
            // 
            // cmbTipoviResenja
            // 
            this.cmbTipoviResenja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoviResenja.FormattingEnabled = true;
            this.cmbTipoviResenja.Location = new System.Drawing.Point(6, 89);
            this.cmbTipoviResenja.Name = "cmbTipoviResenja";
            this.cmbTipoviResenja.Size = new System.Drawing.Size(121, 26);
            this.cmbTipoviResenja.TabIndex = 8;
            this.cmbTipoviResenja.SelectedIndexChanged += new System.EventHandler(this.CmbTipoviResenja_SelectedIndexChanged);
            // 
            // btnUcitajResenja
            // 
            this.btnUcitajResenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajResenja.Location = new System.Drawing.Point(8, 368);
            this.btnUcitajResenja.Name = "btnUcitajResenja";
            this.btnUcitajResenja.Size = new System.Drawing.Size(121, 30);
            this.btnUcitajResenja.TabIndex = 5;
            this.btnUcitajResenja.Text = "Učitaj rešenja";
            this.btnUcitajResenja.ToolTipText = "Dohvatanje rešenja za selektovane zaposlene";
            this.btnUcitajResenja.UseVisualStyleBackColor = true;
            this.btnUcitajResenja.Click += new System.EventHandler(this.BtnUcitajResenja_Click);
            // 
            // FrmResenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.dgvResenjaSva);
            this.Controls.Add(this.pnlBottomLeftRes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Name = "FrmResenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rešenja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmResenja_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmResenja_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bsResenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResenjaSva)).EndInit();
            this.pnlBottomLeftRes.ResumeLayout(false);
            this.pnlBottomLeftRes.PerformLayout();
            this.gbAkcije.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcLeftPanel pnlBottomLeftRes;
        private Controls.UcButton btnUcitajResenja;
        private Controls.UcDGV dgvResenjaSva;
        private System.Windows.Forms.BindingSource bsResenja;
        private Data.Ds ds;
        private System.Windows.Forms.ComboBox cmbSkGod;
        private System.Windows.Forms.ComboBox cmbTipoviResenja;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBrojRedova;
        private Controls.UcButton btnAkcijaPokreni;
        private System.Windows.Forms.ComboBox cmbAkcije;
        private Controls.UcExitAppButton btnExit;
        private System.Windows.Forms.GroupBox gbAkcije;
        private System.Windows.Forms.CheckBox chkSamoAktivnaZaposlenja;
        private System.Windows.Forms.ToolTip ttSamoAktivnaZaposlenja;
        private System.Windows.Forms.CheckBox chkAktivniUgovori;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojResenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolskaGodinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipResenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procenatAngPoResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPodnosenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcAktivnoResenje;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcDokument;
    }
}