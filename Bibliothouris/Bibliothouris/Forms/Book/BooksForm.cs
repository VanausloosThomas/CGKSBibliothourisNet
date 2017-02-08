using Bibliothouris.Source.Book;
using System;
using System.Windows.Forms;
using Bibliothouris.Source.Books;


namespace Bibliothouris.Forms.Books
{
    public partial class BooksForm : Form
    {
        private BookController bookController;
        public BooksForm()
        {
            InitializeComponent();
        }

        public void SetController(BookController bookController)
        {
            this.bookController = bookController;
        }

        public void AddBook(Book book)
        {
            bookListView.Items.Add(CreateBookListViewItem(book));
        }

        private ListViewItem CreateBookListViewItem(Book book)
        {
            ListViewItem bookItem = new ListViewItem(book.title, book.author, book.ISBN);
            return bookItem;
        }

        private void userListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ClearAllBooks()
        {
            bookListView.Items.Clear();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            bookController.addBookView();
        }
    }
}
