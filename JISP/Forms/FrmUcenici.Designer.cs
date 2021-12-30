﻿namespace JISP.Forms
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
            this.bsUcenici = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv = new JISP.Controls.UcDGV();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.btnOpstiPodaci = new JISP.Controls.UcButton();
            this.btnUcitajSveJOBove = new JISP.Controls.UcButton();
            this.btnOdRaz = new JISP.Controls.UcButton();
            this.chkAllowNew = new System.Windows.Forms.CheckBox();
            this.btnSrednjoskolci = new JISP.Controls.UcButton();
            this.ucExitApp1 = new JISP.Controls.UcExitAppButton();
            this.lblRowCount = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsUcenici
            // 
            this.bsUcenici.DataMember = "Ucenici";
            this.bsUcenici.DataSource = this.ds;
            this.bsUcenici.Sort = "Skola, Razred, Odeljenje";
            this.bsUcenici.CurrentChanged += new System.EventHandler(this.BsUcenici_CurrentChanged);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 423);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1297, 27);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 21);
            this.lblStatus.Text = "/";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvcGodine});
            this.dgv.CopyOnCellClick = false;
            this.dgv.DataSource = this.bsUcenici;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(150, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 30;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1147, 423);
            this.dgv.TabIndex = 1;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dgv_DataError);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnOpstiPodaci);
            this.pnlLeft.Controls.Add(this.btnUcitajSveJOBove);
            this.pnlLeft.Controls.Add(this.btnOdRaz);
            this.pnlLeft.Controls.Add(this.chkAllowNew);
            this.pnlLeft.Controls.Add(this.btnSrednjoskolci);
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
            this.pnlLeft.Size = new System.Drawing.Size(150, 423);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnOpstiPodaci
            // 
            this.btnOpstiPodaci.Location = new System.Drawing.Point(7, 302);
            this.btnOpstiPodaci.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpstiPodaci.Name = "btnOpstiPodaci";
            this.btnOpstiPodaci.Size = new System.Drawing.Size(127, 38);
            this.btnOpstiPodaci.TabIndex = 6;
            this.btnOpstiPodaci.Text = "Opšti podaci";
            this.btnOpstiPodaci.ToolTipText = "Uzimanje opštih podataka (datum rođenja, ...) za selektovane učenike";
            this.btnOpstiPodaci.UseVisualStyleBackColor = false;
            this.btnOpstiPodaci.Click += new System.EventHandler(this.BtnOpstiPodaci_Click);
            // 
            // btnUcitajSveJOBove
            // 
            this.btnUcitajSveJOBove.Location = new System.Drawing.Point(7, 256);
            this.btnUcitajSveJOBove.Margin = new System.Windows.Forms.Padding(4);
            this.btnUcitajSveJOBove.Name = "btnUcitajSveJOBove";
            this.btnUcitajSveJOBove.Size = new System.Drawing.Size(127, 38);
            this.btnUcitajSveJOBove.TabIndex = 5;
            this.btnUcitajSveJOBove.Text = "Novi učenici?...";
            this.btnUcitajSveJOBove.ToolTipText = null;
            this.btnUcitajSveJOBove.UseVisualStyleBackColor = false;
            this.btnUcitajSveJOBove.Click += new System.EventHandler(this.BtnNoviUcenici_Click);
            // 
            // btnOdRaz
            // 
            this.btnOdRaz.Location = new System.Drawing.Point(7, 210);
            this.btnOdRaz.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdRaz.Name = "btnOdRaz";
            this.btnOdRaz.Size = new System.Drawing.Size(127, 38);
            this.btnOdRaz.TabIndex = 4;
            this.btnOdRaz.Text = "Razredi i odelj.";
            this.btnOdRaz.ToolTipText = null;
            this.btnOdRaz.UseVisualStyleBackColor = false;
            this.btnOdRaz.Click += new System.EventHandler(this.BtnOdRaz_Click);
            // 
            // chkAllowNew
            // 
            this.chkAllowNew.AutoSize = true;
            this.chkAllowNew.Location = new System.Drawing.Point(7, 125);
            this.chkAllowNew.Name = "chkAllowNew";
            this.chkAllowNew.Size = new System.Drawing.Size(167, 24);
            this.chkAllowNew.TabIndex = 1;
            this.chkAllowNew.Text = "Dozvoli dodavanje";
            this.chkAllowNew.UseVisualStyleBackColor = true;
            this.chkAllowNew.CheckedChanged += new System.EventHandler(this.ChkAllowNew_CheckedChanged);
            // 
            // btnSrednjoskolci
            // 
            this.btnSrednjoskolci.Location = new System.Drawing.Point(7, 164);
            this.btnSrednjoskolci.Margin = new System.Windows.Forms.Padding(4);
            this.btnSrednjoskolci.Name = "btnSrednjoskolci";
            this.btnSrednjoskolci.Size = new System.Drawing.Size(127, 38);
            this.btnSrednjoskolci.TabIndex = 3;
            this.btnSrednjoskolci.Text = "Srednjoškolci";
            this.btnSrednjoskolci.ToolTipText = null;
            this.btnSrednjoskolci.UseVisualStyleBackColor = true;
            this.btnSrednjoskolci.Click += new System.EventHandler(this.BtnSrednjoskolci_Click);
            // 
            // ucExitApp1
            // 
            this.ucExitApp1.BackColor = System.Drawing.Color.Red;
            this.ucExitApp1.ForeColor = System.Drawing.Color.White;
            this.ucExitApp1.Location = new System.Drawing.Point(7, 15);
            this.ucExitApp1.Margin = new System.Windows.Forms.Padding(4);
            this.ucExitApp1.Name = "ucExitApp1";
            this.ucExitApp1.Size = new System.Drawing.Size(127, 34);
            this.ucExitApp1.TabIndex = 101;
            this.ucExitApp1.Text = "Izlaz";
            this.ucExitApp1.ToolTipText = "Izlaz iz aplikacije";
            this.ucExitApp1.UseVisualStyleBackColor = false;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(4, 66);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(65, 20);
            this.lblRowCount.TabIndex = 3;
            this.lblRowCount.Text = "Redova";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveData.Location = new System.Drawing.Point(7, 381);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(127, 38);
            this.btnSaveData.TabIndex = 100;
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
            this.txtFilter.Size = new System.Drawing.Size(127, 26);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFilter_KeyDown);
            // 
            // dgvcIdUcenika
            // 
            this.dgvcIdUcenika.DataPropertyName = "IdUcenika";
            this.dgvcIdUcenika.HeaderText = "IdUcenika";
            this.dgvcIdUcenika.MinimumWidth = 6;
            this.dgvcIdUcenika.Name = "dgvcIdUcenika";
            this.dgvcIdUcenika.Visible = false;
            this.dgvcIdUcenika.Width = 125;
            // 
            // dgvcIme
            // 
            this.dgvcIme.DataPropertyName = "Ime";
            this.dgvcIme.HeaderText = "Učenik";
            this.dgvcIme.MinimumWidth = 6;
            this.dgvcIme.Name = "dgvcIme";
            this.dgvcIme.Width = 265;
            // 
            // dgvcPrezime
            // 
            this.dgvcPrezime.DataPropertyName = "Prezime";
            this.dgvcPrezime.HeaderText = "Prezime";
            this.dgvcPrezime.MinimumWidth = 6;
            this.dgvcPrezime.Name = "dgvcPrezime";
            this.dgvcPrezime.Visible = false;
            this.dgvcPrezime.Width = 125;
            // 
            // dgvcJOB
            // 
            this.dgvcJOB.DataPropertyName = "JOB";
            this.dgvcJOB.HeaderText = "JOB";
            this.dgvcJOB.MinimumWidth = 6;
            this.dgvcJOB.Name = "dgvcJOB";
            this.dgvcJOB.Width = 180;
            // 
            // dgvcSkola
            // 
            this.dgvcSkola.DataPropertyName = "Skola";
            this.dgvcSkola.HeaderText = "Škola";
            this.dgvcSkola.MinimumWidth = 6;
            this.dgvcSkola.Name = "dgvcSkola";
            this.dgvcSkola.Width = 125;
            // 
            // dgvcRazred
            // 
            this.dgvcRazred.DataPropertyName = "Razred";
            this.dgvcRazred.HeaderText = "Razred";
            this.dgvcRazred.MinimumWidth = 6;
            this.dgvcRazred.Name = "dgvcRazred";
            this.dgvcRazred.Width = 125;
            // 
            // dgvcOdeljenje
            // 
            this.dgvcOdeljenje.DataPropertyName = "Odeljenje";
            this.dgvcOdeljenje.HeaderText = "Odeljenje";
            this.dgvcOdeljenje.MinimumWidth = 6;
            this.dgvcOdeljenje.Name = "dgvcOdeljenje";
            this.dgvcOdeljenje.Width = 125;
            // 
            // dgvcNapomene
            // 
            this.dgvcNapomene.DataPropertyName = "Napomene";
            this.dgvcNapomene.HeaderText = "Napomene";
            this.dgvcNapomene.MinimumWidth = 6;
            this.dgvcNapomene.Name = "dgvcNapomene";
            this.dgvcNapomene.Width = 125;
            // 
            // dgvcPol
            // 
            this.dgvcPol.DataPropertyName = "Pol";
            this.dgvcPol.HeaderText = "Pol";
            this.dgvcPol.MinimumWidth = 6;
            this.dgvcPol.Name = "dgvcPol";
            this.dgvcPol.Width = 50;
            // 
            // dgvcDatRodj
            // 
            this.dgvcDatRodj.DataPropertyName = "DatumRodjenja";
            this.dgvcDatRodj.HeaderText = "Dat Rođ";
            this.dgvcDatRodj.MinimumWidth = 6;
            this.dgvcDatRodj.Name = "dgvcDatRodj";
            this.dgvcDatRodj.Width = 125;
            // 
            // dgvcDanaDoRodj
            // 
            this.dgvcDanaDoRodj.DataPropertyName = "DanaDoRodj";
            this.dgvcDanaDoRodj.HeaderText = "Do Rođ.";
            this.dgvcDanaDoRodj.MinimumWidth = 6;
            this.dgvcDanaDoRodj.Name = "dgvcDanaDoRodj";
            this.dgvcDanaDoRodj.Width = 90;
            // 
            // dgvcGodine
            // 
            this.dgvcGodine.DataPropertyName = "Godine";
            dataGridViewCellStyle1.Format = "N1";
            this.dgvcGodine.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcGodine.HeaderText = "Godine";
            this.dgvcGodine.MinimumWidth = 6;
            this.dgvcGodine.Name = "dgvcGodine";
            this.dgvcGodine.Width = 75;
            // 
            // FrmUcenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::JISP.Properties.Resources.grb_srb;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUcenici";
            this.Text = "Učenici";
            this.Load += new System.EventHandler(this.FrmUcenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JISP.Controls.UcLeftPanel pnlLeft;
        private Controls.UcDGV dgv;
        private System.Windows.Forms.BindingSource bsUcenici;
        private Data.Ds ds;
        private Controls.UcFilterTextBox txtFilter;
        private Controls.UcButton btnSaveData;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private Controls.UcExitAppButton ucExitApp1;
        private Controls.UcButton btnSrednjoskolci;
        private System.Windows.Forms.CheckBox chkAllowNew;
        private Controls.UcButton btnOdRaz;
        private Controls.UcButton btnUcitajSveJOBove;
        private Controls.UcButton btnOpstiPodaci;
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
    }
}