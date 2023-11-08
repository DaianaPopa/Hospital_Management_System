namespace Hospital_Management_System
{
    partial class Mail
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(199, 43);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 0;
            label1.Text = "Mails";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(184, 40);
            label2.TabIndex = 1;
            label2.Text = "Amanda/ check health eye\r\ntoday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 82);
            label3.Name = "label3";
            label3.Size = new Size(178, 40);
            label3.TabIndex = 2;
            label3.Text = "Timond/ covid symptoms\r\n12/04/2023\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 136);
            label4.Name = "label4";
            label4.Size = new Size(140, 40);
            label4.TabIndex = 3;
            label4.Text = "Anna/ skin concerns\r\n28/05/2023";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(42, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 181);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointments";
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(322, 136);
            button5.Name = "button5";
            button5.Size = new Size(61, 20);
            button5.TabIndex = 9;
            button5.Text = "Reject";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LimeGreen;
            button6.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(255, 136);
            button6.Name = "button6";
            button6.Size = new Size(61, 20);
            button6.TabIndex = 8;
            button6.Text = "Confirm";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(322, 82);
            button3.Name = "button3";
            button3.Size = new Size(61, 20);
            button3.TabIndex = 7;
            button3.Text = "Reject";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LimeGreen;
            button4.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(255, 82);
            button4.Name = "button4";
            button4.Size = new Size(61, 20);
            button4.TabIndex = 6;
            button4.Text = "Confirm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(322, 25);
            button2.Name = "button2";
            button2.Size = new Size(61, 20);
            button2.TabIndex = 5;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(255, 25);
            button1.Name = "button1";
            button1.Size = new Size(61, 20);
            button1.TabIndex = 4;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Maria's Test Labs arrivers today.", "11:02AM", "Jack M. sent a mail.", "( Hi doc, I honder...)", "Smith' Lab test arrived yesterday.", "09:10AM" });
            listBox1.Location = new Point(42, 306);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(389, 104);
            listBox1.TabIndex = 5;
            // 
            // Mail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "Mail";
            Text = "HMS";
            Load += Mail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private ListBox listBox1;
    }
}