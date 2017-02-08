using Bibliothouris.Source.Book;
using System;
using System.Windows.Forms;
using Bibliothouris.Source.Book;


namespace Bibliothouris.Forms.Book
{
    public interface IBookView
    {
        void SetController(BookController bookController);
        void AddBook(Book book);
        void ClearAllUsers();
        DialogResult ShowDialog();
            }

    public partial class BooksForm : Form, IBookView
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

        public void ClearAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
