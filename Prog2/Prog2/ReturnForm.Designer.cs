namespace LibraryItems
{
    partial class ReturnForm
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
            this.returnItemComboBox = new System.Windows.Forms.ComboBox();
            this.cancelReturnBtn = new System.Windows.Forms.Button();
            this.confirmReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnItemComboBox
            // 
            this.returnItemComboBox.FormattingEnabled = true;
            this.returnItemComboBox.Location = new System.Drawing.Point(12, 25);
            this.returnItemComboBox.Name = "returnItemComboBox";
            this.returnItemComboBox.Size = new System.Drawing.Size(237, 24);
            this.returnItemComboBox.TabIndex = 0;
            this.returnItemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.returnItemComboBox_Validating);
            // 
            // cancelReturnBtn
            // 
            this.cancelReturnBtn.Location = new System.Drawing.Point(13, 73);
            this.cancelReturnBtn.Name = "cancelReturnBtn";
            this.cancelReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelReturnBtn.TabIndex = 1;
            this.cancelReturnBtn.Text = "Cancel";
            this.cancelReturnBtn.UseVisualStyleBackColor = true;
            this.cancelReturnBtn.Click += new System.EventHandler(this.cancelReturnBtn_Click);
            // 
            // confirmReturnBtn
            // 
            this.confirmReturnBtn.Location = new System.Drawing.Point(173, 73);
            this.confirmReturnBtn.Name = "confirmReturnBtn";
            this.confirmReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmReturnBtn.TabIndex = 2;
            this.confirmReturnBtn.Text = "Ok";
            this.confirmReturnBtn.UseVisualStyleBackColor = true;
            this.confirmReturnBtn.Click += new System.EventHandler(this.confirmReturnBtn_Click);
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 108);
            this.Controls.Add(this.confirmReturnBtn);
            this.Controls.Add(this.cancelReturnBtn);
            this.Controls.Add(this.returnItemComboBox);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox returnItemComboBox;
        private System.Windows.Forms.Button cancelReturnBtn;
        private System.Windows.Forms.Button confirmReturnBtn;
    }
}