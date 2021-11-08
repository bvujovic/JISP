using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                //var json = await WebApi.GetJson(WebApi.ReqEnum.Uc_DuosSrednjoskolci);
                //var ucenici = Newtonsoft.Json.JsonConvert.DeserializeObject
                //    <List<Srednjoskolac>>(json);
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
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, btnGetBasicData.Text); }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                //broj razlicitih vrednosti u koloni
                var colIdx = 0;
                var vc = dgv.ValuesCount(colIdx);
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, btnTest.Text); }
        }

        private async void BtnGetAdditionalData_Click(object sender, EventArgs e)
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
    }
}
