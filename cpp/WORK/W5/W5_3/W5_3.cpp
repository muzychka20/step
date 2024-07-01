#include <iostream>
#include <string>
#include <vector>

using namespace std;

//Задача 5 : Комплексная задача с использованием структур
//Цель : Создать систему для управления библиотекой.
//
//Определите структуры Book(с полями : название, автор, год издания) и Library(содержащую массив книг и количество книг).
//Реализуйте функции для добавления книги в библиотеку, поиска книги по названию и вывода всего списка книг.
//Дополнительно : реализуйте функции для удаления книги из библиотеки и редактирования информации о книге.

struct Book {
    string name;
    string author;
    int year;
};

struct Library {
    vector<Book> array;
    int amount;
};

void PrintBook(Book book)
{
    cout << "Book\n";
    cout << "Name: " << book.name << endl;
    cout << "Author: " << book.author << endl;
    cout << "Year: " << book.year << endl;
    cout << endl;
}

void PrintBooks(vector<Book> books)
{
    for (int i = 0; i < books.size(); i++)
        PrintBook(books[i]);
}

void PrintLibrary(Library library)
{
    PrintBooks(library.array);
}

void AddBook(Library& library, Book book)
{
    library.array.push_back(book);
}

void FindBook(Library& library, string name)
{
    for (int i = 0; i < library.array.size(); i++)
    {
        if (name == library.array[i].name)
        {
            PrintBook(library.array[i]);
            break;
        }
    }        
}

void DeleteBook(Library& library, string name)
{
    for (int i = 0; i < library.array.size(); i++)
    {
        if (name == library.array[i].name)
        {            
            library.array.erase(library.array.begin() + i);
            break;
        }
    }
}

void UpdateBook(Library& library, string name, Book book)
{
    for (int i = 0; i < library.array.size(); i++)
    {
        if (name == library.array[i].name)
        {
            library.array[i].author = book.author;
            library.array[i].name = book.name;
            library.array[i].year = book.year;
            break;
        }
    }
}


int main()
{
    vector<Book> books;
    books.push_back({ "Don Kihot", "Servantes", 2010 });
    books.push_back({ "The Da Vinci Code", "Dan Brown", 2012 });
    Library lib = {books, books.size()};
    
    AddBook(lib, { "Andels & Demons", "Dan Brown", 2015 });
    PrintLibrary(lib);

    cout << endl << endl << endl;
    FindBook(lib, "Don Kihot");

    cout << endl << endl << endl;
    DeleteBook(lib, "The Da Vinci Code");
    PrintLibrary(lib);
    
    cout << endl << endl << endl;
    UpdateBook(lib, "Andels & Demons", {"Andels and Demons", "Dan Brown", 2024});
    PrintLibrary(lib);

    return 0;
}