namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            num1 = new TextBox();
            Computebtn = new Button();
            label1 = new Label();
            num2 = new TextBox();
            operators = new ComboBox();
            Answer = new TextBox();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num1.Location = new Point(56, 72);
            num1.Name = "num1";
            num1.Size = new Size(167, 34);
            num1.TabIndex = 0;
            // 
            // Computebtn
            // 
            Computebtn.Location = new Point(95, 254);
            Computebtn.Name = "Computebtn";
            Computebtn.Size = new Size(98, 23);
            Computebtn.TabIndex = 1;
            Computebtn.Text = "Compute";
            Computebtn.UseVisualStyleBackColor = true;
            Computebtn.Click += Computebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 28);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 2;
            label1.Text = "Basic Calculator";
            // 
            // num2
            // 
            num2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num2.Location = new Point(56, 141);
            num2.Name = "num2";
            num2.Size = new Size(167, 34);
            num2.TabIndex = 3;
            // 
            // operators
            // 
            operators.FormattingEnabled = true;
            operators.Location = new Point(116, 112);
            operators.Name = "operators";
            operators.Size = new Size(48, 23);
            operators.TabIndex = 4;
            // 
            // Answer
            // 
            Answer.BackColor = Color.Black;
            Answer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Answer.ForeColor = Color.Lime;
            Answer.Location = new Point(56, 185);
            Answer.Multiline = true;
            Answer.Name = "Answer";
            Answer.Size = new Size(167, 63);
            Answer.TabIndex = 5;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 314);
            Controls.Add(Answer);
            Controls.Add(operators);
            Controls.Add(num2);
            Controls.Add(label1);
            Controls.Add(Computebtn);
            Controls.Add(num1);
            Name = "FrmBasicCalculator";
            Text = "FrmBasicCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1;
        private Button Computebtn;
        private Label label1;
        private TextBox num2;
        private ComboBox operators;
        private TextBox Answer;
    }
}
