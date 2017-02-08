using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothouris.Forms.Book
{
    public partial class BookAddForm : Form
    {
        private BookController bookController;

        public BookAddForm()
        {
            InitializeComponent();
        }

        public void setController(BookController bookController)
        {
            this.bookController = bookController;
        }

        private void add_Click(object sender, EventArgs e)
        {
            bookController.addBook(titleTextBox.Text, authorFirstNameTextBox.Text, authorLastNameTextBox.Text, isbnTextBox.Text);
        }

        public void clear()
        {
            titleTextBox.Text = "";
            authorLastNameTextBox.Text = "";
            authorFirstNameTextBox.Text = "";
            isbnTextBox.Text = "";
        }
    }
}
