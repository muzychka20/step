#include "FIO.h"

FIO::FIO() {};

FIO::FIO(string name, string surname) : name(name), surname(surname) {}
    
string FIO::getName() { return this->name; }
string FIO::getSurname() { return this->surname; }
   
void FIO::setName(string name) { this->name = name; }
void FIO::setSurname(string surname) { this->surname = surname; }
