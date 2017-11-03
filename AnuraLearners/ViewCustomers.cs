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
    public partial class ViewCustomers : Form
    {
        DbConnection db;

        public ViewCustomers()
        {
            InitializeComponent();
        }


        public string lic, trinee, bike, van, thrw;

        public int bikeamt;
        public int vanamt;
        public int weelamt;
        public int traineeamt;

        public static int fullAmount;

        Customer cus = new Customer();

        Payment pay = new Payment();

        Amount amt = new Amount();

        private void btnEdit_Click(object sender, EventArgs e)
        {

            txtFullPayment.ReadOnly = false;
            txtLicenCategoary.ReadOnly = false;
            txtTelephoneNumber.ReadOnly = false;
            rchtxtCustomerAddress.ReadOnly = false;

        }
   
        private void cmbxTrainee_SelectedIndexChanged(object sender, EventArgs e)
        {
            trinee = cmbxTrainee.Text;
        }

        private void ViewCustomers_Load_1(object sender, EventArgs e)
        {

           


            txtFullPayment.ReadOnly = true;
            txtLicenCategoary.ReadOnly = true;
            txtTelephoneNumber.ReadOnly = true;
            rchtxtCustomerAddress.ReadOnly = true;


            db = new DbConnection();
            AutoCompleteStringCollection idlst = new AutoCompleteStringCollection();
            idlst = db.autoload(1);
            txtCustomerID.AutoCompleteCustomSource = idlst;
            AutoCompleteStringCollection namelst = new AutoCompleteStringCollection();
            namelst = db.autoload(2);
            txtCustomerName.AutoCompleteCustomSource = namelst;

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            cus.customerID = (txtCustomerID.Text).ToString();

            pay.CustomerId = (txtCustomerID.Text).ToString();

            cus.customerName = txtCustomerName.Text;

            cus.customerAdd = rchtxtCustomerAddress.Text;

            cus.customerTele = (txtTelephoneNumber.Text).ToString();

            cus.RegDate = Convert.ToDateTime(DateTime.Today.ToShortDateString());

            cus.lic = lic;

            cus.trainee = trinee;

            cus.licBike = bike;

            cus.licThreewl = thrw;

            cus.licVan = van;

            pay.FullPayment = fullAmount;

            cus.lic = lic;

            cus.trainee = trinee;

            string cusid = txtCustomerID.Text;

            if (cusid == "")
            {
                MessageBox.Show("Enter NIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Focus();

            }


            else {

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


            if (cus.customerName == "")
            {

                MessageBox.Show("Please Enter The Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (cus.customerTele == "")
            {
                MessageBox.Show("Please Enter The Customer Telephone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if ((txtTelephoneNumber.Text).Count(Char.IsDigit) != 10)
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

                int i = db.UpdateCustomer(cus);

                int j = db.updatePayment(pay);

                if (i > 0 && j > 0)
                {

                    MessageBox.Show("Customer Data Updated Succeffully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        

        }

        private void txtCustomerID_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerID.Text.Length == 10)
                {
                    db = new DbConnection();

                    Payment p = new Payment();
                    Customer c = new Customer();

                    c = db.getCustomerDetails(txtCustomerID.Text, 1);
                    db.closeCon();

                    p = db.getDetails(txtCustomerID.Text, 1);
                    db.closeCon();

                    txtCustomerID.Text = c.customerID.ToString();
                    txtCustomerName.Text = c.customerName.ToString();
                    txtTelephoneNumber.Text = c.customerTele.ToString();
                    rchtxtCustomerAddress.Text = c.customerAdd.ToString();
                    txtFullPayment.Text = p.FullPayment.ToString();
                    cmbxLicen.Text = c.lic.ToString();
                    cmbxTrainee.Text = c.trainee.ToString();
                    lblRegistrationDate.Text = c.RegDate.ToShortDateString();


                    if (string.IsNullOrEmpty(c.licBike.ToString()) == false && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == false)
                    {
                        txtLicenCategoary.Text = "Light Vehicle";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == false && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "Bike/Van";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == false && string.IsNullOrEmpty(c.licVan.ToString()) == true && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "Bike";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == true && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "Van/ThreeWeel";

                    }
                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == true && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "ThreeWeel";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == false && string.IsNullOrEmpty(c.licVan.ToString()) == true && string.IsNullOrEmpty(c.licThreewl.ToString()) == false)
                    {
                        txtLicenCategoary.Text = "Bike/ThreeWeel";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == true && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "Van";

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
                    db.closeCon();

                    p = db.getDetails(txtCustomerName.Text, 2);
                    db.closeCon();

                    txtCustomerName.Text = c.customerName.ToString();
                    txtTelephoneNumber.Text = c.customerTele.ToString();
                    rchtxtCustomerAddress.Text = c.customerAdd.ToString();
                    txtFullPayment.Text = p.FullPayment.ToString();
                    cmbxLicen.Text = c.lic.ToString();
                    cmbxTrainee.Text = c.trainee.ToString();



                    if (string.IsNullOrEmpty(c.licBike.ToString()) == false && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == false)
                    {
                        txtLicenCategoary.Text = "Light Vehicle";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == false && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "Bike/Van";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == false && string.IsNullOrEmpty(c.licVan.ToString()) == true && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "Bike";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == true && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "Van/ThreeWeel";

                    }
                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == true && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "ThreeWeel";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == false && string.IsNullOrEmpty(c.licVan.ToString()) == true && string.IsNullOrEmpty(c.licThreewl.ToString()) == false)
                    {
                        txtLicenCategoary.Text = "Bike/ThreeWeel";

                    }

                    else if (string.IsNullOrEmpty(c.licBike.ToString()) == true && string.IsNullOrEmpty(c.licVan.ToString()) == false && string.IsNullOrEmpty(c.licThreewl.ToString()) == true)
                    {
                        txtLicenCategoary.Text = "Van";

                    }


                }
              
            }

        }

        private void txtCustomerID_Leave(object sender, EventArgs e)
        {

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

        private void cmbxTrainee_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            trinee = cmbxTrainee.Text;
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string cusid = (txtCustomerID.Text).ToString();

            if (cusid == "")
            {
                MessageBox.Show("Enter NIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Focus();

            }

            else {

                cus.customerID = (txtCustomerID.Text).ToString();

                pay.CustomerId = (txtCustomerID.Text).ToString();

                int i = db.delCustomer(cus);

                int j = db.delPayment(pay);

                if (i > 0 && j > 0)
                {

                    MessageBox.Show("Customer Deleted Succefully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }


            


        }

        private void txtFullPayment_Enter_1(object sender, EventArgs e)
        {
            txtFullPayment.Text = fullAmount.ToString();
        }

        private void chkbxThreewheel_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkbxThreewheel.Checked == true)
            {

                thrw = chkbxThreewheel.Text;

                int weelamt = db.getWeelAmount();

                fullAmount = fullAmount + weelamt;

            }

        }

        private void chkbxVanCar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkbxVanCar.Checked == true)
            {

                van = chkbxVanCar.Text;

                int vanamt = db.getVanAmount();

                fullAmount = fullAmount + vanamt;

            }

        }

        private void chkbxBike_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkbxBike.Checked == true)
            {

                bike = chkbxBike.Text;

                int bikeamt = db.getBikeAmount();

                fullAmount = fullAmount + bikeamt;

            }



        }

      
       


    }
}
