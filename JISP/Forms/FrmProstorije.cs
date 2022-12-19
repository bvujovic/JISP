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
            dgvLokacije.TsmiSelekcija(false);
            dgvObjekti.TsmiSelekcija(false);
            dgvProstorije.TsmiSelekcija(false);
            PodesiCmbPodaciZaDohvatanje();
            lblStatistika.Text = "";
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

                    foreach (var p in DgvProstorijeSelectedRows())
                        await DataGetter.GetProstorijeDodatnoAsync(p.IdProstorije);
                });
        }

        public bool IsDgvProstorijeSelectedRowsEmpty()
            => dgvProstorije.SelectedRows.Count == 0;

        public IEnumerable<Ds.ProstorijeRow> DgvProstorijeSelectedRows()
            => dgvProstorije.SelectedDataRows<Ds.ProstorijeRow>();

        public bool IsDgvProstorijeCurrentRowNull()
            => dgvProstorije.CurrentRow == null;

        public Ds.ProstorijeRow DgvProstorijeCurrentRow()
            => dgvProstorije.CurrDataRow<Ds.ProstorijeRow>();

        private void BtnRacunari_Click(object sender, EventArgs e)
        {
            frmRacunari = new FrmRacunari(this);
            dgvProstorije.CurrentCellChanged += frmRacunari.ProstorijeCurrentRowChanged;
            frmRacunari.Show();
            if (Screen.PrimaryScreen.WorkingArea.Height - Top - Height > FrmRacunari.INIT_HEIGHT)
            {
                frmRacunari.StartPosition = FormStartPosition.Manual;
                frmRacunari.Top = Top + Height + 5;
                frmRacunari.Left = Left + 5;
            }
        }

        private FrmRacunari frmRacunari;

        private void FrmProstorije_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmRacunari != null && !frmRacunari.Disposing && !frmRacunari.IsDisposed)
            {
                dgvProstorije.CurrentCellChanged -= frmRacunari.ProstorijeCurrentRowChanged;
                frmRacunari.Close();
            }
        }

        private void DgvProstorije_SelectionChanged(object sender, EventArgs e)
        {
            var imaPosla = true;
            if (dgvProstorije.SelectedCells.Count <= 1)
                imaPosla = false;
            var cells = dgvProstorije.SelectedCells.Cast<DataGridViewCell>();
            var cols = cells.Select(it => it.ColumnIndex).Distinct();
            if (cols.Count() == 0 || cols.Count() > 1)
                imaPosla = false;
            var numTypes = new Type[] { typeof(int), typeof(float), typeof(double) };
            if (imaPosla && !numTypes.Contains(dgvProstorije.Columns[cols.First()].ValueType))
                imaPosla = false;

            if (imaPosla)
            {
                var sum = cells.Sum(it => (double)it.Value);
                lblStatistika.Text = $"Broj: {cells.Count()}\r\nSuma: {sum}";
            }
            else
                lblStatistika.Text = string.Empty;
        }
    }
}
