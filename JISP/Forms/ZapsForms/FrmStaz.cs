﻿using JISP.Classes;
using JISP.Data;
using System;
using System.Windows.Forms;

namespace JISP.Forms.ZapsForms
{
    public partial class FrmStaz : Form
    {
        public FrmStaz()
        {
            InitializeComponent();

            var strDatum = AppData.LoadSett(AppData.DatumIzvestajaTrezora);
            if (!string.IsNullOrEmpty(strDatum))
                DatumIzvestajaTrezora = DateTime.Parse(strDatum);
            this.FormStandardSettings();
        }

        public DateTime DatumIzvestajaTrezora
        {
            get => dtp.Value;
            set => dtp.Value = value;
        }
    }
}
