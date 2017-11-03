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
    public partial class Exams : Form
    {
        public Exams()
        {
            InitializeComponent();
        }

        Exam exm = new Exam();
        DbConnection db = new DbConnection();

        string exmtm;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            exm.customerID = (txtCustomerID.Text).ToString();
      
            exm.examDate = Convert.ToDateTime(DateTime.Today.ToShortDateString());

            exm.examTime = exmtm;

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

            if (cmbxExamTime.SelectedIndex < 0)
            {

                MessageBox.Show("Enter Exam Time");

            }

            else
            {
                int i = db.NewExam(exm);

                if (i > 0)
                {

                    MessageBox.Show("Exam Data Saved Succefully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }

           

        }

        private void cmbxExamTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            exmtm = cmbxExamTime.Text;
        }

        private void Exams_Load(object sender, EventArgs e)
        {
            db = new DbConnection();
            AutoCompleteStringCollection idlst = new AutoCompleteStringCollection();
            idlst = db.autoload(1);
            txtCustomerID.AutoCompleteCustomSource = idlst;
            AutoCompleteStringCollection namelst = new AutoCompleteStringCollection();
            namelst = db.autoload(2);
            txtCustomerName.AutoCompleteCustomSource = namelst;


        }

        private void txtCustomerID_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerName.Text = "";
            cmbxExamTime.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerID.Text.Length == 10)
                {
                    db = new DbConnection();

               
                    Customer c = new Customer();

                    Exam exm = new Exam();

                    c = db.getCustomerDetails(txtCustomerID.Text, 1);
                    db.closeCon();

                     exm.customerID = (txtCustomerID.Text).ToString();

                     exm = db.getExam(exm);


                    txtCustomerID.Text = c.customerID.ToString();
                    txtCustomerName.Text = c.customerName.ToString();
                    try
                    {
                        dtpExamDate.Value = exm.examDate;
                        if (exm.ExamTime == "8.30 AM")
                        {
                            cmbxExamTime.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbxExamTime.SelectedIndex = 1;
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                        dtpExamDate.Focus();
                    }


                }
              
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            txtCustomerID.Text = "";
            cmbxExamTime.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerName.Text.Length > 3)
                {

                    db = new DbConnection();
                    Customer c = new Customer();

                    c = db.getCustomerDetails(txtCustomerName.Text, 2);
                    db.closeCon();
                    txtCustomerID.Text = c.customerID.ToString();
                    exm.customerID = (txtCustomerID.Text).ToString();

                    exm = db.getExam(exm);


                    txtCustomerID.Text = c.customerID.ToString();
                    txtCustomerName.Text = c.customerName.ToString();
                    try
                    {
                        dtpExamDate.Value = exm.examDate;
                        if (exm.ExamTime == "8.30 AM")
                        {
                            cmbxExamTime.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbxExamTime.SelectedIndex = 1;
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                        dtpExamDate.Focus();
                    }
                    
                    

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            exm.customerID = (txtCustomerID.Text).ToString();
            exm.examDate = dtpExamDate.Value;
            exm.examTime = exmtm;

            int i = db.UpdateExam(exm);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            cmbxExamTime.Text = "";

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

            if (cmbxExamTime.SelectedIndex < 0)
            {

                MessageBox.Show("Enter Exam Time");

            }

            else
            {
                int i = db.UpdateExam(exm);

                if (i > 0)
                {

                    MessageBox.Show("Exam Data Updated Succefully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }

        }
    }
}
