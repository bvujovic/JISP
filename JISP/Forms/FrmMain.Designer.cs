namespace JISP.Forms
{
    partial class FrmMain
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.lblApiTokenCaption = new System.Windows.Forms.Label();
            this.lblApiToken = new System.Windows.Forms.Label();
            this.ttApiToken = new System.Windows.Forms.ToolTip(this.components);
            this.lblDataFolder = new System.Windows.Forms.Label();
            this.ttDataFolder = new System.Windows.Forms.ToolTip(this.components);
            this.cmbBrowser = new System.Windows.Forms.ComboBox();
            this.btnBackup = new JISP.Controls.UcButton();
            this.btnZaposleni = new JISP.Controls.UcButton();
            this.btnUcenici = new JISP.Controls.UcButton();
            this.cmbSkolskaGodina = new System.Windows.Forms.ComboBox();
            this.btnProstorije = new JISP.Controls.UcButton();
            this.btnPrikaziPoruke = new System.Windows.Forms.Button();
            this.btnTest = new JISP.Controls.UcButton();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(69, 205);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 18);
            label2.TabIndex = 6;
            label2.Text = "Folder sa podacima:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(69, 259);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 18);
            label1.TabIndex = 8;
            label1.Text = "Internet Browser:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(69, 286);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 18);
            label3.TabIndex = 10;
            label3.Text = "Školska Godina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(69, 232);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 18);
            label4.TabIndex = 6;
            label4.Text = "Poruke:";
            // 
            // lblApiTokenCaption
            // 
            this.lblApiTokenCaption.AutoSize = true;
            this.lblApiTokenCaption.Location = new System.Drawing.Point(69, 179);
            this.lblApiTokenCaption.Name = "lblApiTokenCaption";
            this.lblApiTokenCaption.Size = new System.Drawing.Size(80, 18);
            this.lblApiTokenCaption.TabIndex = 4;
            this.lblApiTokenCaption.Text = "API Token:";
            // 
            // lblApiToken
            // 
            this.lblApiToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApiToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblApiToken.Location = new System.Drawing.Point(210, 176);
            this.lblApiToken.Name = "lblApiToken";
            this.lblApiToken.Size = new System.Drawing.Size(338, 24);
            this.lblApiToken.TabIndex = 4;
            this.lblApiToken.Click += new System.EventHandler(this.LblApiToken_Click);
            // 
            // lblDataFolder
            // 
            this.lblDataFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDataFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDataFolder.Location = new System.Drawing.Point(210, 202);
            this.lblDataFolder.Name = "lblDataFolder";
            this.lblDataFolder.Size = new System.Drawing.Size(338, 24);
            this.lblDataFolder.TabIndex = 5;
            this.lblDataFolder.Click += new System.EventHandler(this.LblDataFolder_Click);
            // 
            // cmbBrowser
            // 
            this.cmbBrowser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrowser.FormattingEnabled = true;
            this.cmbBrowser.Items.AddRange(new object[] {
            "Chrome",
            "MS Edge"});
            this.cmbBrowser.Location = new System.Drawing.Point(210, 256);
            this.cmbBrowser.Name = "cmbBrowser";
            this.cmbBrowser.Size = new System.Drawing.Size(121, 25);
            this.cmbBrowser.TabIndex = 6;
            this.cmbBrowser.SelectedIndexChanged += new System.EventHandler(this.CmbBrowser_SelectedIndexChanged);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(413, 90);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(135, 48);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "BackUp";
            this.btnBackup.ToolTipText = "Čuvanje podataka iz DataSet-a u posebnom XML fajlu.";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(69, 90);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(135, 48);
            this.btnZaposleni.TabIndex = 1;
            this.btnZaposleni.Text = "&Zaposleni";
            this.btnZaposleni.ToolTipText = null;
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.BtnZaposleni_Click);
            // 
            // btnUcenici
            // 
            this.btnUcenici.Location = new System.Drawing.Point(69, 36);
            this.btnUcenici.Name = "btnUcenici";
            this.btnUcenici.Size = new System.Drawing.Size(135, 48);
            this.btnUcenici.TabIndex = 0;
            this.btnUcenici.Text = "&Učenici";
            this.btnUcenici.ToolTipText = null;
            this.btnUcenici.UseVisualStyleBackColor = true;
            this.btnUcenici.Click += new System.EventHandler(this.BtnUcenici_Click);
            // 
            // cmbSkolskaGodina
            // 
            this.cmbSkolskaGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkolskaGodina.FormattingEnabled = true;
            this.cmbSkolskaGodina.Items.AddRange(new object[] {
            "Chrome",
            "MS Edge"});
            this.cmbSkolskaGodina.Location = new System.Drawing.Point(210, 283);
            this.cmbSkolskaGodina.Name = "cmbSkolskaGodina";
            this.cmbSkolskaGodina.Size = new System.Drawing.Size(121, 25);
            this.cmbSkolskaGodina.TabIndex = 7;
            this.cmbSkolskaGodina.SelectedIndexChanged += new System.EventHandler(this.CmbSkolskaGodina_SelectedIndexChanged);
            // 
            // btnProstorije
            // 
            this.btnProstorije.Location = new System.Drawing.Point(413, 36);
            this.btnProstorije.Name = "btnProstorije";
            this.btnProstorije.Size = new System.Drawing.Size(135, 48);
            this.btnProstorije.TabIndex = 2;
            this.btnProstorije.Text = "&Prostorije";
            this.btnProstorije.ToolTipText = null;
            this.btnProstorije.UseVisualStyleBackColor = true;
            this.btnProstorije.Click += new System.EventHandler(this.BtnProstorije_Click);
            // 
            // btnPrikaziPoruke
            // 
            this.btnPrikaziPoruke.Location = new System.Drawing.Point(209, 228);
            this.btnPrikaziPoruke.Name = "btnPrikaziPoruke";
            this.btnPrikaziPoruke.Size = new System.Drawing.Size(121, 26);
            this.btnPrikaziPoruke.TabIndex = 11;
            this.btnPrikaziPoruke.Text = "Prikaži poruke";
            this.btnPrikaziPoruke.UseVisualStyleBackColor = true;
            this.btnPrikaziPoruke.Click += new System.EventHandler(this.BtnPrikaziPoruke_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(413, 144);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(135, 29);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "Test";
            this.btnTest.ToolTipText = "Čuvanje podataka iz DataSet-a u posebnom XML fajlu.";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 340);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnPrikaziPoruke);
            this.Controls.Add(this.btnProstorije);
            this.Controls.Add(this.cmbSkolskaGodina);
            this.Controls.Add(label3);
            this.Controls.Add(this.cmbBrowser);
            this.Controls.Add(label1);
            this.Controls.Add(this.lblDataFolder);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(this.lblApiToken);
            this.Controls.Add(this.lblApiTokenCaption);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.btnUcenici);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JISP";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.UcButton btnUcenici;
        private Controls.UcButton btnZaposleni;
        private Controls.UcButton btnBackup;
        private System.Windows.Forms.Label lblApiTokenCaption;
        private System.Windows.Forms.Label lblApiToken;
        private System.Windows.Forms.ToolTip ttApiToken;
        private System.Windows.Forms.Label lblDataFolder;
        private System.Windows.Forms.ToolTip ttDataFolder;
        private System.Windows.Forms.ComboBox cmbBrowser;
        private System.Windows.Forms.ComboBox cmbSkolskaGodina;
        private Controls.UcButton btnProstorije;
        private System.Windows.Forms.Button btnPrikaziPoruke;
        private Controls.UcButton btnTest;
    }
}

