#ifndef Password_hpp
#define Password_hpp

#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace::std;

class Password {
private:
    string password;
    bool hasLowercase();
    bool hasUppercase();
    bool hasDigits();
    bool hasLength();
    bool hasFormat();	

public:
    Password(string _password);
    bool validPassword();
};

#endif
