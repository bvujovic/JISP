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
            this.btnUcenici = new JISP.Controls.UcButton();
            this.btnZaposleni = new JISP.Controls.UcButton();
            this.btnBackup = new JISP.Controls.UcButton();
            this.lblApiTokenCaption = new System.Windows.Forms.Label();
            this.lblApiToken = new System.Windows.Forms.Label();
            this.ttApiToken = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnUcenici
            // 
            this.btnUcenici.Location = new System.Drawing.Point(41, 36);
            this.btnUcenici.Name = "btnUcenici";
            this.btnUcenici.Size = new System.Drawing.Size(135, 48);
            this.btnUcenici.TabIndex = 0;
            this.btnUcenici.Text = "&Učenici";
            this.btnUcenici.ToolTipText = null;
            this.btnUcenici.UseVisualStyleBackColor = true;
            this.btnUcenici.Click += new System.EventHandler(this.BtnUcenici_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(41, 90);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(135, 48);
            this.btnZaposleni.TabIndex = 1;
            this.btnZaposleni.Text = "&Zaposleni";
            this.btnZaposleni.ToolTipText = null;
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.BtnZaposleni_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(382, 36);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(135, 48);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "BackUp";
            this.btnBackup.ToolTipText = "Čuvanje podataka iz DataSet-a u posebnom XML fajlu.";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // lblApiTokenCaption
            // 
            this.lblApiTokenCaption.AutoSize = true;
            this.lblApiTokenCaption.Location = new System.Drawing.Point(38, 196);
            this.lblApiTokenCaption.Name = "lblApiTokenCaption";
            this.lblApiTokenCaption.Size = new System.Drawing.Size(80, 18);
            this.lblApiTokenCaption.TabIndex = 4;
            this.lblApiTokenCaption.Text = "API Token:";
            // 
            // lblApiToken
            // 
            this.lblApiToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApiToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblApiToken.Location = new System.Drawing.Point(124, 193);
            this.lblApiToken.Name = "lblApiToken";
            this.lblApiToken.Size = new System.Drawing.Size(189, 24);
            this.lblApiToken.TabIndex = 5;
            this.lblApiToken.Click += new System.EventHandler(this.TxtApiToken_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 279);
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
    }
}

