// unset

using System;
using System.Collections.Generic;
using System.Linq;


namespace Ex3
{
    public static class Catalog
    {
        private static List<Book> _catalog = new List<Book>();
        static Catalog()
        {
            _catalog.Add(new Book("1984", "George Orwell"));
            _catalog.Add(new Book("Life of Pi", "Martel Yann"));
            _catalog.Add(new Book("Hannibal", "Harris Thomas"));
            _catalog.Add(new Book("Fahrenheit 451", "Ray Bradburry"));
            _catalog.Add(new Book("Animal Farm", "George Orwell"));
            _catalog.Add(new Book("Fight Club", "Chuck Palahniuk"));
            _catalog.Add(new Book("Self", "Martel Yann"));
            _catalog.Add(new Book("The Martian Chronicles", "Ray Bradburry"));
            _catalog.Add(new Book("Dandelion Wine", "Ray Bradburry"));
        }

        public static void ShowCatalog()
        {
            foreach (var book in _catalog)
                Console.WriteLine(book.Title + ", " + book.Author + ", " + book.DaysInUse + " days in use");
        }

        public static void ShowCatalogByAlphabetOrder()
        {
            _catalog.Sort(new BookNameComparer());
            ShowCatalog();
        }

        public static void FindBooksByAuthor(string author)
        {
            var isFind = false;

            foreach (var book in _catalog.Where(book => string.Equals(book.Author.ToLower(), author.ToLower(), StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine(book.Title + ", " + book.Author + ", " + book.DaysInUse + " days in use");
                isFind = true;
            }
            if (!isFind)
                Console.WriteLine($"No books by {author} found");
            
        }

        public static void FindBooksByName(string title)
        {
            var isFind = false;

            foreach (var book in _catalog.Where(book => book.Title.ToLower().Contains(title.ToLower())))
            {
                Console.WriteLine(book.Title + ", " + book.Author + ", " + book.DaysInUse + " days in use");
                isFind = true;
            }
            if (!isFind)
                Console.WriteLine($"No books contains {title} found");
        }

        public static void ReceiveBook(Book book)
        {
            _catalog.Add(book);
        }

        public static void GiveAwayBook(string name, string author, out Book book)
        {
            foreach (var currentBook in _catalog.Where(currentBook => currentBook.Title == name && currentBook.Author == author))
            {
                _catalog.Remove(currentBook);
                book = currentBook;
                return;
            }
            book = null;
        }
    }
}