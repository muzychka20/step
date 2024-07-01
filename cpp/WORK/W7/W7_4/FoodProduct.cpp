#include "FoodProduct.h"

void FoodProduct::showInfoFoodProduct()
{
	this->showProductInfo();
	cout << "Expiration Date: " << this->expirationDate << endl;
}