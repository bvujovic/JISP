using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmObrazovanje : Form
    {
        public FrmObrazovanje()
        {
            InitializeComponent();
        }

        private const string CmbDohvatiZapSaGlavne = "glavne forme";
        private const string CmbDohvatiZapSaOveForme = "ove forme";

        private void FrmObrazovanje_Load(object sender, EventArgs e)
        {
            cmbPodaciZaDohvatanje.Items.AddRange(new[] {
                CmbDohvatiZapSaGlavne,
                CmbDohvatiZapSaOveForme
            });
            cmbPodaciZaDohvatanje.SelectedIndex = 0;
            cmbPodaciZaDohvatanje.AdjustWidth();

            bsObrazovanja.DataSource = AppData.Ds.Obrazovanja;
            dgvObrazovanja.StandardSort = bsObrazovanja.Sort;
            this.FormStandardSettings();
        }

        private async void BtnDohvatiPodatke_Click(object sender, EventArgs e)
        {
            try
            {
                var frmZaposleni = Application.OpenForms.OfType<FrmZaposleni>().FirstOrDefault();
                IEnumerable<Ds.ZaposleniRow> selZaposleni = null;
                if ((string)cmbPodaciZaDohvatanje.SelectedItem == CmbDohvatiZapSaOveForme)
                    selZaposleni = (dgvObrazovanja.SelectedRows.Count > 0)
                        ? dgvObrazovanja.SelectedDataRows<Ds.ObrazovanjaRow>().Select(it => it.ZaposleniRow).Distinct()
                        : new List<Ds.ZaposleniRow> { dgvObrazovanja.CurrDataRow<Ds.ObrazovanjaRow>().ZaposleniRow };
                else
                    selZaposleni = frmZaposleni.SelektovaniZaposleni;

                foreach (var zaposleni in selZaposleni)
                    await (sender as Controls.UcButton).RunAsync(async () =>
                {
                    lblStatus.Text = zaposleni.ToString();
                    await DataGetter.GetObrazovanjaAsync(zaposleni.IdZaposlenog);
                });
                lblStatus.Text = "";
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void TxtFilterZaposleni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsObrazovanja.Filter = $"_Zaposleni LIKE '%{txtFilterZaposleni.Text}%'";
            }
            catch (Exception ex) { Utils.ShowMbox(ex, this.Text); }
        }

        private async void DgvObrazovanja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvcDokument.Index)
                await Utils.PreuzmiDokument(dgvObrazovanja, e);
        }
    }
}
