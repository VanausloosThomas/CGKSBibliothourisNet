using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Book {
    class BookRepository {

        private List<Book> books;

        public BookRepository() {
            books = new List<Book>();
        }

        public virtual List<Book> GetAllBooks() {
            return books;
        }

        public virtual void AddBook(Book book) {
            books.Add(book);
        }
    }
}