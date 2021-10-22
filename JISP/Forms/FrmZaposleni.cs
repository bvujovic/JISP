using JISP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmZaposleni : Form
    {
        public FrmZaposleni()
        {
            InitializeComponent();

            bsZap.DataSource = Data.AppData.Ds;
        }

        private void BtnSaveData_Click(object sender, EventArgs e)
            => Data.AppData.SaveDsData();

        /// <summary>Ucitavanje JSON podataka o zaposlenima iz clipboard-a.</summary>
        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                //                var json = @"
                //[
                //{
                //""id"": 586542,
                //""ime"": ""Александар"",
                //""prezime"": ""Урошевић"",
                //""imeJednogRoditelja"": null,
                //""jmbg"": ""1234567893"",
                //""pol"": null
                //}
                //,
                //{
                //    ime: ""Pera"",
                //    prezime: ""Mitrovic""
                //}
                //]
                //";
                var json = Clipboard.GetText();

                var zaps = Newtonsoft.Json.JsonConvert.DeserializeObject
                    <List<Data.Zaposleni>>(json);
                //var ja = zaps.FirstOrDefault(it => it.Ime == "Бојан");
                //if(ja != null)
                //    MessageBox.Show(ja.ToString());
                //MessageBox.Show(zaps.Count.ToString());

                foreach (var zap in zaps)
                {
                    var red = Data.AppData.Ds.Zaposleni.NewZaposleniRow();
                    red.Ime = zap.Ime;
                    red.Prezime = zap.Prezime;
                    red.JMBG = zap.JMBG;
                    Data.AppData.Ds.Zaposleni.AddZaposleniRow(red);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnLoadData.Text); }
        }
    }
}
