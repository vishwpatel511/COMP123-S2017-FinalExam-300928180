using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Vishw Patel
 * Student ID: 300928180
 * Date: July 17, 2017
 * Description: This is the Suit enum
 * Version: 0.1 - Created the Suit enum
 */

namespace COMP123_S2017_FinalExam_300928180
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PickHighestCardForm());
        }
    }
}
