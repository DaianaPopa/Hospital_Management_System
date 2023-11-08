using System.Data.SQLite;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace Hospital_Management_System
{
    public partial class FrmPatientHealthRecord : Form
    {
        public FrmPatientHealthRecord()
        {
            InitializeComponent();
        }

        private void FrmPatientHealthRecord_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMenu nef = new FrmMenu();
            nef.ShowDialog();
            Show();
        }
        public void LoadData()
        {
            SQLiteConnection conn = new(@"data source = C:\Users\popad\OneDrive\Desktop\Hospital_Management_System\hsp_db.db");
            conn.Open();

            string query = "Select * from Patient_Health_Record";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvPatientHealthRecord.DataSource = dt;

            conn.Close();

        }
        private void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C: \Users\popad\OneDrive\Desktop\Hospital_Management_System\hsp_db.db");
            conn.Open();

            string query = txtQuery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            txtPatientID.Text = "";
            txtAllergies.Text = "";
            txtProblems.Text = "";
            txtTreatment.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Insert into Patient_Health_Record(ID, Problem, Allergies, Treatment) values ('" + txtPatientID.Text + "', '" + txtProblems.Text + "', '" + txtAllergies.Text + "', '" + txtTreatment.Text + "')";
            AmendDatabase(query);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Patient_Health_Record where ID ='" + txtPatientID.Text + "'";
            AmendDatabase(query);
            LoadData();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            lblNote.Text = txtNotes.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {
                lblNote.Hide();
                txtNotes.Hide();
                btnAddNote.Hide();
            }
            if(comboBox1.SelectedIndex == 1)
            {
              lblAllergies.Hide();
              txtAllergies.Hide();
              lblPatientId.Hide();
              lblPatientProblems.Hide();
              lblPatientTreatment.Hide();
              txtPatientID.Hide();
              txtProblems.Hide();
              txtTreatment.Hide();
              btnUpdate.Hide();
              btnDelete.Hide();
                lblNote.Show();
                txtNotes.Show();
                btnAddNote.Show();
            }
        }
    }
}
