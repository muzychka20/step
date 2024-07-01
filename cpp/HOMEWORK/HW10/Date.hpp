#ifndef Date_hpp
#define Date_hpp

#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace::std;

class Date {
private:
    int day, month, year;    
    string date;
    bool validDateForm();
    
public:
    Date(string _date);
    bool validDate();    
    int getDay();
    int getMonth();
    int getYear();
    bool isLeapYear();
};

#endif
