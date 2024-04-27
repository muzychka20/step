#include "Card.h"

Card::Card() {}
Card::Card(int card_number, string card_type, int CVV) : card_number(card_number), card_type(card_type), CVV(CVV) {}

int Card::getCardNumber() { return this->card_number; }
string Card::getCardType() { return this->card_type; }
int Card::getCVV() { return this->CVV; }

void Card::setCardNumber(int card_number) { this->card_number = card_number; }
void Card::setCardType(string card_type) { this->card_type = card_type; }
void Card::setCVV(int cvv) { this->CVV = cvv; }
