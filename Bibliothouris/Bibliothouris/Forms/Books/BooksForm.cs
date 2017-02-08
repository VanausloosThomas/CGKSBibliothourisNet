
using Bibliothouris.Source.Book;
using System;
using System.Windows.Forms;


namespace Bibliothouris.Forms.Books
{
    public interface IBookView
    {
        void SetController(BookController bookController);
        void AddBook(Book book);
        void ClearAllBooks();
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
            ListViewItem bookItem = new ListViewItem(book.title);
            bookItem.SubItems.Add(book.author.FirstName + " " +  book.author.LastName);
            bookItem.SubItems.Add(book.ISBN);
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

        private void BooksForm_Load(object sender, EventArgs e)
        {
            bookController.LoadAllBooks();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bookController.SearchBook();
        }
    }
}
