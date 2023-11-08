namespace Hospital_Management_System
{
    partial class FrmPatientDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAdd = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            txtID = new TextBox();
            dgvRecord = new DataGridView();
            lblID = new Label();
            lblName = new Label();
            txtName = new TextBox();
            txtDob = new TextBox();
            txtGender = new TextBox();
            txtAddress = new TextBox();
            lblDOB = new Label();
            lblGender = new Label();
            lblAddress = new Label();
            btnBack = new Button();
            lblPatientDetails = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(56, 396);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(124, 41);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click_1;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(295, 396);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(124, 41);
            BtnUpdate.TabIndex = 1;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click_1;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(531, 396);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(124, 41);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click_1;
            // 
            // txtID
            // 
            txtID.Location = new Point(120, 273);
            txtID.Name = "txtID";
            txtID.Size = new Size(128, 27);
            txtID.TabIndex = 3;
            // 
            // dgvRecord
            // 
            dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecord.Location = new Point(56, 79);
            dgvRecord.Name = "dgvRecord";
            dgvRecord.RowHeadersWidth = 51;
            dgvRecord.RowTemplate.Height = 29;
            dgvRecord.Size = new Size(668, 155);
            dgvRecord.TabIndex = 4;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(56, 276);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 6;
            lblID.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(56, 328);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 321);
            txtName.Name = "txtName";
            txtName.Size = new Size(128, 27);
            txtName.TabIndex = 8;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(371, 273);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(125, 27);
            txtDob.TabIndex = 9;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(371, 321);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(125, 27);
            txtGender.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(599, 273);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 11;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(295, 276);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(40, 20);
            lblDOB.TabIndex = 12;
            lblDOB.Text = "DOB";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(295, 328);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(531, 276);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblPatientDetails
            // 
            lblPatientDetails.AutoSize = true;
            lblPatientDetails.Location = new Point(352, 21);
            lblPatientDetails.Name = "lblPatientDetails";
            lblPatientDetails.Size = new Size(104, 20);
            lblPatientDetails.TabIndex = 17;
            lblPatientDetails.Text = "Patient Details";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Patient/Receptionist", "Doctor/Nurse" });
            comboBox1.Location = new Point(629, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FrmPatientDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(comboBox1);
            Controls.Add(lblPatientDetails);
            Controls.Add(btnBack);
            Controls.Add(lblAddress);
            Controls.Add(lblGender);
            Controls.Add(lblDOB);
            Controls.Add(txtAddress);
            Controls.Add(txtGender);
            Controls.Add(txtDob);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblID);
            Controls.Add(dgvRecord);
            Controls.Add(txtID);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnAdd);
            Name = "FrmPatientDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS";
            Load += FrmHospital_Load;
            Click += BtnAdd_Click_1;
            ((System.ComponentModel.ISupportInitialize)dgvRecord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private Button BtnUpdate;
        private Button BtnDelete;
        private TextBox txtID;
        private DataGridView dgvRecord;
        private Label lblID;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtDob;
        private TextBox txtGender;
        private TextBox txtAddress;
        private Label lblDOB;
        private Label lblGender;
        private Label lblAddress;
        private Button btnBack;
        private Label lblPatientDetails;
        private ComboBox comboBox1;
    }
}