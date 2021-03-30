// unset

using System;

namespace Ex3
{
    public static class LibraryController
    {
        public static void ShowMenu()
        {
            bool isBookKeeper;
            Console.WriteLine("Library. Choose you role: 1. Bookkeeper. 2. Reader");
            while (true)
            {
                var answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("Welcome bookkeeper. Choose you action: 1. Add book. 2.Delete book 3. Show all books. " +
                                      "4. Find by author 5. Find by name. 6.Show journal");
                    isBookKeeper = true;
                    break;
                }
                if (answer == "2")
                {
                    Console.WriteLine("Welcome reader. Choose you action: 1. Take book ");
                    break;
                }
                Console.WriteLine("Please, answer with digits 1 or 2.");
            }
            Console.WriteLine();
            switch (Console.WriteLine(answer)){ }
        }
    }
}