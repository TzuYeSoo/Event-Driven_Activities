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
    public partial class NewServing : Form
    {
        public NewServing()
        {
            InitializeComponent();
        }

        public void NewServing_Load(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count != 0)
            {
                newServ.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                newServ.Text = "<Number>";
            }
        }
    }
}
