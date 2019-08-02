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
            this.SelectFormLabel = new System.Windows.Forms.Label();
            this.SelectFormGridView = new System.Windows.Forms.DataGridView();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.SelectTextBox = new System.Windows.Forms.TextBox();
            this.SelectCancelButton = new System.Windows.Forms.Button();
            this.SelectNextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFormGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFormLabel
            // 
            this.SelectFormLabel.AutoSize = true;
            this.SelectFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFormLabel.Location = new System.Drawing.Point(-3, 9);
            this.SelectFormLabel.Name = "SelectFormLabel";
            this.SelectFormLabel.Size = new System.Drawing.Size(386, 29);
            this.SelectFormLabel.TabIndex = 0;
            this.SelectFormLabel.Text = "Dollar Computer Hardware List :";
            // 
            // SelectFormGridView
            // 
            this.SelectFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectFormGridView.Location = new System.Drawing.Point(2, 41);
            this.SelectFormGridView.Name = "SelectFormGridView";
            this.SelectFormGridView.ReadOnly = true;
            this.SelectFormGridView.RowTemplate.Height = 28;
            this.SelectFormGridView.Size = new System.Drawing.Size(921, 234);
            this.SelectFormGridView.TabIndex = 1;
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionLabel.Location = new System.Drawing.Point(-3, 412);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(206, 29);
            this.SelectionLabel.TabIndex = 2;
            this.SelectionLabel.Text = "Your Selection : ";
            // 
            // SelectTextBox
            // 
            this.SelectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTextBox.Location = new System.Drawing.Point(195, 409);
            this.SelectTextBox.Name = "SelectTextBox";
            this.SelectTextBox.ReadOnly = true;
            this.SelectTextBox.Size = new System.Drawing.Size(456, 35);
            this.SelectTextBox.TabIndex = 3;
            // 
            // SelectCancelButton
            // 
            this.SelectCancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SelectCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCancelButton.Location = new System.Drawing.Point(677, 409);
            this.SelectCancelButton.Name = "SelectCancelButton";
            this.SelectCancelButton.Size = new System.Drawing.Size(101, 40);
            this.SelectCancelButton.TabIndex = 4;
            this.SelectCancelButton.Text = "Cancel";
            this.SelectCancelButton.UseVisualStyleBackColor = false;
            this.SelectCancelButton.Click += new System.EventHandler(this.selectCancelButton_Click);
            // 
            // SelectNextButton
            // 
            this.SelectNextButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SelectNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectNextButton.Location = new System.Drawing.Point(811, 409);
            this.SelectNextButton.Name = "SelectNextButton";
            this.SelectNextButton.Size = new System.Drawing.Size(101, 40);
            this.SelectNextButton.TabIndex = 5;
            this.SelectNextButton.Text = "Next";
            this.SelectNextButton.UseVisualStyleBackColor = false;
            this.SelectNextButton.Click += new System.EventHandler(this.SelectNextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(924, 469);
            this.ControlBox = false;
            this.Controls.Add(this.SelectNextButton);
            this.Controls.Add(this.SelectCancelButton);
            this.Controls.Add(this.SelectTextBox);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.SelectFormGridView);
            this.Controls.Add(this.SelectFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer !";
            ((System.ComponentModel.ISupportInitialize)(this.SelectFormGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectFormLabel;
        private System.Windows.Forms.DataGridView SelectFormGridView;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.TextBox SelectTextBox;
        private System.Windows.Forms.Button SelectCancelButton;
        private System.Windows.Forms.Button SelectNextButton;
    }
}