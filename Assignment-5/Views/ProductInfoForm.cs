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
        { 
            //configure the file dialog
            ProductInfoSaveFileDialogue.FileName = "Product.txt";
            ProductInfoSaveFileDialogue.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialogue.Filter = "Text Files(*.txt)|*.txt| All Files (*.*)|*.*";
            //open the file dialog
            var result = ProductInfoSaveFileDialogue.ShowDialog();
            if (result != DialogResult.Cancel)
                //open a stream to write
                using (StreamWriter outputString = new StreamWriter(
                File.Open(ProductInfoSaveFileDialogue.FileName,FileMode.Create)))
            {
                //write content - string type - to the file
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
                MessageBox.Show("File saved...", "Saving file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            {
                ProductIDTextBox.Text = Program.productDetails.ProductionId.ToString();
                CostTextBox.Text = Program.productDetails.Cost.ToString();
                ConditionTexBox.Text = Program.productDetails.Condition;
                PlatformTextBox.Text = Program.productDetails.Platform;
                OSTextBox.Text = Program.productDetails.OS;
                ManufacturerTextBox.Text = Program.productDetails.Manufacturer;
                ModelTextBox.Text = Program.productDetails.Model;
                MemoryTextBox.Text = Program.productDetails.RamSize;
                LCDTextBox.Text = Program.productDetails.LCDSize;
                HDDTextBox.Text = Program.productDetails.HDDSize;
                CPUBrandTextBox.Text = Program.productDetails.CPUBrand;
                CPUNumberTextBox.Text = Program.productDetails.CPUNumber;
                GPUTypeTextBox.Text = Program.productDetails.GPUType;
                CPUTypeTextBox.Text = Program.productDetails.CPUType;
                CPUSpeedTextBox.Text = Program.productDetails.CPUSpeed;
                WebCamTextBox.Text = Program.productDetails.WebCam;
            }
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            //open the stream for reading
            ProductInfoOpenFileDialogue.FileName = "Product.txt";
            ProductInfoOpenFileDialogue.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoOpenFileDialogue.Filter = "Text Files(*.txt)|*.txt| All Files (*.*)|*.*";

            var result = ProductInfoOpenFileDialogue.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader inputStream = new StreamReader(
                    File.Open(ProductInfoOpenFileDialogue.FileName, FileMode.Open)))
                    {
                        //read the file
                        Program.productDetails.ProductionId = int.Parse(inputStream.ReadLine());
                        Program.productDetails.Cost = double.Parse(inputStream.ReadLine());
                        Program.productDetails.Manufacturer = inputStream.ReadLine();
                        Program.productDetails.Model = inputStream.ReadLine();
                        Program.productDetails.RamType = inputStream.ReadLine();
                        Program.productDetails.RamSize = inputStream.ReadLine();
                        Program.productDetails.DisplayType = inputStream.ReadLine();
                        Program.productDetails.LCDSize = inputStream.ReadLine();
                        Program.productDetails.CPUClass = inputStream.ReadLine();
                        Program.productDetails.CPUBrand = inputStream.ReadLine();
                        Program.productDetails.CPUType = inputStream.ReadLine();
                        Program.productDetails.CPUSpeed = inputStream.ReadLine();
                        Program.productDetails.CPUNumber = inputStream.ReadLine();
                        Program.productDetails.Condition = inputStream.ReadLine();
                        Program.productDetails.OS = inputStream.ReadLine();
                        Program.productDetails.Platform = inputStream.ReadLine();
                        Program.productDetails.HDDSize = inputStream.ReadLine();
                        Program.productDetails.HDDSpeed = inputStream.ReadLine();
                        Program.productDetails.GPUType = inputStream.ReadLine();
                        Program.productDetails.OpticalDrive = inputStream.ReadLine();
                        Program.productDetails.AudioType = inputStream.ReadLine();
                        Program.productDetails.LAN = inputStream.ReadLine();
                        Program.productDetails.WIFI = inputStream.ReadLine();
                        Program.productDetails.Width = inputStream.ReadLine();
                        Program.productDetails.Height = inputStream.ReadLine();
                        Program.productDetails.Depth = inputStream.ReadLine();
                        Program.productDetails.Weight = inputStream.ReadLine();
                        Program.productDetails.MouseType = inputStream.ReadLine();
                        Program.productDetails.Power = inputStream.ReadLine();
                        Program.productDetails.WebCam = inputStream.ReadLine();

                        inputStream.Close();
                        inputStream.Dispose();
                    }
                    NextButton_Click(sender, e);
                }
                catch (IOException exception)
                {
                    MessageBox.Show("ERROR" + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
                
            
        }
    }
}
