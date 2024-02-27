using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prectice27_02
{
    public class BookList
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public bool Contains(Book book)
        {
            return books.Contains(book);
        }

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public int Count
        {
            get { return books.Count; }
        }

        public static BookList operator +(BookList bookList, Book book)
        {
            bookList.AddBook(book);
            return bookList;
        }

        public static BookList operator -(BookList bookList, Book book)
        {
            bookList.RemoveBook(book);
            return bookList;
        }
    }
}
