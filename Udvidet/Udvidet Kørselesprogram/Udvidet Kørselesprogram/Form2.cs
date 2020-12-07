using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Udvidet_Kørselesprogram
{
    public partial class Form2 : Form
    {
        // This is the Connection string that bindes the SQL Database together with the C#. //
        SqlConnection Connect = new SqlConnection("Data Source=10.0.4.115;Initial Catalog=TogTUdividet;User ID=Admin;Password=Passw0rd");

        public Form2()
        {
            InitializeComponent();
        }
        // This is the "ok" button in the Ny Bruger tab. //
        private void OpretOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OpretNavn.Text) || string.IsNullOrEmpty(OpretNrPlade.Text))
                return;
            DateTime Date = DateTime.Now;
            string Time = Date.ToString("yyyy-MM-dd HH:mm:ss");
            OpretNavn.Focus();
            // Here i try to insert the information from the user into the database. //
            try
            {
                Connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO BrugerData(BrugerNavn,Dato,NrPlade,TotalKmDriven)  VALUES(@OPBN,@OPD,@OPNP,@TDKM)", Connect);
                cmd.Parameters.AddWithValue("@OPBN", OpretNavn.Text);
                cmd.Parameters.AddWithValue("@OPD", Time);
                cmd.Parameters.AddWithValue("@OPNP", OpretNrPlade.Text);
                cmd.Parameters.AddWithValue("@TDKM", 0);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully.");
                Connect.Close();
            }
            // If it is not possible to insert the user information in the database the program vil give an error message. //
            catch
            {
                MessageBox.Show("Error!");
            }
            OpretNavn.Clear();
            OpretNrPlade.Clear();
        }
        // This is the "Cancel" button in the Ny Bruger tab, it clears the input feilds. //
        private void OpretCancel_Click(object sender, EventArgs e)
        {
            OpretNavn.Clear();
            OpretNrPlade.Clear();
        }


    }
}
