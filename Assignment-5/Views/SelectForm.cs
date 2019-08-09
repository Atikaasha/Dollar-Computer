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

                string outputString = manufacturer +"," + model + "," + " $"     + cost;


            SelectTextBox.Text = outputString;
            //Program.productDetails.ProductID = int.parse(cells[0].Value.ToString());
        }
    }
}
