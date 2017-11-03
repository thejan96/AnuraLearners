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
        private SqlDataReader dr;
        Amount amt = new Amount();
        Trial trl = new Trial();
        
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
            int res=0;
            openCon();
            string query = "UPDATE [Payments]   SET[FirstPayment] = '" + p.FirstPayment + "',[FirstPaymentDate] = '" + p.FirstPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query,con);
            res = cmd.ExecuteNonQuery();
            closeCon();
            return res;
            
        }

        public int addSecondPayment(Payment p)
        {
            int res = 0;
            openCon();
            string query = "UPDATE [Payments]   SET[SecondPayment] = '" + p.SecoundPayment + "',[SecondPaymentDate] = '" + p.SecoundPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query, con);
            res = cmd.ExecuteNonQuery();
            closeCon();
            return res;

        }

        public int addThirdPayment(Payment p)
        {
            openCon();
            string query = "UPDATE [Payments]   SET[ThirdPayment] = '" + p.ThirdPayment + "',[ThirdPaymentDate] = '" + p.ThirdPaymentDate + "' WHERE [CustomerId] = '" + p.CustomerId + "'";
            cmd = new SqlCommand(query, con);
            closeCon();
            return cmd.ExecuteNonQuery();
           

        }

        public Payment getDetails(string customerId, int x)
        {
            openCon();
            //SqlDataReader dr;
            Payment p1 = new Payment();
            if (x==1)
            {
                string query = "Select FirstPayment,FirstPaymentDate,FullPayment FROM [tblPayments] where [CustomerId] = '" + customerId + "' ";
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
                string query = "Select FirstPayment,FirstPaymentDate,SecondPayment,SecondPaymentDate,FullPayment FROM [tblPayments] where [CustomerId] = '" + customerId + "' ";
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
                string query = "Select FirstPayment,FirstPaymentDate,SecondPayment,SecondPaymentDate,ThirdPayment,FullPayment FROM [tblPayments] where [CustomerId] = '" + customerId + "' ";
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
            else if (x == 4)
            {
                string query = "Select FirstPayment,FirstPaymentDate,SecondPayment,SecondPaymentDate,ThirdPayment,ThirdPaymentDate,FullPayment FROM [tblPayments] where [CustomerId] = '" + customerId + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        p1.FirstPayment = Convert.ToSingle(dr[0]);
                        p1.FirstPaymentDate = Convert.ToDateTime(dr[1]);
                        p1.SecoundPayment = Convert.ToSingle(dr[2]);
                        p1.FullPayment = Convert.ToSingle(dr[6]);
                        p1.SecoundPaymentDate = Convert.ToDateTime(dr[3]);
                        p1.ThirdPayment = Convert.ToSingle(dr[4]);
                        p1.ThirdPaymentDate = Convert.ToDateTime(dr[5]);

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
                string query = "SELECT [CustomerId] FROM [tblCustomer]";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
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
                string query = "SELECT [CustomerName] FROM [tblCustomer]";
                cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
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
            //SqlDataReader dr;
            Customer c1 = new Customer();
            if (x==1)
            {
                string query = "Select [CustomerId],[CustomerName],[CustomerAddress],[CustomerTelephone],[Licen],[Bike],[ThreeWeel],[Van],[RegistrationDate],[Trainee] FROM [tblCustomer] where [CustomerId] = '" + searchKey + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    c1.customerID = dr[0].ToString();
                    c1.customerName = dr[1].ToString();
                    c1.customerAdd = dr[2].ToString();
                    c1.customerTele = dr[3].ToString();
                    c1.lic = dr[4].ToString();
                    c1.licBike = dr[5].ToString();
                    c1.licThreewl = dr[6].ToString();
                    c1.licVan = dr[7].ToString();
                    c1.RegDate = Convert.ToDateTime( dr[8]);
                    c1.trainee = dr[9].ToString();
                }
                con.Close();
                return c1;
                
            }
            else if (x==2)
            {
                string query = "Select [CustomerId],[CustomerName],[CustomerAddress],[CustomerTelephone],[Licen],[Bike],[ThreeWeel],[Van],[RegistrationDate],[Trainee] FROM [tblCustomer] where [CustomerName] = '" + searchKey + "' ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    c1.customerID = dr[0].ToString();
                    c1.customerName = dr[1].ToString();
                    c1.customerAdd = dr[2].ToString();
                    c1.customerTele = dr[3].ToString();
                    c1.lic = dr[4].ToString();
                    c1.licBike = dr[5].ToString();
                    c1.licThreewl = dr[6].ToString();
                    c1.licVan = dr[7].ToString();
                    c1.RegDate = Convert.ToDateTime(dr[8]);
                    c1.trainee = dr[9].ToString();
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
                string query = "select * from tblCustomer where RegistrationDate between '" + fromDate + "' and '" + toDate + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            else if (type == 2)
            {
                string query = "SELECT * from tblPayments Where FirstPaymentDate between '"+fromDate+ "' and '" + toDate + "' OR SecondPaymentDate between '" + fromDate + "' and '" + toDate + "' OR ThirdPaymentDate between '" + fromDate + "' and '" + toDate + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            else if (type == 3)
            {
                string query = "SELECT [CustomerName],[ExamDate],[ExamTime],tblCustomer.CustomerTelephone from tblExam INNER JOIN tblCustomer ON tblExam.CustomerId = tblCustomer.CustomerId WHERE [ExamDate] between '" + fromDate + "' and '" + toDate + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            else if (type == 4)
            {
                string query = "SELECT * from tblTrials WHERE [ExamDate] between '" + fromDate + "' and '" + toDate + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            else if (type == 5)
            {
                string query = "SELECT tblCustomer.CustomerName,tblCustomer.CustomerTelephone,[FirstPayment],[FirstPaymentDate],[SecondPayment],[SecondPaymentDate],[ThirdPayment],[ThirdPaymentDate],[FullPayment] FROM [tblPayments] INNER JOIN tblCustomer ON tblPayments.CustomerId = tblCustomer.CustomerId WHERE (Customer.RegistrationDate between '" + fromDate + "' AND '" + toDate + "') AND (Payments.FirstPayment IS NULL OR Payments.SecondPayment IS NULL OR Payments.ThirdPayment IS NULL)";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            closeCon();
            return dt;
        }

        public int newCustomer(Customer c)
        {
            int res = 0;

            try
            {

                openCon();

                string query = "INSERT INTO tblCustomer values('" + c.customerID + "','" + c.customerName + "','" + c.customerAdd + "','" + c.customerTele + "','" + c.lic + "','" + c.licBike + "','" + c.licThreewl + "','" + c.licVan + "','" + c.RegDate + "','" + c.trainee + "')";

                cmd = new SqlCommand(query, con);

                res = cmd.ExecuteNonQuery();


            }

            catch (SqlException)
            {

                MessageBox.Show("NIC Already Exists");

            }

            closeCon();
            return res;

        }

        public int getBikeAmount()
        {

            con.Open();
            string query = "select * from tblLicenType where TypeID = 1 ";

            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                amt.bikeAmount = dr.GetInt32(2);


            }

            closeCon();
            return amt.bikeAmount;



        }



        public int getTraineeAmount()
        {

            con.Open();
            string query = "select * from tblLicenType where TypeID = 5";

            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                amt.traAmount = dr.GetInt32(2);

            }

            closeCon();
            return amt.traAmount;



        }

        public int getVanAmount()
        {

            con.Open();
            string query = "select * from tblLicenType where TypeID = 2 ";

            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                amt.vanAmount = dr.GetInt32(2);

            }

            closeCon();
            return amt.vanAmount;


        }


        public int getWeelAmount()
        {

            con.Open();
            string query = "select * from tblLicenType where TypeID = 3 ";

            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                amt.thAmount = dr.GetInt32(2);


            }

            closeCon();

            return amt.thAmount;



        }

        public int newPayment(Payment p)
        {

            openCon();
            string query = "INSERT INTO tblPayments(CustomerID,FullPayment) VALUES('" + p.CustomerId + "','" + p.FullPayment + "')";

            cmd = new SqlCommand(query, con);

            int res = cmd.ExecuteNonQuery();

            closeCon();

            return res;





        }


        public int delCustomer(Customer cus)
        {
            openCon();

            string query = "Delete from tblCustomer where CustomerID = '" + cus.customerID + "'";

            cmd = new SqlCommand(query, con);

            int res = cmd.ExecuteNonQuery();

            closeCon();

            return res;


        }


        public int delPayment(Payment pay)
        {

            openCon();

            string query = "Delete from tblPayments where CustomerID = '" + pay.CustomerId + "'";

            cmd = new SqlCommand(query, con);

            int res = cmd.ExecuteNonQuery();

            closeCon();

            return res;


        }

        public int updatePayment(Payment pay)
        {

            openCon();

            string query = "Update tblPayments set FullPayment = '" + pay.FullPayment + "' where CustomerID = '" + pay.CustomerId + "'";

            cmd = new SqlCommand(query, con);

            int res = cmd.ExecuteNonQuery();

            closeCon();

            return res;


        }

        public int NewExam(Exam e)
        {
            openCon();

            string query = "INSERT INTO tblExams values('" + e.customerID + "', '" + e.examDate + "','" + e.examTime + "')";

            cmd = new SqlCommand(query, con);

            int res = cmd.ExecuteNonQuery();

            closeCon();


            return res;



        }


        public int UpdateCustomer(Customer cus)
        {

            openCon();

            string query = "Update tblCustomer set CustomerName = '" + cus.customerName + "', CustomerAddress = '" + cus.customerAdd + "', CustomerTelephone = '" + cus.customerTele + "', Licen = '" + cus.lic + "',Bike = '" + cus.licBike + "', ThreeWeel = '" + cus.licThreewl + "',Van = '" + cus.licVan + "', RegistrationDate = '" + cus.RegDate + "',Trainee = '" + cus.trainee + "' where CustomerID = '" + cus.customerID + "'";

            cmd = new SqlCommand(query, con);

            int res = cmd.ExecuteNonQuery();

            closeCon();

            return res;


        }

        public int UpdateExam(Exam exm)
        {

            openCon();

            string query = "Update tblExam set ExamDate = '" + exm.examDate + "', ExamTime = '" + exm.examTime + "'where CustomerID = '" + exm.customerID + "'";

            cmd = new SqlCommand(query, con);

            int res = cmd.ExecuteNonQuery();

            closeCon();

            return res;



        }

        public Exam getExam(Exam ex)
        {
            con.Open();
            Exam e = new Exam();

            string query = "select * from tblExam where CustomerID = '" + ex.customerID + "' ";

            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                e.examDate = Convert.ToDateTime(dr[2]);
                e.examTime = dr[3].ToString();
            }

            con.Close();
            return e;




        }

        public int NewTrial(Trial trl)
        {
            openCon();

            string query = "INSERT INTO tblTrials values('" + trl.customerID + "', '" + trl.trialDate + "')";

            cmd = new SqlCommand(query, con);

            int res = cmd.ExecuteNonQuery();

            closeCon();


            return res;



        }

       
         public int UpdateTrial(Trial trl)
        {

            openCon();

            string query = "Update tblTrials set TrialDate = '" + trl.trialDate + "' where CustomerID = '" + trl.CustomerID + "'";

            cmd = new SqlCommand(query, con);

            int res = cmd.ExecuteNonQuery();

            closeCon();

            return res;



        }
       
         public Trial getTrial(Trial tr)
        {

            con.Open();

            string query = "select * from tblTrials where CustomerID = '" + tr.customerID + "' ";

            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                trl.trialDate = Convert.ToDateTime(dr[1]);


            }

            con.Close();
            return trl;


        }

    }


}



