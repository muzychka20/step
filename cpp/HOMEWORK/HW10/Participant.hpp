#ifndef Participant_hpp
#define Participant_hpp

#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace std;

class Participant {
public:
    Participant(int _age, string _INN);
    int age;
    string INN;
};

#endif
