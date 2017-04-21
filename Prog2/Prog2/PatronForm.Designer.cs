namespace LibraryItems
{
    partial class PatronForm
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
            this.patronNameLbl = new System.Windows.Forms.Label();
            this.patronIdLbl = new System.Windows.Forms.Label();
            this.patronNameTextBox = new System.Windows.Forms.TextBox();
            this.patronIdTextBox = new System.Windows.Forms.TextBox();
            this.addPatronBtn = new System.Windows.Forms.Button();
            this.patronCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patronNameLbl
            // 
            this.patronNameLbl.AutoSize = true;
            this.patronNameLbl.Location = new System.Drawing.Point(12, 29);
            this.patronNameLbl.Name = "patronNameLbl";
            this.patronNameLbl.Size = new System.Drawing.Size(49, 17);
            this.patronNameLbl.TabIndex = 0;
            this.patronNameLbl.Text = "Name:";
            // 
            // patronIdLbl
            // 
            this.patronIdLbl.AutoSize = true;
            this.patronIdLbl.Location = new System.Drawing.Point(12, 62);
            this.patronIdLbl.Name = "patronIdLbl";
            this.patronIdLbl.Size = new System.Drawing.Size(25, 17);
            this.patronIdLbl.TabIndex = 1;
            this.patronIdLbl.Text = "ID:";
            // 
            // patronNameTextBox
            // 
            this.patronNameTextBox.Location = new System.Drawing.Point(67, 26);
            this.patronNameTextBox.Name = "patronNameTextBox";
            this.patronNameTextBox.Size = new System.Drawing.Size(188, 22);
            this.patronNameTextBox.TabIndex = 2;
            this.patronNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronNameTextBox_Validating);
            // 
            // patronIdTextBox
            // 
            this.patronIdTextBox.Location = new System.Drawing.Point(67, 59);
            this.patronIdTextBox.Name = "patronIdTextBox";
            this.patronIdTextBox.Size = new System.Drawing.Size(188, 22);
            this.patronIdTextBox.TabIndex = 3;
            this.patronNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronNameTextBox_Validating);
            // 
            // addPatronBtn
            // 
            this.addPatronBtn.Location = new System.Drawing.Point(186, 105);
            this.addPatronBtn.Name = "addPatronBtn";
            this.addPatronBtn.Size = new System.Drawing.Size(75, 23);
            this.addPatronBtn.TabIndex = 4;
            this.addPatronBtn.Text = "Add";
            this.addPatronBtn.UseVisualStyleBackColor = true;
            this.addPatronBtn.Click += new System.EventHandler(this.addPatronBtn_Click);
            // 
            // patronCancelBtn
            // 
            this.patronCancelBtn.Location = new System.Drawing.Point(12, 105);
            this.patronCancelBtn.Name = "patronCancelBtn";
            this.patronCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.patronCancelBtn.TabIndex = 5;
            this.patronCancelBtn.Text = "Cancel";
            this.patronCancelBtn.UseVisualStyleBackColor = true;
            this.patronCancelBtn.Click += new System.EventHandler(this.patronCancelBtn_Click);
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 143);
            this.Controls.Add(this.patronCancelBtn);
            this.Controls.Add(this.addPatronBtn);
            this.Controls.Add(this.patronIdTextBox);
            this.Controls.Add(this.patronNameTextBox);
            this.Controls.Add(this.patronIdLbl);
            this.Controls.Add(this.patronNameLbl);
            this.Name = "PatronForm";
            this.Text = "Add Patron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patronNameLbl;
        private System.Windows.Forms.Label patronIdLbl;
        private System.Windows.Forms.TextBox patronNameTextBox;
        private System.Windows.Forms.TextBox patronIdTextBox;
        private System.Windows.Forms.Button addPatronBtn;
        private System.Windows.Forms.Button patronCancelBtn;
    }
}