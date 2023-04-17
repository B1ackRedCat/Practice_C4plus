using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class LibraryService
    {
        private Library library;

        public  LibraryService(Library library)
        {
            this.library = library;
        }

        internal void Add(Book book)
        {
            library.Add(book);
        }

        internal void Delete(string number)
        {
            library.Delete(number);
        }

        internal List<Book> GetAll()
        {
            return library.GetAll();
        }

        internal List<Book> GetByNumber(string numberToSearch)
        {
            return library.GetAll().Where(book => book.Number == numberToSearch).ToList();
        }
    }
}
