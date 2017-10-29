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
        float fullPayment = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstPayment.Text != "")
            {
                try
                {
                    if (txtSecondPayment.Text != "" && int.Parse(txtSecondPayment.Text) > 0 && txtSecondPayment.Text != "0")
                    {
                        if (int.Parse(txtSecondPayment.Text) < int.Parse(txtRestPayment.Text))
                        {
                            db = new DbConnection();
                            Payment p1 = new Payment();
                            p1.CustomerId = txtCustomerId.Text;
                            p1.SecoundPayment = float.Parse(txtSecondPayment.Text);
                            p1.SecoundPaymentDate = Convert.ToDateTime(DateTime.Today.ToShortDateString());
                            float RestPayement = fullPayment - float.Parse(txtSecondPayment.Text);
                            int ret = db.addSecondPayment(p1);
                            if (ret == 1)
                            {
                                MessageBox.Show("Successfully Payed");
                                clearAllFields();

                            }
                            else
                            {
                                MessageBox.Show("Payment Unsuccessful");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Second Payment Must be Lesser than Full Payment");
                            txtFirstPayment.Focus();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Second Payment must have a value greater than 0");
                        txtFirstPayment.Focus();
                    }
                }
                catch (FormatException)
                {

                    MessageBox.Show("Payment Value must be a Number");
                    txtFirstPayment.Text = "";
                    txtFirstPayment.Focus();
                }


            }
            else
            {
                MessageBox.Show("Customer is not Valid. Please Enter a valid Customer Name/ID");
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
            txtSecondPaymentDate.Text = DateTime.Today.Date.ToShortDateString();
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
                    try
                    {
                        txtCustomerName.Text = c.customerName.ToString();


                        p = db.getDetails(txtCustomerId.Text, 2);
                        if (p.SecoundPayment > 0)
                        {
                            MessageBox.Show("Second Payment is already Settled with : Rs." + p.SecoundPayment.ToString() + "/=");
                            clearAllFields();
                        }
                        else
                        {
                            if (p.FirstPayment == 0)
                            {
                                MessageBox.Show("Please Enter as First Payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                frmFirstPayment f = new frmFirstPayment();
                                f.Show();
                            }
                            else
                            {
                                fullPayment = p.FullPayment;
                                txtFirstPayment.Text = p.FirstPayment.ToString();
                                txtPaymentDate.Text = p.FirstPaymentDate.ToShortDateString();
                                txtRestPayment.Text = Convert.ToString(Convert.ToSingle(p.FullPayment) - Convert.ToSingle(p.FirstPayment));
                                txtSecondPayment.Focus();
                            }
                            if (txtRestPayment.Text == "0")
                            {
                                MessageBox.Show("Full Payment is Complete for this Customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearAllFields();
                                txtCustomerId.Focus();
                            }
                            
                        }
                    }
                    catch (NullReferenceException)
                    {

                        MessageBox.Show("Please Enter a correct ID No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearAllFields();
                        txtCustomerId.Focus();

                    }
                    


                }
                else
                {
                    MessageBox.Show("Please Enter a correct ID No.", "Lenght Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearAllFields();
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
            txtRestPayment.Text = "";

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
                    try
                    {
                        txtCustomerId.Text = c.customerID.ToString();

                        p = db.getDetails(txtCustomerId.Text, 2);
                        if (p.SecoundPayment > 0)
                        {
                            MessageBox.Show("Second Payment is already Settled with : Rs." + p.SecoundPayment.ToString() + "/=");
                            clearAllFields();
                        }
                        else
                        {
                            if (p.FirstPayment == 0)
                            {
                                MessageBox.Show("Please Enter as First Payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                frmFirstPayment f = new frmFirstPayment();
                                f.Show();
                            }
                            else
                            {
                                fullPayment = p.FullPayment;
                                txtFirstPayment.Text = p.FirstPayment.ToString();
                                txtPaymentDate.Text = p.FirstPaymentDate.ToShortDateString();
                                txtRestPayment.Text = Convert.ToString(Convert.ToSingle(p.FullPayment) - Convert.ToSingle(p.FirstPayment));
                                txtSecondPayment.Focus();
                            }
                            

                            if (txtRestPayment.Text == "0")
                            {
                                MessageBox.Show("Full Payment is Complete for this Customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearAllFields();
                                txtCustomerName.Focus();
                            }
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Please Enter a Valid Customer ID/Name");
                        clearAllFields();
                        txtCustomerName.Focus();

                    }
               
                }
                else
                {
                    MessageBox.Show("Please Enter a correct ID No.", "Lenght Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearAllFields();
                }
            }
        }
    }
}
