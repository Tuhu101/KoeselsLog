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
        SqlConnection Connect = new SqlConnection("Data Source=10.0.4.115;Initial Catalog=TogTUdividet;User ID=Admin;Password=Passw0rd");
        SqlCommand jvt;
        SqlDataAdapter Adapter;
        DataTable DT = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }

      

        private void RedigerOK_Click(object sender, EventArgs e)
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("UPDATE BrugerData set NrPlade='" + RedgierNrPlade.Text + "'Where BrugerNavn='" + RedigerNavn.Text + "'", Connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data er blevet opdateret.");
            Connect.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'togTUdividetDataSet.BrugerData' table. You can move, or remove it, as needed.
            this.brugerDataTableAdapter.Fill(this.togTUdividetDataSet.BrugerData);

        }
    }
}
