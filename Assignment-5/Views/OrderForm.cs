using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Dollar Computer
 * Description: COMP123 Assignment - 5(Computer purchase app)
 * Author: Chowdhury Atika Parvin
 * Project completion Date: 16th August
 * ID# 301007336
 */

namespace Assignment_5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler foe about toolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();

        }

        private void OrderFormBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void OrderFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderPrintForm.PrintAction = PrintAction.PrintToPreview;
            OrderPrintForm.Print();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionTextBox.Text = Program.productDetails.Condition;
            PlatformTextBox.Text = Program.productDetails.Platform;
            ManufacturerTextBox.Text = Program.productDetails.Manufacturer;
            ModelTextBox.Text = Program.productDetails.Model;

            //OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.LCDSize + "\r\n";
            OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.RamSize + "\r\n";
            OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.CPUBrand + "\r\n";
            OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.CPUType + "\r\n";
            OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.CPUNumber + "\r\n";
            OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.CPUSpeed + "\r\n";
            OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.HDDSize + "\r\n";
            OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.GPUType + "\r\n";
            OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.WebCam + "\r\n";
            OrderFormTextBox.Text += "\r\n";
            OrderFormTextBox.Text += Program.productDetails.OS + "\r\n";

            PriceTextBox.Text = $"{Program.productDetails.Cost:C2}".ToString();
            TaxTextBox.Text = $"{(Program.productDetails.Cost * 0.13):C2}".ToString();
            TotalTextBox.Text = $"{(Program.productDetails.Cost + (Program.productDetails.Cost * 0.13)):C2}".ToString();
        }

        private void OrderFormFinishButon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thanks for your order\n\nYour order will be processed within 5 business days", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
