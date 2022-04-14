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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.btnLoadData = new JISP.Controls.UcButton();
            this.btnExit = new JISP.Controls.UcExitAppButton();
            this.pnlZaposleniTop = new System.Windows.Forms.Panel();
            this.chkAktivno = new System.Windows.Forms.CheckBox();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.ucDGV1 = new JISP.Controls.UcDGV();
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
            this.pnlLeft.SuspendLayout();
            this.pnlZaposleniTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnLoadData);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(146, 360);
            this.pnlLeft.TabIndex = 2;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(8, 58);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(128, 40);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Učitaj podatke";
            this.btnLoadData.ToolTipText = "Dohvatanje podataka o zaposlenima (ime, prezime, JMBG, zaposlenja).";
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
            this.pnlZaposleniTop.Location = new System.Drawing.Point(146, 0);
            this.pnlZaposleniTop.Name = "pnlZaposleniTop";
            this.pnlZaposleniTop.Size = new System.Drawing.Size(835, 30);
            this.pnlZaposleniTop.TabIndex = 3;
            // 
            // chkAktivno
            // 
            this.chkAktivno.AutoSize = true;
            this.chkAktivno.Checked = true;
            this.chkAktivno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktivno.Location = new System.Drawing.Point(237, 4);
            this.chkAktivno.Name = "chkAktivno";
            this.chkAktivno.Size = new System.Drawing.Size(69, 22);
            this.chkAktivno.TabIndex = 1;
            this.chkAktivno.Text = "Aktivni";
            this.chkAktivno.UseVisualStyleBackColor = true;
            this.chkAktivno.CheckedChanged += new System.EventHandler(this.ChkAktivno_CheckedChanged);
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
            this.aktivanDataGridViewCheckBoxColumn,
            this.brojUgovoraORaduDataGridViewTextBoxColumn,
            this.radnoMestoNazivDataGridViewTextBoxColumn,
            this.procenatRadnogVremenaDataGridViewTextBoxColumn,
            this.datumZaposlenOdDataGridViewTextBoxColumn,
            this.datumZaposlenDoDataGridViewTextBoxColumn,
            this.noksNivoNazivDataGridViewTextBoxColumn,
            this.vrstaAngazovanjaDataGridViewTextBoxColumn});
            this.ucDGV1.ColumnsForCopyOnClick = null;
            this.ucDGV1.CopyOnCellClick = true;
            this.ucDGV1.CtrlDisplayPositionRowCount = this.lblRowCount;
            this.ucDGV1.DataSource = this.bsZaposlenja;
            this.ucDGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDGV1.Location = new System.Drawing.Point(146, 30);
            this.ucDGV1.Name = "ucDGV1";
            this.ucDGV1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ucDGV1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ucDGV1.RowHeadersWidth = 30;
            this.ucDGV1.Size = new System.Drawing.Size(835, 330);
            this.ucDGV1.StandardSort = null;
            this.ucDGV1.TabIndex = 4;
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            this.aktivanDataGridViewCheckBoxColumn.DataPropertyName = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.HeaderText = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            this.aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktivanDataGridViewCheckBoxColumn.Width = 70;
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
            this.bsZaposlenja.Sort = "Aktivan, DatumZaposlenOd";
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmZaposlenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 360);
            this.Controls.Add(this.ucDGV1);
            this.Controls.Add(this.pnlZaposleniTop);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Icon = global::JISP.Properties.Resources.grb_srb;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZaposlenja";
            this.Text = "Zaposlenja";
            this.pnlLeft.ResumeLayout(false);
            this.pnlZaposleniTop.ResumeLayout(false);
            this.pnlZaposleniTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcLeftPanel pnlLeft;
        private Controls.UcButton btnLoadData;
        private Controls.UcExitAppButton btnExit;
        private System.Windows.Forms.Panel pnlZaposleniTop;
        private System.Windows.Forms.CheckBox chkAktivno;
        private System.Windows.Forms.Label lblRowCount;
        private Controls.UcDGV ucDGV1;
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
    }
}