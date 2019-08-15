using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Dollar Computer
 * Description: COMP123 Assignment - 5(Computer purchase app)
 * Author: Chowdhury Atika Parvin
 * ID# 301007336
 */

namespace Assignment_5.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewOderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.OpenTextFile();
        }
    }
}
