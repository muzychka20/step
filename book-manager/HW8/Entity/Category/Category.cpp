#include "Category.hpp"

int Category::ID = 1;
vector<Category*> Category::categories;

Category::Category(string _name) {
    setName(_name);
    id = ID++;
    inUse = false;
}

void Category::setName(string _name) {
    name = _name;
}

string Category::getName() {
    return name;
}

int Category::getId() {
    return id;
}

void Category::showCategory() {
    cout << "Id: " << id << endl;
    cout << "Category name: " << name << endl;
}

void Category::showCategories() {
    for (int i = 0; i < categories.size(); i++) {
        categories[i]->showCategory();
        cout << endl;
    }
}

void Category::addCategory() {
    string name;
    cout << "Name: "; cin >> name;
    categories.push_back(new Category(name));
}

Category* Category::findCategoryById(int _id) {
    for (auto& category : categories) {
        if (category->getId() == _id) {
            return category;
        }
    }
    return NULL;
}

void Category::deleteCategory() {
    int _id;
    cout << "Category id: "; cin >> _id;
    Category* categoryToDelete = Category::findCategoryById(_id);
    if (categoryToDelete == NULL) {
        cout << "Error: Category not found.\n";
        return;
    }
    if (categoryToDelete->inUse) {
        cout << "Error: Category in use.\n";
        return;
    }            
    auto it = std::find(categories.begin(), categories.end(), categoryToDelete);
    categories.erase(it);
    delete categoryToDelete;
    cout << "Book deleted successfully.\n";
}

void Category::updateCategory() {
    int _id;
    cout << "Category id: "; cin >> _id;
    Category* it = Category::findCategoryById(_id);
    if (it == NULL) {
        cout << "Error: Category not found.\n";
        return;
    }
    string newName;
    cout << "New name: "; cin >> newName;
    it->setName(newName);
    cout << "Category updated successfully.\n";
}
