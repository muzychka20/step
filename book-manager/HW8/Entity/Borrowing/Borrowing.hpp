#ifndef Borrowing_hpp
#define Borrowing_hpp

#include <vector>
#include <stdio.h>
#include "../../Entity/Book/Book.hpp"

using namespace std;

class Borrowing {
  
private:
    static int ID;
    int id;
    Book* book;
    string borrowedDate;
    string returnedDate;
    
public:
    static vector<Borrowing*> borrowings;
    static void showBorrowings();
    static void addBorrowing();
    static Borrowing* findBorrowingById(int _id);
    static void deleteBorrowing();
    static void showNotReturned();
    static void showReturned();
    static void showlastThree();
    static void updateBorrowing();
    Borrowing(Book* _book, string _borrowedDate, string _returnedDate);
    string getBorrowedDate();
    string getReturnedDate();
    void setBorrowedDate(string _borrowedDate);
    void setReturnedDate(string _returnedDate);
    int getId();
    Book* getBook();
    void showBorrowing();    
};

#endif
