using System;
using System.IO;
using System.Text;

/*
2.Создать программу, которая сохраняет введеный текст из консоли в файлы формата: txt,csv,pdf.(Использовать интерфейсы и классы)
Пользователь должен иметь возможность выбора формата сохранения. Не валидные кейсы должны быть учтены.
*/

namespace Ex2
{
    internal class Program
    {
        private static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            FileSaver.SaveFile();
        }
    }
}
