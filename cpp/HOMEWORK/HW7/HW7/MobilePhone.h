#pragma once
#include <string>
#include <iostream>

using namespace std;

class MobilePhone
{
private:
    static int ID;

    int id;
    string model;
    string owner;
    bool repairStatus;

public:

    MobilePhone(string model, string owner);
    MobilePhone(string model, string owner, bool status);
    
    int getID();
    bool getStatus();
    string getModel();
    string getOwner();
    void setModel(string newModel);
    void setOwner(string newOwner);

    void showRepairStatus();
    void changeRepairStatus();

    void showMobilePhoneInfo();
};

