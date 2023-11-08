using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hospital_Management_System
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            SQLiteConnection conn = new(@"data source = C:\Users\popad\OneDrive\Desktop\Hospital_Management_System\hsp_db.db");
            conn.Open();

            string query = "Select * from Appointments";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvAppointment.DataSource = dt;

            conn.Close();

        }
        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\popad\OneDrive\Desktop\Hospital_Management_System\hsp_db.db");
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            txtProblem.Text = "";
            txtDate.Text = "";
            txtPatientID.Text = "";
            txtDoctorName.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "Insert into Appointments(Date, Patient ID, Problem, Doctor Name) values ('" + txtDate.Text + "', '" + txtPatientID.Text + "', '" + txtProblem.Text + "', '" + txtDoctorName.Text + "')";
            AmendDatabase(query);
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string query = "Delete from Appointments where ID ='" + txtPatientID.Text + "'";
            AmendDatabase(query);
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMenu nef = new FrmMenu();
            nef.ShowDialog();
            Show();
        }
    }

}
