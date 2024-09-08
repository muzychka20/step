using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("title1", "author1", "isbn1");
            book.DisplayInfo();
            Console.WriteLine("------------------------------");


            EBook eBook = new EBook("title2", "author2", "isbn2", 24.2);
            eBook.DisplayInfo();
            Console.WriteLine("------------------------------");


            PrintedBook printedBook = new PrintedBook("title3", "author3", "isbn3", 200);
            printedBook.DisplayInfo();
            Console.WriteLine("------------------------------");
        }
    }
}
