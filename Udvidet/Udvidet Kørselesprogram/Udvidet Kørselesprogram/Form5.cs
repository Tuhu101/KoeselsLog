using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udvidet_Kørselesprogram
{
    
    public partial class Form5 : Form
    {
        private string BrugerId;
        
        // This is the Connection string that bindes the SQL Database together with the C#. //
        SqlConnection Connect = new SqlConnection("Data Source=10.0.4.115;Initial Catalog=TogTUdividet;User ID=Admin;Password=Passw0rd");

        public Form5(string BrugerIdentity)
        {
            InitializeComponent();
            BrugerId = BrugerIdentity;
        }
        // This is the "Ok" button for the Opret Ny Log tab. //
        private void KørselsOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Opgave_Formål.Text) || string.IsNullOrEmpty(KørteKM.Text))
                return;
            DateTime Date = DateTime.Now;
            string Time = Date.ToString("yyyy-MM-dd HH:mm:ss");
            Opgave_Formål.Focus();

            // Here i try to insert the information from the user into the database. //
            try
            {
                Connect.Open();
                SqlCommand cmd = new SqlCommand("Insert into NyKørselslog values('" + BrugerId + "', '" + Time + "', '" + Opgave_Formål.Text + "', '" + KørteKM.Text + "')", Connect );
                SqlCommand cmd2 = new SqlCommand("Update BrugerData set TotalKmDriven= (Select SUM(KmKørt) From NyKørselslog Where BrugerID= '" + BrugerId + "') Where BrugerID= '" + BrugerId + "'", Connect);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully.");
                Connect.Close();
            }
            // If it is not possible to insert the user information in the database the program vil give an error message. //
            catch
            {
                MessageBox.Show("Fejl!");
            }
            Opgave_Formål.Clear();
            KørteKM.Clear();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'togTUdividetDataSet.NyKørselslog' table. You can move, or remove it, as needed.
        //    this.nyKørselslogTableAdapter.Fill(this.togTUdividetDataSet.NyKørselslog);
            // TODO: This line of code loads data into the 'togTUdividetDataSet.BrugerData' table. You can move, or remove it, as needed.
            this.brugerDataTableAdapter.Fill(this.togTUdividetDataSet.BrugerData);
        }
    }
}
