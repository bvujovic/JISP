using JISP.Classes;
using JISP.Controls;
using JISP.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmRazrediOdeljenja : Form
    {
        public FrmRazrediOdeljenja()
        {
            InitializeComponent();

            try
            {
                bsRazredi.DataSource = AppData.Ds;
                dgvRazredi.StandardSort = bsRazredi.Sort;
                bsOdeljenja.DataSource = AppData.Ds;
                dgvOdeljenja.StandardSort = bsOdeljenja.Sort;

                lstSkGod.Items.Add("Sve");
                foreach (var skgod in AppData.Ds.Razredi.Select(it => it.SkolskaGodina).Distinct()
                    .OrderByDescending(it => it))
                    lstSkGod.Items.Add(skgod);

                this.FormStandardSettings();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private async void BtnGetRazredi_Click(object sender, EventArgs e)
        {
            await (sender as UcButton).RunAsync(async () =>
            {
                await DataGetter.GetRazredi();
            });
        }

        private async void BtnGetOdeljenja_Click(object sender, EventArgs e)
        {
            foreach (var r in dgvRazredi.SelectedDataRows<Ds.RazrediRow>())
                await (sender as UcButton).RunAsync(async () =>
                {
                    await DataGetter.GetOdeljenja(r.IdRazreda);
                });
        }

        private void LstSkGod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstSkGod.SelectedIndex > 0)
                    bsRazredi.Filter = $"SkolskaGodina = '{lstSkGod.SelectedItem}'";
                else
                    bsRazredi.RemoveFilter();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void BtnPovezi_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var it in AppData.Ds.UcenikSkGod.Where(it => !it.IsRazredNull() && !it.IsOdeljenjeNull()))
                {
                    var idOdeljenja = FindIdOdRaz(it.SkGod, it.Razred, it.Odeljenje);
                    if (idOdeljenja.HasValue)
                        it.IdOdeljenja = idOdeljenja.Value;
                    else
                        it.SetIdOdeljenjaNull();
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private int? FindIdOdRaz(string skGod, string razred, string odeljenje)
        {
            var idRaz = AppData.Ds.Razredi.FirstOrDefault
                (it => it.SkolskaGodina == skGod && it.NazivRazreda == razred)?.IdRazreda;
            var idOd = AppData.Ds.OdRaz.FirstOrDefault(it => it.OdeljenjaRow.NazivOdeljenja == odeljenje
                && it.IdRazreda == idRaz)?.IdOdeljenja;
            return idOd;
        }
    }
}
