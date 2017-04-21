namespace LibraryItems
{
    partial class BookForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.callNumTextBox = new System.Windows.Forms.TextBox();
            this.copyrightTextBox = new System.Windows.Forms.TextBox();
            this.loanPeriodTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.callNumLbl = new System.Windows.Forms.Label();
            this.copyrightLbl = new System.Windows.Forms.Label();
            this.loanPeriodLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(19, 34);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(39, 17);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(115, 34);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(143, 22);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleTextBox_Validating);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(115, 62);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(143, 22);
            this.publisherTextBox.TabIndex = 2;
            this.publisherTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.publisherTextBox_Validating);
            // 
            // callNumTextBox
            // 
            this.callNumTextBox.Location = new System.Drawing.Point(115, 90);
            this.callNumTextBox.Name = "callNumTextBox";
            this.callNumTextBox.Size = new System.Drawing.Size(143, 22);
            this.callNumTextBox.TabIndex = 3;
            this.callNumTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.callNumTextBox_Validating);
            // 
            // copyrightTextBox
            // 
            this.copyrightTextBox.Location = new System.Drawing.Point(115, 118);
            this.copyrightTextBox.Name = "copyrightTextBox";
            this.copyrightTextBox.Size = new System.Drawing.Size(143, 22);
            this.copyrightTextBox.TabIndex = 4;
            this.copyrightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.copyrightTextBox_Validating);
            // 
            // loanPeriodTextBox
            // 
            this.loanPeriodTextBox.Location = new System.Drawing.Point(115, 146);
            this.loanPeriodTextBox.Name = "loanPeriodTextBox";
            this.loanPeriodTextBox.Size = new System.Drawing.Size(143, 22);
            this.loanPeriodTextBox.TabIndex = 5;
            this.loanPeriodTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.loanPeriodTextBox_Validating);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(115, 174);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(143, 22);
            this.authorTextBox.TabIndex = 6;
            this.authorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.authorTextBox_Validating);
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(19, 65);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(71, 17);
            this.publisherLbl.TabIndex = 7;
            this.publisherLbl.Text = "Publisher:";
            // 
            // callNumLbl
            // 
            this.callNumLbl.AutoSize = true;
            this.callNumLbl.Location = new System.Drawing.Point(19, 93);
            this.callNumLbl.Name = "callNumLbl";
            this.callNumLbl.Size = new System.Drawing.Size(47, 17);
            this.callNumLbl.TabIndex = 8;
            this.callNumLbl.Text = "Call #:";
            // 
            // copyrightLbl
            // 
            this.copyrightLbl.AutoSize = true;
            this.copyrightLbl.Location = new System.Drawing.Point(19, 121);
            this.copyrightLbl.Name = "copyrightLbl";
            this.copyrightLbl.Size = new System.Drawing.Size(72, 17);
            this.copyrightLbl.TabIndex = 9;
            this.copyrightLbl.Text = "Copyright:";
            // 
            // loanPeriodLbl
            // 
            this.loanPeriodLbl.AutoSize = true;
            this.loanPeriodLbl.Location = new System.Drawing.Point(19, 149);
            this.loanPeriodLbl.Name = "loanPeriodLbl";
            this.loanPeriodLbl.Size = new System.Drawing.Size(89, 17);
            this.loanPeriodLbl.TabIndex = 10;
            this.loanPeriodLbl.Text = "Loan Period:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(19, 177);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(54, 17);
            this.authorLbl.TabIndex = 11;
            this.authorLbl.Text = "Author:";
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(182, 218);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(75, 23);
            this.addBookBtn.TabIndex = 12;
            this.addBookBtn.Text = "Add";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.loanPeriodLbl);
            this.Controls.Add(this.copyrightLbl);
            this.Controls.Add(this.callNumLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.loanPeriodTextBox);
            this.Controls.Add(this.copyrightTextBox);
            this.Controls.Add(this.callNumTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLbl);
            this.Name = "BookForm";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox callNumTextBox;
        private System.Windows.Forms.TextBox copyrightTextBox;
        private System.Windows.Forms.TextBox loanPeriodTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label callNumLbl;
        private System.Windows.Forms.Label copyrightLbl;
        private System.Windows.Forms.Label loanPeriodLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button button1;
    }
}