﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
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
    }
}
