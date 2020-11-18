namespace Udvidet_Kørselesprogram
{
    partial class Form3
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
            this.SletOK = new System.Windows.Forms.Button();
            this.SletCancel = new System.Windows.Forms.Button();
            this.NavnLabel = new System.Windows.Forms.Label();
            this.SletBruger = new System.Windows.Forms.Label();
            this.SletKnap = new System.Windows.Forms.ComboBox();
            this.togTUdividetDataSet = new Udvidet_Kørselesprogram.TogTUdividetDataSet();
            this.brugerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugerDataTableAdapter = new Udvidet_Kørselesprogram.TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SletOK
            // 
            this.SletOK.Location = new System.Drawing.Point(406, 175);
            this.SletOK.Name = "SletOK";
            this.SletOK.Size = new System.Drawing.Size(103, 23);
            this.SletOK.TabIndex = 0;
            this.SletOK.Text = "Ok";
            this.SletOK.UseVisualStyleBackColor = true;
            this.SletOK.Click += new System.EventHandler(this.SletOK_Click);
            // 
            // SletCancel
            // 
            this.SletCancel.Location = new System.Drawing.Point(297, 175);
            this.SletCancel.Name = "SletCancel";
            this.SletCancel.Size = new System.Drawing.Size(103, 23);
            this.SletCancel.TabIndex = 1;
            this.SletCancel.Text = "Cancel";
            this.SletCancel.UseVisualStyleBackColor = true;
            this.SletCancel.Click += new System.EventHandler(this.SletCancel_Click);
            // 
            // NavnLabel
            // 
            this.NavnLabel.AutoSize = true;
            this.NavnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavnLabel.Location = new System.Drawing.Point(294, 133);
            this.NavnLabel.Name = "NavnLabel";
            this.NavnLabel.Size = new System.Drawing.Size(41, 13);
            this.NavnLabel.TabIndex = 2;
            this.NavnLabel.Text = "Navn:";
            // 
            // SletBruger
            // 
            this.SletBruger.AutoSize = true;
            this.SletBruger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SletBruger.Location = new System.Drawing.Point(321, 90);
            this.SletBruger.Name = "SletBruger";
            this.SletBruger.Size = new System.Drawing.Size(160, 31);
            this.SletBruger.TabIndex = 3;
            this.SletBruger.Text = "Slet Bruger";
            // 
            // SletKnap
            // 
            this.SletKnap.DataSource = this.brugerDataBindingSource;
            this.SletKnap.DisplayMember = "BrugerNavn";
            this.SletKnap.FormattingEnabled = true;
            this.SletKnap.Location = new System.Drawing.Point(388, 133);
            this.SletKnap.Name = "SletKnap";
            this.SletKnap.Size = new System.Drawing.Size(121, 21);
            this.SletKnap.TabIndex = 4;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SletKnap);
            this.Controls.Add(this.SletBruger);
            this.Controls.Add(this.NavnLabel);
            this.Controls.Add(this.SletCancel);
            this.Controls.Add(this.SletOK);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.togTUdividetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugerDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SletOK;
        private System.Windows.Forms.Button SletCancel;
        private System.Windows.Forms.Label NavnLabel;
        private System.Windows.Forms.Label SletBruger;
        private System.Windows.Forms.ComboBox SletKnap;
        private TogTUdividetDataSet togTUdividetDataSet;
        private System.Windows.Forms.BindingSource brugerDataBindingSource;
        private TogTUdividetDataSetTableAdapters.BrugerDataTableAdapter brugerDataTableAdapter;
    }
}