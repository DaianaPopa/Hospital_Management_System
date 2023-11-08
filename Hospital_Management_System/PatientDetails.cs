using System.Data;
using System.Data.SQLite;

namespace Hospital_Management_System
{
    public partial class FrmPatientDetails : Form
    {
        public FrmPatientDetails()
        {
            InitializeComponent();
        }
        private void FrmHospital_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            SQLiteConnection conn = new(@"data source = C:\Users\popad\OneDrive\Desktop\Hospital_Management_System\hsp_db.db");
            conn.Open();

            string query = "Select * from Patient_Details";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvRecord.DataSource = dt;

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

            txtID.Text = "";
            txtName.Text = "";
            txtDob.Text = "";
            txtAddress.Text = "";
            txtGender.Text = "";
        }
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            string query = "Insert into Patient_Details(ID, Name, DOB, Address, Gender) values ('" + txtID.Text + "', '" + txtName.Text + "', '" + txtDob.Text + "', '" + txtAddress.Text + "', '" + txtGender.Text + "')";
            AmendDatabase(query);
            LoadData();
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            string query = "Update Patient_Details set Name ='" + txtName.Text + "'where ID ='" + txtID.Text + "'";
            AmendDatabase(query);
            LoadData();
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            string query = "Delete from Patient_Details where ID ='" + txtID.Text + "'";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lblAddress.Show();
                lblGender.Show();
                lblDOB.Show();
                lblID.Show();
                lblName.Show();
                txtName.Show();
                txtID.Show();
                txtGender.Show();
                txtDob.Show();
                txtAddress.Show();
                BtnAdd.Show();
                BtnDelete.Show();
                BtnUpdate.Show();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                lblAddress.Hide();
                lblGender.Hide();
                lblDOB.Hide();
                lblID.Hide();
                lblName.Hide();
                txtName.Hide();
                txtID.Hide();
                txtGender.Hide();
                txtDob.Hide();
                txtAddress.Hide();
                BtnAdd.Hide();
                BtnDelete.Hide();
                BtnUpdate.Hide();
            }
        }
    }
}