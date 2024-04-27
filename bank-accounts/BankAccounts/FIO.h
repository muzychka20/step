#pragma once

#include <string>

using namespace std;

class FIO
{
private:
    string name;
    string surname;
    
public:
    FIO();
    FIO(string name, string surname);
    
    string getName();
    string getSurname();
    
    void setName(string name);
    void setSurname(string surname);
};