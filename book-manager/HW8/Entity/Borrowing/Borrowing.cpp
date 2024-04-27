#include "Borrowing.hpp"

int Borrowing::ID = 1;
vector<Borrowing*> Borrowing::borrowings;

Borrowing::Borrowing(Book* _book, string _borrowedDate, string _returnedDate) {
    book = _book;
    borrowedDate = _borrowedDate;
    returnedDate = _returnedDate;
    id = ID++;    
}

void Borrowing::setBorrowedDate(std::string _borrowedDate) { 
    borrowedDate = _borrowedDate;
}

void Borrowing::setReturnedDate(std::string _returnedDate) { 
    returnedDate = _returnedDate;
}

string Borrowing::getReturnedDate() {
    return returnedDate;
}

string Borrowing::getBorrowedDate() {
    return borrowedDate;
}

Book* Borrowing::getBook() {
    return book;
}

int Borrowing::getId() {
    return id;
}

void Borrowing::showBorrowing() {
    book->showBook();
    cout << "Borrowed date: " << borrowedDate << endl;
    cout << "Returned date: " << returnedDate << endl;
}

void Borrowing::showBorrowings() {
    for (int i = 0; i < borrowings.size(); i++) {
        borrowings[i]->showBorrowing();
        cout << endl;
    }
}

Borrowing* Borrowing::findBorrowingById(int _id) {
    for (auto& borrowing : borrowings) {
        if (borrowing->getId() == _id) {
            return borrowing;
        }
    }
    return NULL;
}

void Borrowing::addBorrowing() {
    string borrowedDate, returnedDate; int book_id;
    cout << "Book: "; cin >> book_id;
    cout << "Borrowed date: "; cin >> borrowedDate;
    cout << "Returned date: "; cin >> returnedDate;
        
    Book* book = Book::findBookById(book_id);
    
    if (book == NULL) {
        cout << "Book not found!\n";
        return;
    }
    
    book->inUse = true;
    
    Borrowing* borrowing = new Borrowing(book, borrowedDate, returnedDate);
    borrowings.push_back(borrowing);
}

void Borrowing::deleteBorrowing() {
    int _id;
    cout << "Borrowing id: "; cin >> _id;
    Borrowing* borrowingToDelete = Borrowing::findBorrowingById(_id);
    if (borrowingToDelete == NULL) {
        cout << "Error: Borrowing not found.\n";
        return;
    }
    borrowingToDelete->getBook()->inUse = false;
    auto it = std::find(borrowings.begin(), borrowings.end(), borrowingToDelete);
    borrowings.erase(it);
    delete borrowingToDelete;
    cout << "Borrowing deleted successfully.\n";
}

void Borrowing::showNotReturned() {
    for (int i = 0; i < borrowings.size(); i++) {
        if (borrowings[i]->getReturnedDate() == "-") {
            borrowings[i]->showBorrowing();
            cout << endl;
        }
    }
}

void Borrowing::showReturned() {
    for (int i = 0; i < borrowings.size(); i++) {
        if (borrowings[i]->getReturnedDate() != "-") {
            borrowings[i]->showBorrowing();
            cout << endl;
        }
    }
}

void Borrowing::showlastThree() {
    for (size_t i = borrowings.size() - 1; i > borrowings.size() - 4 && i >= 0; i--) {
        borrowings[i]->showBorrowing();
        cout << endl;
    }
}

void Borrowing::updateBorrowing() {
    string newBorrowedDate, newReturnedDate; int _id;
    cout << "Id borrowed: "; cin >> _id;
    cout << "Enter new borrowed date: "; cin >> newBorrowedDate;
    cout << "Enter new returned date: "; cin >> newReturnedDate;    
    Borrowing* borrowing = Borrowing::findBorrowingById(_id);
    if (borrowing == NULL){
        cout << "Error: Borrowing not found.\n";
        return;
    }
    borrowing->setBorrowedDate(newBorrowedDate);
    borrowing->setReturnedDate(newReturnedDate);
    cout << "Borrowing updated successfully.\n";
}
