#include "TechProduct.h"

void TechProduct::showInfoTechProduct()
{
	this->showProductInfo();
	cout << "Manufacturer: " << this->manufacturer << endl;
	cout << "Warranty Period: " << this->warrantyPeriod << endl;
}
