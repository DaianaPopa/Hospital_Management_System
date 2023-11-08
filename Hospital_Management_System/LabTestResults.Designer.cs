namespace Hospital_Management_System
{
    partial class Lab_Test_Results
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
            lblLabTestResult = new Label();
            dgvLabTestResults = new DataGridView();
            btnAdd = new Button();
            txtResult = new TextBox();
            txtTest = new TextBox();
            txtID = new TextBox();
            txtDate = new TextBox();
            btnDelete = new Button();
            lblResult = new Label();
            lblDate = new Label();
            lblPatientId = new Label();
            lblTypesOfTest = new Label();
            btnBack = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLabTestResults).BeginInit();
            SuspendLayout();
            // 
            // lblLabTestResult
            // 
            lblLabTestResult.AutoSize = true;
            lblLabTestResult.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblLabTestResult.Location = new Point(292, 60);
            lblLabTestResult.Name = "lblLabTestResult";
            lblLabTestResult.Size = new Size(176, 31);
            lblLabTestResult.TabIndex = 0;
            lblLabTestResult.Text = "Lab Test Results";
            // 
            // dgvLabTestResults
            // 
            dgvLabTestResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLabTestResults.Location = new Point(104, 133);
            dgvLabTestResults.Name = "dgvLabTestResults";
            dgvLabTestResults.RowHeadersWidth = 51;
            dgvLabTestResults.RowTemplate.Height = 29;
            dgvLabTestResults.Size = new Size(541, 151);
            dgvLabTestResults.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(551, 356);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(401, 356);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(125, 27);
            txtResult.TabIndex = 3;
            // 
            // txtTest
            // 
            txtTest.Location = new Point(186, 407);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(125, 27);
            txtTest.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(186, 358);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 5;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(401, 407);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(551, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(335, 361);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 8;
            lblResult.Text = "Result";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(335, 414);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";
            // 
            // lblPatientId
            // 
            lblPatientId.AutoSize = true;
            lblPatientId.Location = new Point(104, 361);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new Size(73, 20);
            lblPatientId.TabIndex = 10;
            lblPatientId.Text = "Patient ID";
            // 
            // lblTypesOfTest
            // 
            lblTypesOfTest.AutoSize = true;
            lblTypesOfTest.Location = new Point(91, 409);
            lblTypesOfTest.Name = "lblTypesOfTest";
            lblTypesOfTest.Size = new Size(86, 20);
            lblTypesOfTest.TabIndex = 11;
            lblTypesOfTest.Text = "Type of test";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Patient", "Doctor/Nurse" });
            comboBox1.Location = new Point(619, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Lab_Test_Results
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(comboBox1);
            Controls.Add(btnBack);
            Controls.Add(lblTypesOfTest);
            Controls.Add(lblPatientId);
            Controls.Add(lblDate);
            Controls.Add(lblResult);
            Controls.Add(btnDelete);
            Controls.Add(txtDate);
            Controls.Add(txtID);
            Controls.Add(txtTest);
            Controls.Add(txtResult);
            Controls.Add(btnAdd);
            Controls.Add(dgvLabTestResults);
            Controls.Add(lblLabTestResult);
            Name = "Lab_Test_Results";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS";
            Load += Lab_Test_Results_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLabTestResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLabTestResult;
        private DataGridView dgvLabTestResults;
        private Button btnAdd;
        private TextBox txtResult;
        private TextBox txtTest;
        private TextBox txtID;
        private TextBox txtDate;
        private Button btnDelete;
        private Label lblResult;
        private Label lblDate;
        private Label lblPatientId;
        private Label lblTypesOfTest;
        private Button btnBack;
        private ComboBox comboBox1;
    }
}