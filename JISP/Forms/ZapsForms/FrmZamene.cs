using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms.ZapsForms
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
                var pogresneZamene = AppData.Ds.Zaposlenja.Where(it => !it.IsIdZamenjenogZaposlenogNull() &&
                    !it.VrstaAngazovanja.Contains("замен")).ToList();
                if (pogresneZamene.Any() && Utils.ShowMboxYesNo("Ovo su zaposlenja za koje tip ugovora nije \"zamena...\", a imaju unete zaposlene na zameni:" + Environment.NewLine
                    + string.Join(Environment.NewLine, pogresneZamene.Select(it => it._ZamenjeniZaposleni + " zamenjen sa " + it._Zaposleni + ", od " + it.DatumZaposlenOd.ToString(Utils.DatumFormat)))
                    + "Da li želite da poništite unete zamene (ID-evi zaposlenih na zameni) za ova zaposlenja?"
                    , "Greške u zamenama") == DialogResult.Yes)
                    pogresneZamene.ForEach(it => it.SetIdZamenjenogZaposlenogNull());

                var strZamenjen = LatinicaCirilica.Lat2Cir(txtZamenjen.Text.Trim().ToLower());
                var zamenjeniIDs = AppData.Ds.Zaposleni.Where(z => z.ZaposleniString.ToLower().Contains(strZamenjen)).Select(z => z.IdZaposlenog);
                var strZamena = LatinicaCirilica.Lat2Cir(txtZamena.Text.Trim().ToLower());
                var zameneIDs = AppData.Ds.Zaposleni.Where(z => z.ZaposleniString.ToLower().Contains(strZamena)).Select(z => z.IdZaposlenog);
                var njaIDs =
                AppData.Ds.Zaposlenja.Where(it =>
                    !it.IsIdZamenjenogZaposlenogNull() &&
                    (it.DatumZaposlenOd >= new DateTime(skGod.Start, 9, 1) && it.DatumZaposlenOd <= new DateTime(skGod.Kraj, 8, 31) ||
                    it.IsDatumZaposlenDoNull() && it.DatumZaposlenOd <= new DateTime(skGod.Kraj, 8, 31)) &&
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

        private async void DgvZamene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvcDokument.Index)
                    await Utils.PreuzmiDokument(dgvZamene, e);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void BtnBrojZaposlenihKrozVreme_Click(object sender, EventArgs e)
        {
            try
            {
                //* Ukupan broj zaposlenih sa zamenama po danima
                //var datumOd = new DateTime(2024, 12, 1);
                //var datumDo = new DateTime(2024, 12, 31);
                //for (var dt = datumOd; dt <= datumDo; dt = dt.AddDays(1))
                //{
                //    Console.Write(dt.ToShortDateString() + "\t");
                //    var sumProc = 0.0;
                //    var count = 0;
                //    var zaps = new HashSet<int>();
                //    foreach (var nja in AppData.Ds.Zaposlenja)
                //    {
                //        if (nja.DatumZaposlenOd <= dt && (nja.IsDatumZaposlenDoNull() && nja.Aktivan || dt <= nja.DatumZaposlenDo))
                //        {
                //            //Console.WriteLine(nja);
                //            count++;
                //            zaps.Add(nja.ZaposleniRow.IdZaposlenog);
                //            sumProc += nja.ProcenatRadnogVremena;
                //        }
                //    }
                //    Console.WriteLine($"\t{zaps.Count}\t{sumProc:0.00}");
                //}

                //* Ukupan broj zaposlenih sa zamenama po mesecima
                var datumOd = new DateTime(2024, 1, 1);
                var datumDo = new DateTime(2025, 1, 30);
                for (var m = datumOd; m <= datumDo; m = m.AddMonths(1))
                {
                    var count = 0;
                    var zaps = new HashSet<int>();
                    for (var dt = m; dt < m.AddMonths(1); dt = dt.AddDays(1))
                    {
                        //Console.WriteLine(dt.ToShortDateString() + "\t" + m.ToShortDateString());
                        foreach (var nja in AppData.Ds.Zaposlenja)
                        {
                            if (nja.DatumZaposlenOd <= dt &&
                                (nja.IsDatumZaposlenDoNull() || dt <= nja.DatumZaposlenDo) &&
                                nja.Valid_NijeNeaktBezDatumDo && nja.Valid_NijeTehGreska)
                            {
                                //Console.WriteLine(nja);
                                count++;
                                zaps.Add(nja.ZaposleniRow.IdZaposlenog);
                            }
                        }
                    }
                    Console.WriteLine(m.Year + "-" + m.Month.ToString("00") + "\t" + zaps.Count);
                    //if (m.Month == 5 && m.Year == 2024)
                    //{
                    //    foreach (var zap in AppData.Ds.Zaposleni.Where(it => zaps.Contains(it.IdZaposlenog)))
                    //        Console.WriteLine(zap.ToStringLat());
                    //}
                }

                //* Greške u zaposlenjima: ne bi smelo za je zaposlenje neaktivno a bez krajnjeg datuma
                //var dt = DateTime.Today;
                //foreach (var nja in AppData.Ds.Zaposlenja)
                //    if (nja.DatumZaposlenOd <= dt && nja.IsDatumZaposlenDoNull() && !nja.Aktivan)
                //        Console.WriteLine(nja);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
