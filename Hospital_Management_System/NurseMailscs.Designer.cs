namespace Hospital_Management_System
{
    partial class NurseMailscs
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(145, 32);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 0;
            label1.Text = "Mails";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "7:20AM", "Dr. Smith sent you a mail.", "9:45AM", "Allam sent you a mail.", "10:55AM", "The lab test are done." });
            listBox1.Location = new Point(35, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(309, 144);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(214, 385);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 350);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 3;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 304);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 110);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 281);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Write a mail";
            // 
            // NurseMailscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "NurseMailscs";
            Text = "HMS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
    }
}