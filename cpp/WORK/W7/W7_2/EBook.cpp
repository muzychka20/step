#include "EBook.h"

void EBook::showEBookInfo()
{
	cout << "Title: " << this->title << endl;
	cout << "Author: " << this->author << endl;
	cout << "Price: " << this->price << endl;
	cout << "Format: " << this->format << endl;	
}
