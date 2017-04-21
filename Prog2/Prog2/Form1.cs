
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
    public partial class Form1 : Form
    {
        //Creates the variable of 'Library' type to hold test data and run
        private Library _library;

        public Form1()
        {
            InitializeComponent();

            //Instantiates the library variable
            _library = new Library();

            //Test data for the library
            _library.AddLibraryBook("Deception", "press", 2000, 12, "234 3G", "John Frisham");

            _library.AddLibraryMovie("Ferris Buelers Day off", "Universal", 1981, 7, "MM D", 92.5, "Mathhewo Machons", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
 
            _library.AddLibraryMusic("Take Care", "OVO", 2011, 14, "232 4Z", 84.3, "Drake", LibraryMediaItem.MediaType.CD, 10);
            
            _library.AddLibraryJournal("Universe", "UofL Journals", 2011, 14, "32123 7M", 1, 2, "Cards Rule", "Andrew Wright");

            _library.AddLibraryMagazine("C#: a contiouns process", "UofL", 2010, 14, "MA1", 16, 7);

            _library.AddPatron("Andrew Right", "12345");
            _library.AddPatron("Tim Burton", "23456");
            _library.AddPatron("John Smith", "34567");
            _library.AddPatron("James Johnson", "45678");
            _library.AddPatron("John Phillips", "56789");
        }

        //Pre Condition: None
        //Post Condition: Brings up dialogue displaying information about the application
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutText = "Developer: D4574" + Environment.NewLine +
            "Program: 2" + Environment.NewLine +
            "Due Date: 03/10/2017";
            MessageBox.Show(aboutText, "About");
        }

        //Pre Condition: None
        //Post Condition: Closes the Program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Pre Condition: None
        //Post Condition: New patron is added to the library list
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates a patron form and opens it
            PatronForm patronForm = new PatronForm();

            string name; // Holds the patrons name
            string id; // Holds the patrons id

            DialogResult result = patronForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                name = patronForm.PatronName;
                id = patronForm.PatronId;

                _library.AddPatron(name, id);

            }
        }

        //Pre Condition: None
        //Post Condition: New book is added to the library list
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates a Book form and opens it
            BookForm bookForm = new BookForm();

            string title; // Holds the book title
            string author; // Holds the Authors name of the book
            string publisher; // holds the publishers name of the book
            int copyrightYr; // holds the copyright year of the book
            int loanPeriod; // holds the loan period of the book
            string callNum; // Holds the call number for the book

            DialogResult result = bookForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                title = bookForm.Title;
                author = bookForm.Author;
                publisher = bookForm.Publisher;
                copyrightYr = Convert.ToInt32(bookForm.Copyright);
                loanPeriod = Convert.ToInt32(bookForm.LoanPeriod);
                callNum = bookForm.CallNum;

                _library.AddLibraryBook(title, publisher, copyrightYr, loanPeriod, callNum, author);

            }
        }

        //Pre Condition: None
        //Post Condition: Item of users choice is checkout from the library
        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates a checkout form and opens it
            CheckOutForm checkoutForm = new CheckOutForm(_library._items, _library._patrons);

            int item; // Holds the item index
            int patron; // Holds the patron index

            DialogResult result = checkoutForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                item = checkoutForm.ItemValue;
                patron = checkoutForm.PatronValue;

                _library.CheckOut(item, patron);
            }
        }

        //Pre Condition: None
        //Post Condition: Item of users choice is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnForm returnForm = new ReturnForm(_library._items);

            int item; // Holds the item index

            DialogResult result = returnForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                item = returnForm.ItemValue;

                _library.ReturnToShelf(item);
            }
        }

        //Pre Condition: None
        //Post Condition: Displays the list of patrons in the library
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDisplay.Clear();

            //Displays all registered patrons in the db
            foreach (var patron in _library._patrons)
            {
                mainDisplay.Text += string.Format("{0}{1}{1}", patron, Environment.NewLine);
            }
        }

        //Pre Condition: None
        //Post Condition: Displays the list of items in the Library
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDisplay.Clear();

            mainDisplay.Text += string.Format("There are {0} items in the library. {1}", _library.GetItemCount(), Environment.NewLine);

            //Displays all registered library items
            foreach (var item in _library._items)
            {
                mainDisplay.Text += string.Format("{1}{0}{1}", item, Environment.NewLine);
            }
        }

        //Pre Condition: None
        //Post Condition: displays a list of the checked out items at the library
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDisplay.Clear();

            //gets items that are checked out
            var checkedOutItems =
                from item in _library._items
                where item.IsCheckedOut()
                select item;

            mainDisplay.Text += string.Format("There are {0} items that are checked out. {1}", checkedOutItems.Count(), Environment.NewLine);

            //Displays all registered library items that are checked out
            foreach (var item in checkedOutItems)
            {
                mainDisplay.Text += string.Format("{1}{0}{1}", item, Environment.NewLine);
            }
        }
    }
}
