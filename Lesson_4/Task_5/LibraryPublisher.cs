using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class LibraryPublisher
    {
        public LibraryPublisher()
        {
        }

        internal void Publish(Library library)
        {
            Publish(library.GetAll());
        }

        internal void Publish(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
