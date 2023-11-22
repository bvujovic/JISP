using JISP.Classes;
using JISP.Controls;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmRacunari : Form
    {
        public FrmRacunari(FrmProstorije frmProstorije)
        {
            InitializeComponent();
            this.frmProstorije = frmProstorije;
        }

        private readonly FrmProstorije frmProstorije;
        /// <summary>Pocetna visina ove forme.</summary>
        public static readonly int INIT_HEIGHT = 290;

        private void FrmRacunari_Load(object sender, EventArgs e)
        {
            txtFilter.ShouldBeCyrillic = false;
            bsRacunari.DataSource = AppData.Ds;
            dgvRacunari.TsmiSelekcija(false);
            FilterData();
            Height = INIT_HEIGHT;
            chkFloatingForma.Checked = FormaJeTopMost;
            dgvRacunari.StandardSort = bsRacunari.Sort;
            this.FormStandardSettings();
        }

        private void FilterData()
        {
            try
            {
                var filters = new List<string>();
                if (rbPrikazIzProstorije.Checked && !frmProstorije.IsDisposed
                    && !frmProstorije.IsDgvProstorijeCurrentRowNull())
                    filters.Add($"IdProstorije = {frmProstorije.DgvProstorijeCurrentRow().IdProstorije}");
                var s = txtFilter.Text.Trim();
                if (s.Length > 0)
                    filters.Add($"(NazivRacunara LIKE '%{s}%' OR Procesor LIKE '%{s}%')");

                if (filters.Count > 0)
                    bsRacunari.Filter = string.Join(" AND ", filters);
                else
                    bsRacunari.RemoveFilter();
                dgvcProstorija.Visible = rbPrikazSvi.Checked;
                if (rbPrikazIzProstorije.Checked)
                    Text = frmProstorije.IsDgvProstorijeCurrentRowNull() ? "Računari iz prostorije..."
                        : $"Računari iz prostorije \"{frmProstorije.DgvProstorijeCurrentRow().NazivProstorije}\"";
                else
                    Text = "Svi računari u školi";
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Pretraga računara"); }
        }

        public void ProstorijeCurrentRowChanged(object sender, EventArgs e)
            => FilterData();

        private void RbPrikaz_CheckedChanged(object sender, EventArgs e)
            => FilterData();

        private async void BtnDohvatiPodatke_Click(object sender, EventArgs e)
        {
            try
            {
                if (!frmProstorije.IsDisposed)
                    await (sender as UcButton).RunAsync(async () =>
                    {
                        if (!frmProstorije.IsDgvProstorijeSelectedRowsEmpty())
                            foreach (var r in frmProstorije.DgvProstorijeSelectedRows())
                                await DataGetter.GetRacunariOsnovnoAsync(r.IdProstorije);
                        else
                            await DataGetter.GetRacunariOsnovnoAsync(frmProstorije.DgvProstorijeCurrentRow().IdProstorije);
                    });
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
            => FilterData();

        private void ChkFloatingForma_CheckedChanged(object sender, EventArgs e)
            => TopMost = chkFloatingForma.Checked;

        private static bool FormaJeTopMost = false;

        private void FrmRacunari_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormaJeTopMost = chkFloatingForma.Checked;
        }
    }
}
