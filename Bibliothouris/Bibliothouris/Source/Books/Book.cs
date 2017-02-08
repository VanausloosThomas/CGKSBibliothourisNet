using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Book {
    public class Book {

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

        public override bool Equals(object obj) {
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }

            return ISBN.Equals(((Book)obj).ISBN) &&
                title.Equals(((Book)obj).title) &&
                author.Equals(((Book)obj).author);
        }

        // override object.GetHashCode
        public override int GetHashCode() {
            return ISBN.GetHashCode() + title.GetHashCode() + author.GetHashCode();
        }
    }
}
