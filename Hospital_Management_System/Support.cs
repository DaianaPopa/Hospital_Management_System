namespace Hospital_Management_System
{
    public partial class support : Form
    {
        public support()
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

        private void support_Load(object sender, EventArgs e)
        {

        }
    }
}
