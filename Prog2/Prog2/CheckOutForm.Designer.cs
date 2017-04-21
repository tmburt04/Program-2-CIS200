namespace LibraryItems
{
    partial class CheckOutForm
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
            this.patronComboBox = new System.Windows.Forms.ComboBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.checkOutCancelBtn = new System.Windows.Forms.Button();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patronComboBox
            // 
            this.patronComboBox.FormattingEnabled = true;
            this.patronComboBox.Location = new System.Drawing.Point(12, 23);
            this.patronComboBox.Name = "patronComboBox";
            this.patronComboBox.Size = new System.Drawing.Size(241, 24);
            this.patronComboBox.TabIndex = 0;
            this.patronComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronComboBox_Validating);
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(12, 63);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(241, 24);
            this.itemComboBox.TabIndex = 1;
            this.itemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.itemComboBox_Validating);
            // 
            // checkOutCancelBtn
            // 
            this.checkOutCancelBtn.Location = new System.Drawing.Point(13, 115);
            this.checkOutCancelBtn.Name = "checkOutCancelBtn";
            this.checkOutCancelBtn.Size = new System.Drawing.Size(86, 23);
            this.checkOutCancelBtn.TabIndex = 2;
            this.checkOutCancelBtn.Text = "Cancel";
            this.checkOutCancelBtn.UseVisualStyleBackColor = true;
            this.checkOutCancelBtn.Click += new System.EventHandler(this.checkOutCancelBtn_Click);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(172, 115);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(84, 23);
            this.checkOutBtn.TabIndex = 3;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 150);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.checkOutCancelBtn);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.patronComboBox);
            this.Name = "CheckOutForm";
            this.Text = "Check Out";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox patronComboBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Button checkOutCancelBtn;
        private System.Windows.Forms.Button checkOutBtn;
    }
}