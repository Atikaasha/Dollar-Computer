using Assignment_5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void selectCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                SelectNextButton.Enabled = false;
            }
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectNextButton.Enabled = true;
            //local scope aliases
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            //rows[rowIndex].Selected = true;


            Program.productDetails.Cost = double.Parse(cells[(int)ProductDetails.ProductField.Cost].Value.ToString());
            Program.productDetails.Manufacturer = (cells[(int)ProductDetails.ProductField.Manufacturer].Value.ToString());
            Program.productDetails.Model = cells[(int)ProductDetails.ProductField.Model].Value.ToString();

            //string outputString = string.Empty;
            string manufacturer = Program.productDetails.Manufacturer;
            string model = Program.productDetails.Model;
            double cost = Program.productDetails.Cost;

            string outputString = manufacturer +", " + model + ", " + " $"     + cost;
            SelectTextBox.Text = outputString;
            Program.productDetails.ProductionId = int.Parse(cells[(int)ProductDetails.ProductField.Product_ID].Value.ToString());
            Program.productDetails.Cost = double.Parse(cells[(int)ProductDetails.ProductField.Cost].Value.ToString());
            Program.productDetails.Manufacturer = (cells[(int)ProductDetails.ProductField.Manufacturer].Value.ToString());
            Program.productDetails.Model = cells[(int)ProductDetails.ProductField.Model].Value.ToString();
            Program.productDetails.RamType = cells[(int)ProductDetails.ProductField.RAM_Type].Value.ToString();
            Program.productDetails.RamSize = cells[(int)ProductDetails.ProductField.RAM_Size].Value.ToString();
            Program.productDetails.DisplayType = cells[(int)ProductDetails.ProductField.Display_Type].Value.ToString();
            Program.productDetails.LCDSize = cells[(int)ProductDetails.ProductField.LCD_Size].Value.ToString();
            Program.productDetails.CPUClass = cells[(int)ProductDetails.ProductField.CPU_Class].Value.ToString();
            Program.productDetails.CPUBrand = cells[(int)ProductDetails.ProductField.CPU_Brand].Value.ToString();
            Program.productDetails.CPUType = cells[(int)ProductDetails.ProductField.CPU_Type].Value.ToString();
            Program.productDetails.CPUSpeed = cells[(int)ProductDetails.ProductField.CPU_Speed].Value.ToString();
            Program.productDetails.CPUNumber = cells[(int)ProductDetails.ProductField.CPU_Number].Value.ToString();
            Program.productDetails.Condition = cells[(int)ProductDetails.ProductField.Condition].Value.ToString();
            Program.productDetails.OS = cells[(int)ProductDetails.ProductField.OS].Value.ToString();
            Program.productDetails.Platform = cells[(int)ProductDetails.ProductField.Platform].Value.ToString();
            Program.productDetails.HDDSize = cells[(int)ProductDetails.ProductField.HDD_Size].Value.ToString();
            Program.productDetails.HDDSpeed = cells[(int)ProductDetails.ProductField.HDD_Speed].Value.ToString();
            Program.productDetails.GPUType = cells[(int)ProductDetails.ProductField.GPU_Type].Value.ToString();
            Program.productDetails.OpticalDrive = cells[(int)ProductDetails.ProductField.Optical_drive].Value.ToString();
            Program.productDetails.AudioType = cells[(int)ProductDetails.ProductField.Audio_Type].Value.ToString();
            Program.productDetails.LAN = cells[(int)ProductDetails.ProductField.LAN].Value.ToString();
            Program.productDetails.WIFI = cells[(int)ProductDetails.ProductField.WIFI].Value.ToString();
            Program.productDetails.Width = cells[(int)ProductDetails.ProductField.Width].Value.ToString();
            Program.productDetails.Height = cells[(int)ProductDetails.ProductField.Height].Value.ToString();
            Program.productDetails.Depth = cells[(int)ProductDetails.ProductField.Depth].Value.ToString();
            Program.productDetails.Weight = cells[(int)ProductDetails.ProductField.Weight].Value.ToString();
            Program.productDetails.MouseType = cells[(int)ProductDetails.ProductField.Mouse_Type].Value.ToString();
            Program.productDetails.Power = cells[(int)ProductDetails.ProductField.Power].Value.ToString();
            Program.productDetails.WebCam = cells[(int)ProductDetails.ProductField.Web_Cam].Value.ToString();

        }
    }
}
