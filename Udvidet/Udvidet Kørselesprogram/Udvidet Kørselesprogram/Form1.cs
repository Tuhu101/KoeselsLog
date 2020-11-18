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
using System.Security.Cryptography;

namespace Udvidet_Kørselesprogram
{

    public partial class Form1 : Form
    {
        SqlConnection Connect = new SqlConnection("Server=10.0.4.115; Database=TogTUdvidet; User=Admin; Password=Passw0rd");
        SqlCommand jvt;
        SqlDataAdapter Adapter;
        DataTable DT = new DataTable();
       

        public Form1()
        {
            InitializeComponent();
            
        }

        // Opret Ny Bruger. //
        private void NyBruger_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();
        
        }

        // Slet en Bruger. //
        private void SletBruger_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.ShowDialog();
        }

        // Rediger en bruger. //
        private void RedigerBruger_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.ShowDialog();
        }

        // Opret en ny log til en bruger. //
        private void NyLogBruger_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'togTUdividetDataSet.BrugerData' table. You can move, or remove it, as needed.
            // this.brugerDataTableAdapter.Fill(this.togTUdividetDataSet.BrugerData);

            DisplayData();

        }

        private void DisplayData()
        {
            SqlConnection Connect = new SqlConnection("Server=10.0.4.115; Database=TogTUdvidet; User=Admin; Password=Passw0rd");
            Connect.Open();
            Adapter = new SqlDataAdapter("Select * From BrugerData", Connect);
            DataSet DT = new DataSet();
            Adapter.Fill(DT, "BrugerData");
            PersonListe.DataSource = DT;
            PersonListe.DataMember = "BrugerData";
            Connect.Close();
        }



    }
}
