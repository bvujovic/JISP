using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JISP
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var progData = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "OneDrive\\Posao\\ProgData");
            var fileName = Path.Combine(progData, "deca.txt");
            if (File.Exists(fileName))
                MessageBox.Show(File.ReadAllText(fileName));
            else
                MessageBox.Show("Nema deceee");
        }
    }
}
