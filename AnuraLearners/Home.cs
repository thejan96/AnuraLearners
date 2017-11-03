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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        string loguser = "Principle";

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer newcus = new NewCustomer();
            newcus.Show();
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomers vwcus = new ViewCustomers();
            vwcus.Show();
        }

        private void examsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exams exms = new Exams();
            exms.Show();
        }

        private void trialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trials trls = new Trials();
            trls.Show();
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReports gr = new GenerateReports();

            gr.Show();
        }

        private void stPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirstPayment pay1 = new frmFirstPayment();
            pay1.Show();
        }

        private void ndPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecondPayment pay2 = new frmSecondPayment();
            pay2.Show();
        }

        private void rdPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThirdPayment pay3 = new frmThirdPayment();
            pay3.Show();
        }

        private void viewPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPayments vwpay = new ViewPayments();
            vwpay.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (loguser == "Cashier")
            {

                reportsToolStripMenuItem.Enabled = false;

            }

            else if (loguser == "Principle")
            {

                reportsToolStripMenuItem.Enabled = true;

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
