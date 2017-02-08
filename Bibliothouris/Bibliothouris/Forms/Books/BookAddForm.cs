using Bibliothouris.Source.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothouris.Forms.Books
{
    public interface IBookAddView
    {
        void SetController(BookController bookController);
        void Close();
        void Clear();
        DialogResult ShowDialog();
    }

    public partial class BookAddForm : Form, IBookAddView
    {
        private BookController bookController;

        public BookAddForm()
        {
            InitializeComponent();
        }

        public void SetController(BookController bookController)
        {
            this.bookController = bookController;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Author author = new Author(authorFirstNameTextBox.Text, authorLastNameTextBox.Text);
            bookController.AddBook(isbnTextBox.Text, titleTextBox.Text, author);
        }

        public void Clear()
        {
            titleTextBox.Text = "";
            authorLastNameTextBox.Text = "";
            authorFirstNameTextBox.Text = "";
            isbnTextBox.Text = "";
        }


    }
}
