
namespace JISP.Forms
{
    partial class FrmSrednjoskolci
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
            this.ds1 = new JISP.Data.Ds();
            this.bsSrednjoskolci = new System.Windows.Forms.BindingSource(this.components);
            this.dgv = new JISP.Controls.UcDGV();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regUceLiceSrednjeObrazovanjeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skolskaGodinaUpisaNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumUpisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeProgramaObrazovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcOdeljenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelRealizacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipUpisaNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smerObrazovniProfilNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft = new JISP.Controls.UcLeftPanel();
            this.btnGetAdditionalData = new System.Windows.Forms.Button();
            this.btnCountUniqueValues = new System.Windows.Forms.Button();
            this.btnExitApp = new JISP.Controls.UcExitApp();
            this.btnGetBasicData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSrednjoskolci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // ds1
            // 
            this.ds1.DataSetName = "Ds";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsSrednjoskolci
            // 
            this.bsSrednjoskolci.DataMember = "Srednjoskolci";
            this.bsSrednjoskolci.DataSource = this.ds1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.jOBDataGridViewTextBoxColumn,
            this.regUceLiceSrednjeObrazovanjeIdDataGridViewTextBoxColumn,
            this.skolskaGodinaUpisaNazivDataGridViewTextBoxColumn,
            this.datumUpisaDataGridViewTextBoxColumn,
            this.trajanjeProgramaObrazovanjaDataGridViewTextBoxColumn,
            this.razredDataGridViewTextBoxColumn,
            this.dgvcOdeljenje,
            this.modelRealizacijeDataGridViewTextBoxColumn,
            this.tipUpisaNazivDataGridViewTextBoxColumn,
            this.smerObrazovniProfilNazivDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsSrednjoskolci;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(150, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.Size = new System.Drawing.Size(834, 411);
            this.dgv.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBDataGridViewTextBoxColumn
            // 
            this.jOBDataGridViewTextBoxColumn.DataPropertyName = "JOB";
            this.jOBDataGridViewTextBoxColumn.HeaderText = "JOB";
            this.jOBDataGridViewTextBoxColumn.Name = "jOBDataGridViewTextBoxColumn";
            this.jOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regUceLiceSrednjeObrazovanjeIdDataGridViewTextBoxColumn
            // 
            this.regUceLiceSrednjeObrazovanjeIdDataGridViewTextBoxColumn.DataPropertyName = "RegUceLiceSrednjeObrazovanjeId";
            this.regUceLiceSrednjeObrazovanjeIdDataGridViewTextBoxColumn.HeaderText = "RegUceLiceSrednjeObrazovanjeId";
            this.regUceLiceSrednjeObrazovanjeIdDataGridViewTextBoxColumn.Name = "regUceLiceSrednjeObrazovanjeIdDataGridViewTextBoxColumn";
            this.regUceLiceSrednjeObrazovanjeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skolskaGodinaUpisaNazivDataGridViewTextBoxColumn
            // 
            this.skolskaGodinaUpisaNazivDataGridViewTextBoxColumn.DataPropertyName = "SkolskaGodinaUpisaNaziv";
            this.skolskaGodinaUpisaNazivDataGridViewTextBoxColumn.HeaderText = "SkolskaGodinaUpisaNaziv";
            this.skolskaGodinaUpisaNazivDataGridViewTextBoxColumn.Name = "skolskaGodinaUpisaNazivDataGridViewTextBoxColumn";
            this.skolskaGodinaUpisaNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumUpisaDataGridViewTextBoxColumn
            // 
            this.datumUpisaDataGridViewTextBoxColumn.DataPropertyName = "DatumUpisa";
            this.datumUpisaDataGridViewTextBoxColumn.HeaderText = "DatumUpisa";
            this.datumUpisaDataGridViewTextBoxColumn.Name = "datumUpisaDataGridViewTextBoxColumn";
            this.datumUpisaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trajanjeProgramaObrazovanjaDataGridViewTextBoxColumn
            // 
            this.trajanjeProgramaObrazovanjaDataGridViewTextBoxColumn.DataPropertyName = "TrajanjeProgramaObrazovanja";
            this.trajanjeProgramaObrazovanjaDataGridViewTextBoxColumn.HeaderText = "TrajanjeProgramaObrazovanja";
            this.trajanjeProgramaObrazovanjaDataGridViewTextBoxColumn.Name = "trajanjeProgramaObrazovanjaDataGridViewTextBoxColumn";
            this.trajanjeProgramaObrazovanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razredDataGridViewTextBoxColumn
            // 
            this.razredDataGridViewTextBoxColumn.DataPropertyName = "Razred";
            this.razredDataGridViewTextBoxColumn.HeaderText = "Razred";
            this.razredDataGridViewTextBoxColumn.Name = "razredDataGridViewTextBoxColumn";
            this.razredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvcOdeljenje
            // 
            this.dgvcOdeljenje.DataPropertyName = "Odeljenje";
            this.dgvcOdeljenje.HeaderText = "Odeljenje";
            this.dgvcOdeljenje.Name = "dgvcOdeljenje";
            this.dgvcOdeljenje.ReadOnly = true;
            // 
            // modelRealizacijeDataGridViewTextBoxColumn
            // 
            this.modelRealizacijeDataGridViewTextBoxColumn.DataPropertyName = "ModelRealizacije";
            this.modelRealizacijeDataGridViewTextBoxColumn.HeaderText = "ModelRealizacije";
            this.modelRealizacijeDataGridViewTextBoxColumn.Name = "modelRealizacijeDataGridViewTextBoxColumn";
            this.modelRealizacijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipUpisaNazivDataGridViewTextBoxColumn
            // 
            this.tipUpisaNazivDataGridViewTextBoxColumn.DataPropertyName = "TipUpisaNaziv";
            this.tipUpisaNazivDataGridViewTextBoxColumn.HeaderText = "TipUpisaNaziv";
            this.tipUpisaNazivDataGridViewTextBoxColumn.Name = "tipUpisaNazivDataGridViewTextBoxColumn";
            this.tipUpisaNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smerObrazovniProfilNazivDataGridViewTextBoxColumn
            // 
            this.smerObrazovniProfilNazivDataGridViewTextBoxColumn.DataPropertyName = "SmerObrazovniProfilNaziv";
            this.smerObrazovniProfilNazivDataGridViewTextBoxColumn.HeaderText = "SmerObrazovniProfilNaziv";
            this.smerObrazovniProfilNazivDataGridViewTextBoxColumn.Name = "smerObrazovniProfilNazivDataGridViewTextBoxColumn";
            this.smerObrazovniProfilNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnGetAdditionalData);
            this.pnlLeft.Controls.Add(this.btnCountUniqueValues);
            this.pnlLeft.Controls.Add(this.btnExitApp);
            this.pnlLeft.Controls.Add(this.btnGetBasicData);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PanelWidthState = JISP.Controls.PanelWidthState.Expanded;
            this.pnlLeft.RightWingWidth = 6;
            this.pnlLeft.Size = new System.Drawing.Size(150, 411);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnGetAdditionalData
            // 
            this.btnGetAdditionalData.Location = new System.Drawing.Point(12, 126);
            this.btnGetAdditionalData.Name = "btnGetAdditionalData";
            this.btnGetAdditionalData.Size = new System.Drawing.Size(122, 34);
            this.btnGetAdditionalData.TabIndex = 4;
            this.btnGetAdditionalData.Text = "Dohvati dodatno";
            this.btnGetAdditionalData.UseVisualStyleBackColor = true;
            this.btnGetAdditionalData.Click += new System.EventHandler(this.BtnGetAdditionalData_Click);
            // 
            // btnCountUniqueValues
            // 
            this.btnCountUniqueValues.Location = new System.Drawing.Point(12, 188);
            this.btnCountUniqueValues.Name = "btnCountUniqueValues";
            this.btnCountUniqueValues.Size = new System.Drawing.Size(122, 34);
            this.btnCountUniqueValues.TabIndex = 3;
            this.btnCountUniqueValues.Text = "Broj razl vrednosti";
            this.btnCountUniqueValues.UseVisualStyleBackColor = true;
            this.btnCountUniqueValues.Click += new System.EventHandler(this.BtnCountUniqueValues_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Red;
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.Location = new System.Drawing.Point(12, 12);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(122, 34);
            this.btnExitApp.TabIndex = 2;
            this.btnExitApp.Text = "Izlaz";
            this.btnExitApp.UseVisualStyleBackColor = false;
            // 
            // btnGetBasicData
            // 
            this.btnGetBasicData.Location = new System.Drawing.Point(12, 86);
            this.btnGetBasicData.Name = "btnGetBasicData";
            this.btnGetBasicData.Size = new System.Drawing.Size(122, 34);
            this.btnGetBasicData.TabIndex = 1;
            this.btnGetBasicData.Text = "Dohvati osnovno";
            this.btnGetBasicData.UseVisualStyleBackColor = true;
            this.btnGetBasicData.Click += new System.EventHandler(this.BtnGetBasicData_Click);
            // 
            // FrmSrednjoskolci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSrednjoskolci";
            this.Text = "Srednjoskolci";
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSrednjoskolci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcLeftPanel pnlLeft;
        private System.Windows.Forms.Button btnGetBasicData;
        private Controls.UcExitApp btnExitApp;
        private System.Windows.Forms.Button btnCountUniqueValues;
        private Controls.UcDGV dgv;
        private System.Windows.Forms.BindingSource bsSrednjoskolci;
        private Data.Ds ds1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regUceLiceSrednjeObrazovanjeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skolskaGodinaUpisaNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumUpisaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeProgramaObrazovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcOdeljenje;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelRealizacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipUpisaNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smerObrazovniProfilNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGetAdditionalData;
    }
}