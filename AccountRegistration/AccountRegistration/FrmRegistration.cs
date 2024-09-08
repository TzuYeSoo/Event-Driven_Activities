namespace AccountRegistration
{
    public partial class NextButton : Form
    {
        public NextButton()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.GetProgram(ProgBox.Text);
            StudentInfoClass.GetFirstName(fnameBox.Text);
            StudentInfoClass.GetLastName(lnameBox.Text);
            StudentInfoClass.GetMiddletName(MnameBox.Text);
            StudentInfoClass.GetStundentNo(Convert.ToInt64(StNumBox.Text));
            StudentInfoClass.GetAddress(Address.Text);
            StudentInfoClass.GetAge(Convert.ToInt64(AgeBox.Text));
            StudentInfoClass.GetContactNo(Convert.ToInt64(ContactBox.Text));

            frmConfirm confirm = new frmConfirm();

            if (confirm.ShowDialog() == DialogResult.OK)
            {
                ProgBox.SelectedIndex = -1;
                fnameBox.Clear();
                lnameBox.Clear();
                MnameBox.Clear();
                AgeBox.Clear();
                ContactBox.Clear();
                Address.Clear();
                StNumBox.Clear();

            }

        }
    }
}
