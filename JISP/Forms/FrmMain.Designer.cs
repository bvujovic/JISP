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
            this.btnUcenici = new System.Windows.Forms.Button();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcenici
            // 
            this.btnUcenici.Location = new System.Drawing.Point(41, 36);
            this.btnUcenici.Name = "btnUcenici";
            this.btnUcenici.Size = new System.Drawing.Size(135, 48);
            this.btnUcenici.TabIndex = 0;
            this.btnUcenici.Text = "Učenici";
            this.btnUcenici.UseVisualStyleBackColor = true;
            this.btnUcenici.Click += new System.EventHandler(this.BtnUcenici_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(382, 36);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(135, 48);
            this.btnZaposleni.TabIndex = 1;
            this.btnZaposleni.Text = "Zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.BtnZaposleni_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(382, 205);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(135, 48);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "BackUp";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 279);
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

        }

        #endregion

        private System.Windows.Forms.Button btnUcenici;
        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Button btnBackup;
    }
}

