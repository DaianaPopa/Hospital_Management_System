using System.Data.SQLite;
using System.Data;
using System.Xml.Linq;

namespace Hospital_Management_System
{
    public partial class Lab_Test_Results : Form
    {
        public Lab_Test_Results()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMenu nef = new FrmMenu();
            nef.ShowDialog();
            Show();
        }

        private void Lab_Test_Results_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            SQLiteConnection conn = new(@"data source = C:\Users\popad\OneDrive\Desktop\Hospital_Management_System\hsp_db.db");
            conn.Open();

            string query = "Select * from Lab_Test_Result";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvLabTestResults.DataSource = dt;

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
            txtDate.Text = "";
            txtResult.Text = "";
            txtTest.Text = "";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "Insert into Lab_Test_Result(ID, Test Type, Result, Date) values ('" + txtID.Text + "', '" + txtTest.Text + "', '" + txtResult.Text + "', '" + txtDate.Text + "')";
            AmendDatabase(query);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Lab_Test_Result where ID ='" + txtID.Text + "'";
            AmendDatabase(query);
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lblDate.Hide();
                lblPatientId.Hide();   
                lblResult.Hide();
                lblTypesOfTest.Hide(); 
                txtDate.Hide();
                txtResult.Hide();
                txtTest.Hide();
                txtID.Hide();
                btnAdd.Hide();
                btnDelete.Hide();
            }
            if (comboBox1.SelectedIndex == 1) 
            {
                lblDate.Show();
                lblPatientId.Show();
                lblResult.Show();
                lblTypesOfTest.Show();
                txtDate.Show();
                txtResult.Show();
                txtTest.Show();
                txtID.Show();
                btnAdd.Show();
                btnDelete.Show();
            }
        }
    }
}
