namespace Hospital_Management_System
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Frm3_Load(object sender, EventArgs e)
        {
            UnableButtons();
            btnNurse.Hide();
        }

        private void btnPatientDetails_Click(object sender, EventArgs e)
        {

            FrmPatientDetails nef = new FrmPatientDetails();
            nef.ShowDialog();
            Show();
        }

        private void btnPatientRecords_Click(object sender, EventArgs e)
        {

            FrmPatientHealthRecord nef = new FrmPatientHealthRecord();
            nef.ShowDialog();
            Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {

            Appointments nef = new Appointments();
            nef.ShowDialog();
            Show();
        }

        private void bntStaffInfo_Click(object sender, EventArgs e)
        {

            staffInfo nef = new staffInfo();
            nef.ShowDialog();
            Show();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {

            support nef = new support();
            nef.ShowDialog();
            Show();
        }

        private void btnLabTestResults_Click(object sender, EventArgs e)
        {

            Lab_Test_Results nef = new Lab_Test_Results();
            nef.ShowDialog();
            Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin nef = new FrmLogin();
            nef.ShowDialog();
            Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            Mail nef = new Mail();
            nef.ShowDialog();
            Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                EnableButtons();
                btnAppointments.Enabled = false;
                btnNotification.Show();
                btnNurse.Show();
                btnMail.Hide();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                EnableButtons();
                btnLabTestResults.Enabled = false;
                btnPatientRecords.Enabled = false;
                btnMail.Hide();
                btnNotification.Hide();
                btnNurse.Show();
            }
            if (comboBox1.SelectedIndex == 0)
            {
                EnableButtons();
                btnAppointments.Enabled = false;
                btnMail.Show();
                btnNotification.Show();
                btnNurse.Hide();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                EnableButtons();
                btnPatientRecords.Enabled = false;
                btnMail.Hide();
                btnNotification.Hide();
                btnNurse.Hide();
            }
        }
        private void EnableButtons()
        {
            btnAppointments.Enabled = true;
            btnLabTestResults.Enabled = true;
            btnPatientRecords.Enabled = true;
            btnMail.Enabled = true;
            btnNotification.Enabled = true;
            btnPatientDetails.Enabled = true;
            btnSupport.Enabled = true;
        }
        private void UnableButtons()
        {
            btnAppointments.Enabled = false;
            btnLabTestResults.Enabled = false;
            btnPatientRecords.Enabled = false;
            btnMail.Enabled = false;
            btnNotification.Enabled = false;
            btnPatientDetails.Enabled = false;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            Notification nef = new Notification();
            nef.ShowDialog();
            Show();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            NurseMailscs nef = new NurseMailscs();
            nef.ShowDialog();
            Show();
        }
    }
}
