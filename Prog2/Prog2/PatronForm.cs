// Program 2
// CIS 200-01
// Spring 2017
// By: D4574

// File: PatronForm.cs

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
    public partial class PatronForm : Form
    {
        public PatronForm()
        {
            InitializeComponent();
        }

        public string PatronName
        {
            //Precondition: None
            //PostCondition: Patron Name is returned from GUI
            get
            {
                return patronNameTextBox.Text;
            }
            //Precondition: None
            //PostCondition: Patron Name is updated in GUI
            set
            {
                patronNameTextBox.Text = value;
            }
        }
        // Precondition:  Attempting to change focus from patron name input
        // Postcondition: If input is valid string, focus will change
        private void patronNameTextBox_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(patronNameTextBox.Text))
                e.Cancel = true; // Stops focus changing process

            patronNameTextBox.SelectAll(); // Select all text in textbox to ease correction

        }

        public string PatronId
        {
            //Precondition: None
            //PostCondition: Patron id is returned from GUI
            get
            {
                return patronIdTextBox.Text;
            }
            //Precondition: None
            //PostCondition: Patron id is updated in GUI
            set
            {
                patronIdTextBox.Text = value;
            }
        }
        // Precondition:  Attempting to change focus from patron id input
        // Postcondition: If input is valid string, focus will change
        private void patronIdTextBox_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(patronIdTextBox.Text))
                e.Cancel = true; // Stops focus changing process

            patronIdTextBox.SelectAll(); // Select all text in textbox to ease correction

        }

        private void addPatronBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(patronIdTextBox.Text) && !string.IsNullOrWhiteSpace(patronIdTextBox.Text))
                this.DialogResult = DialogResult.OK;
        }

        private void patronCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
