namespace Udvidet_Kørselesprogram
{
    partial class Form2
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
            this.OpretOK = new System.Windows.Forms.Button();
            this.OpretCancel = new System.Windows.Forms.Button();
            this.OpretDato = new System.Windows.Forms.TextBox();
            this.OpretNrPlade = new System.Windows.Forms.TextBox();
            this.OpretNavn = new System.Windows.Forms.TextBox();
            this.DatoLabel = new System.Windows.Forms.Label();
            this.NavnLabel = new System.Windows.Forms.Label();
            this.NrPladeLabel = new System.Windows.Forms.Label();
            this.StamData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpretOK
            // 
            this.OpretOK.Location = new System.Drawing.Point(341, 208);
            this.OpretOK.Name = "OpretOK";
            this.OpretOK.Size = new System.Drawing.Size(100, 23);
            this.OpretOK.TabIndex = 3;
            this.OpretOK.Text = "Ok";
            this.OpretOK.UseVisualStyleBackColor = true;
            this.OpretOK.Click += new System.EventHandler(this.OpretOK_Click);
            // 
            // OpretCancel
            // 
            this.OpretCancel.Location = new System.Drawing.Point(235, 208);
            this.OpretCancel.Name = "OpretCancel";
            this.OpretCancel.Size = new System.Drawing.Size(100, 23);
            this.OpretCancel.TabIndex = 4;
            this.OpretCancel.Text = "Cancel";
            this.OpretCancel.UseVisualStyleBackColor = true;
            this.OpretCancel.Click += new System.EventHandler(this.OpretCancel_Click);
            // 
            // OpretDato
            // 
            this.OpretDato.Enabled = false;
            this.OpretDato.Location = new System.Drawing.Point(341, 114);
            this.OpretDato.Name = "OpretDato";
            this.OpretDato.Size = new System.Drawing.Size(100, 20);
            this.OpretDato.TabIndex = 0;
            // 
            // OpretNrPlade
            // 
            this.OpretNrPlade.Location = new System.Drawing.Point(341, 166);
            this.OpretNrPlade.Name = "OpretNrPlade";
            this.OpretNrPlade.Size = new System.Drawing.Size(100, 20);
            this.OpretNrPlade.TabIndex = 2;
            // 
            // OpretNavn
            // 
            this.OpretNavn.Location = new System.Drawing.Point(341, 140);
            this.OpretNavn.Name = "OpretNavn";
            this.OpretNavn.Size = new System.Drawing.Size(100, 20);
            this.OpretNavn.TabIndex = 1;
            // 
            // DatoLabel
            // 
            this.DatoLabel.AutoSize = true;
            this.DatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatoLabel.Location = new System.Drawing.Point(235, 117);
            this.DatoLabel.Name = "DatoLabel";
            this.DatoLabel.Size = new System.Drawing.Size(38, 13);
            this.DatoLabel.TabIndex = 5;
            this.DatoLabel.Text = "Dato:";
            // 
            // NavnLabel
            // 
            this.NavnLabel.AutoSize = true;
            this.NavnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavnLabel.Location = new System.Drawing.Point(232, 143);
            this.NavnLabel.Name = "NavnLabel";
            this.NavnLabel.Size = new System.Drawing.Size(41, 13);
            this.NavnLabel.TabIndex = 6;
            this.NavnLabel.Text = "Navn:";
            // 
            // NrPladeLabel
            // 
            this.NrPladeLabel.AutoSize = true;
            this.NrPladeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrPladeLabel.Location = new System.Drawing.Point(232, 169);
            this.NrPladeLabel.Name = "NrPladeLabel";
            this.NrPladeLabel.Size = new System.Drawing.Size(64, 13);
            this.NrPladeLabel.TabIndex = 7;
            this.NrPladeLabel.Text = "Nr. Plade:";
            // 
            // StamData
            // 
            this.StamData.AutoSize = true;
            this.StamData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StamData.Location = new System.Drawing.Point(232, 70);
            this.StamData.Name = "StamData";
            this.StamData.Size = new System.Drawing.Size(152, 31);
            this.StamData.TabIndex = 8;
            this.StamData.Text = "StamData:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StamData);
            this.Controls.Add(this.NrPladeLabel);
            this.Controls.Add(this.NavnLabel);
            this.Controls.Add(this.DatoLabel);
            this.Controls.Add(this.OpretNavn);
            this.Controls.Add(this.OpretNrPlade);
            this.Controls.Add(this.OpretDato);
            this.Controls.Add(this.OpretCancel);
            this.Controls.Add(this.OpretOK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpretOK;
        private System.Windows.Forms.Button OpretCancel;
        private System.Windows.Forms.TextBox OpretDato;
        private System.Windows.Forms.TextBox OpretNrPlade;
        private System.Windows.Forms.TextBox OpretNavn;
        private System.Windows.Forms.Label DatoLabel;
        private System.Windows.Forms.Label NavnLabel;
        private System.Windows.Forms.Label NrPladeLabel;
        private System.Windows.Forms.Label StamData;
    }
}