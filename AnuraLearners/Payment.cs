using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuraLearners
{
    class Payment
    {
        int paymentId;
        string customerId;
        float firstPayment, secoundPayment, thirdPayment, fullPayment;
        DateTime firstPaymentDate, secoundPaymentDate, thirdPaymentDate;

        public int PaymentId
        {
            get
            {
                return paymentId;
            }

            set
            {
                paymentId = value;
            }
        }

        public float FirstPayment
        {
            get
            {
                return firstPayment;
            }

            set
            {
                firstPayment = value;
            }
        }

        public float SecoundPayment
        {
            get
            {
                return secoundPayment;
            }

            set
            {
                secoundPayment = value;
            }
        }

        public float ThirdPayment
        {
            get
            {
                return thirdPayment;
            }

            set
            {
                thirdPayment = value;
            }
        }

        public float FullPayment
        {
            get
            {
                return fullPayment;
            }

            set
            {
                fullPayment = value;
            }
        }

        public DateTime FirstPaymentDate
        {
            get
            {
                return firstPaymentDate;
            }

            set
            {
                firstPaymentDate = value;
            }
        }

        public DateTime SecoundPaymentDate
        {
            get
            {
                return secoundPaymentDate;
            }

            set
            {
                secoundPaymentDate = value;
            }
        }

        public DateTime ThirdPaymentDate
        {
            get
            {
                return thirdPaymentDate;
            }

            set
            {
                thirdPaymentDate = value;
            }
        }

        public string CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        
    }
}
