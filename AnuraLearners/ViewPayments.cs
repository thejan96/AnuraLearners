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
    public partial class ViewPayments : Form
    {
        public ViewPayments()
        {
            InitializeComponent();
        }
        DbConnection db;
        private void ViewPayments_Load(object sender, EventArgs e)
        {
            db = new DbConnection();
            AutoCompleteStringCollection idlist = new AutoCompleteStringCollection();
            idlist = db.autoload(1);
            txtCustomerId.AutoCompleteCustomSource = idlist;
            AutoCompleteStringCollection namelist = db.autoload(2);
            namelist = db.autoload(2);
            txtCustomerName.AutoCompleteCustomSource = namelist;
        }

        private void txtCustomerId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerId.Text.Length == 10)
                {
                    db = new DbConnection();
                    Payment p = new Payment();
                    Customer c = new Customer();
                    c = db.getCustomerDetails(txtCustomerId.Text, 1);

                    try
                    {
                        txtCustomerName.Text = c.customerName.ToString();


                        p = db.getDetails(txtCustomerId.Text, 4);

                        //fullPayment = p.FullPayment;
                        txtFirstPayment.Text = p.FirstPayment.ToString();
                        txtFirstPayementDate.Text = p.FirstPaymentDate.ToShortDateString();
                        txtSecondPayment.Text = p.SecoundPayment.ToString();
                        txtSecondPaymentDate.Text = p.SecoundPaymentDate.ToShortDateString();
                        txtFullPayment.Text = p.FullPayment.ToString();
                        txtThirdPayment.Text = p.ThirdPayment.ToString();
                        txtThirdPaymentDate.Text = p.ThirdPaymentDate.ToShortDateString();
                        //txtThirdPayment.Focus();
                    }
                    catch (NullReferenceException)
                    {

                        MessageBox.Show("Please Enter a correct ID No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCustomerId.Focus();

                    }


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
                    Payment p = new Payment();
                    Customer c = new Customer();
                    c = db.getCustomerDetails(txtCustomerName.Text, 2);

                    try
                    {
                        txtCustomerId.Text = c.customerID.ToString();


                        p = db.getDetails(txtCustomerId.Text, 4);

                        //fullPayment = p.FullPayment;
                        txtFirstPayment.Text = p.FirstPayment.ToString();
                        txtFirstPayementDate.Text = p.FirstPaymentDate.ToShortDateString();
                        txtSecondPayment.Text = p.SecoundPayment.ToString();
                        txtSecondPaymentDate.Text = p.SecoundPaymentDate.ToShortDateString();
                        txtFullPayment.Text = p.FullPayment.ToString();
                        txtThirdPayment.Text = p.ThirdPayment.ToString();
                        txtThirdPaymentDate.Text = p.ThirdPaymentDate.ToShortDateString();
                        //txtThirdPayment.Focus();
                    }
                    catch (NullReferenceException)
                    {

                        MessageBox.Show("Please Enter a correct ID No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCustomerId.Focus();

                    }


                }
                else
                {
                    MessageBox.Show("Please Enter a correct ID No.", "Lenght Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
