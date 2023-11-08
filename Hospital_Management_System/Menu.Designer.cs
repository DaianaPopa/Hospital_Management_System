namespace Hospital_Management_System
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            lblMenu = new Label();
            btnPatientDetails = new Button();
            btnPatientRecords = new Button();
            btnLabTestResults = new Button();
            btnAppointments = new Button();
            bntStaffInfo = new Button();
            btnSupport = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            btnMail = new Button();
            btnNotification = new Button();
            btnNurse = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(66, 39);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(98, 41);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Menu";
            // 
            // btnPatientDetails
            // 
            btnPatientDetails.Location = new Point(12, 110);
            btnPatientDetails.Name = "btnPatientDetails";
            btnPatientDetails.Size = new Size(201, 59);
            btnPatientDetails.TabIndex = 1;
            btnPatientDetails.Text = "Patient Details";
            btnPatientDetails.UseVisualStyleBackColor = true;
            btnPatientDetails.Click += btnPatientDetails_Click;
            // 
            // btnPatientRecords
            // 
            btnPatientRecords.Location = new Point(12, 175);
            btnPatientRecords.Name = "btnPatientRecords";
            btnPatientRecords.Size = new Size(201, 59);
            btnPatientRecords.TabIndex = 1;
            btnPatientRecords.Text = "Patient Health Records";
            btnPatientRecords.UseVisualStyleBackColor = true;
            btnPatientRecords.Click += btnPatientRecords_Click;
            // 
            // btnLabTestResults
            // 
            btnLabTestResults.Location = new Point(12, 240);
            btnLabTestResults.Name = "btnLabTestResults";
            btnLabTestResults.Size = new Size(201, 59);
            btnLabTestResults.TabIndex = 1;
            btnLabTestResults.Text = "Lab Test Results";
            btnLabTestResults.UseVisualStyleBackColor = true;
            btnLabTestResults.Click += btnLabTestResults_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Location = new Point(12, 305);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(201, 59);
            btnAppointments.TabIndex = 2;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // bntStaffInfo
            // 
            bntStaffInfo.Location = new Point(12, 370);
            bntStaffInfo.Name = "bntStaffInfo";
            bntStaffInfo.Size = new Size(201, 59);
            bntStaffInfo.TabIndex = 3;
            bntStaffInfo.Text = "Staff Information";
            bntStaffInfo.UseVisualStyleBackColor = true;
            bntStaffInfo.Click += bntStaffInfo_Click;
            // 
            // btnSupport
            // 
            btnSupport.Location = new Point(12, 435);
            btnSupport.Name = "btnSupport";
            btnSupport.Size = new Size(201, 59);
            btnSupport.TabIndex = 4;
            btnSupport.Text = "Support";
            btnSupport.UseVisualStyleBackColor = true;
            btnSupport.Click += btnSupport_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(569, 435);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(201, 59);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.person_icon;
            pictureBox1.Image = Properties.Resources.person_icon;
            pictureBox1.InitialImage = Properties.Resources.icon;
            pictureBox1.Location = new Point(442, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(493, 39);
            label1.Name = "label1";
            label1.Size = new Size(107, 41);
            label1.TabIndex = 7;
            label1.Text = "Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 269);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Doctor ", "Nurse", "Receptionist", "Guest" });
            comboBox1.Location = new Point(442, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnMail
            // 
            btnMail.BackColor = SystemColors.ButtonFace;
            btnMail.BackgroundImage = (Image)resources.GetObject("btnMail.BackgroundImage");
            btnMail.BackgroundImageLayout = ImageLayout.Zoom;
            btnMail.FlatStyle = FlatStyle.Flat;
            btnMail.ForeColor = SystemColors.ButtonFace;
            btnMail.Location = new Point(442, 353);
            btnMail.Name = "btnMail";
            btnMail.Size = new Size(94, 44);
            btnMail.TabIndex = 10;
            btnMail.TextAlign = ContentAlignment.BottomCenter;
            btnMail.UseVisualStyleBackColor = true;
            btnMail.Click += btnMail_Click;
            // 
            // btnNotification
            // 
            btnNotification.BackColor = SystemColors.ButtonFace;
            btnNotification.BackgroundImage = (Image)resources.GetObject("btnNotification.BackgroundImage");
            btnNotification.BackgroundImageLayout = ImageLayout.Zoom;
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.ForeColor = SystemColors.ButtonFace;
            btnNotification.Location = new Point(542, 353);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(94, 44);
            btnNotification.TabIndex = 11;
            btnNotification.TextAlign = ContentAlignment.BottomCenter;
            btnNotification.UseVisualStyleBackColor = false;
            btnNotification.Click += btnNotification_Click;
            // 
            // btnNurse
            // 
            btnNurse.BackColor = SystemColors.ButtonFace;
            btnNurse.BackgroundImage = (Image)resources.GetObject("btnNurse.BackgroundImage");
            btnNurse.BackgroundImageLayout = ImageLayout.Zoom;
            btnNurse.FlatStyle = FlatStyle.Flat;
            btnNurse.ForeColor = SystemColors.ButtonFace;
            btnNurse.Location = new Point(647, 305);
            btnNurse.Name = "btnNurse";
            btnNurse.Size = new Size(94, 44);
            btnNurse.TabIndex = 12;
            btnNurse.TextAlign = ContentAlignment.BottomCenter;
            btnNurse.UseVisualStyleBackColor = true;
            btnNurse.Click += btnNurse_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(btnNurse);
            Controls.Add(btnNotification);
            Controls.Add(btnMail);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnSupport);
            Controls.Add(bntStaffInfo);
            Controls.Add(btnAppointments);
            Controls.Add(btnLabTestResults);
            Controls.Add(btnPatientRecords);
            Controls.Add(btnPatientDetails);
            Controls.Add(lblMenu);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            Load += Frm3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private Button btnPatientDetails;
        private Button btnPatientRecords;
        private Button btnLabTestResults;
        private Button btnAppointments;
        private Button bntStaffInfo;
        private Button btnSupport;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button btnMail;
        private Button btnNotification;
        private Button btnNurse;
    }
}