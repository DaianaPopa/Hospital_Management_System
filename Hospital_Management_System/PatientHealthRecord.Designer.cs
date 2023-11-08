namespace Hospital_Management_System
{
    partial class FrmPatientHealthRecord
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
            lblPatientHealthRecord = new Label();
            dgvPatientHealthRecord = new DataGridView();
            txtTreatment = new TextBox();
            txtAllergies = new TextBox();
            txtProblems = new TextBox();
            txtPatientID = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAddNote = new Button();
            lblPatientId = new Label();
            lblAllergies = new Label();
            lblPatientProblems = new Label();
            lblPatientTreatment = new Label();
            txtNotes = new TextBox();
            lblNote = new Label();
            btnBack = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPatientHealthRecord).BeginInit();
            SuspendLayout();
            // 
            // lblPatientHealthRecord
            // 
            lblPatientHealthRecord.AutoSize = true;
            lblPatientHealthRecord.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientHealthRecord.Location = new Point(278, 19);
            lblPatientHealthRecord.Name = "lblPatientHealthRecord";
            lblPatientHealthRecord.Size = new Size(209, 28);
            lblPatientHealthRecord.TabIndex = 0;
            lblPatientHealthRecord.Text = "Patient Health Record";
            // 
            // dgvPatientHealthRecord
            // 
            dgvPatientHealthRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatientHealthRecord.Location = new Point(57, 77);
            dgvPatientHealthRecord.Name = "dgvPatientHealthRecord";
            dgvPatientHealthRecord.RowHeadersWidth = 51;
            dgvPatientHealthRecord.RowTemplate.Height = 29;
            dgvPatientHealthRecord.Size = new Size(541, 188);
            dgvPatientHealthRecord.TabIndex = 1;
            // 
            // txtTreatment
            // 
            txtTreatment.Location = new Point(462, 332);
            txtTreatment.Name = "txtTreatment";
            txtTreatment.Size = new Size(125, 27);
            txtTreatment.TabIndex = 2;
            // 
            // txtAllergies
            // 
            txtAllergies.Location = new Point(177, 339);
            txtAllergies.Name = "txtAllergies";
            txtAllergies.Size = new Size(125, 27);
            txtAllergies.TabIndex = 3;
            // 
            // txtProblems
            // 
            txtProblems.Location = new Point(462, 283);
            txtProblems.Name = "txtProblems";
            txtProblems.Size = new Size(125, 27);
            txtProblems.TabIndex = 4;
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(177, 283);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(125, 27);
            txtPatientID.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(639, 333);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Location = new Point(639, 277);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddNote
            // 
            btnAddNote.FlatStyle = FlatStyle.Popup;
            btnAddNote.Location = new Point(358, 404);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(129, 28);
            btnAddNote.TabIndex = 8;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // lblPatientId
            // 
            lblPatientId.AutoSize = true;
            lblPatientId.Location = new Point(47, 286);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new Size(73, 20);
            lblPatientId.TabIndex = 9;
            lblPatientId.Text = "Patient ID";
            // 
            // lblAllergies
            // 
            lblAllergies.AutoSize = true;
            lblAllergies.Location = new Point(47, 339);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(67, 20);
            lblAllergies.TabIndex = 10;
            lblAllergies.Text = "Allergies";
            // 
            // lblPatientProblems
            // 
            lblPatientProblems.AutoSize = true;
            lblPatientProblems.Location = new Point(358, 286);
            lblPatientProblems.Name = "lblPatientProblems";
            lblPatientProblems.Size = new Size(75, 20);
            lblPatientProblems.TabIndex = 11;
            lblPatientProblems.Text = " Problems";
            // 
            // lblPatientTreatment
            // 
            lblPatientTreatment.AutoSize = true;
            lblPatientTreatment.Location = new Point(358, 342);
            lblPatientTreatment.Name = "lblPatientTreatment";
            lblPatientTreatment.Size = new Size(76, 20);
            lblPatientTreatment.TabIndex = 12;
            lblPatientTreatment.Text = "Treatment";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(358, 438);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(129, 27);
            txtNotes.TabIndex = 13;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.FlatStyle = FlatStyle.Popup;
            lblNote.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNote.ForeColor = Color.Crimson;
            lblNote.Location = new Point(177, 430);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(61, 35);
            lblNote.TabIndex = 14;
            lblNote.Text = "Note";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Doctor", "Nurse" });
            comboBox1.Location = new Point(619, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FrmPatientHealthRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(comboBox1);
            Controls.Add(btnBack);
            Controls.Add(lblNote);
            Controls.Add(txtNotes);
            Controls.Add(lblPatientTreatment);
            Controls.Add(lblPatientProblems);
            Controls.Add(lblAllergies);
            Controls.Add(lblPatientId);
            Controls.Add(btnAddNote);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtPatientID);
            Controls.Add(txtProblems);
            Controls.Add(txtAllergies);
            Controls.Add(txtTreatment);
            Controls.Add(dgvPatientHealthRecord);
            Controls.Add(lblPatientHealthRecord);
            Name = "FrmPatientHealthRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS";
            Load += FrmPatientHealthRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatientHealthRecord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPatientHealthRecord;
        private DataGridView dgvPatientHealthRecord;
        private TextBox txtTreatment;
        private TextBox txtAllergies;
        private TextBox txtProblems;
        private TextBox txtPatientID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddNote;
        private Label lblPatientId;
        private Label lblAllergies;
        private Label lblPatientProblems;
        private Label lblPatientTreatment;
        private TextBox txtNotes;
        private Label lblNote;
        private Button btnBack;
        private ComboBox comboBox1;
    }
}