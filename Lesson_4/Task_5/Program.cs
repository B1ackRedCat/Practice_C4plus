namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library(BooksProvider.GetBooks());
            var libraryService = new LibraryService(library);
            var libraryPublisher = new LibraryPublisher();
            while (true)
            {
                Console.WriteLine("Choose variant:");
                Console.WriteLine();
                Console.WriteLine("1.Add book");
                Console.WriteLine("2.Delete book");
                Console.WriteLine("3.Search book by number");
                Console.WriteLine("4.Sort book(s) by title");
                Console.WriteLine("5.Show all books");
                Console.WriteLine("6.Press CTRL+C to exit");
                int value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Book book = CreateBook();
                        libraryService.Add(book);
                        libraryPublisher.Publish(library);
                        break;
                    case 2:
                        string number = InputNumber();
                        libraryService.Delete(number);
                        libraryPublisher.Publish(library);
                        break;
                    case 3:
                        string numberToSearch = InputNumber();
                        List<Book> books = libraryService.GetByNumber(numberToSearch);
                        if (books != null)
                        {
                            libraryPublisher.Publish(books);
                        }
                        break;
                    case 4:
                        List<Book> orderedBooks = libraryService.GetAll()
                                                                .OrderBy(book => book.Title, StringComparer.OrdinalIgnoreCase)
                                                                .ToList();
                        libraryPublisher.Publish(orderedBooks);
                        break;
                    case 5:
                        libraryPublisher.Publish(library);
                        break;
                    default:
                        Console.WriteLine("Incorrect input.");
                        break;
                }
            }
        }

        private static string InputNumber()
        {
            bool isValid = false;
            var validNumber = default(string);
            while (!isValid)
            {
                Console.WriteLine("Try enter number example: abc123de");
                var input = Console.ReadLine();
                if (NumberValidator.Validate(input))
                {
                    validNumber = input;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Input not a number");
                }
            }
            return validNumber;
        }

        private static Book CreateBook()
        {
            var book = new Book();
            Console.WriteLine("Enter number: ");
            book.Number = InputNumber();

            Console.Write("Enter book title: ");
            book.Title = Console.ReadLine();
            
            Console.Write("Enter author name: ");
            book.Author = Console.ReadLine();

            Console.Write("Enter year of publication: ");
            book.PublishYear = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Enter genre: ");
            book.Genre = Console.ReadLine();

            return book;
        }
    }
}