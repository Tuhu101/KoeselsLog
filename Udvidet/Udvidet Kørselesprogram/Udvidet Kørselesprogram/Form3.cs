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
    public partial class Form3 : Form
    {
        private string BrugerId;
        private string BrugerNavn;
        // This is the Connection string that bindes the SQL Database together with the C#. //
        SqlConnection Connect = new SqlConnection("Data Source=10.0.4.115;Initial Catalog=TogTUdividet;User ID=Admin;Password=Passw0rd");
        
        public Form3(string BrugerIdentity, string BrugerName)
        {
            InitializeComponent();
            BrugerId = BrugerIdentity;
            BrugerNavn = BrugerName;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'togTUdividetDataSet.BrugerData' table. You can move, or remove it, as needed.
            this.brugerDataTableAdapter.Fill(this.togTUdividetDataSet.BrugerData);
        }
        // This is the "Ok" button in the Slet Bruger tab. //
        private void SletOK_Click(object sender, EventArgs e)
        {
            // This deletes the chosen user. //
            Connect.Open();
            SqlCommand cmd1 = new SqlCommand("Delete NyKørselslog where BrugerID= '" + BrugerId + "'", Connect);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("DELETE BrugerData where BrugerNavn='" + BrugerNavn + "' and BrugerID= '" + BrugerId + "'", Connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bruger er blevet slettet");
            Connect.Close();
        }

        // This is the "Cancel" button in the Slet Bruger tab. 
        private void SletCancel_Click(object sender, EventArgs e)
        {
            // Nothing needed here. //
        }

       
    }
}
