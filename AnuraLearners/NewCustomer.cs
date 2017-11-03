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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }


        DbConnection db = new DbConnection();

        public string lic, trinee, bike, van, thrw;

        public int bikeamt;
        public int vanamt;
        public int weelamt;
        public int traineeamt;
       
        public static int  fullAmount;

        Customer cus = new Customer();

        Payment pay = new Payment();

        Amount amt = new Amount();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          

            cus.customerID = (txtCustomerID.Text).ToString();

            pay.CustomerId = (txtCustomerID.Text).ToString();

            cus.customerName = txtCustomerName.Text;

            cus.customerAdd = rtxtCustomerAddress.Text;

            cus.customerTele = (txtCustomerTelephone.Text).ToString();

            cus.RegDate = Convert.ToDateTime(DateTime.Today.ToShortDateString());

            cus.lic = lic;

            cus.trainee = trinee;

            cus.licBike = bike;

            cus.licThreewl = thrw;

            cus.licVan = van;

            pay.FullPayment = fullAmount;

            if (cus.customerName == "")
            {

                MessageBox.Show("Please Enter The Customer Name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

            else if (cus.customerTele == "")
            {
                MessageBox.Show("Please Enter The Customer Telephone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if ((txtCustomerTelephone.Text).Count(Char.IsDigit) != 10)
            {

                MessageBox.Show("Please Enter a Correct Customer Telephone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (cus.customerAdd == "")

            {

                MessageBox.Show("Please Enter The Customer Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (pay.FullPayment == 0)
            {

                MessageBox.Show("Please Select a Licen Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (cmbxLicen.SelectedIndex < 0)
            {

                MessageBox.Show("Please Select  Licen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (cmbxTrainee.SelectedIndex < 0)
            {

                MessageBox.Show("Please Select Trainee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else {

                int i = db.newCustomer(cus);

                int j = db.newPayment(pay);

                if (i > 0 && j > 0)
                {

                    MessageBox.Show("Customer Data Saved Succefully","Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
     
            }

        

        }

        private void cmbxLicen_SelectedIndexChanged(object sender, EventArgs e)
        {

            lic = cmbxLicen.Text;

            if (lic == "Yes")
            {

                traineeamt = db.getTraineeAmount();

                fullAmount = fullAmount + traineeamt;



            }
            else if (lic == "No")
            {

                traineeamt = db.getTraineeAmount();

                fullAmount = fullAmount - traineeamt;

            }

        }

       

        private void cmbxTrainee_SelectedIndexChanged(object sender, EventArgs e)
        {
            trinee = cmbxTrainee.Text;
        }

        private void lblTrainee_Click(object sender, EventArgs e)
        {

        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
          lblRegistrationDate.Text = DateTime.Today.Date.ToShortDateString();
        }

        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
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


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtFullPayment.Text = "";
            txtCustomerTelephone.Text = "";
            rtxtCustomerAddress.Text = "";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chkbxBike_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxBike.Checked == true)
            {

                bike = chkbxBike.Text;

                int bikeamt = db.getBikeAmount();

                fullAmount = fullAmount + bikeamt;

            }
            else if (chkbxBike.Checked == false)
            {

                int bikeamt = db.getBikeAmount();

                fullAmount = fullAmount - bikeamt;

            }

        }

        private void chkbxVanCar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxVanCar.Checked == true)
            {

                van = chkbxVanCar.Text;

                int vanamt = db.getVanAmount();

                fullAmount = fullAmount + vanamt;

            }

            else if(chkbxVanCar.Checked == false)
            {

                int vanamt = db.getVanAmount();

                fullAmount = fullAmount - vanamt;


            }

        }

        private void chkbxThreewheel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxThreewheel.Checked == true)
            {

                thrw = chkbxThreewheel.Text;

                int weelamt = db.getWeelAmount();

                fullAmount = fullAmount + weelamt;

            }

            else if (chkbxThreewheel.Checked == false)
            {

                int weelamt = db.getWeelAmount();

                fullAmount = fullAmount - weelamt;


            }
        }

        private void txtFullPayment_Enter(object sender, EventArgs e)
        {

            txtFullPayment.Text = fullAmount.ToString();

        }

    }
}
