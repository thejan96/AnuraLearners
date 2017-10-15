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
            string query = "UPDATE [dbo].[Payments]   SET[FirstPayment] = '" + p.FirstPayment + "',[FirstPaymentDate] = '" + p.FirstPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
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

        public Payment getDetails(string customerId, int x)
        {
            openCon();
            SqlDataReader dr;
            Payment p1 = new Payment();
            switch (x)
            {
                case 1:
                    string query = "Select FirstPayment,FirstPaymentDate,SecondPayment,SecondPaymentDate FROM [dbo].[Payments] where [CustomerId] = '" + customerId + "' ";
                    cmd = new SqlCommand(query, con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        p1.FirstPayment = Convert.ToSingle(dr[0]);
                        p1.FirstPaymentDate = Convert.ToDateTime(dr[1]);
                        p1.SecoundPayment = Convert.ToSingle(dr[2]);
                        p1.SecoundPaymentDate = Convert.ToDateTime(dr[3]);
                    }
                    return p1;
                    break;
                default:
                    return p1;
                    break;
            }
        }



    }
}
