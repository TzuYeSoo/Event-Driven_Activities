using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingSystem
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        private CashierWindowQueueForm cashierwindowQueueForm;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            

            CashierWindowQueueForm cash = new CashierWindowQueueForm();
            cash.Show();
            NewServing serving = new NewServing();
            serving.Show();

            Timer timer = new Timer();
            timer.Interval = (1 * 500); // .5 sec.
            timer.Tick += new EventHandler(cash.btnRefresh_Click);
            timer.Tick += new EventHandler(serving.NewServing_Load);
            timer.Start();

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

    }
}
