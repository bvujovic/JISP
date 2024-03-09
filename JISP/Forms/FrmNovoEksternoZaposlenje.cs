using JISP.Classes;
using JISP.Data;
using System;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmNovoEksternoZaposlenje : Form
    {
        public FrmNovoEksternoZaposlenje()
        {
            InitializeComponent();
            this.FormStandardSettings();
            try
            {
                bsTipoviPoslodavaca.DataSource = AppData.Ds;
                bsTipoviPoslodavaca.Filter = "IdTipaPosl <> " +
                    Ds.TipoviPoslodavacaDataTable.SvetiSava.IdTipaPosl;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        public double Procenat { get { return (double)numProcenat.Value; } }
        public DateTime DatumOd { get { return dtpDatumOd.Value; } }
        public DateTime DatumDo { get { return dtpDatumDo.Value; } }
        public string Staz { get { return txtStaz.Text; } }
        public int IdTipaPoslodavca { get { return (int)cmbTipPoslodavca.SelectedValue; } }
        public string NazivPoslodavca { get { return txtNazivPoslodavca.Text; } }
        public string Napomene { get { return txtNapomene.Text; } }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (DatumDo < DatumOd)
                {
                    dtpDatumDo.Focus();
                    new Exception("Početak zaposlenja mora doći pre kraja zaposlenja.");
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void DtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtStaz.Text = Classes.Staz.Razlika(dtpDatumOd.Value, dtpDatumDo.Value).ToString();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Računanje staža"); }
        }
    }
}
