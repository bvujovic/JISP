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

            bsZaposleni.DataSource = Ds = Data.AppData.Ds;
            bsZaposlenja.DataMember = "FK_Zaposleni_Zaposlenja";
            DisplayRowCount();

            //var zap = Ds.Zaposleni.FirstOrDefault();
            //var nje = Ds.Zaposlenja.NewZaposlenjaRow();
            //nje.IdZaposlenog = zap.IdZaposlenog;
            //nje.IdZaposlenja = 123;
            //Ds.Zaposlenja.AddZaposlenjaRow(nje);
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
                        var nja = zap.ZaposleniZaposlenje;
                        if (nja != null)
                            foreach (var nje in nja)
                            {
                                var redNje = red.GetZaposlenjaRows()
                                    .FirstOrDefault(it => it.RadnoMestoNaziv == nje.RadnoMestoNaziv);
                                if (redNje == null) // novo zaposlenje
                                {
                                    redNje = Ds.Zaposlenja.NewZaposlenjaRow();
                                    redNje.RadnoMestoNaziv = nje.RadnoMestoNaziv;
                                    redNje.IdZaposlenog = red.IdZaposlenog;
                                    Ds.Zaposlenja.AddZaposlenjaRow(redNje);
                                }
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
    }
}
