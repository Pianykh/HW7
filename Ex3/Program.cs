﻿

/*
3.Написать программу "Библиотека" В библиотеке должен быть каталог книг (изначально в каталоге 5 книг). 
Должна быть возможность добавить книгу в каталог, исключить из каталога, вывести содержимое каталога по алфавиту (по автору или по названию книги), 
вывести список книг определенного автора, найти книгу в списке по слову или по нескольким словам в названии.
Книгу можно "взять почитать" из библиотеки на определенное количество дней, 
при этом в журнал должно записываться кто и на сколько дней какую книгу взял из библиотеки. 
У каждой книги должен быть параметр, показывающий количество дней, которое книга была у читателей. 
Задание должно быть выполнено с помощью классов.
*/

using System;
using System.Text;

namespace Ex3
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Catalog.FindBooksByAuthor("Matrell");
            Catalog.FindBooksByName("F");

            BookKeeper.DeleteBookFromCatalog("Life of P", "Martel Yann");
            Catalog.ShowCatalog();
        }
    }
}