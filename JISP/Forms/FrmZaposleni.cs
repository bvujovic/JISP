using JISP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmZaposleni : Form
    {
        public FrmZaposleni()
        {
            InitializeComponent();

            bsZaposleni.DataSource = Ds = Data.AppData.Ds;
            bsZaposlenja.DataMember = "FK_Zaposleni_Zaposlenja";
            bsZaposlenja.Sort = "Aktivan DESC";
            DisplayRowCount();
        }

        private readonly Data.Ds Ds;

        private void BtnSaveData_Click(object sender, EventArgs e)
            => Data.AppData.SaveDsData();

        private void DisplayRowCount()
            => lblRowCount.Text = $"Redova: {bsZaposleni.Count}";

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var s = txtFilter.Text;
                bsZaposleni.Filter = $"Ime LIKE '%{s}%' OR Prezime LIKE '%{s}%' OR JMBG LIKE '%{s}%' ";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            DisplayRowCount();
        }

        private void ChkAktivniZap_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkAktivniZap.CheckState == CheckState.Indeterminate)
                    bsZaposleni.RemoveFilter();
                else
                    bsZaposleni.Filter = $"Aktivan = {chkAktivniZap.Checked}";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            DisplayRowCount();
        }

        /// <summary>Ucitavanje JSON podataka o zaposlenima iz clipboard-a.</summary>
        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                // osnovni podaci o zaposlenima ne ukljucuju id zaposlenja
                // tako da se update te tabele radi kao Clear, pa Add new
                Ds.Zaposlenja.Clear();
                var json = Clipboard.GetText();
                var zaps = Newtonsoft.Json.JsonConvert.DeserializeObject
                    <List<Data.Zaposleni>>(json);
                foreach (var zap in zaps)
                    try
                    {
                        var red = Ds.Zaposleni.FindByIdZaposlenog(zap.Id);
                        if (red == null) // novi zaposleni
                        {
                            red = Ds.Zaposleni.NewZaposleniRow();
                            red.IdZaposlenog = zap.Id;
                            red.Ime = zap.Ime;
                            red.Prezime = zap.Prezime;
                            red.JMBG = zap.JMBG;
                            red.Aktivan = (bool)zap.TrenutnoZaposlen;
                            Ds.Zaposleni.AddZaposleniRow(red);
                        }
                        else // update zaposlenog
                        {
                            red.Ime = zap.Ime;
                            red.Prezime = zap.Prezime;
                            red.JMBG = zap.JMBG;
                            red.Aktivan = (bool)zap.TrenutnoZaposlen;
                        }

                        var nja = zap.ZaposleniZaposlenje;
                        if (nja != null)
                            foreach (var nje in nja)
                            {
                                var redNje = Ds.Zaposlenja.NewZaposlenjaRow();
                                redNje.IdZaposlenog = red.IdZaposlenog;
                                redNje.Aktivan = nje.Aktivan;
                                redNje.RadnoMestoNaziv = nje.RadnoMestoNaziv;
                                Ds.Zaposlenja.AddZaposlenjaRow(redNje);
                            }

                    }
                    catch (Exception ex)
                    {
                        if (!chkLoadWoMsgs.Checked &&
                            Utils.ShowMboxYesNo($"Greška: {ex.Message}\r\nNastavi učitavanje?", btnLoadData.Text) != DialogResult.Yes)
                            break;
                    }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnLoadData.Text); }
            DisplayRowCount();
        }

        private void DgvZaposleni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvcZapId.Index || e.RowIndex == -1)
                return;
            var drv = dgvZaposleni.CurrentRow.DataBoundItem as System.Data.DataRowView;
            if (drv.Row is Data.Ds.ZaposleniRow zap)
            {
                var url = $"https://jisp.mpn.gov.rs/regzaposlenih/sekcije/{zap.JMBG}/{zap.IdZaposlenog}";
                Utils.GoToLink(url);
            }
        }
    }
}
