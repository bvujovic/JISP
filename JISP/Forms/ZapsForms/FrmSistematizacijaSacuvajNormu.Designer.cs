namespace JISP.Forms.ZapsForms
{
    partial class FrmSistematizacijaSacuvajNormu
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.numUkNormaPoSistem = new System.Windows.Forms.NumericUpDown();
            this.lblUkNormaPoRM = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUkNormaPoSistem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 63);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(233, 17);
            label1.TabIndex = 0;
            label1.Text = "Ukupna norma po RM osim zamena";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 29);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(211, 17);
            label2.TabIndex = 0;
            label2.Text = "Ukupna norma po sistematizaciji";
            // 
            // numUkNormaPoSistem
            // 
            this.numUkNormaPoSistem.DecimalPlaces = 2;
            this.numUkNormaPoSistem.Location = new System.Drawing.Point(305, 27);
            this.numUkNormaPoSistem.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUkNormaPoSistem.Name = "numUkNormaPoSistem";
            this.numUkNormaPoSistem.Size = new System.Drawing.Size(93, 23);
            this.numUkNormaPoSistem.TabIndex = 1;
            this.numUkNormaPoSistem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumUkNormaPoSistem_KeyDown);
            // 
            // lblUkNormaPoRM
            // 
            this.lblUkNormaPoRM.AutoSize = true;
            this.lblUkNormaPoRM.Location = new System.Drawing.Point(301, 63);
            this.lblUkNormaPoRM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUkNormaPoRM.Name = "lblUkNormaPoRM";
            this.lblUkNormaPoRM.Size = new System.Drawing.Size(12, 17);
            this.lblUkNormaPoRM.TabIndex = 0;
            this.lblUkNormaPoRM.Text = "/";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSacuvaj.Location = new System.Drawing.Point(305, 111);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(93, 32);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // FrmSistematizacijaSacuvajNormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 155);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.numUkNormaPoSistem);
            this.Controls.Add(this.lblUkNormaPoRM);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSistematizacijaSacuvajNormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmena norme za radno mesto";
            this.Load += new System.EventHandler(this.FrmSistematizacijaSacuvajNormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUkNormaPoSistem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUkNormaPoSistem;
        private System.Windows.Forms.Label lblUkNormaPoRM;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}