using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Book {
    public interface IBookService {
        List<Book> GetAllBooks();
       void AddBook(string ISBN, string title, Author author);
    }

    public class BookService : IBookService {

        private BookRepository bookRepository;

        public BookService() : this(new BookRepository()) {
        }

        public BookService(BookRepository bookRepository) {
            this.bookRepository = bookRepository;
        }

        public List<Book> GetAllBooks() {
            return bookRepository.GetAllBooks();
        }

        public void AddBook(string ISBN, string title, Author author) {
            bookRepository.AddBook(Book.CreateBook(ISBN, title, author));
        }
    }
}