using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmSistematizacija : Form
    {
        public FrmSistematizacija()
        {
            InitializeComponent();
            bsSistematizacija.DataSource = AppData.Ds;
        }

        private void FrmSistematizacija_Load(object sender, EventArgs e)
        {
            btnOsveziPodatke.PerformClick();

            dgvSistematizacija.TsmiSelekcija(false);
            dgvSistematizacija.ColumnsForCopyOnClick = new int[] { radnoMestoDgvc.Index, predmetDgvc.Index };
            dgvSistematizacija.CopyOnCellClick = true;
            dgvDetalji.ColumnsForCopyOnClick = new int[] { zaposleniDgvc.Index, tipUgovoraDgvc.Index };
            dgvDetalji.CopyOnCellClick = true;
        }

        private async void BtnOsveziPodatke_Click(object sender, EventArgs e)
        {
            await (sender as Controls.UcButton).RunAsync(async () =>
            {
                await DataGetter.GetSistematizacijaAsync();
            });
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var s = txtFilter.Text;
                bsSistematizacija.Filter = $"RadnoMesto LIKE '%{s}%' OR Predmet LIKE '%{s}%'";
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void DgvSistematizacija_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // bojenje redova kod kojih se razlikuju ukupne norme
            var idxSistemat = ukupnaNormaPoSistematizacijiDgvc.Index;
            var idxPoRM = ukupnaNormaPoRMOsimZamenaDgvc.Index;
            foreach (DataGridViewRow row in dgvSistematizacija.Rows)
            {
                if ((double)row.Cells[idxSistemat].Value != (double)row.Cells[idxPoRM].Value)
                    row.DefaultCellStyle.ForeColor = Color.Red;
                else
                    row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private async void DgvSistematizacija_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 &&
                    (e.ColumnIndex == radnoMestoDgvc.Index || e.ColumnIndex == predmetDgvc.Index))
                {
                    await DataGetter.GetSistematizacijaDetaljiAsync
                        (dgvSistematizacija.CurrDataRow<Ds.SistematizacijaRow>());
                    bsDetalji.MoveLast();
                    bsDetalji.MoveFirst();
                }
                else
                {
                    var sis = dgvSistematizacija.CurrDataRow<Ds.SistematizacijaRow>();
                    var frm = new FrmSistematizacijaSacuvajNormu
                        (sis.UkupnaNormaPoSistematizaciji, sis.UkupnaNormaPoRMOsimZamena);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (AppData.Ds.IzvoriFinansiranja.Count == 0)
                            await DataGetter.GetIzvoriFinansiranjaAsync();
                        var izvorFin = AppData.Ds.IzvoriFinansiranja.FirstOrDefault
                            (it => it.Naziv == sis.IzvorFinansiranja);
                        if (izvorFin != null)
                        {
                            var body = $"{{\"regUstUstanovaSistematizacijaId\":{sis.RegUstSisId},\"radnoMestoId\":{sis.RadnoMestoId},\"predmetId\":{NZ(sis.PredmetId)},\"predmetPodnivoId\":{NZ(sis.PodnivoPredmetaId)},\"jezikNastaveId\":{NZ(sis.JezikNastaveId)},\"izvorFinansiranjaId\":{izvorFin.IdIzvoraFin},\"ukupnaNormaPoSistematizaciji\":{frm.UkupnaNormaPoSistem},\"skolskaGodina\":{sis.SkolskaGodinaId},\"id\":{sis.IdSistematizacije},\"rucniUnosSistematizacije\":{sis.RucniUnos.ToString().ToLower()},\"ukupnaNormaPoRMOsimZamena\":{sis.UkupnaNormaPoRMOsimZamena}}}";
                            await WebApi.PostForJson(WebApi.ReqEnum.Zap_SistematizacijaSacuvajNormu, body);
                            btnOsveziPodatke.PerformClick();
                        }
                        else
                            Utils.ShowMbox($"Izvor finansiranja '{sis.IzvorFinansiranja}' nije pronađen u odgovarajućoj tabeli.", Text);
                    }
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private static string NZ(int x)
            => x == 0 ? "null" : x.ToString();
    }
}
