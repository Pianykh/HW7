// unset

using System;

namespace Ex3
{
    public static class LibraryController
    {
        private static string _name;

        public static void ShowMenu()
        {
            var isBookKeeper = false;
            Console.WriteLine("Library. Choose you role:\n 1.Bookkeeper\n 2.Reader");
            while (true)
            {
                var answer = Console.ReadLine();

                if (answer == "1")
                {
                    isBookKeeper = true;
                    break;
                }

                if (answer == "2")
                {
                    Console.WriteLine("Welcome reader. What is your name?");
                    _name = Console.ReadLine();
                    break;
                }

                Console.WriteLine("Please, answer with digits 1 or 2.");
            }

            while (true)
            {
                if (!isBookKeeper)
                    Console.WriteLine($"Welcome {_name}. Choose you action:\n1.Show all books\n2.Find by author\n" +
                                      "3.Find by title\n4.Take book\n5.Change role to bookkeeper");
                else
                    Console.WriteLine(
                        "Welcome bookkeeper. Choose you action:\n1.Show all books\n2.Find by author\n3.Find by title\n" +
                        "4.Add book\n5.Delete book\n6.Show journal\n7.Change role to reader");
                switch (Console.ReadLine())
                {
                    case "1":
                        Catalog.ShowCatalogByAlphabetOrder();
                        break;
                    case "2":
                        Console.WriteLine("Please, enter the author");
                        Catalog.FindBooksByAuthor(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Please, enter the title");
                        Catalog.FindBooksByName(Console.ReadLine());
                        break;
                    case "4" when isBookKeeper:
                        var book = new Book();
                        BookKeeper.AddBookToCatalog(ref book);
                        break;
                    case "4":
                        ReaderTakeBook();
                        break;
                    case "5" when isBookKeeper:
                        BookKeeperDeleteBook();
                        break;
                    case "5":
                        isBookKeeper = true;
                        Console.WriteLine("Role changed");
                        break;
                    case "6" when isBookKeeper:
                        Journal.ShowRecords();
                        break;
                    case "7" when isBookKeeper:
                        isBookKeeper = false;
                        Console.WriteLine("Role changed");
                        Console.WriteLine("Welcome reader. What is your name?");
                        _name = Console.ReadLine();
                        break;
                    
                }
            }
        }

        private static void ReaderTakeBook()
        {
            Console.WriteLine("What title of the book?");
            var title = Console.ReadLine();
            Console.WriteLine("What author of the book?");
            var author = Console.ReadLine();
            Catalog.GiveAwayBook(title, author, out var book);

            if (book != null)
            {
                Console.WriteLine("For how many days did you take the book?");
                int days = Convert.ToInt16(Console.ReadLine());
                book.DaysInUse += days;
                Console.WriteLine($"Book [{title}, {author}] taken");
                Journal.MakeRecord(_name, book, days);
                BookKeeper.AddBookToCatalog(ref book);
            }
            else
                Console.WriteLine($"Book [{title}, {author}] is not in the catalog");
        }

        private static void BookKeeperDeleteBook()
        {
            Console.WriteLine("What title of the book?");
            var title = Console.ReadLine();
            Console.WriteLine("What author of the book?");
            var author = Console.ReadLine();
            BookKeeper.DeleteBookFromCatalog(title, author);
        }
    }
}
