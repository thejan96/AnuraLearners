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

        private void txtCustomerId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerId.Text.Length == 10)
                {
                    db = new DbConnection();
                    Customer c = new Customer();
                    Payment p = new Payment();
                    c = db.getCustomerDetails(txtCustomerId.Text, 1);
                    db.closeCon();
                    txtCustomerName.Text = c.customerName.ToString();

                   
                    p = db.getDetails(txtCustomerId.Text, 1);
                    db.closeCon();

                    lblRegistrationDate.Text = c.RegDate.ToShortDateString();
                    txtCustomerId.Focus();
                    lblFullPayment.Text = p.FullPayment.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter a correct ID No.", "Lenght Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerName.Text.Length > 3)
                {
                    db = new DbConnection();
                    Customer c = new Customer();
                    Payment p = new Payment();
                    c = db.getCustomerDetails(txtCustomerName.Text, 2);
                    txtCustomerId.Text = c.customerID.ToString();
                    db.closeCon();
                    p = db.getDetails(txtCustomerId.Text, 1);
                    db.closeCon();
                    
                    lblRegistrationDate.Text = c.RegDate.ToShortDateString();
                    txtCustomerId.Focus();
                    lblFullPayment.Text = p.FullPayment.ToString();



                }
            }
        }
    }
}
