#pragma once

#include <string>

using namespace std;

class Card
{
private:
    int card_number;
    string card_type;
    int CVV;

public:
    Card();
    Card(int card_number, string card_type, int CVV);

    int getCardNumber();
    string getCardType();
    int getCVV();

    void setCardNumber(int card_number);
    void setCardType(string card_type);
    void setCVV(int cvv);
};

