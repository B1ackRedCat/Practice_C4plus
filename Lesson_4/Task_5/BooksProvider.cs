using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class BooksProvider
    {
        internal static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book()
                {
                    Number = "Number0",
                    Title = "Title0",
                    Author = "Author0",
                    PublishYear = DateOnly.FromDateTime(DateTime.Now),
                    Genre = "Genre0"
                },
                new Book()
                {
                    Number = "Number1",
                    Title = "Title1",
                    Author = "Author1",
                    PublishYear = DateOnly.FromDateTime(DateTime.Now),
                    Genre = "Genre1"
                },
                new Book()
                {
                    Number = "Number2",
                    Title = "Title2",
                    Author = "Author2",
                    PublishYear = DateOnly.FromDateTime(DateTime.Now),
                    Genre = "Genre2"
                },
            };
        }
    }
}
