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

namespace Koeselslog__Simpel_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection("Server=10.0.4.115;Database=Tec;User ID=Admin;Password=Passw0rd");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tecDataSet.Bruger' table. You can move, or remove it, as needed.
            this.brugerTableAdapter.Fill(this.tecDataSet.Bruger);
        }

        // Opret Ok Knap. //
        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            string format = Date.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                Connect.Open();
                SqlCommand cmd = new SqlCommand("insert into Bruger values('" + textBox1.Text + "', '" + format + "', '" + textBox3.Text + "','')", Connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully.");
                Connect.Close();
            }
            catch
            {
                MessageBox.Show("Brugt NummerPlade indtast ny!");
            }
            // Her clear vi alt der står i de 2 tekst felter så de er klar til brug igen. //
            textBox1.Clear();
            textBox3.Clear();

            // Refresh på Datagridview. //
            this.brugerTableAdapter.Fill(this.tecDataSet.Bruger);
        }

        // Rediger Ok knap. //
        private void Button3_Click(object sender, EventArgs e)
        {
            Connect.Open();
            // Hvis brugeren har villet ændre på nmmerpladen, overføre den her del det til databasen. //
            SqlCommand cmd = new SqlCommand("update Bruger set BrugerNRPlade='" + textBox5.Text + "' where BrugerNavn='" + comboBox1.Text + "'", Connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully.");
            Connect.Close();

            // Refresh på Datagridview. //
            this.brugerTableAdapter.Fill(this.tecDataSet.Bruger);
        }

        // Slet Ok knap. //
        private void Button5_Click(object sender, EventArgs e)
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("delete Bruger where BrugerNavn='" + comboBox2.Text + "'", Connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully.");
            Connect.Close();

            // Refresh på Datagridview. //
            this.brugerTableAdapter.Fill(this.tecDataSet.Bruger);
        }

        // Opret log ok knap. //
        private void Button6_Click(object sender, EventArgs e)
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("update Bruger set Opgave='" + textBox8.Text + "' where BrugerNavn='" + comboBox3.Text + "'", Connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully.");
            Connect.Close();
            // Refresh på Datagridview. //
            this.brugerTableAdapter.Fill(this.tecDataSet.Bruger);
        }

        // Opret Bruger Cancel knap. //
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
        }

        // Rediger Bruger Cancel knap. //
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        // Opret log Cancel knap. //
        private void Button7_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
        }
    }
}
