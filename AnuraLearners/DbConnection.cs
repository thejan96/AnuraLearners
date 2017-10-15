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

        public int addFirstPayment(Payment p)
        {
            openCon();
            string query = "INSERT INTO [dbo].[Payments] ([CustomerId],[FirstPayment],[FirstPaymentDate]) VALUES ('" + p.CustomerId + "','" + p.FirstPayment + "','" + p.FirstPaymentDate + "')";
            cmd = new SqlCommand(query,con);
            return cmd.ExecuteNonQuery();
            
        }

        public int addSecondPayment(Payment p)
        {
            openCon();
            string query = "UPDATE [dbo].[Payments]   SET[SecondPayment] = '" + p.SecoundPayment + "',[SecondPaymentDate] = '" + p.SecoundPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query, con);
            return cmd.ExecuteNonQuery();
            
        }

        public int addThirdPayment(Payment p)
        {
            openCon();
            string query = "UPDATE [dbo].[Payments]   SET[ThirdPayment] = '" + p.ThirdPayment + "',[ThirdPaymentDate] = '" + p.ThirdPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query, con);
            return cmd.ExecuteNonQuery();

        }



    }
}
