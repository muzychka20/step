#pragma once
#include "Product.h"

class TechProduct : public Product
{
public:
	int warrantyPeriod;
	string manufacturer;

	void showInfoTechProduct();
};

