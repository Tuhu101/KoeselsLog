using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Udvidet_Kørselesprogram
{
    public partial class Form4 : Form
    {
        private string BrugerNavn;

        // This is the Connection string that bindes the SQL Database together with the C#. //
        SqlConnection Connect = new SqlConnection("Data Source=10.0.4.115;Initial Catalog=TogTUdividet;User ID=Admin;Password=Passw0rd");
       
        public Form4(string BrugerIdentity)
        {
            InitializeComponent();
            BrugerNavn = BrugerIdentity;
            textBox1.Text = BrugerNavn;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'togTUdividetDataSet.BrugerData' table. You can move, or remove it, as needed.
            this.brugerDataTableAdapter.Fill(this.togTUdividetDataSet.BrugerData);
        }

        // This is the "Ok" button in the Rediger Bruger tab. //
        private void RedigerOK_Click(object sender, EventArgs e)
        {
            // This part updates the BrugerData table, with the input the user gives the program. //
            Connect.Open();
            SqlCommand cmd = new SqlCommand("UPDATE BrugerData set NrPlade='" + RedgierNrPlade.Text + "'Where BrugerNavn='" + BrugerNavn + "'", Connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data er blevet opdateret.");
            Connect.Close();
            this.Close();
        }
        // This is the "Cancel" button for the Rediger Bruger tab, it clears the input fields. //
        private void RedigerCancel_Click(object sender, EventArgs e)
        {
            RedgierNrPlade.Clear();
        }

        private void RedigerNavn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
