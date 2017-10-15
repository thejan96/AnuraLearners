using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnuraLearners
{
    public partial class frmThirdPayment : Form
    {
        public frmThirdPayment()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            Payment p1 = new Payment();
            p1.CustomerId = txtCustomerId.Text;
            p1.ThirdPayment  = Int32.Parse(txtThirdPayment.Text);
            p1.ThirdPaymentDate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
            int ret = db.addThirdPayment(p1);
            if (ret == 1)
            {
                MessageBox.Show("Successfully Payed");
                db.closeCon();
            }
            else
            {
                MessageBox.Show("Payment Unsuccessful");
            }
            db.closeCon();
        }
    }
}
