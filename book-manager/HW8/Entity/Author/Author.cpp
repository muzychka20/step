#include "Author.hpp"

int Author::ID = 1;
vector<Author*> Author::authors;

Author::Author(string _name) {
    setName(_name);
    id = ID++;
    inUse = false;
}

void Author::setName(string _name) {
    name = _name;
}

string Author::getName() {
    return name;
}

int Author::getId() {
    return id;
}

void Author::showAuthor() {
    cout << "Id: " << id << endl;
    cout << "Author name: " << name << endl;
}

void Author::showAuthors() {
    for (int i = 0; i < authors.size(); i++) {
        authors[i]->showAuthor();
        cout << endl;
    }
}

void Author::addAuthor() {
    string name;
    cout << "Name: "; cin >> name;
    authors.push_back(new Author(name));
}

Author* Author::findAuthorById(int _id) {
    for (auto& author : authors) {
        if (author->getId() == _id) {
            return author;
        }
    }
    return NULL;
}

void Author::deleteAuthor() {
    int _id;
    cout << "Author id: "; cin >> _id;
    Author* authorToDelete = Author::findAuthorById(_id);
    if (authorToDelete == NULL) {
        cout << "Error: Author not found.\n";
        return;
    }
    if (authorToDelete->inUse) {
        cout << "Error: Author in use.\n";
        return;
    }
    auto it = std::find(authors.begin(), authors.end(), authorToDelete);
    authors.erase(it);
    delete authorToDelete;
    cout << "Author deleted successfully.\n";
}

void Author::updateAuthor() {
    int _id;
    cout << "Author id: "; cin >> _id;
    Author* it = Author::findAuthorById(_id);
    if (it == NULL) {
        cout << "Error: Author not found.\n";
        return;
    }
    string newName;
    cout << "New name: "; cin >> newName;
    it->setName(newName);
    cout << "Author updated successfully.\n";
}
