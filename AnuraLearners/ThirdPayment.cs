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
            p1.ThirdPayment  = Int32.Parse(txtFullPayment.Text);
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
            db = new DbConnection();
            AutoCompleteStringCollection idlist = new AutoCompleteStringCollection();
            idlist = db.autoload(1);
            txtCustomerId.AutoCompleteCustomSource = idlist;
            AutoCompleteStringCollection namelist = db.autoload(2);
            namelist = db.autoload(2);
            txtCustomerName.AutoCompleteCustomSource = namelist;
            txtThirdPaymentDate.Text = DateTime.Today.Date.ToShortDateString();

        }

        private void txtCustomerId_Leave(object sender, EventArgs e)
        {
            
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
                    Payment x = new Payment();
                    Customer c = new Customer();
                    c = db.getCustomerDetails(txtCustomerId.Text, 1);
                    db.closeCon();
                    
                    x = db.getDetails(txtCustomerId.Text, 1);
                    db.closeCon();
                    txtCustomerName.Text = c.customerName.ToString();
                    txtFirstPayment.Text = x.FirstPayment.ToString();
                    txtSecondPayement.Text = x.SecoundPayment.ToString();
                    txtPaymentDate.Text = x.FirstPaymentDate.ToShortDateString();
                    txtSecondPaymentDate.Text = x.SecoundPaymentDate.ToShortDateString();
                    txtFullPayment.Text = x.FullPayment.ToString();
                    float fp = x.FirstPayment;
                    float sp = x.SecoundPayment;
                    float rp = x.FullPayment - (fp + sp);
                    txtThirdPayment.Text = rp.ToString();

                }
                else
                {
                    MessageBox.Show("Please Enter a correct ID No.","Lenght Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    c = db.getCustomerDetails(txtCustomerName.Text, 2);
                    db.closeCon();
                    txtCustomerId.Text = c.customerID.ToString();
                    txtCustomerId.Focus();


                }
            }
        }
    }
}
