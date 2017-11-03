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
    public partial class Trials : Form
    {

        DbConnection db = new DbConnection();
        Customer c = new Customer();

        Trial trl = new Trial();
        public Trials()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            trl.customerID = (txtCustomerID.Text).ToString();

            trl.trialDate = dtpTrialDate.Value;

          

            string cusid = txtCustomerID.Text;

            if (cusid == "")
            {
                MessageBox.Show("Enter NIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Focus();

            }


            else
            {

                if ((cusid.Count(char.IsDigit) == 9) &&
                cusid.EndsWith("V", StringComparison.OrdinalIgnoreCase))
                {


                }

                else
                {

                    MessageBox.Show("Wrong NIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerID.Focus();

                }

            }

           

               int i = db.NewTrial(trl);

                if (i > 0)
                {

                    MessageBox.Show("Trial Data Saved Succefully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    trl.customerID = (txtCustomerID.Text).ToString();

                    trl = db.getTrial(trl);


                    txtCustomerID.Text = c.customerID.ToString();
                    txtCustomerName.Text = c.customerName.ToString();
                    dtpTrialDate.Value = trl.trialDate;
                }

            }
        }

        private void txtCustomerID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerID.Text.Length == 10)
                {
                    db = new DbConnection();


                    

                    c = db.getCustomerDetails(txtCustomerID.Text, 1);
                    db.closeCon();

                    trl.customerID = (txtCustomerID.Text).ToString();

                    trl = db.getTrial(trl);


                    txtCustomerID.Text = c.customerID.ToString();
                    txtCustomerName.Text = c.customerName.ToString();
                    dtpTrialDate.Value = trl.trialDate;



                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            trl.customerID = (txtCustomerID.Text).ToString();
            trl.trialDate = dtpTrialDate.Value;
           

            string cusid = txtCustomerID.Text;

            if (cusid == "")
            {
                MessageBox.Show("Enter NIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Focus();

            }


            else
            {

                if ((cusid.Count(char.IsDigit) == 9) &&
                cusid.EndsWith("V", StringComparison.OrdinalIgnoreCase))
                {


                }

                else
                {

                    MessageBox.Show("Wrong NIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerID.Focus();

                }

            }

           

                int i = db.UpdateTrial(trl);

                if (i > 0)
                {

                    MessageBox.Show("Exam Data Updated Succefully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }
    }

