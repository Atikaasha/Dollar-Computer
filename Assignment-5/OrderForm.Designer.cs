﻿namespace Assignment_5
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormGroupBox = new System.Windows.Forms.GroupBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.InnerGroupBox = new System.Windows.Forms.GroupBox();
            this.LCDLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.OrderFormTextBox = new System.Windows.Forms.TextBox();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormBackButton = new System.Windows.Forms.Button();
            this.OrderFormCancelButton = new System.Windows.Forms.Button();
            this.OrderFormFinishButon = new System.Windows.Forms.Button();
            this.OrderFormPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormMenuStrip.SuspendLayout();
            this.OrderFormGroupBox.SuspendLayout();
            this.InnerGroupBox.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(955, 33);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "OderFormMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // OrderFormGroupBox
            // 
            this.OrderFormGroupBox.Controls.Add(this.InnerGroupBox);
            this.OrderFormGroupBox.Controls.Add(this.ModelTextBox);
            this.OrderFormGroupBox.Controls.Add(this.ModelLabel);
            this.OrderFormGroupBox.Controls.Add(this.textBox1);
            this.OrderFormGroupBox.Controls.Add(this.PlatformLabel);
            this.OrderFormGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.OrderFormGroupBox.Controls.Add(this.ManufacturerLabel);
            this.OrderFormGroupBox.Controls.Add(this.ConditionTextBox);
            this.OrderFormGroupBox.Controls.Add(this.ConditionLabel);
            this.OrderFormGroupBox.Location = new System.Drawing.Point(13, 37);
            this.OrderFormGroupBox.Name = "OrderFormGroupBox";
            this.OrderFormGroupBox.Size = new System.Drawing.Size(513, 460);
            this.OrderFormGroupBox.TabIndex = 1;
            this.OrderFormGroupBox.TabStop = false;
            this.OrderFormGroupBox.Text = "System Components";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(38, 29);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(90, 20);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition:";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTextBox.Location = new System.Drawing.Point(135, 23);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(115, 30);
            this.ConditionTextBox.TabIndex = 1;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(7, 65);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(121, 20);
            this.ManufacturerLabel.TabIndex = 2;
            this.ManufacturerLabel.Text = "Manufacturer:";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTextBox.Location = new System.Drawing.Point(135, 65);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(115, 30);
            this.ManufacturerTextBox.TabIndex = 3;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(292, 33);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(81, 20);
            this.PlatformLabel.TabIndex = 4;
            this.PlatformLabel.Text = "Platform:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(379, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(115, 30);
            this.textBox1.TabIndex = 5;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(292, 65);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(62, 20);
            this.ModelLabel.TabIndex = 6;
            this.ModelLabel.Text = "Model:";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(379, 65);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(115, 30);
            this.ModelTextBox.TabIndex = 7;
            // 
            // InnerGroupBox
            // 
            this.InnerGroupBox.Controls.Add(this.OrderFormTextBox);
            this.InnerGroupBox.Controls.Add(this.OSLabel);
            this.InnerGroupBox.Controls.Add(this.WebCamLabel);
            this.InnerGroupBox.Controls.Add(this.GPUTypeLabel);
            this.InnerGroupBox.Controls.Add(this.HDDLabel);
            this.InnerGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.InnerGroupBox.Controls.Add(this.CPUNumberLabel);
            this.InnerGroupBox.Controls.Add(this.CPUTypeLabel);
            this.InnerGroupBox.Controls.Add(this.CPUBrandLabel);
            this.InnerGroupBox.Controls.Add(this.MemoryLabel);
            this.InnerGroupBox.Controls.Add(this.LCDLabel);
            this.InnerGroupBox.Location = new System.Drawing.Point(7, 101);
            this.InnerGroupBox.Name = "InnerGroupBox";
            this.InnerGroupBox.Size = new System.Drawing.Size(487, 329);
            this.InnerGroupBox.TabIndex = 8;
            this.InnerGroupBox.TabStop = false;
            // 
            // LCDLabel
            // 
            this.LCDLabel.AutoSize = true;
            this.LCDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDLabel.Location = new System.Drawing.Point(24, 22);
            this.LCDLabel.Name = "LCDLabel";
            this.LCDLabel.Size = new System.Drawing.Size(89, 20);
            this.LCDLabel.TabIndex = 9;
            this.LCDLabel.Text = "LCD Size:";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(37, 51);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(76, 20);
            this.MemoryLabel.TabIndex = 10;
            this.MemoryLabel.Text = "Memory:";
            this.MemoryLabel.Click += new System.EventHandler(this.MemoryLabel_Click);
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(10, 80);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(103, 20);
            this.CPUBrandLabel.TabIndex = 11;
            this.CPUBrandLabel.Text = "CPU Brand:";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(20, 111);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(93, 20);
            this.CPUTypeLabel.TabIndex = 12;
            this.CPUTypeLabel.Text = "CPU Type:";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(-4, 144);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(117, 20);
            this.CPUNumberLabel.TabIndex = 13;
            this.CPUNumberLabel.Text = "CPU Number:";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(6, 176);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(107, 20);
            this.CPUSpeedLabel.TabIndex = 14;
            this.CPUSpeedLabel.Text = "CPU Speed:";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.Location = new System.Drawing.Point(60, 212);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(53, 20);
            this.HDDLabel.TabIndex = 15;
            this.HDDLabel.Text = "HDD:";
            this.HDDLabel.Click += new System.EventHandler(this.HDDLabel_Click);
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(18, 241);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(95, 20);
            this.GPUTypeLabel.TabIndex = 16;
            this.GPUTypeLabel.Text = "GPU Type:";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamLabel.Location = new System.Drawing.Point(22, 273);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(91, 20);
            this.WebCamLabel.TabIndex = 17;
            this.WebCamLabel.Text = "Web Cam:";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(74, 304);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(39, 20);
            this.OSLabel.TabIndex = 18;
            this.OSLabel.Text = "OS:";
            // 
            // OrderFormTextBox
            // 
            this.OrderFormTextBox.Location = new System.Drawing.Point(119, 22);
            this.OrderFormTextBox.Multiline = true;
            this.OrderFormTextBox.Name = "OrderFormTextBox";
            this.OrderFormTextBox.ReadOnly = true;
            this.OrderFormTextBox.Size = new System.Drawing.Size(362, 301);
            this.OrderFormTextBox.TabIndex = 19;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotalTextBox);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.TaxTextBox);
            this.PriceGroupBox.Controls.Add(this.PriceTextBox);
            this.PriceGroupBox.Controls.Add(this.TaxLabel);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Location = new System.Drawing.Point(540, 234);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(403, 178);
            this.PriceGroupBox.TabIndex = 3;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(6, 38);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(54, 20);
            this.PriceLabel.TabIndex = 20;
            this.PriceLabel.Text = "Price:";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(6, 80);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(149, 20);
            this.TaxLabel.TabIndex = 21;
            this.TaxLabel.Text = "Sales Tax (13%) :";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(200, 38);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(185, 30);
            this.PriceTextBox.TabIndex = 9;
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTextBox.Location = new System.Drawing.Point(200, 80);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(185, 30);
            this.TaxTextBox.TabIndex = 22;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(6, 130);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(54, 20);
            this.TotalLabel.TabIndex = 23;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(200, 123);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(185, 30);
            this.TotalTextBox.TabIndex = 24;
            // 
            // OrderFormBackButton
            // 
            this.OrderFormBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormBackButton.Location = new System.Drawing.Point(550, 453);
            this.OrderFormBackButton.Name = "OrderFormBackButton";
            this.OrderFormBackButton.Size = new System.Drawing.Size(90, 35);
            this.OrderFormBackButton.TabIndex = 4;
            this.OrderFormBackButton.Text = "Back";
            this.OrderFormBackButton.UseVisualStyleBackColor = true;
            // 
            // OrderFormCancelButton
            // 
            this.OrderFormCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormCancelButton.Location = new System.Drawing.Point(690, 453);
            this.OrderFormCancelButton.Name = "OrderFormCancelButton";
            this.OrderFormCancelButton.Size = new System.Drawing.Size(90, 35);
            this.OrderFormCancelButton.TabIndex = 5;
            this.OrderFormCancelButton.Text = "Cancel";
            this.OrderFormCancelButton.UseVisualStyleBackColor = true;
            // 
            // OrderFormFinishButon
            // 
            this.OrderFormFinishButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormFinishButon.Location = new System.Drawing.Point(820, 453);
            this.OrderFormFinishButon.Name = "OrderFormFinishButon";
            this.OrderFormFinishButon.Size = new System.Drawing.Size(90, 35);
            this.OrderFormFinishButon.TabIndex = 6;
            this.OrderFormFinishButon.Text = "Finish";
            this.OrderFormFinishButon.UseVisualStyleBackColor = true;
            // 
            // OrderFormPictureBox
            // 
            this.OrderFormPictureBox.BackgroundImage = global::Assignment_5.Properties.Resources.Latop;
            this.OrderFormPictureBox.Location = new System.Drawing.Point(570, 47);
            this.OrderFormPictureBox.Name = "OrderFormPictureBox";
            this.OrderFormPictureBox.Size = new System.Drawing.Size(170, 162);
            this.OrderFormPictureBox.TabIndex = 2;
            this.OrderFormPictureBox.TabStop = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(955, 509);
            this.ControlBox = false;
            this.Controls.Add(this.OrderFormFinishButon);
            this.Controls.Add(this.OrderFormCancelButton);
            this.Controls.Add(this.OrderFormBackButton);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.OrderFormPictureBox);
            this.Controls.Add(this.OrderFormGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Your Order";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.OrderFormGroupBox.ResumeLayout(false);
            this.OrderFormGroupBox.PerformLayout();
            this.InnerGroupBox.ResumeLayout(false);
            this.InnerGroupBox.PerformLayout();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox OrderFormGroupBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.GroupBox InnerGroupBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox OrderFormTextBox;
        private System.Windows.Forms.PictureBox OrderFormPictureBox;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button OrderFormBackButton;
        private System.Windows.Forms.Button OrderFormCancelButton;
        private System.Windows.Forms.Button OrderFormFinishButon;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}