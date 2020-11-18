namespace Udvidet_Kørselesprogram
{
    partial class Form4
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
            this.RedigerStamData = new System.Windows.Forms.Label();
            this.NrPladeLabel = new System.Windows.Forms.Label();
            this.NavnLabel = new System.Windows.Forms.Label();
            this.DatoLabel = new System.Windows.Forms.Label();
            this.RedgierNrPlade = new System.Windows.Forms.TextBox();
            this.RedigerDato = new System.Windows.Forms.TextBox();
            this.RedigerCancel = new System.Windows.Forms.Button();
            this.RedigerOK = new System.Windows.Forms.Button();
            this.RedigerNavn = new System.Windows.Forms.ComboBox();
            this.togTUdividetDataSet = new Udvidet_Kørselesprogram.TogTUdividetDataSet();
            this.brugerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataTableAdapter = new Udvidet_Kørselesprogram.TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RedigerStamData
            // 
            this.RedigerStamData.AutoSize = true;
            this.RedigerStamData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedigerStamData.Location = new System.Drawing.Point(293, 128);
            this.RedigerStamData.Name = "RedigerStamData";
            this.RedigerStamData.Size = new System.Drawing.Size(248, 31);
            this.RedigerStamData.TabIndex = 17;
            this.RedigerStamData.Text = "Rediger Stamdata";
            // 
            // NrPladeLabel
            // 
            this.NrPladeLabel.AutoSize = true;
            this.NrPladeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrPladeLabel.Location = new System.Drawing.Point(296, 238);
            this.NrPladeLabel.Name = "NrPladeLabel";
            this.NrPladeLabel.Size = new System.Drawing.Size(64, 13);
            this.NrPladeLabel.TabIndex = 16;
            this.NrPladeLabel.Text = "Nr. Plade:";
            // 
            // NavnLabel
            // 
            this.NavnLabel.AutoSize = true;
            this.NavnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavnLabel.Location = new System.Drawing.Point(296, 212);
            this.NavnLabel.Name = "NavnLabel";
            this.NavnLabel.Size = new System.Drawing.Size(41, 13);
            this.NavnLabel.TabIndex = 15;
            this.NavnLabel.Text = "Navn:";
            // 
            // DatoLabel
            // 
            this.DatoLabel.AutoSize = true;
            this.DatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatoLabel.Location = new System.Drawing.Point(299, 186);
            this.DatoLabel.Name = "DatoLabel";
            this.DatoLabel.Size = new System.Drawing.Size(38, 13);
            this.DatoLabel.TabIndex = 14;
            this.DatoLabel.Text = "Dato:";
            // 
            // RedgierNrPlade
            // 
            this.RedgierNrPlade.Location = new System.Drawing.Point(405, 235);
            this.RedgierNrPlade.Name = "RedgierNrPlade";
            this.RedgierNrPlade.Size = new System.Drawing.Size(136, 20);
            this.RedgierNrPlade.TabIndex = 12;
            // 
            // RedigerDato
            // 
            this.RedigerDato.Enabled = false;
            this.RedigerDato.Location = new System.Drawing.Point(405, 183);
            this.RedigerDato.Name = "RedigerDato";
            this.RedigerDato.Size = new System.Drawing.Size(136, 20);
            this.RedigerDato.TabIndex = 11;
            // 
            // RedigerCancel
            // 
            this.RedigerCancel.Location = new System.Drawing.Point(299, 277);
            this.RedigerCancel.Name = "RedigerCancel";
            this.RedigerCancel.Size = new System.Drawing.Size(100, 23);
            this.RedigerCancel.TabIndex = 10;
            this.RedigerCancel.Text = "Cancel";
            this.RedigerCancel.UseVisualStyleBackColor = true;
            // 
            // RedigerOK
            // 
            this.RedigerOK.Location = new System.Drawing.Point(420, 277);
            this.RedigerOK.Name = "RedigerOK";
            this.RedigerOK.Size = new System.Drawing.Size(121, 23);
            this.RedigerOK.TabIndex = 9;
            this.RedigerOK.Text = "Ok";
            this.RedigerOK.UseVisualStyleBackColor = true;
            this.RedigerOK.Click += new System.EventHandler(this.RedigerOK_Click);
            // 
            // RedigerNavn
            // 
            this.RedigerNavn.DataSource = this.brugerDataBindingSource;
            this.RedigerNavn.DisplayMember = "BrugerNavn";
            this.RedigerNavn.FormattingEnabled = true;
            this.RedigerNavn.Location = new System.Drawing.Point(405, 209);
            this.RedigerNavn.Name = "RedigerNavn";
            this.RedigerNavn.Size = new System.Drawing.Size(136, 21);
            this.RedigerNavn.TabIndex = 18;
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RedigerNavn);
            this.Controls.Add(this.RedigerStamData);
            this.Controls.Add(this.NrPladeLabel);
            this.Controls.Add(this.NavnLabel);
            this.Controls.Add(this.DatoLabel);
            this.Controls.Add(this.RedgierNrPlade);
            this.Controls.Add(this.RedigerDato);
            this.Controls.Add(this.RedigerCancel);
            this.Controls.Add(this.RedigerOK);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RedigerStamData;
        private System.Windows.Forms.Label NrPladeLabel;
        private System.Windows.Forms.Label NavnLabel;
        private System.Windows.Forms.Label DatoLabel;
        private System.Windows.Forms.TextBox RedgierNrPlade;
        private System.Windows.Forms.TextBox RedigerDato;
        private System.Windows.Forms.Button RedigerCancel;
        private System.Windows.Forms.Button RedigerOK;
        private System.Windows.Forms.ComboBox RedigerNavn;
        private TogTUdividetDataSet togTUdividetDataSet;
        private System.Windows.Forms.BindingSource brugerDataBindingSource;
        private TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter brugerDataTableAdapter;
    }
}