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
    public partial class GenerateReports : Form
    {
        public GenerateReports()
        {
            InitializeComponent();
        }
        DbConnection db;
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void GenerateReports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new DbConnection();
            DataTable dt = db.generateRep(dtmFrom.Value, dtmTo.Value, 1);
            dataGridView1.DataSource = dt;
        }
    }
}
