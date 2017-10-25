﻿using System;
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
            openCon();
            string query = "UPDATE [dbo].[Payments]   SET[FirstPayment] = '" + p.FirstPayment + "',[FirstPaymentDate] = '" + p.FirstPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query,con);
            return cmd.ExecuteNonQuery();
            closeCon();
            
        }

        public int addSecondPayment(Payment p)
        {
            openCon();
            string query = "UPDATE [dbo].[Payments]   SET[SecondPayment] = '" + p.SecoundPayment + "',[SecondPaymentDate] = '" + p.SecoundPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query, con);
            return cmd.ExecuteNonQuery();
            con.Close();
            
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
            switch (x)
            {
                case 1:
                    string query = "Select FirstPayment,FirstPaymentDate,SecondPayment,SecondPaymentDate,FullPayment FROM [dbo].[Payments] where [CustomerId] = '" + customerId + "' ";
                    cmd = new SqlCommand(query, con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        p1.FirstPayment = Convert.ToSingle(dr[0]);
                        p1.FirstPaymentDate = Convert.ToDateTime(dr[1]);
                        p1.SecoundPayment = Convert.ToSingle(dr[2]);
                        p1.SecoundPaymentDate = Convert.ToDateTime(dr[3]);
                        p1.FullPayment = Convert.ToSingle(dr[4]);
                    }
                    return p1;
                    break;
                default:
                    return p1;
                    break;
            }
            con.Close();
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
                    MessageBox.Show(dr.GetString(0));
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
                return c1;
                con.Close();
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
                return c1;
                con.Close();
            }
            else
            {
                return null;
            }
                    
                    
                    
                   
            }
        }

}
