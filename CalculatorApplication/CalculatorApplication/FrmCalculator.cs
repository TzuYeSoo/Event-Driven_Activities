using System.Text.RegularExpressions;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass compute;
        public FrmCalculator()
        {

            InitializeComponent();

            compute = new CalculatorClass();

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {


            if (txtBoxInput1.Text == "")
            {
                MessageBox.Show("Please input Number in the First Number");
            }
            else if (txtBoxInput2.Text == "")
            {
                MessageBox.Show("Please input Number in the second Number");
            }
            else
            {
                double num1 = Convert.ToDouble(txtBoxInput1.Text);
                double num2 = Convert.ToDouble(txtBoxInput2.Text);

                if (cbOperator.SelectedItem.ToString().Equals("Operator"))
                {
                    MessageBox.Show("Please choose an operator first");

                }
                else if (cbOperator.SelectedItem.ToString().Equals("+"))
                {
                    compute.CalculateEvent += new Computation<double>(compute.getSum);
                    lblDisplayTotal.Text = compute.getSum(num1, num2).ToString();
                    compute.CalculateEvent -= new Computation<double>(compute.getSum);

                }
                else if (cbOperator.SelectedItem.ToString().Equals("/"))
                {
                    compute.CalculateEvent += new Computation<double>(compute.getQuotient);
                    lblDisplayTotal.Text = compute.getQuotient(num1, num2).ToString();
                    compute.CalculateEvent -= new Computation<double>(compute.getQuotient);

                }
                else if (cbOperator.SelectedItem.ToString().Equals("*"))
                {
                    compute.CalculateEvent += new Computation<double>(compute.getProduct);
                    lblDisplayTotal.Text = compute.getProduct(num1, num2).ToString();
                    compute.CalculateEvent -= new Computation<double>(compute.getProduct);

                }
                else if (cbOperator.SelectedItem.ToString().Equals("-"))
                {
                    compute.CalculateEvent += new Computation<double>(compute.getDifference);
                    lblDisplayTotal.Text = compute.getDifference(num1, num2).ToString();
                    compute.CalculateEvent -= new Computation<double>(compute.getDifference);

                }
                else
                {
                    MessageBox.Show("Select an Operator First");
                }


            }

        }

        private void txtBoxInput1_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(txtBoxInput1.Text, "^[0-9]+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                txtBoxInput1.Clear();
            }
        }

        private void txtBoxInput2_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(txtBoxInput2.Text, "^[0-9]+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                txtBoxInput2.Clear();
            }
        }
    }
}
