using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibliothouris.Source.Book;
using System.Collections.Generic;

namespace Tests {
    [TestClass]
    public class BookRepositoryTest {
        [TestMethod]
        public void IsbnFilterWorksTest() {
            BookRepository repo = new BookRepository();
            List<Book> expected = new List<Book>();
            expected.Add(Book.CreateBook("1234", "Book nr 1's title", new Author("JK", "Rowling")));
            expected.Add(Book.CreateBook("9012", "Book nr 3's title", new Author("Xan", "BridgeBuilder")));
            
            CollectionAssert.AreEqual(expected, repo.searchBookISBN("12*"));
        }

        [TestMethod]
        public void TitleFilterWorksTest() {
            BookRepository repo = new BookRepository();
            List<Book> expected = new List<Book>();
            expected.Add(Book.CreateBook("1234", "Book nr 1's title", new Author("JK", "Rowling")));
            expected.Add(Book.CreateBook("5678", "Book nr 2's title", new Author("Steven", "Da King")));
            expected.Add(Book.CreateBook("9012", "Book nr 3's title", new Author("Xan", "BridgeBuilder")));

            CollectionAssert.AreEqual(expected, repo.searchBookTitle("Book*"));
        }
    }
}
