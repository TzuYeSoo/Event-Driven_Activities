using CalculatorPrivateAssembly1;
namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
            operators.Items.Add("+");
            operators.Items.Add("-");
            operators.Items.Add("/");
            operators.Items.Add("*");
            Answer.Text = "Total: 00000";
            Answer.ReadOnly = true;
        }

        private void Computebtn_Click(object sender, EventArgs e)
        {
            switch (operators.SelectedItem)
            {
                case "+":
                    
                    Answer.Text = "Total: \n" + BasicComputation.Addition(Convert.ToInt64(num1.Text), Convert.ToInt64(num2.Text));
                    break;

                case "-":
                    
                    Answer.Text = "Total: \n" + BasicComputation.Subtraction(Convert.ToInt64(num1.Text), Convert.ToInt64(num2.Text));
                    break;

                case "/":
                    Answer.Text = "Total: \n" + BasicComputation.Division(Convert.ToInt64(num1.Text), Convert.ToInt64(num2.Text));
                    break;

                case "*":
                    Answer.Text = "Total: \n" + BasicComputation.Multiplication(Convert.ToInt64(num1.Text), Convert.ToInt64(num2.Text)); ;
                    break;
            }
        }
    }
}
