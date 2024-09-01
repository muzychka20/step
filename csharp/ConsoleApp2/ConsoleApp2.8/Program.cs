/*
задание 1
Создайте класс Book, который будет представлять книгу.
Класс должен содержать следующие закрытые поля: title (название книги), author (автор) и pages (количество страниц).
Реализуйте свойства для доступа к этим полям. Добавьте конструктор, который принимает значения для всех полей.
Создайте метод GetDescription, который возвращает строку с описанием книги.
 */

using System;

namespace ConsoleApp2._8
{
    class Book
    {
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private int pages;
        public int Pages 
        {
            get { return pages; }
            set { pages = value; }
        }

        public void GetDescription()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Pages: {pages}");
            Console.WriteLine("-------------------");
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Name", "Author", 100);            
            book.GetDescription();
            book.Title = "New Title";
            book.Author = "New Author";
            book.Pages = 200;
            book.GetDescription();
        }
    }
}
