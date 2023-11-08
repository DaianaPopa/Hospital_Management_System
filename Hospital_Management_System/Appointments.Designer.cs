namespace Hospital_Management_System
{
    partial class Appointments
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
            lblDoctorName = new Label();
            lblProblem = new Label();
            lblPatientID = new Label();
            lblDate = new Label();
            lblTitle = new Label();
            dgvAppointment = new DataGridView();
            btnAdd = new Button();
            btnRemove = new Button();
            btnBack = new Button();
            txtPatientID = new TextBox();
            txtDoctorName = new TextBox();
            txtDate = new TextBox();
            txtProblem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAppointment).BeginInit();
            SuspendLayout();
            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Location = new Point(91, 391);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(99, 20);
            lblDoctorName.TabIndex = 0;
            lblDoctorName.Text = "Doctor Name";
            // 
            // lblProblem
            // 
            lblProblem.AutoSize = true;
            lblProblem.Location = new Point(269, 391);
            lblProblem.Name = "lblProblem";
            lblProblem.Size = new Size(65, 20);
            lblProblem.TabIndex = 1;
            lblProblem.Text = "Problem";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Location = new Point(91, 308);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(73, 20);
            lblPatientID.TabIndex = 2;
            lblPatientID.Text = "Patient ID";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(269, 308);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(348, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 28);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Appointments";
            // 
            // dgvAppointment
            // 
            dgvAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointment.Location = new Point(122, 74);
            dgvAppointment.Name = "dgvAppointment";
            dgvAppointment.RowHeadersWidth = 51;
            dgvAppointment.RowTemplate.Height = 29;
            dgvAppointment.Size = new Size(529, 188);
            dgvAppointment.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(520, 323);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 51);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(520, 399);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(131, 52);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(91, 347);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(125, 27);
            txtPatientID.TabIndex = 9;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Location = new Point(91, 424);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(125, 27);
            txtDoctorName.TabIndex = 10;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(269, 347);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 11;
            // 
            // txtProblem
            // 
            txtProblem.Location = new Point(269, 424);
            txtProblem.Name = "txtProblem";
            txtProblem.Size = new Size(125, 27);
            txtProblem.TabIndex = 12;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(txtProblem);
            Controls.Add(txtDate);
            Controls.Add(txtDoctorName);
            Controls.Add(txtPatientID);
            Controls.Add(btnBack);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dgvAppointment);
            Controls.Add(lblTitle);
            Controls.Add(lblDate);
            Controls.Add(lblPatientID);
            Controls.Add(lblProblem);
            Controls.Add(lblDoctorName);
            Name = "Appointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS";
            Load += Appointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDoctorName;
        private Label lblProblem;
        private Label lblPatientID;
        private Label lblDate;
        private Label lblTitle;
        private DataGridView dgvAppointment;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnBack;
        private TextBox txtPatientID;
        private TextBox txtDoctorName;
        private TextBox txtDate;
        private TextBox txtProblem;
    }
}