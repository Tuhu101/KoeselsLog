namespace Udvidet_Kørselesprogram
{
    partial class Form5
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
            this.StamData = new System.Windows.Forms.Label();
            this.NrPladeLabel = new System.Windows.Forms.Label();
            this.NavnLabel = new System.Windows.Forms.Label();
            this.DatoLabel = new System.Windows.Forms.Label();
            this.Opgave_Formål = new System.Windows.Forms.TextBox();
            this.KørteKM = new System.Windows.Forms.TextBox();
            this.DatoForKørsel = new System.Windows.Forms.TextBox();
            this.KørselsCancel = new System.Windows.Forms.Button();
            this.KørselsOK = new System.Windows.Forms.Button();
            this.brugerDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.togTUdividetDataSet = new Udvidet_Kørselesprogram.TogTUdividetDataSet();
            this.brugerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataTableAdapter = new Udvidet_Kørselesprogram.TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter();
            this.nyKørselslogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nyKørselslogTableAdapter = new Udvidet_Kørselesprogram.TogTUdividetDataSetTableAdapters.NyKørselslogTableAdapter();
            this.togTUdividetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // StamData
            // 
            this.StamData.AutoSize = true;
            this.StamData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StamData.Location = new System.Drawing.Point(293, 123);
            this.StamData.Name = "StamData";
            this.StamData.Size = new System.Drawing.Size(177, 31);
            this.StamData.TabIndex = 17;
            this.StamData.Text = "Kørsels Log:";
            // 
            // NrPladeLabel
            // 
            this.NrPladeLabel.AutoSize = true;
            this.NrPladeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrPladeLabel.Location = new System.Drawing.Point(299, 236);
            this.NrPladeLabel.Name = "NrPladeLabel";
            this.NrPladeLabel.Size = new System.Drawing.Size(61, 13);
            this.NrPladeLabel.TabIndex = 16;
            this.NrPladeLabel.Text = "Kørte km:";
            // 
            // NavnLabel
            // 
            this.NavnLabel.AutoSize = true;
            this.NavnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavnLabel.Location = new System.Drawing.Point(299, 210);
            this.NavnLabel.Name = "NavnLabel";
            this.NavnLabel.Size = new System.Drawing.Size(98, 13);
            this.NavnLabel.TabIndex = 15;
            this.NavnLabel.Text = "Opgave/Formål:";
            // 
            // DatoLabel
            // 
            this.DatoLabel.AutoSize = true;
            this.DatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatoLabel.Location = new System.Drawing.Point(299, 184);
            this.DatoLabel.Name = "DatoLabel";
            this.DatoLabel.Size = new System.Drawing.Size(95, 13);
            this.DatoLabel.TabIndex = 14;
            this.DatoLabel.Text = "Dato for kørsel:";
            // 
            // Opgave_Formål
            // 
            this.Opgave_Formål.Location = new System.Drawing.Point(400, 207);
            this.Opgave_Formål.Name = "Opgave_Formål";
            this.Opgave_Formål.Size = new System.Drawing.Size(100, 20);
            this.Opgave_Formål.TabIndex = 1;
            // 
            // KørteKM
            // 
            this.KørteKM.Location = new System.Drawing.Point(400, 233);
            this.KørteKM.Name = "KørteKM";
            this.KørteKM.Size = new System.Drawing.Size(100, 20);
            this.KørteKM.TabIndex = 2;
            // 
            // DatoForKørsel
            // 
            this.DatoForKørsel.Enabled = false;
            this.DatoForKørsel.Location = new System.Drawing.Point(400, 181);
            this.DatoForKørsel.Name = "DatoForKørsel";
            this.DatoForKørsel.Size = new System.Drawing.Size(100, 20);
            this.DatoForKørsel.TabIndex = 0;
            // 
            // KørselsCancel
            // 
            this.KørselsCancel.Location = new System.Drawing.Point(294, 275);
            this.KørselsCancel.Name = "KørselsCancel";
            this.KørselsCancel.Size = new System.Drawing.Size(100, 23);
            this.KørselsCancel.TabIndex = 4;
            this.KørselsCancel.Text = "Cancel";
            this.KørselsCancel.UseVisualStyleBackColor = true;
            // 
            // KørselsOK
            // 
            this.KørselsOK.Location = new System.Drawing.Point(400, 275);
            this.KørselsOK.Name = "KørselsOK";
            this.KørselsOK.Size = new System.Drawing.Size(100, 23);
            this.KørselsOK.TabIndex = 3;
            this.KørselsOK.Text = "Ok";
            this.KørselsOK.UseVisualStyleBackColor = true;
            this.KørselsOK.Click += new System.EventHandler(this.KørselsOK_Click);
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
            // brugerDataBindingSource
            // 
            this.brugerDataBindingSource.DataMember = "BrugerData";
            this.brugerDataBindingSource.DataSource = this.togTUdividetDataSet;
            // 
            // brugerDataTableAdapter
            // 
            this.brugerDataTableAdapter.ClearBeforeFill = true;
            // 
            // nyKørselslogBindingSource
            // 
            this.nyKørselslogBindingSource.DataMember = "NyKørselslog";
            this.nyKørselslogBindingSource.DataSource = this.togTUdividetDataSet;
            // 
            // nyKørselslogTableAdapter
            // 
            this.nyKørselslogTableAdapter.ClearBeforeFill = true;
            // 
            // togTUdividetDataSetBindingSource
            // 
            this.togTUdividetDataSetBindingSource.DataSource = this.togTUdividetDataSet;
            this.togTUdividetDataSetBindingSource.Position = 0;
            // 
            // brugerDataBindingSource1
            // 
            this.brugerDataBindingSource1.DataMember = "BrugerData";
            this.brugerDataBindingSource1.DataSource = this.togTUdividetDataSet;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StamData);
            this.Controls.Add(this.NrPladeLabel);
            this.Controls.Add(this.NavnLabel);
            this.Controls.Add(this.DatoLabel);
            this.Controls.Add(this.Opgave_Formål);
            this.Controls.Add(this.KørteKM);
            this.Controls.Add(this.DatoForKørsel);
            this.Controls.Add(this.KørselsCancel);
            this.Controls.Add(this.KørselsOK);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyKørselslogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StamData;
        private System.Windows.Forms.Label NrPladeLabel;
        private System.Windows.Forms.Label NavnLabel;
        private System.Windows.Forms.Label DatoLabel;
        private System.Windows.Forms.TextBox Opgave_Formål;
        private System.Windows.Forms.TextBox KørteKM;
        private System.Windows.Forms.TextBox DatoForKørsel;
        private System.Windows.Forms.Button KørselsCancel;
        private System.Windows.Forms.Button KørselsOK;
        private TogTUdividetDataSet togTUdividetDataSet;
        private System.Windows.Forms.BindingSource brugerDataBindingSource;
        private TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter brugerDataTableAdapter;
        private System.Windows.Forms.BindingSource nyKørselslogBindingSource;
        private TogTUdividetDataSetTableAdapters.NyKørselslogTableAdapter nyKørselslogTableAdapter;
        private System.Windows.Forms.BindingSource brugerDataBindingSource1;
        private System.Windows.Forms.BindingSource togTUdividetDataSetBindingSource;
        private System.Windows.Forms.BindingSource brugerDataBindingSource2;
    }
}