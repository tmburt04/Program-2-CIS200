// Program 2
// CIS 200-01
// Spring 2017
// By: D4574

// File: CheckoutForm.cs

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
    public partial class CheckOutForm : Form
    {
        public CheckOutForm(List<LibraryItem> itemList, List<LibraryPatron> patronList)
        {
            InitializeComponent();


            //Finds the items that havent been checked out.
            var availableItems =
            from item in itemList
            where !item.IsCheckedOut()
            select item;

            // adds all of the library items to the items combo box
            foreach (var item in availableItems)
            {
                itemComboBox.Items.Add(string.Format("{0}, {1}", item.Title, item.CallNumber));
            }

            //Adds all of the patrons in the patron combo box
            foreach (var patron in patronList)
            {
                patronComboBox.Items.Add(string.Format("{0}, {1}", patron.PatronName, patron.PatronID));
            }

        }

        public int ItemValue
        {
            //pre condition: none
            //Post condition: Item in combobox is returned
            get
            {
                return itemComboBox.SelectedIndex;
            }
        }
        // Precondition:  Attempting to change focus from item combobox input
        // Postcondition: If input has a valid index, focus will change
        private void itemComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (itemComboBox.SelectedIndex < 0)
                e.Cancel = true; // Stops focus changing process
        }

        public int PatronValue
        {
            //pre condition: none
            //Post condition: Patron in combobox is returned
            get
            {
                return patronComboBox.SelectedIndex;
            }
        }
        // Precondition:  Attempting to change focus from patron combobox input
        // Postcondition: If input has a valid index, focus will change
        private void patronComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (patronComboBox.SelectedIndex < 0)
                e.Cancel = true; // Stops focus changing process
        }

        //Pre condition: User has clicked 'Check out' on  the gui
        //Post Condition: Form is closed and item is checked out
        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (patronComboBox.SelectedIndex >= 0 && itemComboBox.SelectedIndex >= 0)
                this.DialogResult = DialogResult.OK;
        }

        //Pre condition: User has clicked 'Cancel' on the gui
        //Post Condition: Form is closed and item is not checked out
        private void checkOutCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
