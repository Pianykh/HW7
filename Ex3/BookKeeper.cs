// unset

using System;

namespace Ex3
{
    public static class BookKeeper
    {
        public static void AddBookToCatalog(Book book)
        {
            Catalog.ReceiveBook(book);
        }

        public static void DeleteBookFromCatalog(string name, string author)
        {
            Catalog.GiveAwayBook(name, author, out var book);
            Console.WriteLine(book != null
                ? $"Book [{name}, {author}] was deleted "
                : $"Book [{name}, {author}] is not in the catalog");
        }

    }
}