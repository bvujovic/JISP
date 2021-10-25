using JISP.Classes;
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
    public partial class FrmZaposleni : Form
    {
        public FrmZaposleni()
        {
            InitializeComponent();

            bsZap.DataSource = Ds = Data.AppData.Ds;
            DisplayRowCount();
        }

        //! Ne koristiti ds, vec samo Ds. Videti da se ds ukloni ako je moguce.
        private Data.Ds Ds;

        private void BtnSaveData_Click(object sender, EventArgs e)
            => Data.AppData.SaveDsData();

        private void DisplayRowCount()
            => lblRowCount.Text = $"Redova: {bsZap.Count}";

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var s = txtFilter.Text;
                bsZap.Filter = $"Ime LIKE '%{s}%' OR Prezime LIKE '%{s}%' OR JMBG LIKE '%{s}%' ";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            DisplayRowCount();
        }

        /// <summary>Ucitavanje JSON podataka o zaposlenima iz clipboard-a.</summary>
        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
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

                        //TODO dodavanje zaposlenja
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
    }
}
