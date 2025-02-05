using System.Drawing;
using System.Windows.Forms;

namespace JISP.Forms.ZapsForms
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
    }
}
