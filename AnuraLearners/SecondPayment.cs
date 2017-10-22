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
    public partial class frmSecondPayment : Form
    {
        public frmSecondPayment()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            Payment p1 = new Payment();
            p1.CustomerId = txtCustomerId.Text;
            p1.SecoundPayment = Int32.Parse(txtSecondPayment.Text);
            p1.SecoundPaymentDate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
            int ret = db.addSecondPayment(p1);
            if (ret == 1)
            {
                MessageBox.Show("Successfully Payed");
                db.closeCon();
            }
            else
            {
                MessageBox.Show("Payment Unsuccessful");
            }
        }

        private void frmSecondPayment_Load(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            AutoCompleteStringCollection idlist = db.autoload(1);
            AutoCompleteStringCollection namelist = db.autoload(2);
            txtCustomerId.AutoCompleteCustomSource = idlist;
            txtCustomerName.AutoCompleteCustomSource = namelist;
        }
    }
}
