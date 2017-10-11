using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AnuraLearners
{
    class DbConnection
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public  DbConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=MACAW;Initial Catalog=AnuraLearners;Integrated Security=True";
        }

        public void openCon()
        {
            con.Open();
        }
        public void closeCon()
        {
            con.Close();
        }

        public int addPayment(string customerid,double paymentval)
        {
            openCon();
            string query = "INSERT INTO [dbo].[Payments] ([CustomerId],[FirstPayment],[FirstPaymentDate]) VALUES ('" + customerid + "','" + paymentval + "','" + DateTime.Today.ToShortDateString() + "')";
            cmd = new SqlCommand(query,con);
            return cmd.ExecuteNonQuery();
            closeCon();
        }

    }
}
