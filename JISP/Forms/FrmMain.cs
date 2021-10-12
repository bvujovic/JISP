using JISP.Classes;
using JISP.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JISP
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
            try
            {
                if (Directory.Exists(Properties.Settings.Default.DataFolderHome))
                    Data.AppData.DataFolder = Properties.Settings.Default.DataFolderHome;
                if (Directory.Exists(Properties.Settings.Default.DataFolderAway))
                    Data.AppData.DataFolder = Properties.Settings.Default.DataFolderAway;
                if (string.IsNullOrEmpty(Data.AppData.DataFolder))
                    throw new Exception("AppData.DataFolder nije inicijalizovan.");

                Data.AppData.LoadDsData();

                // skolska test promena koda
                //var progData = Path.Combine(
                //    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                //    "OneDrive\\Posao\\ProgData");
                //var fileName = Path.Combine(progData, "deca.txt");
                //if (File.Exists(fileName))
                //    MessageBox.Show(File.ReadAllText(fileName));
                //else
                //    MessageBox.Show("Nema deceee");
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Form Load"); }
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
