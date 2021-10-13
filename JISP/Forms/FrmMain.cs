using JISP.Classes;
using JISP.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private FrmUcenici frmUcenici = null;

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void BtnUcenici_Click(object sender, EventArgs e)
        {
            if (frmUcenici == null || frmUcenici.IsDisposed)
                frmUcenici = new FrmUcenici();
            frmUcenici.Show();
            if (frmUcenici.WindowState == FormWindowState.Minimized)
                frmUcenici.WindowState = FormWindowState.Normal;
        }
    }
}
