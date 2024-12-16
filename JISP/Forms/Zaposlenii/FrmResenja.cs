using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmResenja : Form
    {
        public FrmResenja()
        {
            InitializeComponent();

            try
            {
                bsResenja.DataSource = AppData.Ds;
                dgvResenjaSva.StandardSort = bsResenja.Sort;

                var skGodine = AppData.Ds.Resenja.Select(it => it.SkolskaGodina).Distinct();
                cmbSkGod.Items.Add("Sve");
                foreach (var skgod in skGodine.OrderByDescending(it => it))
                    cmbSkGod.Items.Add(skgod);
                //B cmbSkGod.SelectedIndex = 0;
                //B cmbSkGod.SelectedItem = AppData.SkolskaGodina.Naziv;
                cmbSkGod.SelectedItem = AppData.LoadSett("FrmResenja_cmbSkGod", (string)cmbSkGod.Items[0]);

                var tipoviResenja = AppData.Ds.Resenja.Select(it => it.TipResenja).Distinct();
                cmbTipoviResenja.Items.Add("Svi");
                foreach (var tipRes in tipoviResenja)
                    cmbTipoviResenja.Items.Add(tipRes);
                cmbTipoviResenja.SelectedIndex = 0;
                cmbTipoviResenja.AdjustWidth();

                cmbAkcije.Items.AddRange(new[] {
                CmbAkcijaDuplikatiBrojeva,
                CmbAkcijaDuplikatiZaposlenih,
                CmbAkcijaNedostajuciZaposleni,
            });
                cmbAkcije.AdjustWidth();

                ttSamoAktivnaZaposlenja.SetToolTip(chkSamoAktivnaZaposlenja
                    , "Da li se učitavaju rešenja samo za aktivna zaposlenja ili za sva.");
                this.FormStandardSettings();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private const string CmbAkcijaDuplikatiBrojeva = "Pronalaženje duplikata brojeva rešenja";
        private const string CmbAkcijaDuplikatiZaposlenih = "Pronalaženje duplikata zaposlenih";
        private const string CmbAkcijaNedostajuciZaposleni = "Prikaz zaposlenih koji nisu u tabeli";

        private async void BtnUcitajResenja_Click(object sender, EventArgs e)
        {
            //if (Utils.ShowMboxYesNo("Da li ste sigurni? Dohvatanje svih rešenja može trajati dugo."
            //    , btnUcitajResenja.Text) != DialogResult.Yes)
            //    return;

            var frm = Application.OpenForms.OfType<FrmZaposleni>().FirstOrDefault();
            foreach (var zaposleni in frm.SelektovaniZaposleni)
                await (sender as Controls.UcButton).RunAsync(async () =>
                {
                    lblStatus.Text = zaposleni.ToString();

                    var zaposlenja = zaposleni.GetZaposlenjaRows().Where
                        (it => chkSamoAktivnaZaposlenja.Checked ? it.Aktivan : true);
                    await DataGetter.GetResenjaAsync(zaposlenja);
                });
            lblStatus.Text = "";
        }

        private static string f(object current, string column)
            => (string)(current as DataRowView).Row[column];

        private void BtnAkcijaPokreni_Click(object sender, EventArgs e)
        {
            var selItem = (string)cmbAkcije.SelectedItem;
            try
            {
                if (selItem == CmbAkcijaDuplikatiBrojeva || selItem == CmbAkcijaDuplikatiZaposlenih)
                {
                    var col = selItem == CmbAkcijaDuplikatiBrojeva ? "BrojResenja" : "_Zaposleni";
                    if (!bsResenja.Sort.StartsWith(col))
                    {
                        bsResenja.Sort = col;
                        bsResenja.MoveFirst();
                    }
                    bsResenja.MoveNext();
                    while (bsResenja.Position < bsResenja.Count - 1)
                    {
                        if (f(bsResenja.Current, col) == f(bsResenja[bsResenja.Position - 1], col))
                            break;
                        bsResenja.MoveNext();
                    }
                }

                if (selItem == CmbAkcijaNedostajuciZaposleni)
                {
                    var zapIDs = AppData.Ds.Zaposleni.Select(it => it.IdZaposlenog).ToList();
                    foreach (var res in bsResenja.List.Cast<DataRowView>().Select(it => it.Row as Ds.ResenjaRow))
                        zapIDs.RemoveAll(it => it == res.ZaposlenjaRow.IdZaposlenog);
                    var zaps = AppData.Ds.Zaposleni
                        .Where(it => it.Aktivan && zapIDs.Contains(it.IdZaposlenog))
                        .Select(it => it.ToString()).OrderBy(it => it);
                    Utils.ShowMbox($"Broj zaposlenih: {zaps.Count()}\r\n\r\n" +
                        string.Join(Environment.NewLine, zaps), selItem);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, selItem); }
        }

        private async void DgvResenjaSva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvcDokument.Index)
                await Utils.PreuzmiDokument(dgvResenjaSva, e);
        }

        private void FiltriranjeResenja()
        {
            try
            {
                var filteri = new List<string>();
                if (chkAktivniUgovori.Checked)
                    filteri.Add("AktivnoZaposlenje = 1");
                if (cmbSkGod.SelectedIndex > 0)
                    filteri.Add($"SkolskaGodina = '{cmbSkGod.SelectedItem}'");
                if (cmbTipoviResenja.SelectedIndex > 0)
                    filteri.Add($"TipResenja = '{cmbTipoviResenja.SelectedItem}'");
                bsResenja.Filter = string.Join(" AND ", filteri);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void CmbSkGod_SelectedIndexChanged(object sender, EventArgs e)
            => FiltriranjeResenja();

        private void CmbTipoviResenja_SelectedIndexChanged(object sender, EventArgs e)
            => FiltriranjeResenja();

        private void ChkAktivniUgovori_CheckedChanged(object sender, EventArgs e)
            => FiltriranjeResenja();

        private void FrmResenja_FormClosed(object sender, FormClosedEventArgs e)
        {
            //AppData.SaveSett("FrmResenja_cmbSkGod", (string)cmbSkGod.SelectedItem);
        }

        private void FrmResenja_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppData.SaveSett("FrmResenja_cmbSkGod", (string)cmbSkGod.SelectedItem);
        }
    }
}
