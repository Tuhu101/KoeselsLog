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
        string BrugerId;
        string BrugerNavn;

        public Form1()
        {
            InitializeComponent();
        }

        // Den her metode loader alle dataerne ind i DataGridViewet. //
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'togTUdividetDataSet1.NyKørselslog' table. You can move, or remove it, as needed.
            this.nyKørselslogTableAdapter1.Fill(this.togTUdividetDataSet1.NyKørselslog);
            // TODO: This line of code loads data into the 'togTUdividetDataSet1.BrugerData' table. You can move, or remove it, as needed.
            this.brugerDataTableAdapter1.Fill(this.togTUdividetDataSet1.BrugerData);
            // TODO: This line of code loads data into the 'togTUdividetDataSet.NyKørselslog' table. You can move, or remove it, as needed.
            //  this.nyKørselslogTableAdapter.Fill(this.togTUdividetDataSet.NyKørselslog);

            // TODO: This line of code loads data into the 'togTUdividetDataSet.BrugerData' table. You can move, or remove it, as needed.
          //  this.brugerDataTableAdapter.Fill(this.togTUdividetDataSet.BrugerData);
            
        }
        
        // Opret Ny Bruger. //
        private void NyBruger_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.FormClosed += new FormClosedEventHandler(F2_FormClosed);
            F2.ShowDialog();
        }
        
        // Metode til at lukke Form 2. //
        void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.brugerDataTableAdapter1.Fill(this.togTUdividetDataSet1.BrugerData);
        }

        // Metode til at lukke Form 3. //
        void F3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.brugerDataTableAdapter1.Fill(this.togTUdividetDataSet1.BrugerData);
        }

        // Metode til at lukke Form 4. //
        void F4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.brugerDataTableAdapter1.Fill(this.togTUdividetDataSet1.BrugerData);
        }

        // Metode til at lukke Form 5. //
        void F5_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.brugerDataTableAdapter1.Fill(this.togTUdividetDataSet1.BrugerData);
        }

        // Den her metode gør så, hvis der bliver klikket på en knap i DataGridViewet åbner programmet den form der passer til. //
        private void PersonListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (PersonListe.SelectedCells.Count > 0)
            {
                int selectedrowindex = PersonListe.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = PersonListe.Rows[selectedrowindex];
                BrugerId = Convert.ToString(selectedRow.Cells["brugerIDDataGridViewTextBoxColumn"].Value);
            }

            if (PersonListe.SelectedCells.Count > 1)
            {
                int selectedrowindex = PersonListe.SelectedCells[1].RowIndex;
                DataGridViewRow selectedRow = PersonListe.Rows[selectedrowindex];
                BrugerNavn = Convert.ToString(selectedRow.Cells["brugernavnDataGridViewTextBoxColumn"].Value);
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 5)
            {
                Form3 F3 = new Form3(BrugerId, BrugerNavn);
                F3.FormClosed += new FormClosedEventHandler(F3_FormClosed);
                F3.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 6)
            {
                Form4 F4 = new Form4(BrugerNavn);
                F4.FormClosed += new FormClosedEventHandler(F4_FormClosed);
                F4.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7)
            {
                Form5 F5 = new Form5(BrugerId);
                F5.FormClosed += new FormClosedEventHandler(F5_FormClosed);
                F5.ShowDialog();
            }
        }

        private void PersonListe_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Data Source=10.0.4.115;Initial Catalog=TogTUdividet;User ID=Admin;Password=Passw0rd");
            if (PersonListe.SelectedCells.Count > 0)
            {
                int selectedrowindex = PersonListe.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = PersonListe.Rows[selectedrowindex];
                BrugerId = Convert.ToString(selectedRow.Cells["brugerIDDataGridViewTextBoxColumn"].Value);
            }
            Connect.Open();
            Adapter = new SqlDataAdapter("Select * from NyKørselslog where BrugerID= '" + BrugerId + "'", Connect);
            Connect.Close();

            SqlCommandBuilder cb = new SqlCommandBuilder(Adapter);
            DT = new DataTable();
            Adapter.Fill(DT);
            LogOversigtForBruger.DataSource = DT;

        }



        // Jeg har givet op. //

        // Jeg kan ikke finde det jeg skal bruge. //

        // Fordi jeg er dårlig til at bruge internettet til min hjælp. //

        // Slut. //


    }
}
