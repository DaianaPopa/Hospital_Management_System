namespace Hospital_Management_System
{
    partial class staffInfo
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
            label1 = new Label();
            dgvDoctor = new DataGridView();
            dgvNurse = new DataGridView();
            btnBack = new Button();
            lblTitle = new Label();
            lblDoctor = new Label();
            lblNurse = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNurse).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            // 
            // dgvDoctor
            // 
            dgvDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctor.Location = new Point(192, 72);
            dgvDoctor.Name = "dgvDoctor";
            dgvDoctor.RowHeadersWidth = 51;
            dgvDoctor.RowTemplate.Height = 29;
            dgvDoctor.Size = new Size(469, 159);
            dgvDoctor.TabIndex = 1;
            // 
            // dgvNurse
            // 
            dgvNurse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNurse.Location = new Point(192, 294);
            dgvNurse.Name = "dgvNurse";
            dgvNurse.RowHeadersWidth = 51;
            dgvNurse.RowTemplate.Height = 29;
            dgvNurse.Size = new Size(469, 160);
            dgvNurse.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(320, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 28);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Staff Information";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(59, 72);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(109, 20);
            lblDoctor.TabIndex = 7;
            lblDoctor.Text = "Doctors details";
            // 
            // lblNurse
            // 
            lblNurse.AutoSize = true;
            lblNurse.Location = new Point(73, 322);
            lblNurse.Name = "lblNurse";
            lblNurse.Size = new Size(95, 20);
            lblNurse.TabIndex = 8;
            lblNurse.Text = "Nurse details";
            // 
            // staffInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(lblNurse);
            Controls.Add(lblDoctor);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Controls.Add(dgvNurse);
            Controls.Add(dgvDoctor);
            Controls.Add(label1);
            Name = "staffInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS";
            Load += staffInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNurse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDoctor;
        private DataGridView dgvNurse;
        private Button btnBack;
        private Label lblTitle;
        private Label lblDoctor;
        private Label lblNurse;
    }
}