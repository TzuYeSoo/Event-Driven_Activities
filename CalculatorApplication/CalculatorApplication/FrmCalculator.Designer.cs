namespace CalculatorApplication
{
    partial class FrmCalculator
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
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            btnEqual = new Button();
            lblDisplayTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput1.Location = new Point(255, 64);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(261, 39);
            txtBoxInput1.TabIndex = 0;
            txtBoxInput1.TextChanged += txtBoxInput1_TextChanged;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput2.Location = new Point(255, 205);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(261, 39);
            txtBoxInput2.TabIndex = 1;
            txtBoxInput2.TextChanged += txtBoxInput2_TextChanged;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "/", "*", "+", "-" });
            cbOperator.Location = new Point(302, 130);
            cbOperator.Name = "cbOperator";
            cbOperator.RightToLeft = RightToLeft.No;
            cbOperator.Size = new Size(155, 36);
            cbOperator.TabIndex = 2;
            cbOperator.Text = "Operator";
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(284, 332);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(173, 34);
            btnEqual.TabIndex = 3;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(255, 276);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(250, 25);
            lblDisplayTotal.TabIndex = 4;
            lblDisplayTotal.Text = "__________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 71);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 5;
            label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 205);
            label2.Name = "label2";
            label2.Size = new Size(190, 25);
            label2.TabIndex = 6;
            label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 276);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 7;
            label3.Text = "Answer:";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 393);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDisplayTotal);
            Controls.Add(btnEqual);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            Load += FrmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Button btnEqual;
        private Label lblDisplayTotal;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
