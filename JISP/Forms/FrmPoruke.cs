using JISP.Classes;
using JISP.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmPoruke : Form
    {
        public FrmPoruke()
        {
            InitializeComponent();
            bsPoruke.DataSource = AppData.Ds;
            this.FormStandardSettings();
        }
    }
}
