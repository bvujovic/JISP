namespace JISP.Forms
{
    partial class FrmNovoEksternoZaposlenje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.numProcenat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStaz = new System.Windows.Forms.TextBox();
            this.cmbTipPoslodavca = new System.Windows.Forms.ComboBox();
            this.bsTipoviPoslodavaca = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new JISP.Data.Ds();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazivPoslodavca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNapomene = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numProcenat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoviPoslodavaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procenat";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(82, 301);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 33);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // numProcenat
            // 
            this.numProcenat.Location = new System.Drawing.Point(108, 21);
            this.numProcenat.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numProcenat.Name = "numProcenat";
            this.numProcenat.Size = new System.Drawing.Size(55, 24);
            this.numProcenat.TabIndex = 0;
            this.numProcenat.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaposlen od";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumOd.Location = new System.Drawing.Point(108, 51);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(138, 24);
            this.dtpDatumOd.TabIndex = 1;
            this.dtpDatumOd.Value = new System.DateTime(2024, 3, 9, 0, 0, 0, 0);
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.DtpDatumOd_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zaposlen do";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumDo.Location = new System.Drawing.Point(108, 81);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(138, 24);
            this.dtpDatumDo.TabIndex = 2;
            this.dtpDatumDo.Value = new System.DateTime(2024, 3, 9, 0, 0, 0, 0);
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.DtpDatumOd_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Staž";
            // 
            // txtStaz
            // 
            this.txtStaz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStaz.Location = new System.Drawing.Point(108, 111);
            this.txtStaz.Name = "txtStaz";
            this.txtStaz.ReadOnly = true;
            this.txtStaz.Size = new System.Drawing.Size(137, 24);
            this.txtStaz.TabIndex = 3;
            this.txtStaz.TabStop = false;
            // 
            // cmbTipPoslodavca
            // 
            this.cmbTipPoslodavca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipPoslodavca.DataSource = this.bsTipoviPoslodavaca;
            this.cmbTipPoslodavca.DisplayMember = "NazivTipaPosl";
            this.cmbTipPoslodavca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipPoslodavca.FormattingEnabled = true;
            this.cmbTipPoslodavca.Location = new System.Drawing.Point(108, 142);
            this.cmbTipPoslodavca.Name = "cmbTipPoslodavca";
            this.cmbTipPoslodavca.Size = new System.Drawing.Size(137, 26);
            this.cmbTipPoslodavca.TabIndex = 4;
            this.cmbTipPoslodavca.ValueMember = "IdTipaPosl";
            // 
            // bsTipoviPoslodavaca
            // 
            this.bsTipoviPoslodavaca.DataMember = "TipoviPoslodavaca";
            this.bsTipoviPoslodavaca.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tip poslod.";
            // 
            // txtNazivPoslodavca
            // 
            this.txtNazivPoslodavca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNazivPoslodavca.Location = new System.Drawing.Point(108, 175);
            this.txtNazivPoslodavca.Name = "txtNazivPoslodavca";
            this.txtNazivPoslodavca.Size = new System.Drawing.Size(137, 24);
            this.txtNazivPoslodavca.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Naziv posl.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Napomene";
            // 
            // txtNapomene
            // 
            this.txtNapomene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNapomene.Location = new System.Drawing.Point(109, 205);
            this.txtNapomene.Multiline = true;
            this.txtNapomene.Name = "txtNapomene";
            this.txtNapomene.Size = new System.Drawing.Size(137, 73);
            this.txtNapomene.TabIndex = 6;
            // 
            // FrmNovoEksternoZaposlenje
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 354);
            this.Controls.Add(this.txtNapomene);
            this.Controls.Add(this.txtNazivPoslodavca);
            this.Controls.Add(this.cmbTipPoslodavca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStaz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numProcenat);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovoEksternoZaposlenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Eksterno Zaposlenje";
            ((System.ComponentModel.ISupportInitialize)(this.numProcenat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoviPoslodavaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numProcenat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaz;
        private System.Windows.Forms.ComboBox cmbTipPoslodavca;
        private System.Windows.Forms.BindingSource bsTipoviPoslodavaca;
        private Data.Ds ds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazivPoslodavca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNapomene;
    }
}