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
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            lblPaymentDate.Text = DateTime.Today.Date.ToShortDateString();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            int ret = db.addPayment(txtCustomerId.Text,Int32.Parse( txtFirstPayment.Text));
            if (ret==1)
            {
                MessageBox.Show("Successfully Payed");
            }
            else
            {
                MessageBox.Show("Payment Unsuccessful");
            }
        }
    }
}
