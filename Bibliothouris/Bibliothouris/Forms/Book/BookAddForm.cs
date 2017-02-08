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

namespace Bibliothouris.Forms.Book
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

        public void setController(BookController bookController)
        {
            this.bookController = bookController;
        }

        private void add_Click(object sender, EventArgs e)
        {
            bookController.AddBook(titleTextBox.Text, authorFirstNameTextBox.Text, authorLastNameTextBox.Text, isbnTextBox.Text);
        }

        public void clear()
        {
            titleTextBox.Text = "";
            authorLastNameTextBox.Text = "";
            authorFirstNameTextBox.Text = "";
            isbnTextBox.Text = "";
        }

        public void SetController(BookController bookController)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
