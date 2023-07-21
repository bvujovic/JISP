using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
#if DEBUG
                btnTest.Visible = true;
#endif
                var godine = new List<SkolskaGodina>();
                for (int i = 2020; i <= DateTime.Today.Year; i++)
                    godine.Add(new SkolskaGodina(i));
                cmbSkolskaGodina.DataSource = godine;

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
                cmbSkolskaGodina.SelectedItem = AppData.SkolskaGodina;
                BackupData.CreateBackupIfNeeded();
                Text = "Naš JISP - " + Utils.GetVersionName();
                Icon = Properties.Resources.grb_srb;
            }
            catch (Exception ex)
            {
                Utils.ShowMbox(ex, "Učitavanje podataka iz XMLa");
                Close();
            }

            ttDataFolder.SetToolTip(lblDataFolder, "Klik za otvaranje foldera sa podacima");
            ttApiToken.SetToolTip(lblApiToken, "Klik za paste Web API Token-a (Copy request headers)");
            lblApiToken.Text = WebApi.TokenDisplay;
            FormClosing += FrmMain_FormClosing;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppData.SaveToRegistry();
            AppData.ClearTempTables();
            if (AppData.Ds.HasChanges())
            {
                var sb = new StringBuilder();
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
        private static void AddChangesDescription(string caption, DataSet ds, StringBuilder sb)
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

        private void BtnProstorije_Click(object sender, EventArgs e)
        {
            Utils.ShowForm(typeof(FrmProstorije));
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            BackupData.CreateBackup();
        }

        public void FrmChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            var floatingForms = new[] { nameof(FrmSistematizacija), nameof(FrmRacunari) };
            if (Application.OpenForms.Cast<Form>().Where(it => !floatingForms.Contains(it.Name))
                .Count() == 0)
            {
                ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
            }
        }

        private async void LblApiToken_Click(object sender, EventArgs e)
        {
            var clipboard = Clipboard.GetText();
            if (clipboard.Contains(Environment.NewLine))
                WebApi.TakeApiToken(clipboard);
            else
                WebApi.Token = clipboard;
            lblApiToken.Text = WebApi.TokenDisplay;
            if (WebApi.IsTokenValid())
            {
                AppData.SaveSett(WebApi.TOKEN_CAPTION, WebApi.Token);
                try
                {
                    await DataGetter.GetSistematizacijaAsync();
                    var novaPorukaSist = await DataGetter.GetPorukaAsync(TipPoruke.Sistematizacija);
                    await DataGetter.GetCenusAsync();
                    var novaPorukaCenus = await DataGetter.GetPorukaAsync(TipPoruke.CENUS);
                    btnPrikaziPoruke.BackColor = System.Drawing.Color.Orange;
                    if (!novaPorukaSist && !novaPorukaCenus)
                    {
                        await System.Threading.Tasks.Task.Delay(500);
                        btnPrikaziPoruke.BackColor = System.Drawing.SystemColors.Control;
                    }
                }
                catch (Exception ex) { Utils.ShowMbox(ex, lblApiToken.Text); }
            }
        }

        private void LblDataFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppData.DataFolder);
        }

        private void CmbBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppData.Browser = cmbBrowser.SelectedItem.ToString();
        }

        private void CmbSkolskaGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppData.SkolskaGodina = (SkolskaGodina)cmbSkolskaGodina.SelectedItem;
            // ovo pravi gresku na pocetku ucitavanja programa kod ucitavanja podataka iz XMLa
            //?AppData.SaveSett(AppData.SkGodSett, AppData.SkolskaGodina.Start.ToString());
        }

        private void BtnPrikaziPoruke_Click(object sender, EventArgs e)
        {
            new FrmPoruke().ShowDialog();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.ShowForm(typeof(FrmFormAutoInput));

                //                var sb = new StringBuilder();
                //                foreach (var z in AppData.Ds.Zaposleni)
                //                {
                //                    sb.Append($@"
                //    {{
                //        ""lat"": ""{LatinicaCirilica.Cir2Lat(z.ToString())}"",
                //        ""cir"": ""{z}"",
                //        ""broj"": 0
                //    }},
                //");
                //                }
                //                Clipboard.SetText(sb.ToString());
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnTest.Text); }
        }
    }
}
