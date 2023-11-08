namespace Hospital_Management_System
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User u = new User();

            u.SetPassword(txtPassword.Text);
            u.SetUserName(txtUserName.Text);

               Hide();
                FrmMenu nef = new FrmMenu();
                nef.ShowDialog();
                Show();
           
        }

        public string GetName()
        {
            return txtUserName.Text;
        }
    }
}
