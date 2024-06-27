#ifndef Book_hpp
#define Book_hpp

#include <stdio.h>
#include <vector>
#include <unordered_map> 
#include "../../Entity/Author/Author.hpp"
#include "../../Entity/Category/Category.hpp"

using namespace std;

class Book {
    
private:
    static int ID;
    int id;
    string title;
    Author* author;
    Category* category;
        
public:
    static vector<Book*> books;
    static Book* findBookById(int _id);
    static void addBook();
    static void showBooks();
    static void deleteBook();
    static void showBookByGenre();
    static void countBooksOfAuthor();
    static void showAmountBooksOfAuthorBiggerThanOne();
    static void updateBook();
    
    Book(string _title, Author* _author, Category* _category);
    int getId();
    string getTitle();
    void setTitle(string _title);
    void setAuthor(Author* _author);
    void setCategory(Category* _category);
    Author* getAuthor();
    Category* getCategory();
    void showBook();
    bool inUse;
    
};

#endif
