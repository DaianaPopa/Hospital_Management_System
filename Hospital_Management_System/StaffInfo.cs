using Microsoft.VisualBasic.ApplicationServices;
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

namespace Hospital_Management_System
{
    public partial class staffInfo : Form
    {
        public staffInfo()
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

        private void staffInfo_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData2();
        }
        public void LoadData()
        {
            SQLiteConnection conn = new(@"data source = C:\Users\popad\OneDrive\Desktop\Hospital_Management_System\hsp_db.db");
            conn.Open();

            string query = "Select * from Doctor";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvDoctor.DataSource = dt;

            conn.Close();

        }
        public void LoadData2()
        {
            SQLiteConnection conn = new(@"data source = C:\Users\popad\OneDrive\Desktop\Hospital_Management_System\hsp_db.db");
            conn.Open();

            string query = "Select * from Nurse";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvNurse.DataSource = dt;

            conn.Close();

        }
    }
}
