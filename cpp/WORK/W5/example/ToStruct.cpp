#include <iostream>
#include <string>
using namespace std;

void printBookDetails(string title, string author, int year, int pages, string janr) {
    cout << "Book: " << title << "\n"
        << "Author: " << author << "\n"
        << "Year: " << year << "\n"
        << "Pages: " << pages << "\n"
        << "Ganre: " << janr << endl;
}

struct Book {
    string title;
    string author;
    int year;
    int pages;
    string janr;
};

//По значению :
//При передаче структуры по значению создается копия объекта.Изменения, сделанные с копией внутри функции, не отражаются на оригинальном объекте.
void processBook(Book book) {
    // Изменения в book здесь не повлияют на оригинальный объект
}

//По ссылке :
//Передача структуры по ссылке позволяет функции работать непосредственно с оригинальным объектом, без создания его копии.Изменения, сделанные в функции, будут отражаться на оригинальном объекте.
void modifyBook(Book& book) {
    // Изменения в book повлияют на оригинальный объект
}


//По константной ссылке :
//Как уже обсуждалось, передача по константной ссылке позволяет функции читать объект, но не изменять его.Это эффективный способ передачи больших структур, когда не требуется их модификация.
void displayBook(const Book& book) {
    // Функция может читать book, но не изменять
}

//По указателю :
//Передача по указателю похожа на передачу по ссылке, но в данном случае используются указатели.Это также позволяет функции изменять объект, на который указывает указатель.
void updateBook(Book* book) {
    if (book != nullptr) {
        // Изменения в *book повлияют на оригинальный объект
    }
}


void printBookDetails(const Book& book) {
    cout << "Book: " << book.title << "\n"
        << "Author: " << book.author << "\n"
        << "Year: " << book.year << "\n"
        << "Pages: " << book.pages << endl;
}


int main() {
    Book book = { "1984", "George Orwell", 1949, 328 };
    printBookDetails(book);
    return 0;
}
