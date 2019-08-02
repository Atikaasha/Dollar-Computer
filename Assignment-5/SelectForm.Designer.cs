namespace Assignment_5
{
    partial class SelectForm
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
            this.selectFormLabel = new System.Windows.Forms.Label();
            this.selectFormGridView = new System.Windows.Forms.DataGridView();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectCancelButton = new System.Windows.Forms.Button();
            this.selectNextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectFormGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFormLabel
            // 
            this.selectFormLabel.AutoSize = true;
            this.selectFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFormLabel.Location = new System.Drawing.Point(-3, 9);
            this.selectFormLabel.Name = "selectFormLabel";
            this.selectFormLabel.Size = new System.Drawing.Size(386, 29);
            this.selectFormLabel.TabIndex = 0;
            this.selectFormLabel.Text = "Dollar Computer Hardware List :";
            // 
            // selectFormGridView
            // 
            this.selectFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectFormGridView.Location = new System.Drawing.Point(2, 41);
            this.selectFormGridView.Name = "selectFormGridView";
            this.selectFormGridView.ReadOnly = true;
            this.selectFormGridView.RowTemplate.Height = 28;
            this.selectFormGridView.Size = new System.Drawing.Size(921, 234);
            this.selectFormGridView.TabIndex = 1;
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionLabel.Location = new System.Drawing.Point(-3, 412);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(206, 29);
            this.selectionLabel.TabIndex = 2;
            this.selectionLabel.Text = "Your Selection : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(195, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(456, 35);
            this.textBox1.TabIndex = 3;
            // 
            // selectCancelButton
            // 
            this.selectCancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCancelButton.Location = new System.Drawing.Point(677, 409);
            this.selectCancelButton.Name = "selectCancelButton";
            this.selectCancelButton.Size = new System.Drawing.Size(101, 40);
            this.selectCancelButton.TabIndex = 4;
            this.selectCancelButton.Text = "Cancel";
            this.selectCancelButton.UseVisualStyleBackColor = false;
            this.selectCancelButton.Click += new System.EventHandler(this.selectCancelButton_Click);
            // 
            // selectNextButton
            // 
            this.selectNextButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNextButton.Location = new System.Drawing.Point(811, 409);
            this.selectNextButton.Name = "selectNextButton";
            this.selectNextButton.Size = new System.Drawing.Size(101, 40);
            this.selectNextButton.TabIndex = 5;
            this.selectNextButton.Text = "Next";
            this.selectNextButton.UseVisualStyleBackColor = false;
            // 
            // SelectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(924, 469);
            this.ControlBox = false;
            this.Controls.Add(this.selectNextButton);
            this.Controls.Add(this.selectCancelButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.selectFormGridView);
            this.Controls.Add(this.selectFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer !";
            ((System.ComponentModel.ISupportInitialize)(this.selectFormGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectFormLabel;
        private System.Windows.Forms.DataGridView selectFormGridView;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button selectCancelButton;
        private System.Windows.Forms.Button selectNextButton;
    }
}