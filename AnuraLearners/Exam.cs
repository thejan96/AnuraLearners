using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuraLearners
{
    class Exam
    {
       public string CustomerID, CustomerName, ExamTime;
       public DateTime  ExamDate;



        public string customerID
        {
            get
            {
                return CustomerID;
            }

            set
            {
                CustomerID = value;
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

        public string examTime
        {
            get
            {
                return ExamTime;
            }

            set
            {
                ExamTime = value;
            }
        }

        public DateTime examDate
        {
            get
            {
                return ExamDate;
            }

            set
            {
                ExamDate = value;
            }

        }




    }
}
