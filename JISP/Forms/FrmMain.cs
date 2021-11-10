using JISP.Classes;
using JISP.Data;
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ttApiToken.SetToolTip(lblApiToken, "Klikni za paste web api token-a.");
            lblApiToken.Text = WebApi.TokenDisplay;
            FormClosing += FrmMain_FormClosing;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppData.Ds.HasChanges())
            {
                var sb = new System.Text.StringBuilder();
                AddChangesDescription("Dodati redovi:", AppData.Ds.GetChanges(DataRowState.Added), sb);
                AddChangesDescription("\r\nIzmenjeni redovi:", AppData.Ds.GetChanges(DataRowState.Modified), sb);
                AddChangesDescription("\r\nObrisani redovi:", AppData.Ds.GetChanges(DataRowState.Deleted), sb);

                var res = Utils.ShowMboxYesNoCancel(sb.ToString(), "Sačuvaj podatke?");
                if (res == DialogResult.Yes)
                    AppData.SaveDsData();
                else if (res == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// Na prosledjeni string (StringBuilder) metoda dodaje spisak tabela sa brojem
        /// dodatih/izmenjenih/obrisanih redova.
        /// </summary>
        private static void AddChangesDescription(string caption, DataSet ds, System.Text.StringBuilder sb)
        {
            if (ds != null)
            {
                sb.AppendLine(caption);
                foreach (var tbl in ds.Tables.OfType<DataTable>().Where(it => it.Rows.Count > 0))
                    sb.AppendLine(tbl.TableName + ": " + tbl.Rows.Count);
            }
        }

        //B
        //private FrmUcenici frmUcenici = null;
        //private FrmZaposleni frmZaposleni = null;
        //enum ChildForms
        //{
        //    Ucenici, Zaposleni
        //}

        private void BtnUcenici_Click(object sender, EventArgs e)
        {
            //B ShowForm(frmUcenici, ChildForms.Ucenici);
            Utils.ShowForm(typeof(FrmUcenici));
        }

        private void BtnZaposleni_Click(object sender, EventArgs e)
        {
            //B ShowForm(frmZaposleni, ChildForms.Zaposleni);
            Utils.ShowForm(typeof(FrmZaposleni));
        }

        //B
        //private void ShowForm(Type typForm)
        //{
        //    var frm = Application.OpenForms.OfType<Form>().FirstOrDefault(it => it.GetType() == typForm);
        //    if (frm == null || frm.IsDisposed)
        //    {
        //        if (typForm == typeof(FrmZaposleni))
        //            frm = new FrmZaposleni();
        //        if (typForm == typeof(FrmUcenici))
        //            frm = new FrmUcenici();
        //        if (typForm == typeof(FrmSrednjoskolci))
        //            frm = new FrmSrednjoskolci();
        //    }
        //    frm.Show();
        //    frm.WindowState = FormWindowState.Minimized;
        //    frm.WindowState = FormWindowState.Normal;
        //}

        //B
        //private void ShowForm(Form frm, ChildForms childForms)
        //{
        //    if (frm == null || frm.IsDisposed)
        //    {
        //        if (childForms == ChildForms.Ucenici)
        //        {
        //            if (frmUcenici == null || frmUcenici.IsDisposed)
        //                frmUcenici = new FrmUcenici();
        //            frm = frmUcenici;
        //        }
        //        if (childForms == ChildForms.Zaposleni)
        //        {
        //            if (frmZaposleni == null || frmZaposleni.IsDisposed)
        //                frmZaposleni = new FrmZaposleni();
        //            frm = frmZaposleni;
        //        }
        //    }
        //    frm.Show();
        //    frm.WindowState = FormWindowState.Minimized;
        //    frm.WindowState = FormWindowState.Normal;
        //}

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

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            AppData.BackupData();
        }

        private void TxtApiToken_Click(object sender, EventArgs e)
        {
            WebApi.Token = Clipboard.GetText();
            lblApiToken.Text = WebApi.TokenDisplay;
            AppData.SaveDsData();
        }
    }
}
