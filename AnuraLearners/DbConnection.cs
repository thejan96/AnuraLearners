using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

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
            int res=0, res1=0;
            openCon();
            string query = "UPDATE [dbo].[Payments]   SET[FirstPayment] = '" + p.FirstPayment + "',[FirstPaymentDate] = '" + p.FirstPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query,con);
            res = cmd.ExecuteNonQuery();
            //if (res ==1)
            //{
            //    string query1 = "UPDATE [dbo].[Payments]   SET[FullPayment] = '" + RestPayment + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            //    cmd = new SqlCommand(query1, con);
            //    res1 = cmd.ExecuteNonQuery();
            //}
            closeCon();
            return res;
            
        }

        public int addSecondPayment(Payment p)
        {
            int res = 0, res1 = 0;
            openCon();
            string query = "UPDATE [dbo].[Payments]   SET[SecondPayment] = '" + p.SecoundPayment + "',[SecondPaymentDate] = '" + p.SecoundPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query, con);
            res = cmd.ExecuteNonQuery();
            //if (res == 1)
            //{
            //    string query1 = "UPDATE [dbo].[Payments]   SET[FullPayment] = '" + RestPayment + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            //    cmd = new SqlCommand(query1, con);
            //    res1 = cmd.ExecuteNonQuery();
            //}
            closeCon();
            return res;

        }

        public int addThirdPayment(Payment p)
        {
            openCon();
            string query = "UPDATE [dbo].[Payments]   SET[ThirdPayment] = '" + p.ThirdPayment + "',[ThirdPaymentDate] = '" + p.ThirdPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query, con);
            return cmd.ExecuteNonQuery();
            con.Close();

        }

        public Payment getDetails(string customerId, int x)
        {
            openCon();
            SqlDataReader dr;
            Payment p1 = new Payment();
            if (x==1)
            {
                string query = "Select FirstPayment,FirstPaymentDate,FullPayment FROM [dbo].[Payments] where [CustomerId] = '" + customerId + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        p1.FullPayment = Convert.ToSingle(dr[2]);
                        p1.FirstPayment = Convert.ToSingle(dr[0]);
                        p1.FirstPaymentDate = Convert.ToDateTime(dr[1]);
                       
                    }
                    catch (InvalidCastException)
                    {

                        
                    }
                    
                }
            }
            else if (x==2)
            {
                string query = "Select FirstPayment,FirstPaymentDate,SecondPayment,SecondPaymentDate,FullPayment FROM [dbo].[Payments] where [CustomerId] = '" + customerId + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        p1.FirstPayment = Convert.ToSingle(dr[0]);
                        p1.FirstPaymentDate = Convert.ToDateTime(dr[1]);
                        p1.FullPayment = Convert.ToSingle(dr[4]);
                        p1.SecoundPayment = Convert.ToSingle(dr[2]);
                        p1.SecoundPaymentDate = Convert.ToDateTime(dr[3]);
                        
                    }
                    catch (InvalidCastException)
                    {

                        
                    }
                    
                }
            }
            else if (x == 3)
            {
                string query = "Select FirstPayment,FirstPaymentDate,SecondPayment,SecondPaymentDate,ThirdPayment,FullPayment FROM [dbo].[Payments] where [CustomerId] = '" + customerId + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        p1.FirstPayment = Convert.ToSingle(dr[0]);
                        p1.FirstPaymentDate = Convert.ToDateTime(dr[1]);
                        p1.SecoundPayment = Convert.ToSingle(dr[2]);
                        p1.FullPayment = Convert.ToSingle(dr[5]);
                        p1.SecoundPaymentDate = Convert.ToDateTime(dr[3]);
                        p1.ThirdPayment = Convert.ToSingle(dr[4]);
                        
                    }
                    catch (InvalidCastException)
                    {

                        
                    }
                    
                }
            }
            con.Close();
            return p1;
        }

        public AutoCompleteStringCollection autoload(int x)
        {
            if (x == 1)
            {
                con.Open();
                string query = "SELECT [CustomerId] FROM [AnuraLearners].[dbo].[Customer]";
                cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection idlist = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    idlist.Add(dr.GetString(0));

                }
                con.Close();
                return idlist;
            }

            else if (x==2)
            {
                AutoCompleteStringCollection idlist = new AutoCompleteStringCollection();
                string query = "SELECT [CustomerName] FROM [AnuraLearners].[dbo].[Customer]";
                cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    //MessageBox.Show(dr.GetString(0));
                    while (dr.Read())
                    {
                        idlist.Add(dr.GetString(0));
                    }
                    con.Close();
                    return idlist;
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);return idlist;
                }
             
            }
            else
            {
                return null;
            }
            

        }

        public Customer getCustomerDetails(string searchKey, int x)
        {
            openCon();
            SqlDataReader dr;
            Customer c1 = new Customer();
            if (x==1)
            {
                string query = "Select [CustomerId],[CustomerName],[CustomerAddress],[CustomerTelephone],[Licen],[Bike],[ThreeWeel],[Van],[RegistrationDate],[Trainee] FROM[AnuraLearners].[dbo].[Customer] where [CustomerId] = '" + searchKey + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    c1.customerID = dr[0].ToString();
                    c1.customerName = dr[1].ToString();
                    c1.RegDate = Convert.ToDateTime( dr[8]);
                }
                con.Close();
                return c1;
                
            }
            else if (x==2)
            {
                string query = "Select [CustomerId],[CustomerName],[CustomerAddress],[CustomerTelephone],[Licen],[Bike],[ThreeWeel],[Van],[RegistrationDate],[Trainee] FROM[AnuraLearners].[dbo].[Customer] where [CustomerName] = '" + searchKey + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    c1.customerID = dr[0].ToString();
                    c1.customerName = dr[1].ToString();
                    c1.RegDate = Convert.ToDateTime(dr[8]);
                }
                con.Close();
                return c1;
               
            }
            else
            {
                return null;
            }
                    
                    
                    
                   
            }

        public DataTable generateRep(DateTime fromDate, DateTime toDate, int type)
        {
            openCon();
            DataTable dt = new DataTable();
            if (type == 1)
            {
                string query = "select * from Customer where RegistrationDate between '" + fromDate + "' and '" + toDate + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            else if (type == 2)
            {
                string query = "select * from Customer where RegistrationDate between '" + fromDate + "' and '" + toDate + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            closeCon();
            return dt;
        }


    }


}
