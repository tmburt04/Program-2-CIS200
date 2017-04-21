// Program 2
// CIS 200-01
// Spring 2017
// By: D4574

// File: BookForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }
        public string Title
        {
            //Precondition: None
            //PostCondition: Title information is returned from GUI
            get
            {
                return titleTextBox.Text;
            }
            //Precondition: None
            //PostCondition: Title information is updated in GUI
            set
            {
                titleTextBox.Text = value;
            }
        }
        // Precondition:  Attempting to change focus from title input
        // Postcondition: If input is valid string, focus will change
        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
                e.Cancel = true; // Stops focus changing process

            titleTextBox.SelectAll(); // Select all text in textbox to ease correction

        }
        public string Author
        {
            //Precondition: None
            //PostCondition: Author information is returned from GUI
            get
            {
                return authorTextBox.Text;
            }
            //Precondition: None
            //PostCondition: Author information is updated in GUI
            set
            {
                authorTextBox.Text = value;
            }
        }
        // Precondition:  Attempting to change focus from Author input
        // Postcondition: If input is valid string, focus will change
        private void authorTextBox_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(authorTextBox.Text))
                e.Cancel = true; // Stops focus changing process

            authorTextBox.SelectAll(); // Select all text in textbox to ease correction

        }

        public string Publisher
        {
            //Precondition: None
            //PostCondition: Publisher information is returned from GUI
            get
            {
                return publisherTextBox.Text;
            }
            //Precondition: None
            //PostCondition: Publisher information is updated in GUI
            set
            {
                publisherTextBox.Text = value;
            }
        }
        // Precondition:  Attempting to change focus from Publisher input
        // Postcondition: If input is valid string, focus will change
        private void publisherTextBox_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(publisherTextBox.Text))
                e.Cancel = true; // Stops focus changing process

            publisherTextBox.SelectAll(); // Select all text in textbox to ease correction

        }

        public string Copyright
        {
            //Precondition: None
            //PostCondition: Copyright information is returned from GUI
            get
            {
                return copyrightTextBox.Text;
            }
            //Precondition: None
            //PostCondition: Copyright information is updated in GUI
            set
            {
                copyrightTextBox.Text = value;
            }
        }
        // Precondition:  Attempting to change focus from Copyright input
        // Postcondition: If input is valid string, focus will change
        private void copyrightTextBox_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(copyrightTextBox.Text, out num))
            {
                if (num > 0)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;

                    copyrightTextBox.SelectAll(); // Select all text in textbox to ease correction
                }
            }
            else
            {
                e.Cancel = true;

                copyrightTextBox.SelectAll(); // Select all text in textbox to ease correction
            }
        }

        public string LoanPeriod
        {
            //Precondition: None
            //PostCondition: Loan Period information is returned from GUI
            get
            {
                return loanPeriodTextBox.Text;
            }
            //Precondition: None
            //PostCondition: Loan Period information is updated in GUI
            set
            {
                loanPeriodTextBox.Text = value;
            }
        }
        // Precondition:  Attempting to change focus from loan period input
        // Postcondition: If input is valid string, focus will change
        private void loanPeriodTextBox_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(loanPeriodTextBox.Text, out num))
            {
                if (num > 0)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;

                    loanPeriodTextBox.SelectAll(); // Select all text in textbox to ease correction
                }
            }
            else
            {
                e.Cancel = true;

                loanPeriodTextBox.SelectAll(); // Select all text in textbox to ease correction
            }
        }

        public string CallNum
        {
            //Precondition: None
            //PostCondition: Call Number information is returned from GUI
            get
            {
                return callNumTextBox.Text;
            }
            //Precondition: None
            //PostCondition: Call Number information is updated in GUI
            set
            {
                callNumTextBox.Text = value;
            }
        }

        // Precondition:  Attempting to change focus from call num input
        // Postcondition: If input is valid string, focus will change
        private void callNumTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(callNumTextBox.Text))
                e.Cancel = true; // Stops focus changing process

            callNumTextBox.SelectAll(); // Select all text in textbox to ease correction

        }

        // Precondition: User has clicked the Add button
        // PostCondition: Book form is closed and book  is added
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(callNumTextBox.Text) && !string.IsNullOrWhiteSpace(loanPeriodTextBox.Text) && !string.IsNullOrWhiteSpace(copyrightTextBox.Text) &&
                !string.IsNullOrWhiteSpace(authorTextBox.Text) && !string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(publisherTextBox.Text))
                this.DialogResult = DialogResult.OK;
        }
        // Precondition: User has clicked the cancel button
        // PostCondition: Book form is closed
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
