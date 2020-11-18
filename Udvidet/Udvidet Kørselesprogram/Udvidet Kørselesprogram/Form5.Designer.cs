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
            this.StamData = new System.Windows.Forms.Label();
            this.NrPladeLabel = new System.Windows.Forms.Label();
            this.NavnLabel = new System.Windows.Forms.Label();
            this.DatoLabel = new System.Windows.Forms.Label();
            this.Opgave_Formål = new System.Windows.Forms.TextBox();
            this.KørteKM = new System.Windows.Forms.TextBox();
            this.DatoForKørsel = new System.Windows.Forms.TextBox();
            this.KørselsCancel = new System.Windows.Forms.Button();
            this.KørselsOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StamData
            // 
            this.StamData.AutoSize = true;
            this.StamData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StamData.Location = new System.Drawing.Point(296, 126);
            this.StamData.Name = "StamData";
            this.StamData.Size = new System.Drawing.Size(177, 31);
            this.StamData.TabIndex = 17;
            this.StamData.Text = "Kørsels Log:";
            // 
            // NrPladeLabel
            // 
            this.NrPladeLabel.AutoSize = true;
            this.NrPladeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrPladeLabel.Location = new System.Drawing.Point(296, 238);
            this.NrPladeLabel.Name = "NrPladeLabel";
            this.NrPladeLabel.Size = new System.Drawing.Size(61, 13);
            this.NrPladeLabel.TabIndex = 16;
            this.NrPladeLabel.Text = "Kørte km:";
            // 
            // NavnLabel
            // 
            this.NavnLabel.AutoSize = true;
            this.NavnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavnLabel.Location = new System.Drawing.Point(296, 212);
            this.NavnLabel.Name = "NavnLabel";
            this.NavnLabel.Size = new System.Drawing.Size(98, 13);
            this.NavnLabel.TabIndex = 15;
            this.NavnLabel.Text = "Opgave/Formål:";
            // 
            // DatoLabel
            // 
            this.DatoLabel.AutoSize = true;
            this.DatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatoLabel.Location = new System.Drawing.Point(299, 186);
            this.DatoLabel.Name = "DatoLabel";
            this.DatoLabel.Size = new System.Drawing.Size(95, 13);
            this.DatoLabel.TabIndex = 14;
            this.DatoLabel.Text = "Dato for kørsel:";
            // 
            // Opgave_Formål
            // 
            this.Opgave_Formål.Location = new System.Drawing.Point(405, 209);
            this.Opgave_Formål.Name = "Opgave_Formål";
            this.Opgave_Formål.Size = new System.Drawing.Size(100, 20);
            this.Opgave_Formål.TabIndex = 13;
            // 
            // KørteKM
            // 
            this.KørteKM.Location = new System.Drawing.Point(405, 235);
            this.KørteKM.Name = "KørteKM";
            this.KørteKM.Size = new System.Drawing.Size(100, 20);
            this.KørteKM.TabIndex = 12;
            // 
            // DatoForKørsel
            // 
            this.DatoForKørsel.Enabled = false;
            this.DatoForKørsel.Location = new System.Drawing.Point(405, 183);
            this.DatoForKørsel.Name = "DatoForKørsel";
            this.DatoForKørsel.Size = new System.Drawing.Size(100, 20);
            this.DatoForKørsel.TabIndex = 11;
            // 
            // KørselsCancel
            // 
            this.KørselsCancel.Location = new System.Drawing.Point(299, 277);
            this.KørselsCancel.Name = "KørselsCancel";
            this.KørselsCancel.Size = new System.Drawing.Size(100, 23);
            this.KørselsCancel.TabIndex = 10;
            this.KørselsCancel.Text = "Cancel";
            this.KørselsCancel.UseVisualStyleBackColor = true;
            // 
            // KørselsOK
            // 
            this.KørselsOK.Location = new System.Drawing.Point(405, 277);
            this.KørselsOK.Name = "KørselsOK";
            this.KørselsOK.Size = new System.Drawing.Size(100, 23);
            this.KørselsOK.TabIndex = 9;
            this.KørselsOK.Text = "Ok";
            this.KørselsOK.UseVisualStyleBackColor = true;
            this.KørselsOK.Click += new System.EventHandler(this.KørselsOK_Click);
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
    }
}