using JISP.Classes;
using JISP.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms.Zaposlenii
{
    public partial class FrmZamene : Form
    {
        public FrmZamene()
        {
            InitializeComponent();
        }

        private readonly SkolskaGodina skGod = AppData.SkolskaGodina;

        private void FrmZamene_Load(object sender, EventArgs e)
        {
            bsZaposlenja.DataSource = AppData.Ds;
            FilterData();
            dgvZamene.StandardSort = bsZaposlenja.Sort;
            dgvZamene.LoadSettings();
            Text = $"Zamene ({skGod})";
            this.FormStandardSettings();
        }

        private void FilterData()
        {
            try
            {
                var strZamenjen = LatinicaCirilica.Lat2Cir(txtZamenjen.Text.Trim().ToLower());
                var zamenjeniIDs = AppData.Ds.Zaposleni.Where(z => z.ZaposleniString.ToLower().Contains(strZamenjen)).Select(z => z.IdZaposlenog);
                var strZamena = LatinicaCirilica.Lat2Cir(txtZamena.Text.Trim().ToLower());
                var zameneIDs = AppData.Ds.Zaposleni.Where(z => z.ZaposleniString.ToLower().Contains(strZamena)).Select(z => z.IdZaposlenog);
                var jeTekucaSkGod = skGod.PripadaDatum(DateTime.Today);
                var njaIDs =
                AppData.Ds.Zaposlenja.Where(it =>
                    !it.IsIdZamenjenogZaposlenogNull() &&
                    it.DatumZaposlenOd >= new DateTime(skGod.Start, 9, 1) &&
                    (jeTekucaSkGod && it.IsDatumZaposlenDoNull() || it.DatumZaposlenDo <= new DateTime(skGod.Kraj, 8, 31)) &&
                    (!chkAktivno.Checked || chkAktivno.Checked && it.IsDatumZaposlenDoNull()) &&
                    (strZamenjen == "" || !zamenjeniIDs.Any() || zamenjeniIDs.Contains(it.IdZamenjenogZaposlenog)) &&
                    (strZamena == "" || !zameneIDs.Any() || zameneIDs.Contains(it.IdZaposlenog))
                    ).Select(it => it.IdZaposlenja);

                bsZaposlenja.Filter = njaIDs.Any() ? $"IdZaposlenja IN ({string.Join(", ", njaIDs)})" : "1=0";
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Greška pri filtriranju podataka"); }
        }

        private void ChkAktivno_CheckedChanged(object sender, EventArgs e)
            => FilterData();

        private void TxtZamenjen_TextChanged(object sender, EventArgs e)
            => FilterData();

        private void TxtZamena_TextChanged(object sender, EventArgs e)
            => FilterData();

        private void FrmZamene_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvZamene.SaveSettings();
        }
    }
}
