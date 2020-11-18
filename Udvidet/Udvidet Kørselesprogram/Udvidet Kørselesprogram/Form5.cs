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
        SqlConnection Connect = new SqlConnection("Data Source=10.0.4.115;Initial Catalog=TogTUdividet;User ID=Admin;Password=Passw0rd");
        SqlCommand jvt;
        SqlDataAdapter Adapter;
        DataTable DT = new DataTable();
        public Form5()
        {
            InitializeComponent();
        }

        private void KørselsOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Opgave_Formål.Text) || string.IsNullOrEmpty(KørteKM.Text))
                return;
            DateTime Date = DateTime.Now;
            string Time = Date.ToString("yyyy-MM-dd HH:mm:ss");
            Opgave_Formål.Focus();



            try
            {
                Connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO NyKørselslog(Dato,OgaveFormål,KmKørt)  VALUES(@DATO, @OPFO, @KMK)", Connect);
                cmd.Parameters.AddWithValue("@DATO", Time);
                cmd.Parameters.AddWithValue("@OPFO", Opgave_Formål.Text);
                cmd.Parameters.AddWithValue("@KMK", KørteKM.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully.");
                Connect.Close();
            }
            catch
            {
                MessageBox.Show("Fejl!");
            }
            Opgave_Formål.Clear();
            KørteKM.Clear();
        }
    }
}
