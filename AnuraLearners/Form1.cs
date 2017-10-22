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
    public partial class frmFirstPayment : Form
    {
        public frmFirstPayment()
        {
            InitializeComponent();
        }
        DbConnection db;


        private void frmFirstPayment_Load(object sender, EventArgs e)
        {
            db = new DbConnection();
            AutoCompleteStringCollection idlist = new AutoCompleteStringCollection();
            idlist = db.autoload(1);
            txtCustomerId.AutoCompleteCustomSource = idlist;
            AutoCompleteStringCollection namelist = db.autoload(2);
            namelist = db.autoload(2);
            txtCustomerName.AutoCompleteCustomSource = namelist;
            lblPaymentDate.Text = DateTime.Today.Date.ToShortDateString();
        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db = new DbConnection();
            Payment p1 = new Payment();
            p1.CustomerId = txtCustomerId.Text;
            p1.FirstPayment = Int32.Parse(txtFirstPayment.Text);
            p1.FirstPaymentDate =Convert.ToDateTime( DateTime.Today.ToShortDateString());
            int ret = db.addFirstPayment(p1);
            if (ret==1)
            {
                MessageBox.Show("Successfully Payed");
            }
            else
            {
                MessageBox.Show("Payment Unsuccessful");
            }
        }

        private void txtCustomerId_Enter(object sender, EventArgs e)
        {
           
            
        }
    }
}
