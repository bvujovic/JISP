using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JISP.Classes;
using JISP.Data;

namespace JISP.Forms
{
    public partial class FrmSrednjoskolci : Form
    {
        public FrmSrednjoskolci()
        {
            InitializeComponent();

            bsSrednjoskolci.DataSource = Ds = AppData.Ds;
        }

        private readonly Ds Ds;

        private async void BtnGetBasicData_Click(object sender, EventArgs e)
        {
            try
            {
                var ucenici = await WebApi.GetList<Srednjoskolac>(WebApi.ReqEnum.Uc_DuosSrednjoskolci);
                Ds.Srednjoskolci.Clear();
                foreach (var u in ucenici)
                {
                    var row = Ds.Srednjoskolci.NewSrednjoskolciRow();
                    row.Id = u.Id;
                    row.RegUceLiceSrednjeObrazovanjeId = u.RegUceLiceSrednjeObrazovanjeId;
                    row.JOB = u.JOB;
                    row.Razred = u.Razred;
                    row.Odeljenje = u.Odeljenje;
                    row.DatumUpisa = u.DatumUpisa;
                    Ds.Srednjoskolci.AddSrednjoskolciRow(row);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnGetBasicData.Text); }
        }

        private void BtnCountUniqueValues_Click(object sender, EventArgs e)
        {
            try
            {
                // broj razlicitih vrednosti u koloni
                var idxCol = dgv.SelectedCells[0].ColumnIndex;
                var vc = dgv.ValuesCount(idxCol);
                var sb = new System.Text.StringBuilder($"Broj razlicitih vrednosti: {vc.Values.Count}\r\n\r\n");
                foreach (var item in vc.OrderBy(it => it.Key))
                    sb.AppendLine(item.Key + "\t" + item.Value);
                Utils.ShowMbox(sb.ToString(), btnCountUniqueValues.Text);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnCountUniqueValues.Text); }
        }

        private async void BtnGetAdditionalData_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    var row = dgv.DataRow<Ds.SrednjoskolciRow>(i);
                    var u = await WebApi.GetObject<Srednjoskolac>
                        (WebApi.ReqEnum.Uc_DuosSrednjoskolciId, row.Id.ToString());
                    row.SkolskaGodinaUpisaNaziv = u.SkolskaGodinaUpisaNaziv;
                    row.ModelRealizacije = u.ModelRealizacije;
                    row.SmerObrazovniProfilNaziv = u.SmerObrazovniProfilNaziv;
                    //System.Threading.Thread.Sleep(500);//? bez ovoga
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnGetAdditionalData.Text); }
        }
    }
}
