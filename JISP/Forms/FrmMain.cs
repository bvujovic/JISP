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
        private FrmZaposleni frmZaposleni = null;

        enum ChildForms
        {
            Ucenici, Zaposleni
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void BtnUcenici_Click(object sender, EventArgs e)
        {
            ShowForm(frmUcenici, ChildForms.Ucenici);
        }

        private void ShowForm(Form frm, ChildForms childForms)
        {
            if (frm == null || frm.IsDisposed)
            {
                if (childForms == ChildForms.Ucenici)
                    frm = new FrmUcenici();
                if (childForms == ChildForms.Zaposleni)
                    frm = new FrmZaposleni();
            }
            frm.Show();
            if (frm.WindowState == FormWindowState.Minimized)
                frm.WindowState = FormWindowState.Normal;
        }

        //void NewItUp(Form form)
        //{
        //    var t = Type.GetType(form);
        //}

        //***
        //void m(Form f)
        //{
        //    if (f == null)
        //        return;
        //    var rr = typeof(FrmMain);
        //    var t = f.GetType();
        //    var frm = Activator.CreateInstance(t);
        //}

        private void BtnZaposleni_Click(object sender, EventArgs e)
        {
            ShowForm(frmZaposleni, ChildForms.Zaposleni);
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            Data.AppData.BackupData();
        }
    }
}
