using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Book {
    public class BookRepository {

        private List<Book> books;

        public BookRepository() {
            books = new List<Book>();
            //some standard books to test with
            books.Add(Book.CreateBook("1234", "Book nr 1's title", new Author("JK", "Rowling")));
            books.Add(Book.CreateBook("5678", "Book nr 2's title", new Author("Steven", "Da King")));
            books.Add(Book.CreateBook("9012", "Book nr 3's title", new Author("Xan", "BridgeBuilder")));

        }

        public virtual List<Book> GetAllBooks() {
            return books;
        }

        public virtual void AddBook(Book book) {
            books.Add(book);
        }

        public List<Book> searchBookISBN(string partialISBN) {
            partialISBN = partialISBN.Replace("\\*", "[0-9]*-?[0-9]*");
            List<Book> booksISBN = new List<Book>();

            return books.Where(book => Regex.IsMatch(book.ISBN, partialISBN)).ToList<Book>();
        }

        public List<Book> searchBookTitle(string partialTitle) {
            partialTitle = partialTitle.Replace("\\*", "[^0-9]*");
            List<Book> booksTITLE = new List<Book>();
            foreach (Book book in books) {
                if (book.title.Contains(partialTitle)) {
                    booksTITLE.Add(book);
                }
            }
            return booksTITLE;
        }

        public List<Book> searchBookAuthor(string partialName) {
            partialName = partialName.Replace("\\*", "[0-9]*-?[0-9]*");
            List<Book> booksAUTHOR = new List<Book>();
            foreach (Book book in books) {
                if (book.author.FirstName.Contains(partialName) || book.author.LastName.Contains(partialName)) {
                    booksAUTHOR.Add(book);
                }
            }
            return booksAUTHOR;
        }
    }
}