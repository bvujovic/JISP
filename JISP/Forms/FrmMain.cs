using JISP.Classes;
using JISP.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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
                {
                    if (frmUcenici == null || frmUcenici.IsDisposed)
                        frmUcenici = new FrmUcenici();
                    frm = frmUcenici;
                }
                if (childForms == ChildForms.Zaposleni)
                {
                    if (frmZaposleni == null || frmZaposleni.IsDisposed)
                        frmZaposleni = new FrmZaposleni();
                    frm = frmZaposleni;
                }
                frm.FormClosed += Frm_FormClosed;
            }
            frm.Show();
            frm.WindowState = FormWindowState.Minimized;
            frm.WindowState = FormWindowState.Normal;
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (JISP.Controls.UcExitApp.ExitSignal)
                Close();
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

        private async void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                // https://stackoverflow.com/questions/14627399/setting-authorization-header-of-httpclient
                using (var client = new System.Net.Http.HttpClient())
                {
                    var url = "https://jisp.mpn.gov.rs/webapi/api/zaposleni/VratiOpstePodatkeOZaposlenima/18976";
                    var token = "";
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", token);
                    var response = await client.GetStringAsync(url);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnTest.Text); }
        }
    }
}
