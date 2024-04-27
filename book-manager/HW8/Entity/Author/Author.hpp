#ifndef Author_hpp
#define Author_hpp

#include <stdio.h>
#include <string>
#include <iostream>
#include <vector>

using namespace std;

class Author {
    
private:
    static int ID;
    int id;
    string name;
    
public:
    static vector<Author*> authors;
    static Author* findAuthorById(int _id);
    static void showAuthors();
    static void addAuthor();
    static void deleteAuthor();
    static void updateAuthor();
    
    Author(string _name);
    void setName(string _name);
    string getName();
    int getId();
    void showAuthor();
    bool inUse;
};

#endif
