namespace Hospital_Management_System
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            lblLogin = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(12, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightGray;
            btnLogin.Location = new Point(520, 165);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.DarkSlateBlue;
            lblLogin.Location = new Point(203, 60);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(51, 20);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Log In";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(203, 83);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = " username";
            txtUserName.Size = new Size(411, 27);
            txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.AccessibleDescription = "";
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(203, 116);
            txtPassword.MaxLength = 10;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " password";
            txtPassword.Size = new Size(411, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 244);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblLogin);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLogin;
        private Label lblLogin;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}