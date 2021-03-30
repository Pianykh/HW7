// unset

using System;
using System.IO;

namespace Ex2
{
    public class PdfWriter : IWritable
    {
        public void WriteFile(string fileName, string text)
        {
            fileName += ".pdf";
            var streamWriter = new StreamWriter(fileName, false);
            streamWriter.Write(text);
            streamWriter.Close();
            Console.WriteLine("File saved");
        }
    }
}