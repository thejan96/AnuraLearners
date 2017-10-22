using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuraLearners
{
    class Customer
    {

         
        string CustomerID, CustomerName,CustomerTelephone, CustomerAddress, Licen, Trainee, licenBike, LicenVan, LicThreeweel;
        DateTime RegistartionDate;
        int FullPayment;

        public string customerID
        {
            get
            {
                return CustomerID;
            }

            set
            {
                CustomerID  = value;
            }
        }

        public string customerName
        {
            get
            {
                return CustomerName;
            }

            set
            {
                CustomerName = value;
            }
        }

        public string customerTele
        {
            get
            {
                return CustomerTelephone;
            }

            set
            {
                CustomerTelephone = value;
            }
        }

        public string customerAdd
        {
            get
            {
                return CustomerAddress;
            }

            set
            {
                CustomerAddress = value;
            }
        }


        public string lic
        {
            get
            {
                return Licen;
            }

            set
            {
                Licen = value;
            }
        }



        public string trainee
        {
            get
            {
                return Trainee;
            }

            set
            {
                Trainee = value;
            }
        }

       public string licBike
        {
            get
            {
                return licenBike;
            }

            set
            {
                licenBike = value;
            }
        }

        public string licVan
        {
            get
            {
                return LicenVan;
            }

            set
            {
                LicenVan = value;
            }
        }

        public string licThreewl
        {
            get
            {
                return LicThreeweel;
            }

            set
            {
                LicThreeweel = value;
            }
        }

        public DateTime RegDate
        {
            get
            {
                return RegistartionDate;
            }

            set
            {
                RegistartionDate = value;
            }

        }

        public int FullPay
        {
            get
            {
                return FullPayment;
            }

            set
            {
                FullPayment = value;
            }

        }







    }
}
