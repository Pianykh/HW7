// unset

using System;

namespace Ex2
{
    public static class FileSaver
    {
        public static bool SaveFile()
        {
            Console.WriteLine("Please, enter text");
            var input = Console.ReadLine();
            Console.WriteLine("How to name the file you want to create?");
            var name = Console.ReadLine();
            Console.WriteLine("In what format do you want to save the file? txt/pdf/csv");
            var format = Console.ReadLine();
            switch (format)
            {
                case "txt":
                {
                    var txtWriter = new TxtWriter();
                    txtWriter.WriteFile(name, input);
                    return true;
                }

                case "pdf":
                {
                    var pdfWriter = new PdfWriter();
                    pdfWriter.WriteFile(name, input);
                    return true;
                    }

                case "csv":
                {
                    var csvWriter = new CsvWriter();
                    csvWriter.WriteFile(name, input);
                    return true;
                    }

                default:
                {
                    Console.WriteLine("Invalid format.");
                    return false;
                }
            }
        }
    }
}