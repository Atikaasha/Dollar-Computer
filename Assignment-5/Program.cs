using Assignment_5.Models;
using Assignment_5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Dollar Computer
 * Description: COMP123 Assignment - 5(Computer purchase app)
 * Author: Chowdhury Atika Parvin
 * ID# 301007336
 * Version: 2.0 Project completed
 * Last modified: August 16, 2019
 */

namespace Assignment_5
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;
        public static ProductDetails productDetails;

        public static Product product;
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();
            product = new Product();
            productDetails = new ProductDetails();
            Application.Run(new SplashForm());  
        }
    }
}
