using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuraLearners
{
    class Trial
    {
        public string CustomerID;
        public DateTime TrialDate;


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



     
        public DateTime trialDate
        {
            get
            {
                return TrialDate;
            }

            set
            {
                TrialDate = value;
            }

        }


    }
}
