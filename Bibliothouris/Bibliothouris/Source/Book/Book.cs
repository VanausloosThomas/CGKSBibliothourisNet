using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Book {
    class Book {

        public string ISBN;
        public string title;
        public Author author;

        private Book(string ISBN, string title, Author author) {

            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }

        public static Book CreateBook(string ISBN, string title, Author author) {
            Book book = new Book(ISBN, title, author);
            return book;
        }

    }
}
