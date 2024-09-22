/*
Задание 2. Поверхностное копирование
Создайте класс Book с полями Title и Author. Реализуйте интерфейс ICloneable для этого класса,
используя метод MemberwiseClone() для выполнения поверхностного копирования.
Продемонстрируйте, что после клонирования изменение заголовка книги в клоне не изменяет оригинал,
а изменение автора изменяет оба объекта (так как это поверхностное копирование).
*/

using System.Net;
using System;

public class Author
{
    public string Name { get; set; }

    public Author(string name)
    {
        Name = name;
    }
}

public class Book : ICloneable
{
    public string Title;
    public Author Author;

    public Book(string title, Author author)
    {
        Title = title;
        Author = author;
    }

    public object Clone()
    {
        return this.MemberwiseClone(); // поверхностное
       
        // Глубокое копирование объекта Person (копируется и адрес)
        // Person clonedPerson = (Person)this.MemberwiseClone(); // Поверхностное копирование
        // clonedPerson.Address = new Address(this.Address.City, this.Address.Street); // Глубокая копия адреса
        // return clonedPerson;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author.Name}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Title", new Author("Author"));
        Book clone = (Book)book.Clone();
        
        Console.WriteLine(book.ToString());
        Console.WriteLine(clone.ToString());

        clone.Author.Name = "a";
        clone.Title = "b";

        Console.WriteLine(book.ToString());
        Console.WriteLine(clone.ToString());    
    }
}
