using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Instance = this;
        }

        public static FrmMain Instance { get; private set; }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // ako folder u kome se nalaze podaci za app ne postoji -> korisnik mora da ga definise
                var setts = Properties.Settings.Default;
                if (string.IsNullOrEmpty(setts.DataFolder))
                    if (!AppData.LoadFromRegistry())
                    {
                        var fbd = new FolderBrowserDialog { Description = "Odabir foldera u kojem će se čuvati podaci ove aplikacije." };
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            setts.DataFolder = fbd.SelectedPath;
                            setts.Save();
                        }
                    }
                lblDataFolder.Text = setts.DataFolder;
                AppData.LoadDsData();
                cmbBrowser.SelectedItem = AppData.Browser;
                BackupData.CreateBackupIfNeeded();
                Text = "Naš JISP - " + Utils.GetVersion();
            }
            catch (Exception ex)
            {
                Utils.ShowMbox(ex, "Učitavanje podataka iz XMLa");
                Close();
            }

            ttDataFolder.SetToolTip(lblDataFolder, "Klik za otvaranje foldera sa podacima");
            ttApiToken.SetToolTip(lblApiToken, "Klik za paste Web API Token-a (Copy response headers)");
            lblApiToken.Text = WebApi.TokenDisplay;
            FormClosing += FrmMain_FormClosing;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppData.SaveToRegistry();
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
                {
                    var count = tbl.Rows.Cast<DataRow>().Where(it => it.RowState != DataRowState.Unchanged).Count();
                    if (count > 0)
                        sb.AppendLine(tbl.TableName + ": " + count);
                }
            }
        }

        private void BtnUcenici_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(typeof(FrmUcenici));
        }

        private void BtnZaposleni_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(typeof(FrmZaposleni));
        }

        public void FrmChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            BackupData.CreateBackup();
        }

        private void LblApiToken_Click(object sender, EventArgs e)
        {
            var clipboard = Clipboard.GetText();
            if (clipboard.Contains(Environment.NewLine))
                WebApi.TakeApiToken(clipboard);
            else
                WebApi.Token = clipboard;
            lblApiToken.Text = WebApi.TokenDisplay;
            AppData.SaveSett(WebApi.TOKEN_CAPTION, WebApi.Token);
        }

        private void LblDataFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppData.DataFolder);
        }

        private void CmbBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppData.Browser = cmbBrowser.SelectedItem.ToString();
        }
    }
}
