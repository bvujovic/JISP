using JISP.Classes;
using JISP.Data;
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

            bsZaposleni.DataSource = Ds = AppData.Ds;
            bsZaposlenja.DataMember = "FK_Zaposleni_Zaposlenja";
            bsZaposlenja.Sort = "Aktivan DESC";
            DisplayPositionRowCount();
        }

        private readonly Ds Ds;

        private void ChkCopyOnClick_CheckedChanged(object sender, EventArgs e)
            => dgvZaposleni.CopyOnCellClick = dgvZaposlenja.CopyOnCellClick = chkCopyOnClick.Checked;

        private void BtnSaveData_Click(object sender, EventArgs e)
            => AppData.SaveDsData();

        private void DisplayPositionRowCount()
            => lblRowCount.Text = $"Red {bsZaposleni.Position + 1} / {bsZaposleni.Count}";

        private void BsZaposleni_CurrentChanged(object sender, EventArgs e)
            => DisplayPositionRowCount();

        /// <summary>Za dati naziv radnog mesta ili njegov deo,
        /// vraca skup IDeva zaposlenih sa tim radim mestom.</summary>
        private static IEnumerable<int> FilterZaposleniIDs(string s)
        {
            s = s.ToLower();
            var ids = new HashSet<int>();
            foreach (var zap in AppData.Ds.Zaposlenja.Where
                (it => it.RadnoMestoNaziv.ToLower().Contains(s)))
                ids.Add(zap.IdZaposlenog);
            return ids;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            try
            {
                var s = txtFilter.Text;
                // osnovna pretraga: ime, prezime, jmbg
                var filter = $"Ime LIKE '%{s}%' OR Prezime LIKE '%{s}%' OR JMBG LIKE '%{s}%' ";
                // pretraga po zaposlenjima (radna mesta)
                var ids = FilterZaposleniIDs(s);
                if (ids.Count() > 0)
                    filter += $" OR IdZaposlenog IN ({string.Join(", ", ids)})";
                // da li je zaposleni aktivan ili ne
                if (chkAktivniZap.CheckState != CheckState.Indeterminate)
                    filter = $"({filter}) AND Aktivan = {chkAktivniZap.Checked}";
                bsZaposleni.Filter = filter;

            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Pretraga zaposlenih"); }
            DisplayPositionRowCount();
        }

        private void TxtFilter_FilterCleared(object sender, EventArgs e)
            => chkAktivniZap.CheckState = CheckState.Indeterminate;

        /// <summary>Ucitavanje JSON podataka o zaposlenima iz clipboard-a.</summary>
        private async void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                // osnovni podaci o zaposlenima ne ukljucuju id zaposlenja
                // tako da se update te tabele radi kao Clear, pa Add new
                Ds.Zaposlenja.Clear();
                var zaps = await WebApi.GetList<Zaposleni>(WebApi.ReqEnum.Zap_OpstiPodaciOZaposlenima);
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
                        if (Utils.ShowMboxYesNo($"Greška: {ex.Message}\r\nNastavi učitavanje?", btnLoadData.Text)
                            != DialogResult.Yes)
                            break;
                    }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnLoadData.Text); }
            DisplayPositionRowCount();
        }

        private void DgvZaposleni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvcZapId.Index || e.RowIndex == -1)
                return;
            var drv = dgvZaposleni.CurrentRow.DataBoundItem as System.Data.DataRowView;
            if (drv.Row is Ds.ZaposleniRow zap)
            {
                var url = $"https://jisp.mpn.gov.rs/regzaposlenih/sekcije/{zap.JMBG}/{zap.IdZaposlenog}";
                Utils.GoToLink(url);
            }
        }
    }
}
