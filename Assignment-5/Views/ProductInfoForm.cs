using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
