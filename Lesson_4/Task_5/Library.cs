using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Library
    {
        private List<Book> _books;

        public Library(List<Book> books)
        {
            this._books = books;
        }

        public Library()
        {
            _books = new List<Book>(0);
        }

        internal void Add(Book book)
        {
            _books.Add(book);
        }

        internal bool Delete(string number)
        {
            var foundBooks = _books.Where(book=>book.Number==number).ToList();
            if (foundBooks.Count == 0)
            {
                return false;
            }
            foreach (var book in foundBooks)
            {
                _books.Remove(book);
            }
            return true;
        }

        internal List<Book> GetAll()
        {
            return _books;
        }
    }
}
