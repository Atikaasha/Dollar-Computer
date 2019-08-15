namespace Assignment_5.Views
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.ProductMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBinaryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAnotherFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionTexBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.TechSpecGroupBox = new System.Windows.Forms.GroupBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.LCDTextBox = new System.Windows.Forms.TextBox();
            this.LCDLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.AnotherButton = new System.Windows.Forms.Button();
            this.CancelProductButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ProductInfoOpenFileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoSaveFileDialogue = new System.Windows.Forms.SaveFileDialog();
            this.ProductMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecGroupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductMenuStrip
            // 
            this.ProductMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ProductMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductMenuStrip.Name = "ProductMenuStrip";
            this.ProductMenuStrip.Size = new System.Drawing.Size(955, 33);
            this.ProductMenuStrip.TabIndex = 0;
            this.ProductMenuStrip.Text = "Menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.OpenBinaryFileToolStripMenuItem,
            this.SaveBinaryToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.OpenToolStripMenuItem.Text = "&Open (Text File)";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.SaveToolStripMenuItem.Text = "&Save (Text File)";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // OpenBinaryFileToolStripMenuItem
            // 
            this.OpenBinaryFileToolStripMenuItem.Name = "OpenBinaryFileToolStripMenuItem";
            this.OpenBinaryFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.OpenBinaryFileToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.OpenBinaryFileToolStripMenuItem.Text = "Open (&Binary File)";
            this.OpenBinaryFileToolStripMenuItem.Click += new System.EventHandler(this.OpenBinaryFileToolStripMenuItem_Click);
            // 
            // SaveBinaryToolStripMenuItem
            // 
            this.SaveBinaryToolStripMenuItem.Name = "SaveBinaryToolStripMenuItem";
            this.SaveBinaryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.SaveBinaryToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.SaveBinaryToolStripMenuItem.Text = "Save (B&inary File)";
            this.SaveBinaryToolStripMenuItem.Click += new System.EventHandler(this.SaveBinaryToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.ExitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAnotherFormToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // SelectAnotherFormToolStripMenuItem
            // 
            this.SelectAnotherFormToolStripMenuItem.Name = "SelectAnotherFormToolStripMenuItem";
            this.SelectAnotherFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.SelectAnotherFormToolStripMenuItem.Size = new System.Drawing.Size(337, 30);
            this.SelectAnotherFormToolStripMenuItem.Text = "Se&lect Another Product";
            this.SelectAnotherFormToolStripMenuItem.Click += new System.EventHandler(this.AnotherButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(29, 57);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(120, 25);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID:";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Enabled = false;
            this.ProductIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDTextBox.Location = new System.Drawing.Point(164, 57);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.ReadOnly = true;
            this.ProductIDTextBox.Size = new System.Drawing.Size(134, 30);
            this.ProductIDTextBox.TabIndex = 2;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(304, 62);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(111, 25);
            this.ConditionLabel.TabIndex = 3;
            this.ConditionLabel.Text = "Condition:";
            // 
            // ConditionTexBox
            // 
            this.ConditionTexBox.Enabled = false;
            this.ConditionTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTexBox.Location = new System.Drawing.Point(412, 62);
            this.ConditionTexBox.Name = "ConditionTexBox";
            this.ConditionTexBox.ReadOnly = true;
            this.ConditionTexBox.Size = new System.Drawing.Size(134, 30);
            this.ConditionTexBox.TabIndex = 4;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(588, 65);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(64, 25);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Enabled = false;
            this.CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.Location = new System.Drawing.Point(670, 65);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(134, 30);
            this.CostTextBox.TabIndex = 6;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.BackColor = System.Drawing.SystemColors.Info;
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Enabled = false;
            this.ProductInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(12, 100);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(866, 109);
            this.ProductInfoGroupBox.TabIndex = 7;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info:";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(400, 64);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(413, 30);
            this.ModelTextBox.TabIndex = 14;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(309, 69);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(78, 25);
            this.ModelLabel.TabIndex = 13;
            this.ModelLabel.Text = "Model:";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTextBox.Location = new System.Drawing.Point(152, 64);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(134, 30);
            this.ManufacturerTextBox.TabIndex = 12;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(0, 69);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(146, 25);
            this.ManufacturerLabel.TabIndex = 11;
            this.ManufacturerLabel.Text = "Manufacturer:";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSTextBox.Location = new System.Drawing.Point(400, 21);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(413, 30);
            this.OSTextBox.TabIndex = 10;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(336, 26);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(51, 25);
            this.OSLabel.TabIndex = 9;
            this.OSLabel.Text = "OS:";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformTextBox.Location = new System.Drawing.Point(152, 26);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(134, 30);
            this.PlatformTextBox.TabIndex = 8;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(48, 26);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(98, 25);
            this.PlatformLabel.TabIndex = 8;
            this.PlatformLabel.Text = "Platform:";
            // 
            // TechSpecGroupBox
            // 
            this.TechSpecGroupBox.BackColor = System.Drawing.SystemColors.Info;
            this.TechSpecGroupBox.Controls.Add(this.WebCamTextBox);
            this.TechSpecGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecGroupBox.Controls.Add(this.LCDTextBox);
            this.TechSpecGroupBox.Controls.Add(this.LCDLabel);
            this.TechSpecGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.TechSpecGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecGroupBox.Enabled = false;
            this.TechSpecGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechSpecGroupBox.Location = new System.Drawing.Point(12, 239);
            this.TechSpecGroupBox.Name = "TechSpecGroupBox";
            this.TechSpecGroupBox.Size = new System.Drawing.Size(866, 162);
            this.TechSpecGroupBox.TabIndex = 15;
            this.TechSpecGroupBox.TabStop = false;
            this.TechSpecGroupBox.Text = " Tech Specs:";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamTextBox.Location = new System.Drawing.Point(697, 110);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.ReadOnly = true;
            this.WebCamTextBox.Size = new System.Drawing.Size(143, 30);
            this.WebCamTextBox.TabIndex = 24;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamLabel.Location = new System.Drawing.Point(582, 110);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(109, 25);
            this.WebCamLabel.TabIndex = 23;
            this.WebCamLabel.Text = "WebCam:";
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(438, 110);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.ReadOnly = true;
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(134, 30);
            this.CPUSpeedTextBox.TabIndex = 22;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(292, 113);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(133, 25);
            this.CPUSpeedLabel.TabIndex = 21;
            this.CPUSpeedLabel.Text = "CPU Speed:";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeTextBox.Location = new System.Drawing.Point(152, 110);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.ReadOnly = true;
            this.CPUTypeTextBox.Size = new System.Drawing.Size(134, 30);
            this.CPUTypeTextBox.TabIndex = 20;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(14, 115);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(119, 25);
            this.CPUTypeLabel.TabIndex = 19;
            this.CPUTypeLabel.Text = "CPU Type:";
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeTextBox.Location = new System.Drawing.Point(697, 71);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.ReadOnly = true;
            this.GPUTypeTextBox.Size = new System.Drawing.Size(143, 30);
            this.GPUTypeTextBox.TabIndex = 18;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(572, 71);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(119, 25);
            this.GPUTypeLabel.TabIndex = 17;
            this.GPUTypeLabel.Text = "GPU Type:";
            // 
            // LCDTextBox
            // 
            this.LCDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDTextBox.Location = new System.Drawing.Point(438, 24);
            this.LCDTextBox.Name = "LCDTextBox";
            this.LCDTextBox.ReadOnly = true;
            this.LCDTextBox.Size = new System.Drawing.Size(134, 30);
            this.LCDTextBox.TabIndex = 16;
            // 
            // LCDLabel
            // 
            this.LCDLabel.AutoSize = true;
            this.LCDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDLabel.Location = new System.Drawing.Point(321, 29);
            this.LCDLabel.Name = "LCDLabel";
            this.LCDLabel.Size = new System.Drawing.Size(111, 25);
            this.LCDLabel.TabIndex = 15;
            this.LCDLabel.Text = "LCD Size:";
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberTextBox.Location = new System.Drawing.Point(438, 71);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.ReadOnly = true;
            this.CPUNumberTextBox.Size = new System.Drawing.Size(134, 30);
            this.CPUNumberTextBox.TabIndex = 14;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(287, 76);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(145, 25);
            this.CPUNumberLabel.TabIndex = 13;
            this.CPUNumberLabel.Text = "CPU Number:";
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandTextBox.Location = new System.Drawing.Point(152, 66);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(134, 30);
            this.CPUBrandTextBox.TabIndex = 12;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(6, 71);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(127, 25);
            this.CPUBrandLabel.TabIndex = 11;
            this.CPUBrandLabel.Text = "CPU Brand:";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDTextBox.Location = new System.Drawing.Point(697, 23);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.ReadOnly = true;
            this.HDDTextBox.Size = new System.Drawing.Size(143, 30);
            this.HDDTextBox.TabIndex = 10;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.Location = new System.Drawing.Point(627, 29);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(64, 25);
            this.HDDLabel.TabIndex = 9;
            this.HDDLabel.Text = "HDD:";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryTextBox.Location = new System.Drawing.Point(152, 26);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(134, 30);
            this.MemoryTextBox.TabIndex = 8;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(37, 31);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(96, 25);
            this.MemoryLabel.TabIndex = 8;
            this.MemoryLabel.Text = "Memory:";
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmLabel.Location = new System.Drawing.Point(18, 422);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(354, 25);
            this.ConfirmLabel.TabIndex = 20;
            this.ConfirmLabel.Text = "Click next to confirm your selection:";
            // 
            // AnotherButton
            // 
            this.AnotherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnotherButton.Location = new System.Drawing.Point(412, 422);
            this.AnotherButton.Name = "AnotherButton";
            this.AnotherButton.Size = new System.Drawing.Size(202, 41);
            this.AnotherButton.TabIndex = 21;
            this.AnotherButton.Text = "Select another Product";
            this.AnotherButton.UseVisualStyleBackColor = true;
            this.AnotherButton.Click += new System.EventHandler(this.AnotherButton_Click);
            // 
            // CancelProductButton
            // 
            this.CancelProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelProductButton.Location = new System.Drawing.Point(650, 422);
            this.CancelProductButton.Name = "CancelProductButton";
            this.CancelProductButton.Size = new System.Drawing.Size(93, 41);
            this.CancelProductButton.TabIndex = 22;
            this.CancelProductButton.Text = "Cancel";
            this.CancelProductButton.UseVisualStyleBackColor = true;
            this.CancelProductButton.Click += new System.EventHandler(this.CancelProductButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(771, 422);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(93, 41);
            this.NextButton.TabIndex = 23;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(955, 31);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // ProductInfoOpenFileDialogue
            // 
            this.ProductInfoOpenFileDialogue.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(955, 509);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelProductButton);
            this.Controls.Add(this.AnotherButton);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.TechSpecGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionTexBox);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductMenuStrip);
            this.MaximizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.ProductMenuStrip.ResumeLayout(false);
            this.ProductMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecGroupBox.ResumeLayout(false);
            this.TechSpecGroupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox ConditionTexBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.GroupBox TechSpecGroupBox;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.TextBox LCDTextBox;
        private System.Windows.Forms.Label LCDLabel;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button AnotherButton;
        private System.Windows.Forms.Button CancelProductButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAnotherFormToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.OpenFileDialog ProductInfoOpenFileDialogue;
        private System.Windows.Forms.SaveFileDialog ProductInfoSaveFileDialogue;
        private System.Windows.Forms.ToolStripMenuItem OpenBinaryFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveBinaryToolStripMenuItem;
    }
}