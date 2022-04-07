namespace JISP.Forms
{
    partial class FrmUcenikOsnovno
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
            this.lblUcenik = new System.Windows.Forms.Label();
            this.lblJOB = new System.Windows.Forms.Label();
            this.txtUcenik = new System.Windows.Forms.TextBox();
            this.txtJOB = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUcenik
            // 
            this.lblUcenik.AutoSize = true;
            this.lblUcenik.Location = new System.Drawing.Point(21, 31);
            this.lblUcenik.Name = "lblUcenik";
            this.lblUcenik.Size = new System.Drawing.Size(58, 18);
            this.lblUcenik.TabIndex = 5;
            this.lblUcenik.Text = "Učenik:";
            // 
            // lblJOB
            // 
            this.lblJOB.AutoSize = true;
            this.lblJOB.Location = new System.Drawing.Point(21, 64);
            this.lblJOB.Name = "lblJOB";
            this.lblJOB.Size = new System.Drawing.Size(42, 18);
            this.lblJOB.TabIndex = 5;
            this.lblJOB.Text = "JOB:";
            // 
            // txtUcenik
            // 
            this.txtUcenik.Location = new System.Drawing.Point(97, 28);
            this.txtUcenik.Name = "txtUcenik";
            this.txtUcenik.Size = new System.Drawing.Size(316, 24);
            this.txtUcenik.TabIndex = 0;
            // 
            // txtJOB
            // 
            this.txtJOB.Location = new System.Drawing.Point(97, 61);
            this.txtJOB.Name = "txtJOB";
            this.txtJOB.Size = new System.Drawing.Size(316, 24);
            this.txtJOB.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(336, 101);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 35);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmUcenikOsnovno
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 148);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtJOB);
            this.Controls.Add(this.txtUcenik);
            this.Controls.Add(this.lblJOB);
            this.Controls.Add(this.lblUcenik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::JISP.Properties.Resources.grb_srb;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUcenikOsnovno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Osnovni podaci o učeniku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUcenik;
        private System.Windows.Forms.Label lblJOB;
        private System.Windows.Forms.TextBox txtUcenik;
        private System.Windows.Forms.TextBox txtJOB;
        private System.Windows.Forms.Button btnOk;
    }
}