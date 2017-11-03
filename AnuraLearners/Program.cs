using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnuraLearners
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmFirstPayment());
            //Application.Run(new frmSecondPayment());
            //Application.Run(new frmThirdPayment());
            //Application.Run(new GenerateReports());
            //Application.Run(new Exams());
            //Application.Run(new Trials());
            Application.Run(new ViewPayments());

        }
    }
}
