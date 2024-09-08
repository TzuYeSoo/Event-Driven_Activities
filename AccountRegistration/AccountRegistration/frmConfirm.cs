using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class frmConfirm : Form
    {
        private StudentInfoClass.DelegateNumber DelAge, DelContact, DelStudNo;
        private StudentInfoClass.Delegatetext DelLname, DelFname, DelMname, DelAddress, DelProg;
        public frmConfirm()
        {
            InitializeComponent();

            DelAddress = new StudentInfoClass.Delegatetext(StudentInfoClass.GetAddress);
            DelProg = new StudentInfoClass.Delegatetext(StudentInfoClass.GetProgram);
            DelLname = new StudentInfoClass.Delegatetext(StudentInfoClass.GetLastName);
            DelFname = new StudentInfoClass.Delegatetext(StudentInfoClass.GetFirstName);
            DelMname = new StudentInfoClass.Delegatetext(StudentInfoClass.GetMiddletName);

            DelAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStundentNo);
            DelContact = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            lnamelbl.Text = DelLname(StudentInfoClass.LastName).ToString();
            fnamelbl.Text = DelFname(StudentInfoClass.FirstName).ToString();
            mnamelbl.Text = DelMname(StudentInfoClass.MiddleName).ToString();
            Addresslbl.Text = DelAddress(StudentInfoClass.Address).ToString();
            proglbl.Text = DelLname(StudentInfoClass.Program).ToString();

            Agelbl.Text = DelAge(StudentInfoClass.Age).ToString();
            Addresslbl.Text = DelContact(StudentInfoClass.ContactNo).ToString();
            stnolbl.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();

        }

        private void ConfirmBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
