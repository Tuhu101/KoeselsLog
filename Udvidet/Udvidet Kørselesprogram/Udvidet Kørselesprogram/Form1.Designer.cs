namespace Udvidet_Kørselesprogram
{
    partial class Form1
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
            this.PersonListe = new System.Windows.Forms.DataGridView();
            this.brugerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brugerNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKmDrivenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLET = new System.Windows.Forms.DataGridViewButtonColumn();
            this.REDIGER = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NYLOG = new System.Windows.Forms.DataGridViewButtonColumn();
            this.brugerDataBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.togTUdividetDataSet1 = new Udvidet_Kørselesprogram.TogTUdividetDataSet1();
            this.brugerDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.togTUdividetDataSet = new Udvidet_Kørselesprogram.TogTUdividetDataSet();
            this.LogOversigtForBruger = new System.Windows.Forms.DataGridView();
            this.brugerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opgaveFormålDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmKørtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyKørselslogBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.nyKørselslogBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.togTUdividetDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NyBruger = new System.Windows.Forms.Button();
            this.togTUdividetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataTableAdapter = new Udvidet_Kørselesprogram.TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter();
            this.brugerDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nyKørselslogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nyKørselslogTableAdapter = new Udvidet_Kørselesprogram.TogTUdividetDataSetTableAdapters.NyKørselslogTableAdapter();
            this.nyKørselslogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nyKørselslogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataTableAdapter1 = new Udvidet_Kørselesprogram.TogTUdividetDataSet1TableAdapters.BrugerDataTableAdapter();
            this.nyKørselslogTableAdapter1 = new Udvidet_Kørselesprogram.TogTUdividetDataSet1TableAdapters.NyKørselslogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOversigtForBruger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonListe
            // 
            this.PersonListe.AllowUserToAddRows = false;
            this.PersonListe.AllowUserToDeleteRows = false;
            this.PersonListe.AllowUserToResizeColumns = false;
            this.PersonListe.AllowUserToResizeRows = false;
            this.PersonListe.AutoGenerateColumns = false;
            this.PersonListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brugerIDDataGridViewTextBoxColumn,
            this.brugerNavnDataGridViewTextBoxColumn,
            this.datoDataGridViewTextBoxColumn,
            this.nrPladeDataGridViewTextBoxColumn,
            this.totalKmDrivenDataGridViewTextBoxColumn,
            this.SLET,
            this.REDIGER,
            this.NYLOG});
            this.PersonListe.DataSource = this.brugerDataBindingSource4;
            this.PersonListe.Location = new System.Drawing.Point(12, 74);
            this.PersonListe.Name = "PersonListe";
            this.PersonListe.ReadOnly = true;
            this.PersonListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonListe.Size = new System.Drawing.Size(745, 298);
            this.PersonListe.TabIndex = 0;
            this.PersonListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonListe_CellContentClick);
            this.PersonListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonListe_CellDoubleClick_1);
            // 
            // brugerIDDataGridViewTextBoxColumn
            // 
            this.brugerIDDataGridViewTextBoxColumn.DataPropertyName = "BrugerID";
            this.brugerIDDataGridViewTextBoxColumn.HeaderText = "BrugerID";
            this.brugerIDDataGridViewTextBoxColumn.Name = "brugerIDDataGridViewTextBoxColumn";
            this.brugerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.brugerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // brugerNavnDataGridViewTextBoxColumn
            // 
            this.brugerNavnDataGridViewTextBoxColumn.DataPropertyName = "BrugerNavn";
            this.brugerNavnDataGridViewTextBoxColumn.HeaderText = "BrugerNavn";
            this.brugerNavnDataGridViewTextBoxColumn.Name = "brugerNavnDataGridViewTextBoxColumn";
            this.brugerNavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datoDataGridViewTextBoxColumn
            // 
            this.datoDataGridViewTextBoxColumn.DataPropertyName = "Dato";
            this.datoDataGridViewTextBoxColumn.HeaderText = "Dato";
            this.datoDataGridViewTextBoxColumn.Name = "datoDataGridViewTextBoxColumn";
            this.datoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrPladeDataGridViewTextBoxColumn
            // 
            this.nrPladeDataGridViewTextBoxColumn.DataPropertyName = "NrPlade";
            this.nrPladeDataGridViewTextBoxColumn.HeaderText = "NrPlade";
            this.nrPladeDataGridViewTextBoxColumn.Name = "nrPladeDataGridViewTextBoxColumn";
            this.nrPladeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalKmDrivenDataGridViewTextBoxColumn
            // 
            this.totalKmDrivenDataGridViewTextBoxColumn.DataPropertyName = "TotalKmDriven";
            this.totalKmDrivenDataGridViewTextBoxColumn.HeaderText = "TotalKmDriven";
            this.totalKmDrivenDataGridViewTextBoxColumn.Name = "totalKmDrivenDataGridViewTextBoxColumn";
            this.totalKmDrivenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SLET
            // 
            this.SLET.HeaderText = "Slet:";
            this.SLET.Name = "SLET";
            this.SLET.ReadOnly = true;
            this.SLET.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SLET.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SLET.Text = "Slet";
            this.SLET.UseColumnTextForButtonValue = true;
            // 
            // REDIGER
            // 
            this.REDIGER.HeaderText = "Rediger:";
            this.REDIGER.Name = "REDIGER";
            this.REDIGER.ReadOnly = true;
            this.REDIGER.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.REDIGER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.REDIGER.Text = "Rediger";
            this.REDIGER.UseColumnTextForButtonValue = true;
            // 
            // NYLOG
            // 
            this.NYLOG.HeaderText = "Ny Log:";
            this.NYLOG.Name = "NYLOG";
            this.NYLOG.ReadOnly = true;
            this.NYLOG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NYLOG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NYLOG.Text = "Ny Log";
            this.NYLOG.UseColumnTextForButtonValue = true;
            // 
            // brugerDataBindingSource4
            // 
            this.brugerDataBindingSource4.DataMember = "BrugerData";
            this.brugerDataBindingSource4.DataSource = this.togTUdividetDataSet1;
            // 
            // togTUdividetDataSet1
            // 
            this.togTUdividetDataSet1.DataSetName = "TogTUdividetDataSet1";
            this.togTUdividetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brugerDataBindingSource2
            // 
            this.brugerDataBindingSource2.DataMember = "BrugerData";
            this.brugerDataBindingSource2.DataSource = this.togTUdividetDataSet;
            // 
            // togTUdividetDataSet
            // 
            this.togTUdividetDataSet.DataSetName = "TogTUdividetDataSet";
            this.togTUdividetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LogOversigtForBruger
            // 
            this.LogOversigtForBruger.AllowUserToAddRows = false;
            this.LogOversigtForBruger.AllowUserToDeleteRows = false;
            this.LogOversigtForBruger.AllowUserToResizeColumns = false;
            this.LogOversigtForBruger.AllowUserToResizeRows = false;
            this.LogOversigtForBruger.AutoGenerateColumns = false;
            this.LogOversigtForBruger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogOversigtForBruger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brugerIDDataGridViewTextBoxColumn1,
            this.datoDataGridViewTextBoxColumn1,
            this.opgaveFormålDataGridViewTextBoxColumn,
            this.kmKørtDataGridViewTextBoxColumn});
            this.LogOversigtForBruger.DataSource = this.nyKørselslogBindingSource4;
            this.LogOversigtForBruger.Location = new System.Drawing.Point(838, 74);
            this.LogOversigtForBruger.Name = "LogOversigtForBruger";
            this.LogOversigtForBruger.ReadOnly = true;
            this.LogOversigtForBruger.Size = new System.Drawing.Size(437, 298);
            this.LogOversigtForBruger.TabIndex = 1;
            // 
            // brugerIDDataGridViewTextBoxColumn1
            // 
            this.brugerIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brugerIDDataGridViewTextBoxColumn1.DataPropertyName = "BrugerID";
            this.brugerIDDataGridViewTextBoxColumn1.HeaderText = "BrugerID";
            this.brugerIDDataGridViewTextBoxColumn1.Name = "brugerIDDataGridViewTextBoxColumn1";
            this.brugerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.brugerIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // datoDataGridViewTextBoxColumn1
            // 
            this.datoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datoDataGridViewTextBoxColumn1.DataPropertyName = "Dato";
            this.datoDataGridViewTextBoxColumn1.HeaderText = "Dato";
            this.datoDataGridViewTextBoxColumn1.Name = "datoDataGridViewTextBoxColumn1";
            this.datoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // opgaveFormålDataGridViewTextBoxColumn
            // 
            this.opgaveFormålDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opgaveFormålDataGridViewTextBoxColumn.DataPropertyName = "OpgaveFormål";
            this.opgaveFormålDataGridViewTextBoxColumn.HeaderText = "OpgaveFormål";
            this.opgaveFormålDataGridViewTextBoxColumn.Name = "opgaveFormålDataGridViewTextBoxColumn";
            this.opgaveFormålDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kmKørtDataGridViewTextBoxColumn
            // 
            this.kmKørtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kmKørtDataGridViewTextBoxColumn.DataPropertyName = "KmKørt";
            this.kmKørtDataGridViewTextBoxColumn.HeaderText = "KmKørt";
            this.kmKørtDataGridViewTextBoxColumn.Name = "kmKørtDataGridViewTextBoxColumn";
            this.kmKørtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nyKørselslogBindingSource4
            // 
            this.nyKørselslogBindingSource4.DataMember = "NyKørselslog";
            this.nyKørselslogBindingSource4.DataSource = this.togTUdividetDataSet1;
            // 
            // nyKørselslogBindingSource3
            // 
            this.nyKørselslogBindingSource3.DataMember = "NyKørselslog";
            this.nyKørselslogBindingSource3.DataSource = this.togTUdividetDataSetBindingSource1;
            // 
            // togTUdividetDataSetBindingSource1
            // 
            this.togTUdividetDataSetBindingSource1.DataSource = this.togTUdividetDataSet;
            this.togTUdividetDataSetBindingSource1.Position = 0;
            // 
            // NyBruger
            // 
            this.NyBruger.Location = new System.Drawing.Point(64, 404);
            this.NyBruger.Name = "NyBruger";
            this.NyBruger.Size = new System.Drawing.Size(75, 23);
            this.NyBruger.TabIndex = 2;
            this.NyBruger.Text = "Ny Bruger";
            this.NyBruger.UseVisualStyleBackColor = true;
            this.NyBruger.Click += new System.EventHandler(this.NyBruger_Click);
            // 
            // togTUdividetDataSetBindingSource
            // 
            this.togTUdividetDataSetBindingSource.DataSource = this.togTUdividetDataSet;
            this.togTUdividetDataSetBindingSource.Position = 0;
            // 
            // brugerDataBindingSource
            // 
            this.brugerDataBindingSource.DataMember = "BrugerData";
            this.brugerDataBindingSource.DataSource = this.togTUdividetDataSetBindingSource;
            // 
            // brugerDataTableAdapter
            // 
            this.brugerDataTableAdapter.ClearBeforeFill = true;
            // 
            // brugerDataBindingSource1
            // 
            this.brugerDataBindingSource1.DataMember = "BrugerData";
            this.brugerDataBindingSource1.DataSource = this.togTUdividetDataSet;
            // 
            // nyKørselslogBindingSource
            // 
            this.nyKørselslogBindingSource.DataMember = "NyKørselslog";
            this.nyKørselslogBindingSource.DataSource = this.togTUdividetDataSetBindingSource;
            // 
            // nyKørselslogTableAdapter
            // 
            this.nyKørselslogTableAdapter.ClearBeforeFill = true;
            // 
            // nyKørselslogBindingSource1
            // 
            this.nyKørselslogBindingSource1.DataMember = "NyKørselslog";
            this.nyKørselslogBindingSource1.DataSource = this.togTUdividetDataSet;
            // 
            // nyKørselslogBindingSource2
            // 
            this.nyKørselslogBindingSource2.DataMember = "NyKørselslog";
            this.nyKørselslogBindingSource2.DataSource = this.togTUdividetDataSetBindingSource1;
            // 
            // brugerDataBindingSource3
            // 
            this.brugerDataBindingSource3.DataMember = "BrugerData";
            this.brugerDataBindingSource3.DataSource = this.togTUdividetDataSet;
            // 
            // brugerDataTableAdapter1
            // 
            this.brugerDataTableAdapter1.ClearBeforeFill = true;
            // 
            // nyKørselslogTableAdapter1
            // 
            this.nyKørselslogTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 578);
            this.Controls.Add(this.NyBruger);
            this.Controls.Add(this.LogOversigtForBruger);
            this.Controls.Add(this.PersonListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOversigtForBruger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NyBruger;
        public System.Windows.Forms.DataGridView PersonListe;
        private System.Windows.Forms.BindingSource togTUdividetDataSetBindingSource;
        private TogTUdividetDataSet togTUdividetDataSet;
        private System.Windows.Forms.BindingSource brugerDataBindingSource;
        private TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter brugerDataTableAdapter;
        private System.Windows.Forms.BindingSource brugerDataBindingSource2;
        private System.Windows.Forms.BindingSource brugerDataBindingSource1;
        private System.Windows.Forms.BindingSource nyKørselslogBindingSource;
        private TogTUdividetDataSetTableAdapters.NyKørselslogTableAdapter nyKørselslogTableAdapter;
        public System.Windows.Forms.DataGridView LogOversigtForBruger;
        private System.Windows.Forms.BindingSource nyKørselslogBindingSource1;
        private System.Windows.Forms.BindingSource nyKørselslogBindingSource2;
        private System.Windows.Forms.BindingSource togTUdividetDataSetBindingSource1;
        private System.Windows.Forms.BindingSource nyKørselslogBindingSource3;
        private System.Windows.Forms.BindingSource brugerDataBindingSource3;
        private TogTUdividetDataSet1 togTUdividetDataSet1;
        private System.Windows.Forms.BindingSource brugerDataBindingSource4;
        private TogTUdividetDataSet1TableAdapters.BrugerDataTableAdapter brugerDataTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brugerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brugerNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPladeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKmDrivenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SLET;
        private System.Windows.Forms.DataGridViewButtonColumn REDIGER;
        private System.Windows.Forms.DataGridViewButtonColumn NYLOG;
        private System.Windows.Forms.BindingSource nyKørselslogBindingSource4;
        private TogTUdividetDataSet1TableAdapters.NyKørselslogTableAdapter nyKørselslogTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brugerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opgaveFormålDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmKørtDataGridViewTextBoxColumn;
    }
}

