namespace RegistrationSystem_Basic
{
    class Program
    {
        private static List<string> _books = new List<string>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----START SYSTEM-----");
                Console.WriteLine("1 - Register Book");
                Console.WriteLine("2 - List Books");
                Console.WriteLine("3 - Remove Book");
                Console.WriteLine("0 - Exit Application");

                var options = Console.ReadLine();

                switch (options)
                {
                    case "1":
                        AddBooks();
                        break;
                    case "2":
                        ShowListBooks();
                        break;
                    case "3":
                        RemoveBooks();
                        break;
                    case "0":
                        Console.WriteLine("End application.");
                        return;
                    default:
                        Console.WriteLine("Invalid Option. \nType a number for correct option.");
                        break;
                }
            }
        }

        private static void AddBooks()
        {
            Console.WriteLine("\n\nType the name book:");
            var nameBook = Console.ReadLine();
            if (nameBook != null) _books.Add(nameBook);
        }

        private static void ShowListBooks()
        {
            Console.WriteLine("\n\nAll books in list:");
            Console.WriteLine($"Number Books: {_books.Count}");
            foreach (string books in _books)
            {
                Console.WriteLine(books);
            }
        }

        private static void RemoveBooks()
        {
            Console.WriteLine("\n\nType book name to remove:");
            var removeBook = Console.ReadLine();
            var removeIsSuccess = removeBook != null && _books.Remove(removeBook);
            Console.WriteLine(removeIsSuccess ? "Book removed with success." : "Book not found.");
        }
    }
}