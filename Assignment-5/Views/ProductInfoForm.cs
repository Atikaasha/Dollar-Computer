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
/* Dollar Computer
 * Description: COMP123 Assignment - 5(Computer purchase app)
 * Author: Chowdhury Atika Parvin
 * ID# 301007336
 */

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


        //Object creation on form activation

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

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTextFile();
        }

        public void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenTextFile();
            //NextButton_Click(sender, e);
        }

        private void SaveBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveBinaryFile();
        }

        private void OpenBinaryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBinaryFile();
        }

        //Opening a text file
        public void OpenTextFile()
        {
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
                    this.Hide();
                    Program.orderForm.Show();
                }
                catch (IOException exception)
                {
                    MessageBox.Show("ERROR" + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    MessageBox.Show("ERROR " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Saving a text file
        public void SaveTextFile()
        {
            //configure the file dialog
            ProductInfoSaveFileDialogue.FileName = "Product.txt";
            ProductInfoSaveFileDialogue.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialogue.Filter = "Text Files(*.txt)|*.txt| All Files (*.*)|*.*";
            //open the file dialog
            var result = ProductInfoSaveFileDialogue.ShowDialog();
            if (result != DialogResult.Cancel)
                //open a stream to write
                using (StreamWriter outputStream = new StreamWriter(
                File.Open(ProductInfoSaveFileDialogue.FileName, FileMode.Create)))
                {
                    //write content - string type - to the file
                    outputStream.WriteLine(Program.productDetails.ProductionId.ToString());
                    outputStream.WriteLine(Program.productDetails.Cost.ToString());
                    outputStream.WriteLine(Program.productDetails.Manufacturer);
                    outputStream.WriteLine(Program.productDetails.Model);
                    outputStream.WriteLine(Program.productDetails.RamType);
                    outputStream.WriteLine(Program.productDetails.RamSize);
                    outputStream.WriteLine(Program.productDetails.DisplayType);
                    outputStream.WriteLine(Program.productDetails.LCDSize);
                    outputStream.WriteLine(Program.productDetails.CPUClass);
                    outputStream.WriteLine(Program.productDetails.CPUBrand);
                    outputStream.WriteLine(Program.productDetails.CPUType);
                    outputStream.WriteLine(Program.productDetails.CPUSpeed);
                    outputStream.WriteLine(Program.productDetails.CPUNumber);
                    outputStream.WriteLine(Program.productDetails.Condition);
                    outputStream.WriteLine(Program.productDetails.OS);
                    outputStream.WriteLine(Program.productDetails.Platform);
                    outputStream.WriteLine(Program.productDetails.HDDSize);
                    outputStream.WriteLine(Program.productDetails.HDDSpeed);
                    outputStream.WriteLine(Program.productDetails.GPUType);
                    outputStream.WriteLine(Program.productDetails.OpticalDrive);
                    outputStream.WriteLine(Program.productDetails.LAN);
                    outputStream.WriteLine(Program.productDetails.WIFI);
                    outputStream.WriteLine(Program.productDetails.AudioType);
                    outputStream.WriteLine(Program.productDetails.Width);
                    outputStream.WriteLine(Program.productDetails.Height);
                    outputStream.WriteLine(Program.productDetails.Depth);
                    outputStream.WriteLine(Program.productDetails.Weight);
                    outputStream.WriteLine(Program.productDetails.MouseType);
                    outputStream.WriteLine(Program.productDetails.Power);
                    outputStream.WriteLine(Program.productDetails.WebCam);
                    //cleanup
                    outputStream.Close();
                    outputStream.Dispose();
                    MessageBox.Show("File saved...", "Saving file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        //Saving a binary file
        private void SaveBinaryFile()
        {
            //configure the file dialog
            ProductInfoSaveFileDialogue.FileName = "Product.dat";
            ProductInfoSaveFileDialogue.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialogue.Filter = "Binary Files(*.dat)|*.dat| All Files (*.*)|*.*";
            //open the file dialog
            var result = ProductInfoSaveFileDialogue.ShowDialog();
            if (result != DialogResult.Cancel)
                //open a stream to write
                using (BinaryWriter outputStream = new BinaryWriter(
                File.Open(ProductInfoSaveFileDialogue.FileName, FileMode.Create)))
                {
                    //write content - string type - to the file
                    outputStream.Write(Program.productDetails.ProductionId.ToString());
                    outputStream.Write(Program.productDetails.Cost.ToString());
                    outputStream.Write(Program.productDetails.Manufacturer);
                    outputStream.Write(Program.productDetails.Model);
                    outputStream.Write(Program.productDetails.RamType);
                    outputStream.Write(Program.productDetails.RamSize);
                    outputStream.Write(Program.productDetails.DisplayType);
                    outputStream.Write(Program.productDetails.LCDSize);
                    outputStream.Write(Program.productDetails.CPUClass);
                    outputStream.Write(Program.productDetails.CPUBrand);
                    outputStream.Write(Program.productDetails.CPUType);
                    outputStream.Write(Program.productDetails.CPUSpeed);
                    outputStream.Write(Program.productDetails.CPUNumber);
                    outputStream.Write(Program.productDetails.Condition);
                    outputStream.Write(Program.productDetails.OS);
                    outputStream.Write(Program.productDetails.Platform);
                    outputStream.Write(Program.productDetails.HDDSize);
                    outputStream.Write(Program.productDetails.HDDSpeed);
                    outputStream.Write(Program.productDetails.GPUType);
                    outputStream.Write(Program.productDetails.OpticalDrive);
                    outputStream.Write(Program.productDetails.LAN);
                    outputStream.Write(Program.productDetails.WIFI);
                    outputStream.Write(Program.productDetails.AudioType);
                    outputStream.Write(Program.productDetails.Width);
                    outputStream.Write(Program.productDetails.Height);
                    outputStream.Write(Program.productDetails.Depth);
                    outputStream.Write(Program.productDetails.Weight);
                    outputStream.Write(Program.productDetails.MouseType);
                    outputStream.Write(Program.productDetails.Power);
                    outputStream.Write(Program.productDetails.WebCam);
                    //cleanup
                    outputStream.Flush();
                    outputStream.Close();
                    outputStream.Dispose();
                    MessageBox.Show("Binary File saved...", "Saving Binary file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        //Opening a binary file
        private void OpenBinaryFile()
        {
            //open the stream for reading
            ProductInfoOpenFileDialogue.FileName = "Product.dat";
            ProductInfoOpenFileDialogue.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoOpenFileDialogue.Filter = "Binary Files(*.dat)|*.dat| All Files (*.*)|*.*";

            var result = ProductInfoOpenFileDialogue.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    using (BinaryReader inputStream = new BinaryReader(
                    File.Open(ProductInfoOpenFileDialogue.FileName, FileMode.Open)))
                    {
                        //read the file
                        Program.productDetails.ProductionId = int.Parse(inputStream.ReadString());
                        Program.productDetails.Cost = double.Parse(inputStream.ReadString());
                        Program.productDetails.Manufacturer = inputStream.ReadString();
                        Program.productDetails.Model = inputStream.ReadString();
                        Program.productDetails.RamType = inputStream.ReadString();
                        Program.productDetails.RamSize = inputStream.ReadString();
                        Program.productDetails.DisplayType = inputStream.ReadString();
                        Program.productDetails.LCDSize = inputStream.ReadString();
                        Program.productDetails.CPUClass = inputStream.ReadString();
                        Program.productDetails.CPUBrand = inputStream.ReadString();
                        Program.productDetails.CPUType = inputStream.ReadString();
                        Program.productDetails.CPUSpeed = inputStream.ReadString();
                        Program.productDetails.CPUNumber = inputStream.ReadString();
                        Program.productDetails.Condition = inputStream.ReadString();
                        Program.productDetails.OS = inputStream.ReadString();
                        Program.productDetails.Platform = inputStream.ReadString();
                        Program.productDetails.HDDSize = inputStream.ReadString();
                        Program.productDetails.HDDSpeed = inputStream.ReadString();
                        Program.productDetails.GPUType = inputStream.ReadString();
                        Program.productDetails.OpticalDrive = inputStream.ReadString();
                        Program.productDetails.AudioType = inputStream.ReadString();
                        Program.productDetails.LAN = inputStream.ReadString();
                        Program.productDetails.WIFI = inputStream.ReadString();
                        Program.productDetails.Width = inputStream.ReadString();
                        Program.productDetails.Height = inputStream.ReadString();
                        Program.productDetails.Depth = inputStream.ReadString();
                        Program.productDetails.Weight = inputStream.ReadString();
                        Program.productDetails.MouseType = inputStream.ReadString();
                        Program.productDetails.Power = inputStream.ReadString();
                        Program.productDetails.WebCam = inputStream.ReadString();

                        inputStream.Close();
                        inputStream.Dispose();
                    }
                    //NextButton_Click(sender, e);
                    this.Hide();
                    Program.orderForm.Show();
                }

                catch (IOException exception)
                {
                    MessageBox.Show("ERROR " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    MessageBox.Show("ERROR " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
