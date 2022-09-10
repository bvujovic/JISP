namespace JISP.Forms
{
    partial class FrmStaz
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
            System.Windows.Forms.Label lblDatumIzvestaja;
            this.btnOk = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            lblDatumIzvestaja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDatumIzvestaja
            // 
            lblDatumIzvestaja.AutoSize = true;
            lblDatumIzvestaja.Location = new System.Drawing.Point(12, 19);
            lblDatumIzvestaja.Name = "lblDatumIzvestaja";
            lblDatumIzvestaja.Size = new System.Drawing.Size(161, 16);
            lblDatumIzvestaja.TabIndex = 0;
            lblDatumIzvestaja.Text = "Datum izveštaja iz trezora:";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(358, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(180, 15);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(122, 22);
            this.dtp.TabIndex = 2;
            // 
            // FrmStaz
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 54);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(lblDatumIzvestaja);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staž";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}