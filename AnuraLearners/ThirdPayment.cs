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
        DbConnection db;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db = new DbConnection();
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

        private void frmThirdPayment_Load(object sender, EventArgs e)
        {
            

        }

        private void txtCustomerId_Leave(object sender, EventArgs e)
        {
            db = new DbConnection();
            Payment x = new Payment();
            x = db.getDetails(txtCustomerId.Text, 1);
            txtFirstPayment.Text = x.FirstPayment.ToString();
            txtSecondPayement.Text = x.SecoundPayment.ToString();
            txtPaymentDate.Text = x.FirstPaymentDate.ToShortDateString();
            txtSecondPaymentDate.Text = x.SecoundPaymentDate.ToShortDateString();
        }
    }
}
