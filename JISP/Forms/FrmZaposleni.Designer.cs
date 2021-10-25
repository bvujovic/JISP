
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.chkLoadWoMsgs = new System.Windows.Forms.CheckBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnExit = new JISP.Controls.UcExitApp();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvZaposleni = new JISP.Controls.UcDGV();
            this.dgvcIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcJMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcGodine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDanaDoRodj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsZaposleni = new System.Windows.Forms.BindingSource(this.components);
            this.pnlZaposleniBottom = new System.Windows.Forms.Panel();
            this.chkAktivniZap = new System.Windows.Forms.CheckBox();
            this.dgvZaposlenja = new System.Windows.Forms.DataGridView();
            this.dgvcNjaRMNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsZaposlenja = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposleni)).BeginInit();
            this.pnlZaposleniBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.chkLoadWoMsgs);
            this.pnlLeft.Controls.Add(this.btnLoadData);
            this.pnlLeft.Controls.Add(this.btnSaveData);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(146, 448);
            this.pnlLeft.TabIndex = 0;
            // 
            // chkLoadWoMsgs
            // 
            this.chkLoadWoMsgs.AutoSize = true;
            this.chkLoadWoMsgs.Location = new System.Drawing.Point(16, 153);
            this.chkLoadWoMsgs.Name = "chkLoadWoMsgs";
            this.chkLoadWoMsgs.Size = new System.Drawing.Size(101, 22);
            this.chkLoadWoMsgs.TabIndex = 4;
            this.chkLoadWoMsgs.Text = "bez poruka";
            this.chkLoadWoMsgs.UseVisualStyleBackColor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 110);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(128, 40);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Učitaj podatke";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(12, 64);
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
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 28);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(3, 6);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(59, 18);
            this.lblRowCount.TabIndex = 6;
            this.lblRowCount.Text = "Redova";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(146, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(128, 24);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer.Size = new System.Drawing.Size(749, 448);
            this.splitContainer.SplitterDistance = 340;
            this.splitContainer.TabIndex = 2;
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.AutoGenerateColumns = false;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIme,
            this.dgvcPrezime,
            this.dgvcJMBG,
            this.dgvcGodine,
            this.dgvcDanaDoRodj});
            this.dgvZaposleni.DataSource = this.bsZaposleni;
            this.dgvZaposleni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposleni.Location = new System.Drawing.Point(0, 0);
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.RowHeadersWidth = 30;
            this.dgvZaposleni.Size = new System.Drawing.Size(749, 310);
            this.dgvZaposleni.TabIndex = 1;
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
            this.dgvcGodine.Name = "dgvcGodine";
            this.dgvcGodine.ReadOnly = true;
            // 
            // dgvcDanaDoRodj
            // 
            this.dgvcDanaDoRodj.DataPropertyName = "DanaDoRodj";
            this.dgvcDanaDoRodj.HeaderText = "Do Rođ.";
            this.dgvcDanaDoRodj.Name = "dgvcDanaDoRodj";
            this.dgvcDanaDoRodj.ReadOnly = true;
            // 
            // bsZaposleni
            // 
            this.bsZaposleni.DataMember = "Zaposleni";
            // 
            // pnlZaposleniBottom
            // 
            this.pnlZaposleniBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZaposleniBottom.Controls.Add(this.chkAktivniZap);
            this.pnlZaposleniBottom.Controls.Add(this.txtFilter);
            this.pnlZaposleniBottom.Controls.Add(this.lblRowCount);
            this.pnlZaposleniBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlZaposleniBottom.Location = new System.Drawing.Point(0, 310);
            this.pnlZaposleniBottom.Name = "pnlZaposleniBottom";
            this.pnlZaposleniBottom.Size = new System.Drawing.Size(749, 30);
            this.pnlZaposleniBottom.TabIndex = 2;
            // 
            // chkAktivniZap
            // 
            this.chkAktivniZap.AutoSize = true;
            this.chkAktivniZap.Location = new System.Drawing.Point(380, 4);
            this.chkAktivniZap.Name = "chkAktivniZap";
            this.chkAktivniZap.Size = new System.Drawing.Size(69, 22);
            this.chkAktivniZap.TabIndex = 7;
            this.chkAktivniZap.Text = "Aktivni";
            this.chkAktivniZap.ThreeState = true;
            this.chkAktivniZap.UseVisualStyleBackColor = true;
            this.chkAktivniZap.CheckStateChanged += new System.EventHandler(this.ChkAktivniZap_CheckStateChanged);
            // 
            // dgvZaposlenja
            // 
            this.dgvZaposlenja.AllowUserToAddRows = false;
            this.dgvZaposlenja.AllowUserToDeleteRows = false;
            this.dgvZaposlenja.AutoGenerateColumns = false;
            this.dgvZaposlenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcNjaRMNaziv});
            this.dgvZaposlenja.DataSource = this.bsZaposlenja;
            this.dgvZaposlenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposlenja.Location = new System.Drawing.Point(0, 0);
            this.dgvZaposlenja.Name = "dgvZaposlenja";
            this.dgvZaposlenja.Size = new System.Drawing.Size(749, 104);
            this.dgvZaposlenja.TabIndex = 0;
            // 
            // dgvcNjaRMNaziv
            // 
            this.dgvcNjaRMNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcNjaRMNaziv.DataPropertyName = "RadnoMestoNaziv";
            this.dgvcNjaRMNaziv.HeaderText = "Radno Mesto";
            this.dgvcNjaRMNaziv.Name = "dgvcNjaRMNaziv";
            this.dgvcNjaRMNaziv.ReadOnly = true;
            // 
            // bsZaposlenja
            // 
            this.bsZaposlenja.DataSource = this.bsZaposleni;
            // 
            // FrmZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 448);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZaposleni";
            this.Text = "Zaposleni";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposleni)).EndInit();
            this.pnlZaposleniBottom.ResumeLayout(false);
            this.pnlZaposleniBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZaposlenja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private Controls.UcDGV dgvZaposleni;
        private System.Windows.Forms.BindingSource bsZaposleni;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
        private Controls.UcExitApp btnExit;
        private System.Windows.Forms.CheckBox chkLoadWoMsgs;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcJMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcGodine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDanaDoRodj;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlZaposleniBottom;
        private System.Windows.Forms.DataGridView dgvZaposlenja;
        private System.Windows.Forms.BindingSource bsZaposlenja;
        private System.Windows.Forms.CheckBox chkAktivniZap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNjaRMNaziv;
    }
}