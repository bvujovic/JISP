
namespace JISP.Controls
{
    partial class UcLeftPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlRightWing = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlRightWing
            // 
            this.pnlRightWing.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightWing.Location = new System.Drawing.Point(144, 0);
            this.pnlRightWing.Name = "pnlRightWing";
            this.pnlRightWing.Size = new System.Drawing.Size(6, 150);
            this.pnlRightWing.TabIndex = 0;
            this.pnlRightWing.Click += new System.EventHandler(this.PnlRightWing_Click);
            this.pnlRightWing.MouseEnter += new System.EventHandler(this.PnlRightWing_MouseEnter);
            this.pnlRightWing.MouseLeave += new System.EventHandler(this.PnlRightWing_MouseLeave);
            // 
            // UcLeftPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlRightWing);
            this.Name = "UcLeftPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRightWing;
    }
}
