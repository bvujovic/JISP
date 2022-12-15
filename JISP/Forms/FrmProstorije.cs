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
    public partial class FrmProstorije : Form
    {
        public FrmProstorije()
        {
            InitializeComponent();
        }

        private void FrmProstorije_Load(object sender, EventArgs e)
        {
            bsLokacije.DataSource = AppData.Ds.Lokacije;
            //dgvLokacije.TsmiSelekcija(false);
            //dgvObjekti.TsmiSelekcija(false);
            PodesiCmbPodaciZaDohvatanje();
        }

        private void PodesiCmbPodaciZaDohvatanje()
        {
            cmbPodaciZaDohvatanje.Items.Clear();
            cmbPodaciZaDohvatanje.Items.AddRange(new[] {
                CmbDohvatiOsnovno,
                CmbDohvatiProstorijeDodatno,
            });
            cmbPodaciZaDohvatanje.AdjustWidth();
        }

        private const string CmbDohvatiOsnovno = "Osnovno: lokacije, objekti, prostorije";
        private const string CmbDohvatiProstorijeDodatno = "Prostorije dodatno: sprat, grejanje, hlađenje...";

        private async void BtnDohvatiPodatke_Click(object sender, EventArgs e)
        {
            var selItem = (string)cmbPodaciZaDohvatanje.SelectedItem;

            if (selItem == CmbDohvatiOsnovno)
                await (sender as UcButton).RunAsync(async () =>
                {
                    await DataGetter.GetLokacijeAsync();
                    await DataGetter.GetObjektiAsync();
                    await DataGetter.GetProstorijeOsnovnoAsync();
                });

            if (selItem == CmbDohvatiProstorijeDodatno)
                await (sender as UcButton).RunAsync(async () =>
                {
                    if (AppData.Ds.SifSpratovi.Count == 0)
                        await DataGetter.GetSpratoviAsync();
                    if (AppData.Ds.SifGrejanja.Count == 0)
                        await DataGetter.GetGrejanjaAsync();
                    if (AppData.Ds.SifHladjenja.Count == 0)
                        await DataGetter.GetHladjenjaAsync();

                    foreach (var p in dgvProstorije.SelectedDataRows<Ds.ProstorijeRow>())
                        await DataGetter.GetProstorijeDodatnoAsync(p.IdProstorije);
                });
        }

        private void ChkCopyOnClick_CheckedChanged(object sender, EventArgs e)
            => dgvLokacije.CopyOnCellClick = dgvObjekti.CopyOnCellClick = dgvProstorije.CopyOnCellClick 
            = chkCopyOnClick.Checked;

    }
}
