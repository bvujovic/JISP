
namespace JISP.Forms
{
    partial class FrmUceniciOcene
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
            this.btnPasteClipboard = new System.Windows.Forms.Button();
            this.lblMarksAverage = new System.Windows.Forms.Label();
            this.chkInvalidMarks = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPasteClipboard
            // 
            this.btnPasteClipboard.Location = new System.Drawing.Point(12, 34);
            this.btnPasteClipboard.Name = "btnPasteClipboard";
            this.btnPasteClipboard.Size = new System.Drawing.Size(75, 29);
            this.btnPasteClipboard.TabIndex = 0;
            this.btnPasteClipboard.Text = "Ok";
            this.btnPasteClipboard.UseVisualStyleBackColor = true;
            this.btnPasteClipboard.Click += new System.EventHandler(this.BtnPasteClipboard_Click);
            // 
            // lblMarksAverage
            // 
            this.lblMarksAverage.AutoSize = true;
            this.lblMarksAverage.Location = new System.Drawing.Point(12, 68);
            this.lblMarksAverage.Name = "lblMarksAverage";
            this.lblMarksAverage.Size = new System.Drawing.Size(61, 16);
            this.lblMarksAverage.TabIndex = 1;
            this.lblMarksAverage.Text = "Prosek: /";
            // 
            // chkInvalidMarks
            // 
            this.chkInvalidMarks.AutoSize = true;
            this.chkInvalidMarks.Checked = true;
            this.chkInvalidMarks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInvalidMarks.Location = new System.Drawing.Point(12, 8);
            this.chkInvalidMarks.Name = "chkInvalidMarks";
            this.chkInvalidMarks.Size = new System.Drawing.Size(158, 20);
            this.chkInvalidMarks.TabIndex = 2;
            this.chkInvalidMarks.Text = "Provera naziva ocena";
            this.chkInvalidMarks.UseVisualStyleBackColor = true;
            // 
            // FrmUceniciOcene
            // 
            this.AcceptButton = this.btnPasteClipboard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 304);
            this.Controls.Add(this.chkInvalidMarks);
            this.Controls.Add(this.lblMarksAverage);
            this.Controls.Add(this.btnPasteClipboard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::JISP.Properties.Resources.grb_srb;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUceniciOcene";
            this.Text = "Provera unosa ocena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasteClipboard;
        private System.Windows.Forms.Label lblMarksAverage;
        private System.Windows.Forms.CheckBox chkInvalidMarks;
    }
}