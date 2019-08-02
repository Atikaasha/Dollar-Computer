namespace Assignment_5
{
    partial class StartForm
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
            this.startlabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.startFormPictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlabel.Location = new System.Drawing.Point(78, 22);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(183, 32);
            this.startlabel.TabIndex = 0;
            this.startlabel.Text = "Order Here!!";
            this.startlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(74, 278);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(187, 39);
            this.newOrderButton.TabIndex = 1;
            this.newOrderButton.Text = "Start a New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            // 
            // startFormPictureBox
            // 
            this.startFormPictureBox.BackgroundImage = global::Assignment_5.Properties.Resources.startForm;
            this.startFormPictureBox.Location = new System.Drawing.Point(74, 66);
            this.startFormPictureBox.Name = "startFormPictureBox";
            this.startFormPictureBox.Size = new System.Drawing.Size(187, 193);
            this.startFormPictureBox.TabIndex = 2;
            this.startFormPictureBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(74, 335);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(187, 39);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Open a Saved Order";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(74, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 39);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(328, 444);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startFormPictureBox);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.startlabel);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dollar Computer welcomes you!";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.PictureBox startFormPictureBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
    }
}