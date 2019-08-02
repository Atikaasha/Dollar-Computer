using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Dollar Computer
 * Description: COMP123 Assignment - 5(Computer purchase app)
 * Author: Chowdhury Atika Parvin
 * ID# 301007336
 * Version: 1.4 Order Form  and About Form User Interface has been created
 * Last modified: August 2, 2019
 */

namespace Assignment_5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static AboutForm aboutForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            aboutForm = new AboutForm();
            Application.Run(new SplashForm());  
        }
    }
}
