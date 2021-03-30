// unset

using System.Collections.Generic;

namespace Ex3
{
    public class BookNameComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return string.Compare(x?.Title, y?.Title) switch
            {
                1 => 1,
                -1 => -1,
                _ => 0
            };
        }
    }
}