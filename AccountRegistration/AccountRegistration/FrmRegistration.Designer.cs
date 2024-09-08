namespace AccountRegistration
{
    partial class NextButton
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
            StNumBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ProgBox = new ComboBox();
            lnameBox = new TextBox();
            fnameBox = new TextBox();
            MnameBox = new TextBox();
            Address = new TextBox();
            label6 = new Label();
            label7 = new Label();
            AgeBox = new TextBox();
            ContactBox = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // StNumBox
            // 
            StNumBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StNumBox.Location = new Point(43, 75);
            StNumBox.Name = "StNumBox";
            StNumBox.Size = new Size(264, 39);
            StNumBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 38);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 1;
            label1.Text = "Student Number:\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(390, 515);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Next\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 38);
            label2.Name = "label2";
            label2.Size = new Size(90, 50);
            label2.TabIndex = 3;
            label2.Text = "Program: \r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 132);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 4;
            label3.Text = "Last Name:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 132);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 5;
            label4.Text = "First Name:\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 132);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 6;
            label5.Text = "Middle Name: \r\n";
            // 
            // ProgBox
            // 
            ProgBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProgBox.FormattingEnabled = true;
            ProgBox.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science", "BS in Computer Engineer", "BS in Information System", "BS in Multimedia Arts" });
            ProgBox.Location = new Point(317, 75);
            ProgBox.Name = "ProgBox";
            ProgBox.Size = new Size(306, 40);
            ProgBox.TabIndex = 7;
            // 
            // lnameBox
            // 
            lnameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnameBox.Location = new Point(43, 160);
            lnameBox.Name = "lnameBox";
            lnameBox.Size = new Size(264, 39);
            lnameBox.TabIndex = 8;
            // 
            // fnameBox
            // 
            fnameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fnameBox.Location = new Point(317, 160);
            fnameBox.Name = "fnameBox";
            fnameBox.Size = new Size(264, 39);
            fnameBox.TabIndex = 9;
            // 
            // MnameBox
            // 
            MnameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MnameBox.Location = new Point(587, 160);
            MnameBox.Name = "MnameBox";
            MnameBox.Size = new Size(264, 39);
            MnameBox.TabIndex = 10;
            // 
            // Address
            // 
            Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Address.Location = new Point(41, 328);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.Size = new Size(808, 181);
            Address.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 300);
            label6.Name = "label6";
            label6.Size = new Size(81, 50);
            label6.TabIndex = 12;
            label6.Text = "Address:\r\n\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 217);
            label7.Name = "label7";
            label7.Size = new Size(48, 25);
            label7.TabIndex = 13;
            label7.Text = "Age:\r\n";
            // 
            // AgeBox
            // 
            AgeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgeBox.Location = new Point(43, 245);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(264, 39);
            AgeBox.TabIndex = 14;
            // 
            // ContactBox
            // 
            ContactBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactBox.Location = new Point(317, 245);
            ContactBox.Name = "ContactBox";
            ContactBox.Size = new Size(264, 39);
            ContactBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(317, 217);
            label8.Name = "label8";
            label8.Size = new Size(106, 25);
            label8.TabIndex = 16;
            label8.Text = "Contact No:\r\n";
            // 
            // NextButton
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 581);
            Controls.Add(label8);
            Controls.Add(ContactBox);
            Controls.Add(AgeBox);
            Controls.Add(label7);
            Controls.Add(Address);
            Controls.Add(MnameBox);
            Controls.Add(fnameBox);
            Controls.Add(lnameBox);
            Controls.Add(ProgBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(StNumBox);
            Controls.Add(label6);
            Name = "NextButton";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StNumBox;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox ProgBox;
        private TextBox lnameBox;
        private TextBox fnameBox;
        private TextBox MnameBox;
        private TextBox Address;
        private Label label6;
        private Label label7;
        private TextBox AgeBox;
        private TextBox ContactBox;
        private Label label8;
    }
}
