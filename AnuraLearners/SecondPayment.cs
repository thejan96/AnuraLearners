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
        DbConnection db;
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
            db = new DbConnection();
            AutoCompleteStringCollection idlist = new AutoCompleteStringCollection();
            idlist = db.autoload(1);
            txtCustomerId.AutoCompleteCustomSource = idlist;
            AutoCompleteStringCollection namelist = db.autoload(2);
            namelist = db.autoload(2);
            txtCustomerName.AutoCompleteCustomSource = namelist;
            lblPaymentDate.Text = DateTime.Today.Date.ToShortDateString();
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
                    txtCustomerName.Text = c.customerName.ToString();


                    p = db.getDetails(txtCustomerId.Text, 2);
                    if (p.SecoundPayment > 0)
                    {
                        MessageBox.Show("Second Payment is already Settled with : Rs." + p.SecoundPayment.ToString() + "/=");
                        clearAllFields();
                    }
                    else
                    {
                        txtFirstPayment.Text = p.FirstPayment.ToString();
                        txtPaymentDate.Text = p.FirstPaymentDate.ToShortDateString();
                    }


                }
                else
                {
                    MessageBox.Show("Please Enter a correct ID No.", "Lenght Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void clearAllFields()
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtFirstPayment.Text = "";
            txtPaymentDate.Text = "";
            txtSecondPayment.Text = "";
            txtSecondPaymentDate.Text = "";
            txtRestPayment.Text = "";

        }
    }
}
