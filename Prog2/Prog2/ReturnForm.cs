// Program 2
// CIS 200-01
// Spring 2017
// By: D4574

// File: ReturnForm.cs

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
    public partial class ReturnForm : Form
    {
        public ReturnForm(List<LibraryItem> items)
        {
            InitializeComponent();

            //Finds the items that have been checked out.
            var checkedOutItems =
            from item in items
            where item.IsCheckedOut()
            select item;

            foreach (var item in checkedOutItems)
            {
                returnItemComboBox.Items.Add(string.Format("{0}, {1}", item.Title, item.CallNumber));
            }
        }

        public int ItemValue
        {
            //Precondition: None
            // Postcondition: item chosen to be returned is returned
            get
            {
                return returnItemComboBox.SelectedIndex;
            }
        }

        // Precondition:  Attempting to change focus from item combobox input
        // Postcondition: If input has a valid index, focus will change
        private void returnItemComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (returnItemComboBox.SelectedIndex < 0)
                e.Cancel = true; // Stops focus changing process
        }

        //Pre condition: User has clicked 'Cancel' on the gui
        //Post Condition: Form is closed and item is not checked out
        private void cancelReturnBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //Pre condition: User has clicked 'Check out' on  the gui
        //Post Condition: Form is closed and item is checked out
        private void confirmReturnBtn_Click(object sender, EventArgs e)
        {
            if (returnItemComboBox.SelectedIndex >= 0)
                this.DialogResult = DialogResult.OK;
        }
    }
}
