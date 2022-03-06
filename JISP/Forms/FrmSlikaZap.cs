using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmSlikaZap : Form
    {
        public FrmSlikaZap()
        {
            InitializeComponent();
        }

        private string slika;
        /// <summary>Putanja slike zaposlenog</summary>
        public string Slika
        {
            get { return slika; }
            set
            {
                slika = value;
                pic.Image = new Bitmap(slika);

                this.Width = pic.Image.Width + this.Width - pic.Width;
                this.Height = pic.Image.Height + this.Height - pic.Height;
            }
        }

        private void FrmSlikaZap_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
