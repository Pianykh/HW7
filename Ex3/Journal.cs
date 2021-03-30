// unset

using System;
using System.Collections.Generic;

namespace Ex3
{
    public static class Journal
    {
        private static List<string> _records = new List<string>();

        public static void MakeRecord(string name, Book book, int days)
        {
            _records.Add($"{name} took [{book.Title}, {book.Author}] for {days} days");
        }

        public static void ShowRecords()
        {
            foreach (var record in _records)
                Console.WriteLine(record);
        }
    }
}