// unset

using System;

namespace Ex3
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int DaysInUse { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public Book()
        {
            string title;
            string author;

            Console.WriteLine("Please, please enter the title of the book");
            while (true)
            {
                title = Console.ReadLine();
                if (title != "") break;
                Console.WriteLine("Title can't be empty");
                Title = title;
            }

            Console.WriteLine("Please, please enter the author of the book");
            while (true)
            {
                author = Console.ReadLine();
                if (author != "") break;
                Console.WriteLine("Author can't be empty");
                Author = author;
            }

            Author = author;
            Title = title;
        }
    }
}