#include <iostream>
#include <cstdlib>
#include <cstdio>
#include "./Entity/Borrowing/Borrowing.hpp"
#include "./Entity/Book/Book.hpp"
#include "./Entity/Category/Category.hpp"
#include "./Entity/Author/Author.hpp"

using namespace std;

int main(int argc, const char * argv[])
{
    string choose; char ch;
 
    while (true) {
        
        system("clear");
        
        cout << "sa - Show all Authors\n";
        cout << "sc - Show all Categories\n";
        cout << "sb - Show all Books\n";
        cout << "st - Show all Borrowed Books\n";
        cout << "ua - Update Authors\n";
        cout << "uc - Update Categories\n";
        cout << "ub - Update Books\n";
        cout << "ut - Update Borrowed Books\n";
        cout << "aa - Add Author\n";
        cout << "ac - Add Category\n";
        cout << "ab - Add Book\n";
        cout << "at - Add Borrowing\n";
        cout << "da - Delete Author\n";
        cout << "dc - Delete Category\n";
        cout << "db - Delete Book\n";
        cout << "dt - Delete Borrowing\n";
        cout << "sbnr - Show not returned books\n";
        cout << "sbr - Show returned books\n";
        cout << "sbg - Show books by genre\n";
        cout << "cba - Count books of each author\n";
        cout << "stl3 - Show last three borrowed books\n";
        cout << "sab1 - Show authors with books bigger 1\n";
        cout << "q - Quit\n";
        
        cin >> choose;
        
        if (choose == "q") break;
        else if (choose == "sa") Author::showAuthors();
        else if (choose == "sc") Category::showCategories();
        else if (choose == "sb") Book::showBooks();
        else if (choose == "st") Borrowing::showBorrowings();
        else if (choose == "ua") Author::updateAuthor();
        else if (choose == "uc") Category::updateCategory();
        else if (choose == "ub") Book::updateBook();
        else if (choose == "ut") Borrowing::updateBorrowing();        
        else if (choose == "aa") Author::addAuthor();
        else if (choose == "ac") Category::addCategory();
        else if (choose == "ab") Book::addBook();
        else if (choose == "at") Borrowing::addBorrowing();
        else if (choose == "da") Author::deleteAuthor();
        else if (choose == "dc") Category::deleteCategory();
        else if (choose == "db") Book::deleteBook();
        else if (choose == "dt") Borrowing::deleteBorrowing();
        else if (choose == "sbnr") Borrowing::showNotReturned();
        else if (choose == "sbr") Borrowing::showReturned();
        else if (choose == "sbg") Book::showBookByGenre();
        else if (choose == "cba") Book::countBooksOfAuthor();
        else if (choose == "stl3") Borrowing::showlastThree();
        else if (choose == "sab1") Book::showAmountBooksOfAuthorBiggerThanOne();
        
        cout << "Press any key to continue...";
        cin.clear();
        cin.ignore(10000, '\n');
        ch = getchar();
    }
    
    return 0;
}
