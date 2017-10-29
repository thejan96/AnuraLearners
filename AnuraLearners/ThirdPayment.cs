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
        float fullPayment = 0;
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
                    Payment p = new Payment();
                    Customer c = new Customer();
                    c = db.getCustomerDetails(txtCustomerId.Text, 1);

                    try
                    {
                        txtCustomerName.Text = c.customerName.ToString();


                        p = db.getDetails(txtCustomerId.Text, 3);
                        if (p.ThirdPayment > 0)
                        {
                            MessageBox.Show("Full Payment is already Settled with : Rs." + p.FullPayment.ToString() + "/=");
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
                            else if (p.SecoundPayment == 0)
                            {
                                MessageBox.Show("Please Enter as Second Payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                frmSecondPayment f1 = new frmSecondPayment();
                                f1.Show();
                            }
                            else
                            {
                                fullPayment = p.FullPayment;
                                txtFirstPayment.Text = p.FirstPayment.ToString();
                                txtPaymentDate.Text = p.FirstPaymentDate.ToShortDateString();
                                txtSecondPayement.Text = p.SecoundPayment.ToString();
                                txtSecondPaymentDate.Text = p.SecoundPaymentDate.ToShortDateString();
                                txtFullPayment.Text = p.FullPayment.ToString();
                                txtThirdPayment.Text = Convert.ToString(Convert.ToSingle(p.FullPayment) - (Convert.ToSingle(p.FirstPayment) + Convert.ToSingle(p.SecoundPayment)));
                                txtThirdPayment.Focus();
                            }
                            if (txtThirdPayment.Text == "0")
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
                    MessageBox.Show("Please Enter a correct ID No.","Lenght Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void clearAllFields()
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtFirstPayment.Text = "";
            txtPaymentDate.Text = "";
            txtSecondPayement.Text = "";
            txtSecondPaymentDate.Text = "";
            txtFirstPayment.Text = "";
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


                        p = db.getDetails(txtCustomerId.Text, 3);
                        if (p.ThirdPayment > 0)
                        {
                            MessageBox.Show("Full Payment is already Settled with : Rs." + p.FullPayment.ToString() + "/=");
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
                            else if (p.SecoundPayment == 0)
                            {
                                MessageBox.Show("Please Enter as Second Payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                frmSecondPayment f1 = new frmSecondPayment();
                                f1.Show();
                            }
                            else
                            {
                                fullPayment = p.FullPayment;
                                txtFirstPayment.Text = p.FirstPayment.ToString();
                                txtPaymentDate.Text = p.FirstPaymentDate.ToShortDateString();
                                txtSecondPayement.Text = p.SecoundPayment.ToString();
                                txtSecondPaymentDate.Text = p.SecoundPaymentDate.ToShortDateString();
                                txtFullPayment.Text = p.FullPayment.ToString();
                                txtThirdPayment.Text = Convert.ToString(Convert.ToSingle(p.FullPayment) - (Convert.ToSingle(p.FirstPayment) + Convert.ToSingle(p.SecoundPayment)));
                                txtThirdPayment.Focus();
                            }
                            if (txtThirdPayment.Text == "0")
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
            }
        }
    }
}
