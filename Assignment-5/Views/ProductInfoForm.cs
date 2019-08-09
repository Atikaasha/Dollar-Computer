using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }

        private void CancelProductButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnotherButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {   //open a stream to write
            using (StreamWriter outputString = new StreamWriter(
                File.Open("Product.txt",FileMode.Create)))
            {
                //write stuff to the file
                outputString.WriteLine(Program.productDetails.ProductionId.ToString());
                outputString.WriteLine(Program.productDetails.Cost.ToString());
                outputString.WriteLine(Program.productDetails.Manufacturer);
                outputString.WriteLine(Program.productDetails.Model);
                outputString.WriteLine(Program.productDetails.RamType);
                outputString.WriteLine(Program.productDetails.RamSize);
                outputString.WriteLine(Program.productDetails.DisplayType);
                outputString.WriteLine(Program.productDetails.LCDSize);
                outputString.WriteLine(Program.productDetails.CPUClass);
                outputString.WriteLine(Program.productDetails.CPUBrand);
                outputString.WriteLine(Program.productDetails.CPUType);
                outputString.WriteLine(Program.productDetails.CPUSpeed);
                outputString.WriteLine(Program.productDetails.CPUNumber);
                outputString.WriteLine(Program.productDetails.Condition);
                outputString.WriteLine(Program.productDetails.OS);
                outputString.WriteLine(Program.productDetails.Platform);
                outputString.WriteLine(Program.productDetails.HDDSize);
                outputString.WriteLine(Program.productDetails.HDDSpeed);
                outputString.WriteLine(Program.productDetails.GPUType);
                outputString.WriteLine(Program.productDetails.OpticalDrive);
                outputString.WriteLine(Program.productDetails.LAN);
                outputString.WriteLine(Program.productDetails.WIFI);
                outputString.WriteLine(Program.productDetails.AudioType);
                outputString.WriteLine(Program.productDetails.Width);
                outputString.WriteLine(Program.productDetails.Height);
                outputString.WriteLine(Program.productDetails.Depth);
                outputString.WriteLine(Program.productDetails.Weight);
                outputString.WriteLine(Program.productDetails.MouseType);
                outputString.WriteLine(Program.productDetails.Power);
                outputString.WriteLine(Program.productDetails.WebCam);

                //cleanup
                outputString.Close();
                outputString.Dispose();
            }
        }
    }
}
