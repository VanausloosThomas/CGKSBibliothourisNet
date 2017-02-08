using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Book {
    public class BookController {

        internal IBookView view { get; }
        private IBookAddView addView;
        private IBookService service;

        public BookController(IBookView bookView, IBookAddView addView, IBookService service) {
            this.view = bookView;
            this.addView = addView;
            this.service = service;
            this.view.SetController(this);
            this.addView.SetController(this);
        }

        public void LoadAllBooks() {
            foreach (Book book in service.GetAllBooks()) {
                view.AddBook(book);
            }
        }
        public void AddBook(string ISBN, string title, Author author) {
            service.AddBook(ISBN, title, author);
            addView.Close();
            ClearAllBooks();
            LoadAllBooks();
        }

        private void ClearAllBooks() {
            view.ClearAllBooks();
        }

        public void addBookView() {
            addView.Clear();
            addView.ShowDialog();
        }

    }
}
