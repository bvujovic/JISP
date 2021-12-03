﻿
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.bsZaposleni = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlZaposleniBottom = new System.Windows.Forms.Panel();
            this.chkAktivniZap = new System.Windows.Forms.CheckBox();
            this.dgvZaposlenja = new Controls.UcDGV();
            this.dgvcNjeAktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcNjaRMNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsZaposlenja = new System.Windows.Forms.BindingSource(this.components);
            this.dgvZaposleni = new JISP.Controls.UcDGV();
            this.dgvcIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcJMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGodine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDanaDoRodj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcZapId = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtFilter = new JISP.Controls.UcFilterTextBox();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.chkCopyOnClick = new System.Windows.Forms.CheckBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnExit = new JISP.Controls.UcExitApp();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposleni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlZaposleniBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(147, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 24);
            label1.TabIndex = 8;
            label1.Text = "Filter:";
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(3, 5);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(75, 24);
            this.lblRowCount.TabIndex = 6;
            this.lblRowCount.Text = "Redova";
            // 
            // bsZaposleni
            // 
            this.bsZaposleni.DataMember = "Zaposleni";
            this.bsZaposleni.CurrentChanged += new System.EventHandler(this.BsZaposleni_CurrentChanged);
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
            this.splitContainer.Panel1.Controls.Add(this.pnlZaposleniBottom);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgvZaposlenja);
            this.splitContainer.Size = new System.Drawing.Size(822, 589);
            this.splitContainer.SplitterDistance = 460;
            this.splitContainer.TabIndex = 2;
            // 
            // pnlZaposleniBottom
            // 
            this.pnlZaposleniBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZaposleniBottom.Controls.Add(label1);
            this.pnlZaposleniBottom.Controls.Add(this.chkAktivniZap);
            this.pnlZaposleniBottom.Controls.Add(this.txtFilter);
            this.pnlZaposleniBottom.Controls.Add(this.lblRowCount);
            this.pnlZaposleniBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlZaposleniBottom.Location = new System.Drawing.Point(0, 0);
            this.pnlZaposleniBottom.Name = "pnlZaposleniBottom";
            this.pnlZaposleniBottom.Size = new System.Drawing.Size(822, 30);
            this.pnlZaposleniBottom.TabIndex = 2;
            // 
            // chkAktivniZap
            // 
            this.chkAktivniZap.AutoSize = true;
            this.chkAktivniZap.Checked = true;
            this.chkAktivniZap.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkAktivniZap.Location = new System.Drawing.Point(509, 4);
            this.chkAktivniZap.Name = "chkAktivniZap";
            this.chkAktivniZap.Size = new System.Drawing.Size(86, 28);
            this.chkAktivniZap.TabIndex = 7;
            this.chkAktivniZap.Text = "Aktivni";
            this.chkAktivniZap.ThreeState = true;
            this.chkAktivniZap.UseVisualStyleBackColor = true;
            this.chkAktivniZap.CheckStateChanged += new System.EventHandler(this.FilterChanged);
            // 
            // dgvZaposlenja
            // 
            this.dgvZaposlenja.AllowUserToAddRows = false;
            this.dgvZaposlenja.AllowUserToDeleteRows = false;
            this.dgvZaposlenja.AutoGenerateColumns = false;
            this.dgvZaposlenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcNjeAktivan,
            this.dgvcNjaRMNaziv});
            this.dgvZaposlenja.DataSource = this.bsZaposlenja;
            this.dgvZaposlenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposlenja.Location = new System.Drawing.Point(0, 0);
            this.dgvZaposlenja.Name = "dgvZaposlenja";
            this.dgvZaposlenja.RowHeadersWidth = 51;
            this.dgvZaposlenja.Size = new System.Drawing.Size(822, 125);
            this.dgvZaposlenja.TabIndex = 0;
            // 
            // dgvcNjeAktivan
            // 
            this.dgvcNjeAktivan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcNjeAktivan.DataPropertyName = "Aktivan";
            this.dgvcNjeAktivan.HeaderText = "Aktivan";
            this.dgvcNjeAktivan.MinimumWidth = 6;
            this.dgvcNjeAktivan.Name = "dgvcNjeAktivan";
            this.dgvcNjeAktivan.ReadOnly = true;
            this.dgvcNjeAktivan.Width = 76;
            // 
            // dgvcNjaRMNaziv
            // 
            this.dgvcNjaRMNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcNjaRMNaziv.DataPropertyName = "RadnoMestoNaziv";
            this.dgvcNjaRMNaziv.HeaderText = "Radno Mesto";
            this.dgvcNjaRMNaziv.MinimumWidth = 6;
            this.dgvcNjaRMNaziv.Name = "dgvcNjaRMNaziv";
            this.dgvcNjaRMNaziv.ReadOnly = true;
            // 
            // bsZaposlenja
            // 
            this.bsZaposlenja.DataSource = this.bsZaposleni;
            this.bsZaposlenja.Sort = "";
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.AllowUserToAddRows = false;
            this.dgvZaposleni.AutoGenerateColumns = false;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIme,
            this.dgvcPrezime,
            this.dgvcJMBG,
            this.dgvcGodine,
            this.dgvcDanaDoRodj,
            this.dgvcPol,
            this.dgvcZapId});
            this.dgvZaposleni.CopyOnCellClick = false;
            this.dgvZaposleni.DataSource = this.bsZaposleni;
            this.dgvZaposleni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposleni.Location = new System.Drawing.Point(0, 30);
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.RowHeadersWidth = 30;
            this.dgvZaposleni.Size = new System.Drawing.Size(822, 430);
            this.dgvZaposleni.TabIndex = 1;
            this.dgvZaposleni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvZaposleni_CellClick);
            // 
            // dgvcIme
            // 
            this.dgvcIme.DataPropertyName = "Ime";
            this.dgvcIme.HeaderText = "Ime";
            this.dgvcIme.MinimumWidth = 6;
            this.dgvcIme.Name = "dgvcIme";
            this.dgvcIme.Width = 115;
            // 
            // dgvcPrezime
            // 
            this.dgvcPrezime.DataPropertyName = "Prezime";
            this.dgvcPrezime.HeaderText = "Prezime";
            this.dgvcPrezime.MinimumWidth = 6;
            this.dgvcPrezime.Name = "dgvcPrezime";
            this.dgvcPrezime.Width = 150;
            // 
            // dgvcJMBG
            // 
            this.dgvcJMBG.DataPropertyName = "JMBG";
            this.dgvcJMBG.HeaderText = "JMBG";
            this.dgvcJMBG.MinimumWidth = 6;
            this.dgvcJMBG.Name = "dgvcJMBG";
            this.dgvcJMBG.Width = 125;
            // 
            // dgvcGodine
            // 
            this.dgvcGodine.DataPropertyName = "Godine";
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvcGodine.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcGodine.HeaderText = "Godine";
            this.dgvcGodine.MinimumWidth = 6;
            this.dgvcGodine.Name = "dgvcGodine";
            this.dgvcGodine.ReadOnly = true;
            this.dgvcGodine.Width = 85;
            // 
            // dgvcDanaDoRodj
            // 
            this.dgvcDanaDoRodj.DataPropertyName = "DanaDoRodj";
            this.dgvcDanaDoRodj.HeaderText = "Do Rođ.";
            this.dgvcDanaDoRodj.MinimumWidth = 6;
            this.dgvcDanaDoRodj.Name = "dgvcDanaDoRodj";
            this.dgvcDanaDoRodj.ReadOnly = true;
            this.dgvcDanaDoRodj.Width = 90;
            // 
            // dgvcPol
            // 
            this.dgvcPol.DataPropertyName = "Pol";
            this.dgvcPol.HeaderText = "Pol";
            this.dgvcPol.MinimumWidth = 6;
            this.dgvcPol.Name = "dgvcPol";
            this.dgvcPol.Width = 50;
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
            // txtFilter
            // 
            this.txtFilter.BindingSource = this.bsZaposleni;
            this.txtFilter.Location = new System.Drawing.Point(193, 1);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(128, 29);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.FilterCleared += new System.EventHandler(this.TxtFilter_FilterCleared);
            this.txtFilter.TextChanged += new System.EventHandler(this.FilterChanged);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.chkCopyOnClick);
            this.pnlLeft.Controls.Add(this.btnLoadData);
            this.pnlLeft.Controls.Add(this.btnSaveData);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(146, 589);
            this.pnlLeft.TabIndex = 0;
            // 
            // chkCopyOnClick
            // 
            this.chkCopyOnClick.AutoSize = true;
            this.chkCopyOnClick.Location = new System.Drawing.Point(9, 159);
            this.chkCopyOnClick.Name = "chkCopyOnClick";
            this.chkCopyOnClick.Size = new System.Drawing.Size(169, 28);
            this.chkCopyOnClick.TabIndex = 4;
            this.chkCopyOnClick.Text = "Kopiranje na klik";
            this.chkCopyOnClick.UseVisualStyleBackColor = true;
            this.chkCopyOnClick.CheckedChanged += new System.EventHandler(this.ChkCopyOnClick_CheckedChanged);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(8, 110);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(128, 40);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Učitaj podatke";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(8, 64);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(128, 40);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.Text = "Sačuvaj podatke";
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
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // FrmZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 589);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZaposleni";
            this.Text = "Zaposleni";
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposleni)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlZaposleniBottom.ResumeLayout(false);
            this.pnlZaposleniBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private JISP.Controls.UcLeftPanel pnlLeft;
        private Controls.UcDGV dgvZaposleni;
        private System.Windows.Forms.BindingSource bsZaposleni;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
        private Controls.UcExitApp btnExit;
        private System.Windows.Forms.CheckBox chkCopyOnClick;
        private System.Windows.Forms.Label lblRowCount;
        private Controls.UcFilterTextBox txtFilter;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlZaposleniBottom;
        private Controls.UcDGV dgvZaposlenja;
        private System.Windows.Forms.BindingSource bsZaposlenja;
        private System.Windows.Forms.CheckBox chkAktivniZap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcNjeAktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNjaRMNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcJMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGodine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDanaDoRodj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPol;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcZapId;
    }
}