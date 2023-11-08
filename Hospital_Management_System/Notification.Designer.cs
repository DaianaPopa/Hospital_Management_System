namespace Hospital_Management_System
{
    partial class Notification
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
            button2 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            lblNew = new Label();
            lblYesterday = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(135, 71);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "Notifications";
            // 
            // button2
            // 
            button2.Location = new Point(276, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.ForeColor = SystemColors.ActiveCaptionText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Dele Houstan sent you a mail.", "11:30AM", " Joan, Dylan visit the hospital page.", "10:20AM", "" });
            listBox1.Location = new Point(37, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(313, 124);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Items.AddRange(new object[] { "Peter Thiel send you the report.", "9:45AM", "Chriss Sacca send you a mail.", "8:53AM", "M. Andreessen send you a mail.", "7:13PM" });
            listBox2.Location = new Point(37, 314);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(313, 124);
            listBox2.TabIndex = 4;
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNew.ForeColor = Color.Red;
            lblNew.Location = new Point(37, 118);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(43, 20);
            lblNew.TabIndex = 5;
            lblNew.Text = "NEW";
            // 
            // lblYesterday
            // 
            lblYesterday.AutoSize = true;
            lblYesterday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblYesterday.Location = new Point(37, 291);
            lblYesterday.Name = "lblYesterday";
            lblYesterday.Size = new Size(75, 20);
            lblYesterday.TabIndex = 6;
            lblYesterday.Text = "Yesterday";
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 453);
            Controls.Add(lblYesterday);
            Controls.Add(lblNew);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "Notification";
            Text = "HMS";
            Load += Notification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label lblNew;
        private Label lblYesterday;
    }
}