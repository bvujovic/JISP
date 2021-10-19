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
    }
}
