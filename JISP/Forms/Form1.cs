using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var asdf = ds.Skole.AddSkoleRow("asdf");
            ds.Skole.AddSkoleRow("qwer");

            ds.Ucenici.AddUceniciRow("pera", "petrovic", "222222", null);
        }
    }
}
