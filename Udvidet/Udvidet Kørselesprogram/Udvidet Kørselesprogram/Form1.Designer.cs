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
            this.brugerDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.togTUdividetDataSet = new Udvidet_Kørselesprogram.TogTUdividetDataSet();
            this.LogOversigtForBruger = new System.Windows.Forms.DataGridView();
            this.Dato1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opgave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmKørt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NyBruger = new System.Windows.Forms.Button();
            this.SletBruger = new System.Windows.Forms.Button();
            this.RedigerBruger = new System.Windows.Forms.Button();
            this.NyLogBruger = new System.Windows.Forms.Button();
            this.togTUdividetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataTableAdapter = new Udvidet_Kørselesprogram.TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter();
            this.brugerDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.brugerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brugerNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REDIGER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NYLOG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PersonListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOversigtForBruger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonListe
            // 
            this.PersonListe.AllowUserToOrderColumns = true;
            this.PersonListe.AutoGenerateColumns = false;
            this.PersonListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brugerIDDataGridViewTextBoxColumn,
            this.brugerNavnDataGridViewTextBoxColumn,
            this.datoDataGridViewTextBoxColumn,
            this.nrPladeDataGridViewTextBoxColumn,
            this.SLET,
            this.REDIGER,
            this.NYLOG});
            this.PersonListe.DataSource = this.brugerDataBindingSource2;
            this.PersonListe.Enabled = false;
            this.PersonListe.Location = new System.Drawing.Point(64, 74);
            this.PersonListe.Name = "PersonListe";
            this.PersonListe.Size = new System.Drawing.Size(744, 298);
            this.PersonListe.TabIndex = 0;
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
            this.LogOversigtForBruger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogOversigtForBruger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dato1,
            this.Opgave,
            this.KmKørt1});
            this.LogOversigtForBruger.Location = new System.Drawing.Point(846, 74);
            this.LogOversigtForBruger.Name = "LogOversigtForBruger";
            this.LogOversigtForBruger.Size = new System.Drawing.Size(348, 298);
            this.LogOversigtForBruger.TabIndex = 1;
            // 
            // Dato1
            // 
            this.Dato1.HeaderText = "Dato:";
            this.Dato1.Name = "Dato1";
            // 
            // Opgave
            // 
            this.Opgave.HeaderText = "Opgave:";
            this.Opgave.Name = "Opgave";
            // 
            // KmKørt1
            // 
            this.KmKørt1.HeaderText = "Km. Kørt";
            this.KmKørt1.Name = "KmKørt1";
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
            // SletBruger
            // 
            this.SletBruger.Location = new System.Drawing.Point(516, 96);
            this.SletBruger.Name = "SletBruger";
            this.SletBruger.Size = new System.Drawing.Size(75, 21);
            this.SletBruger.TabIndex = 3;
            this.SletBruger.Text = "Slet";
            this.SletBruger.UseVisualStyleBackColor = true;
            this.SletBruger.Click += new System.EventHandler(this.SletBruger_Click);
            // 
            // RedigerBruger
            // 
            this.RedigerBruger.Location = new System.Drawing.Point(621, 96);
            this.RedigerBruger.Name = "RedigerBruger";
            this.RedigerBruger.Size = new System.Drawing.Size(75, 21);
            this.RedigerBruger.TabIndex = 4;
            this.RedigerBruger.Text = "Rediger";
            this.RedigerBruger.UseVisualStyleBackColor = true;
            this.RedigerBruger.Click += new System.EventHandler(this.RedigerBruger_Click);
            // 
            // NyLogBruger
            // 
            this.NyLogBruger.Location = new System.Drawing.Point(721, 96);
            this.NyLogBruger.Name = "NyLogBruger";
            this.NyLogBruger.Size = new System.Drawing.Size(75, 21);
            this.NyLogBruger.TabIndex = 5;
            this.NyLogBruger.Text = "Ny Log";
            this.NyLogBruger.UseVisualStyleBackColor = true;
            this.NyLogBruger.Click += new System.EventHandler(this.NyLogBruger_Click);
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
            // brugerIDDataGridViewTextBoxColumn
            // 
            this.brugerIDDataGridViewTextBoxColumn.DataPropertyName = "BrugerID";
            this.brugerIDDataGridViewTextBoxColumn.HeaderText = "BrugerID";
            this.brugerIDDataGridViewTextBoxColumn.Name = "brugerIDDataGridViewTextBoxColumn";
            this.brugerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brugerNavnDataGridViewTextBoxColumn
            // 
            this.brugerNavnDataGridViewTextBoxColumn.DataPropertyName = "BrugerNavn";
            this.brugerNavnDataGridViewTextBoxColumn.HeaderText = "BrugerNavn";
            this.brugerNavnDataGridViewTextBoxColumn.Name = "brugerNavnDataGridViewTextBoxColumn";
            // 
            // datoDataGridViewTextBoxColumn
            // 
            this.datoDataGridViewTextBoxColumn.DataPropertyName = "Dato";
            this.datoDataGridViewTextBoxColumn.HeaderText = "Dato";
            this.datoDataGridViewTextBoxColumn.Name = "datoDataGridViewTextBoxColumn";
            // 
            // nrPladeDataGridViewTextBoxColumn
            // 
            this.nrPladeDataGridViewTextBoxColumn.DataPropertyName = "NrPlade";
            this.nrPladeDataGridViewTextBoxColumn.HeaderText = "NrPlade";
            this.nrPladeDataGridViewTextBoxColumn.Name = "nrPladeDataGridViewTextBoxColumn";
            // 
            // SLET
            // 
            this.SLET.HeaderText = "Slet:";
            this.SLET.Name = "SLET";
            // 
            // REDIGER
            // 
            this.REDIGER.HeaderText = "Rediger:";
            this.REDIGER.Name = "REDIGER";
            // 
            // NYLOG
            // 
            this.NYLOG.HeaderText = "Ny Log:";
            this.NYLOG.Name = "NYLOG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 578);
            this.Controls.Add(this.NyLogBruger);
            this.Controls.Add(this.RedigerBruger);
            this.Controls.Add(this.SletBruger);
            this.Controls.Add(this.NyBruger);
            this.Controls.Add(this.LogOversigtForBruger);
            this.Controls.Add(this.PersonListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOversigtForBruger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView LogOversigtForBruger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opgave;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmKørt1;
        private System.Windows.Forms.Button NyBruger;
        private System.Windows.Forms.Button SletBruger;
        private System.Windows.Forms.Button RedigerBruger;
        private System.Windows.Forms.Button NyLogBruger;
        public System.Windows.Forms.DataGridView PersonListe;
        private System.Windows.Forms.BindingSource togTUdividetDataSetBindingSource;
        private TogTUdividetDataSet togTUdividetDataSet;
        private System.Windows.Forms.BindingSource brugerDataBindingSource;
        private TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter brugerDataTableAdapter;
        private System.Windows.Forms.BindingSource brugerDataBindingSource2;
        private System.Windows.Forms.BindingSource brugerDataBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brugerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brugerNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPladeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLET;
        private System.Windows.Forms.DataGridViewTextBoxColumn REDIGER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NYLOG;
    }
}

