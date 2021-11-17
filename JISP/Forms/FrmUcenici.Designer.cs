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
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.chkAllowNew = new System.Windows.Forms.CheckBox();
            this.btnSrednjoskolci = new System.Windows.Forms.Button();
            this.ucExitApp1 = new JISP.Controls.UcExitApp();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.ds = new JISP.Data.Ds();
            this.bsSkole = new System.Windows.Forms.BindingSource(this.components);
            this.bsUcenici = new System.Windows.Forms.BindingSource(this.components);
            this.dgv = new JISP.Controls.UcDGV();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvcIdUcenika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcJOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSkola = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSkole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
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
            // chkAllowNew
            // 
            this.chkAllowNew.AutoSize = true;
            this.chkAllowNew.Location = new System.Drawing.Point(7, 142);
            this.chkAllowNew.Name = "chkAllowNew";
            this.chkAllowNew.Size = new System.Drawing.Size(167, 24);
            this.chkAllowNew.TabIndex = 7;
            this.chkAllowNew.Text = "Dozvoli dodavanje";
            this.chkAllowNew.UseVisualStyleBackColor = true;
            this.chkAllowNew.CheckedChanged += new System.EventHandler(this.ChkAllowNew_CheckedChanged);
            // 
            // btnSrednjoskolci
            // 
            this.btnSrednjoskolci.Location = new System.Drawing.Point(7, 292);
            this.btnSrednjoskolci.Margin = new System.Windows.Forms.Padding(4);
            this.btnSrednjoskolci.Name = "btnSrednjoskolci";
            this.btnSrednjoskolci.Size = new System.Drawing.Size(127, 38);
            this.btnSrednjoskolci.TabIndex = 6;
            this.btnSrednjoskolci.Text = "Srednjoškolci";
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
            this.ucExitApp1.TabIndex = 5;
            this.ucExitApp1.Text = "Izlaz";
            this.ucExitApp1.UseVisualStyleBackColor = false;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(8, 81);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(65, 20);
            this.lblRowCount.TabIndex = 3;
            this.lblRowCount.Text = "Redova";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(7, 189);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(127, 38);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Sacuvaj podatke";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(7, 108);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(127, 26);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFilter_KeyDown);
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsSkole
            // 
            this.bsSkole.DataMember = "Skole";
            this.bsSkole.DataSource = this.ds;
            // 
            // bsUcenici
            // 
            this.bsUcenici.DataMember = "Ucenici";
            this.bsUcenici.DataSource = this.ds;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIdUcenika,
            this.dgvcIme,
            this.dgvcPrezime,
            this.dgvcJOB,
            this.dgvcSkola});
            this.dgv.DataSource = this.bsUcenici;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(150, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 30;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(843, 423);
            this.dgv.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 423);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(993, 27);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 21);
            this.lblStatus.Text = "/";
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
            this.dgvcIme.HeaderText = "Ucenik";
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
            this.dgvcSkola.HeaderText = "Škola";
            this.dgvcSkola.MinimumWidth = 6;
            this.dgvcSkola.Name = "dgvcSkola";
            this.dgvcSkola.Width = 125;
            // 
            // FrmUcenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUcenici";
            this.Text = "Ucenici";
            this.Load += new System.EventHandler(this.FrmUcenici_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSkole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUcenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JISP.Controls.UcLeftPanel pnlLeft;
        private Controls.UcDGV dgv;
        private System.Windows.Forms.BindingSource bsUcenici;
        private Data.Ds ds;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private Controls.UcExitApp ucExitApp1;
        private System.Windows.Forms.Button btnSrednjoskolci;
        private System.Windows.Forms.CheckBox chkAllowNew;
        private System.Windows.Forms.BindingSource bsSkole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIdUcenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcJOB;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcSkola;
    }
}