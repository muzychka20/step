#ifndef Category_hpp
#define Category_hpp

#include <stdio.h>
#include <string>
#include <iostream>
#include <vector>

using namespace std;

class Category {
    
private:
    static int ID;
    int id;
    string name;
    
public:
    static vector<Category*> categories;
    static Category* findCategoryById(int _id);
    static void addCategory();
    static void showCategories();
    static void deleteCategory();
    static void updateCategory();

    Category(string _name);
    void setName(string _name);
    string getName();
    int getId();
    void showCategory();
    bool inUse;
};

#endif
