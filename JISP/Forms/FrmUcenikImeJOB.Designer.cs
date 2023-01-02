namespace JISP.Forms
{
    partial class FrmUcenikImeJOB
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
            this.txtPrebivaliste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUcenik
            // 
            this.lblUcenik.AutoSize = true;
            this.lblUcenik.Location = new System.Drawing.Point(21, 31);
            this.lblUcenik.Name = "lblUcenik";
            this.lblUcenik.Size = new System.Drawing.Size(64, 18);
            this.lblUcenik.TabIndex = 5;
            this.lblUcenik.Text = "Učenik *";
            // 
            // lblJOB
            // 
            this.lblJOB.AutoSize = true;
            this.lblJOB.Location = new System.Drawing.Point(21, 64);
            this.lblJOB.Name = "lblJOB";
            this.lblJOB.Size = new System.Drawing.Size(48, 18);
            this.lblJOB.TabIndex = 5;
            this.lblJOB.Text = "JOB *";
            // 
            // txtUcenik
            // 
            this.txtUcenik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUcenik.Location = new System.Drawing.Point(110, 28);
            this.txtUcenik.Name = "txtUcenik";
            this.txtUcenik.Size = new System.Drawing.Size(321, 24);
            this.txtUcenik.TabIndex = 0;
            // 
            // txtJOB
            // 
            this.txtJOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJOB.Location = new System.Drawing.Point(110, 61);
            this.txtJOB.Name = "txtJOB";
            this.txtJOB.Size = new System.Drawing.Size(321, 24);
            this.txtJOB.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(354, 136);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 35);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txtPrebivaliste
            // 
            this.txtPrebivaliste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrebivaliste.Location = new System.Drawing.Point(110, 94);
            this.txtPrebivaliste.Name = "txtPrebivaliste";
            this.txtPrebivaliste.Size = new System.Drawing.Size(321, 24);
            this.txtPrebivaliste.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prebivalište";
            // 
            // FrmUcenikImeJOB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 183);
            this.Controls.Add(this.txtPrebivaliste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtJOB);
            this.Controls.Add(this.txtUcenik);
            this.Controls.Add(this.lblJOB);
            this.Controls.Add(this.lblUcenik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUcenikImeJOB";
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
        private System.Windows.Forms.TextBox txtPrebivaliste;
        private System.Windows.Forms.Label label1;
    }
}