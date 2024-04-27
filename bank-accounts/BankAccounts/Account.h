#pragma once

#include <iostream>
#include <string>
#include "Card.h"
#include "FIO.h"

using namespace std;

class Account
{
private:
    static int ID;

    int account_id;
    int summa;
    bool blocked;
    Card card;
    FIO fio;

public:

    Account(FIO fio, int money);
    int getAccountId();
    void getAccountInfo();
    
    void getCard();
    void setCard(Card card);
    void changeCard();

    int getSumma();
    void addMoney();
    void cashOutMoney();
    void showBalance();

    string getFIO();
    void setFIO(FIO fio);
    void changeFIO();
    void showFIO();

    bool getStatus();
    void setStatus(bool status);
    void changeStatus();
};