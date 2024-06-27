#pragma once

#include "Account.h"
#include <vector>

using namespace std;

class AccountStore
{
private:
    static vector<Account> accounts;

public:
    static void registrateAccount();
    static void removeAccount();
    static void showAccounts();
    static Account* getAccount(int id);
};