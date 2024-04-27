#include "Book.hpp"

int Book::ID = 1;
vector<Book*> Book::books;

Book::Book(string _title, Author* _author, Category* _category) {
    title = _title;
    author = _author;
    category = _category;
    id = ID++;
    inUse = false;
}

int Book::getId() { 
    return id;
}

string Book::getTitle() {
    return title;
}

void Book::setTitle(string _title) { 
    title = _title;
}

void Book::setAuthor(Author* _author) {
    author = _author;
}

void Book::setCategory(Category* _category) {
    category = _category;
}

Author* Book::getAuthor() { 
    return author;
}

Category* Book::getCategory() {
    return category;
}

void Book::showBook() {
    cout << "Id: " << id << endl;
    cout << "Title: " << title << endl;
    cout << "Author: " << author->getName() << endl;
    cout << "Category: " << category->getName() << endl;
}

void Book::showBooks() {
    for (int i = 0; i < books.size(); i++) {
        books[i]->showBook();
        cout << endl;
    }
}

void Book::addBook() {
    string title; int category_id, author_id;
    cout << "Title: "; cin >> title;
    cout << "Category: "; cin >> category_id;
    cout << "Author: "; cin >> author_id;
    
    Author* author = Author::findAuthorById(author_id);
    Category* category = Category::findCategoryById(category_id);
    
    if (author == NULL || category == NULL) {
        cout << "Category or author not found!\n";
        return;
    }
    
    author->inUse = true;
    category->inUse = true;
    Book* book = new Book(title, author, category);
    books.push_back(book);
}

Book* Book::findBookById(int _id) {
    for (auto& book : books) {
        if (book->getId() == _id) {
            return book;
        }
    }
    return NULL;
}

void Book::deleteBook() {
    int _id;
    cout << "Book id: "; cin >> _id;
    Book* bookToDelete = Book::findBookById(_id);
    if (bookToDelete == NULL) {
        cout << "Error: Book not found.\n";
        return;
    }
    if (bookToDelete->inUse) {
        cout << "Error: Book in use.\n";
        return;
    }
    auto it = std::find(books.begin(), books.end(), bookToDelete);
    books.erase(it);
    delete bookToDelete;
    cout << "Book deleted successfully.\n";
}

void Book::showBookByGenre() {
    int _id;
    cout << "Genre id: "; cin >> _id;
    for (int i = 0; i < books.size(); i++) {
        if (books[i]->getCategory()->getId() == _id) {
            books[i]->showBook();
            cout << endl;
        }
    }    
}

void Book::countBooksOfAuthor() {
    unordered_map<int, int> authorBookCount;
    for (const auto& book : books) {
        int authorId = book->getAuthor()->getId();
        authorBookCount[authorId]++;
    }
    for (const auto& pair : authorBookCount) {
        Author* author = Author::findAuthorById(pair.first);
        if (author != nullptr) {
            cout << "Author: " << author->getName() << " - Books: " << pair.second << endl;
        }
    }
}

void Book::showAmountBooksOfAuthorBiggerThanOne() {
    unordered_map<int, int> authorBookCount;
    for (const auto& book : books) {
        int authorId = book->getAuthor()->getId();
        authorBookCount[authorId]++;
    }
    for (const auto& pair : authorBookCount) {
        if (pair.second > 1) {
            Author* author = Author::findAuthorById(pair.first);
            if (author != nullptr) {
                cout << "Author: " << author->getName() << " - Books: " << pair.second << endl;
            }
        }
    }
}

void Book::updateBook() {
    string newTitle;
    int newAuthorId, newCategoryId, id;
    cout << "Enter book id: "; cin >> id;
    cout << "Enter new title: "; cin >> newTitle;
    cout << "Enter new author ID: "; cin >> newAuthorId;
    cout << "Enter new category ID: "; cin >> newCategoryId;
    Book* book = Book::findBookById(id);
    if (book == NULL) {
        cout << "Error: Book not found!\n";
    }
    Author* newAuthor = Author::findAuthorById(newAuthorId);
    Category* newCategory = Category::findCategoryById(newCategoryId);
    if (newAuthor == NULL || newCategory == NULL) {
        cout << "New author or category not found!\n";
        return;
    }
    book->setTitle(newTitle);
    book->setAuthor(newAuthor);
    book->setCategory(newCategory);
    cout << "Book updated successfully.\n";
}
