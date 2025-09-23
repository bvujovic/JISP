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
                // dodela SorBroj-eva razredima i odeljenjima, ako im vec nisu dodeljeni
                foreach (var r in AppData.Ds.Razredi)
                {
                    var sb = Utils.RazredSortBroj(r.NazivRazreda);
                    if (r.IsSortBrojNull() || r.SortBroj != sb)
                        r.SortBroj = sb;
                }
                foreach (var od in AppData.Ds.Odeljenja.Where(it => !it.IsRazredNull()))
                {
                    var sb = Utils.RazredSortBroj(od.Razred);
                    if (od.IsSortBrojNull() || od.SortBroj != sb)
                        od.SortBroj = sb;
                }

                bsRazredi.DataSource = AppData.Ds;
                dgvRazredi.StandardSort = bsRazredi.Sort;
                bsOdeljenja.DataSource = AppData.Ds;
                dgvOdeljenja.StandardSort = bsOdeljenja.Sort;

                lstSkGod.Items.Add("Sve");
                foreach (var skgod in AppData.Ds.Razredi.Select(it => it.SkolskaGodina).Distinct()
                    .OrderByDescending(it => it))
                    lstSkGod.Items.Add(skgod);
                if (lstSkGod.Items.Count > 1)
                    lstSkGod.SelectedIndex = 1;

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
            await (sender as UcButton).RunAsync(async () =>
            {
                if (lstSkGod.SelectedIndex > 0)
                    await DataGetter.GetVaspitneGrupe(lstSkGod.SelectedItem.ToString());

                foreach (var r in dgvRazredi.SelectedDataRows<Ds.RazrediRow>())
                    await (sender as UcButton).RunAsync(async () =>
                    {
                        if (r.NazivRazreda != AppData.NazivPppRazreda)
                            await DataGetter.GetOdeljenja(r.IdRazreda);
                    });
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
                // povezivanje ucenika sa odeljenjima
                foreach (var it in AppData.Ds.UcenikSkGod.Where(it => !it.IsRazredNull() && !it.IsOdeljenjeNull()))
                {
                    var idOdeljenja = FindIdOdRaz(it.SkGod, it.Razred, it.Odeljenje);
                    if (idOdeljenja.HasValue)
                        it.IdOdeljenja = idOdeljenja.Value;
                    else
                        it.SetIdOdeljenjaNull();
                }
                // brojanje ucenika 
                foreach (var od in AppData.Ds.Odeljenja)
                {
                    var ucenici = od.GetUcenikSkGodRows().Where(it => !it.Ispisan);
                    od.BrUcenika = ucenici.Count();
                    od.BrUcenikaIOP = ucenici.Count(it => !it.IsIOPNull());
                    od.BrOcenjenih = ucenici.Count(it => !it.IsOceneKrajBrojNull());
                    od.BrKrajObrazovanja = ucenici.Count(it => !it.IsZavrsObrazovanjaRezimeNull());
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

        private void BtnSmerovi_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var od in dgvOdeljenja.SelectedDataRows<Ds.OdeljenjaRow>())
                {
                    var ucSaSmer = AppData.Ds.UcenikSkGod.Where(it =>
                        !it.IsIdOdeljenjaNull() && it.IdOdeljenja == od.IdOdeljenja && !it.IsSmerNull());
                    if (ucSaSmer.Any())
                        od.Smer = string.Join(", ", ucSaSmer.Select(it => it.Smer).Distinct());
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void DgvRazredi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvRazredi.SelectedRows.Count == 0)
                    bsOdeljenja.Filter = "1=0";
                else
                {
                    var razIDs = dgvRazredi.SelectedDataRows<Ds.RazrediRow>().Select(it => it.IdRazreda);
                    var odIDs = AppData.Ds.OdRaz.Where(it => razIDs.Contains(it.IdRazreda)).Select(it => it.IdOdeljenja);
                    if (odIDs.Any())
                        bsOdeljenja.Filter = $"IdOdeljenja IN ({string.Join(", ", odIDs)})";
                    else
                        bsOdeljenja.Filter = "1=0";
                }
            }
            catch { }
        }
    }
}
