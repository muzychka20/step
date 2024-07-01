#pragma once
#include "Product.h"

class FoodProduct : public Product
{
public:
	string expirationDate;

	void showInfoFoodProduct();
};

