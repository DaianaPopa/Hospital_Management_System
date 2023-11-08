namespace Hospital_Management_System
{
    partial class support
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
            LblTelephone = new Label();
            LblAddress = new Label();
            LblEmail = new Label();
            LinkLblEmail = new LinkLabel();
            LblTelephone2 = new Label();
            LblAddress2 = new Label();
            btnBack = new Button();
            lblContactUs = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.hospital;
            pictureBox1.Location = new Point(177, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LblTelephone
            // 
            LblTelephone.AutoSize = true;
            LblTelephone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblTelephone.Location = new Point(221, 447);
            LblTelephone.Name = "LblTelephone";
            LblTelephone.Size = new Size(96, 25);
            LblTelephone.TabIndex = 1;
            LblTelephone.Text = "Telephone:";
            // 
            // LblAddress
            // 
            LblAddress.AutoSize = true;
            LblAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblAddress.Location = new Point(221, 416);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(81, 25);
            LblAddress.TabIndex = 2;
            LblAddress.Text = "Address:";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmail.Location = new Point(221, 478);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(65, 25);
            LblEmail.TabIndex = 2;
            LblEmail.Text = "E-mail:";
            // 
            // LinkLblEmail
            // 
            LinkLblEmail.AutoSize = true;
            LinkLblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LinkLblEmail.Location = new Point(308, 478);
            LinkLblEmail.Name = "LinkLblEmail";
            LinkLblEmail.Size = new Size(205, 25);
            LinkLblEmail.TabIndex = 3;
            LinkLblEmail.TabStop = true;
            LinkLblEmail.Text = "HMSSupport@mail.com";
            // 
            // LblTelephone2
            // 
            LblTelephone2.AutoSize = true;
            LblTelephone2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblTelephone2.Location = new Point(308, 447);
            LblTelephone2.Name = "LblTelephone2";
            LblTelephone2.Size = new Size(122, 25);
            LblTelephone2.TabIndex = 1;
            LblTelephone2.Text = "07123456789";
            // 
            // LblAddress2
            // 
            LblAddress2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblAddress2.Location = new Point(308, 416);
            LblAddress2.Name = "LblAddress2";
            LblAddress2.Size = new Size(272, 20);
            LblAddress2.TabIndex = 2;
            LblAddress2.Text = "42 Narnia Street, Sheffield, S1 1WB";
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
            // lblContactUs
            // 
            lblContactUs.AutoSize = true;
            lblContactUs.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactUs.Location = new Point(308, 352);
            lblContactUs.Name = "lblContactUs";
            lblContactUs.Size = new Size(126, 31);
            lblContactUs.TabIndex = 5;
            lblContactUs.Text = "Contact Us";
            // 
            // support
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(lblContactUs);
            Controls.Add(btnBack);
            Controls.Add(LinkLblEmail);
            Controls.Add(LblEmail);
            Controls.Add(LblAddress2);
            Controls.Add(LblAddress);
            Controls.Add(LblTelephone2);
            Controls.Add(LblTelephone);
            Controls.Add(pictureBox1);
            Name = "support";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS";
            Load += support_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LblTelephone;
        private Label LblAddress;
        private Label LblEmail;
        private LinkLabel LinkLblEmail;
        private Label LblTelephone2;
        private Label LblAddress2;
        private Button btnBack;
        private Label lblContactUs;
    }
}