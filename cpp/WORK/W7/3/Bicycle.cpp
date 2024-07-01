#include "Bicycle.h"

void Bicycle::showBicycleInfo()
{
	this->showInfoVehicle();	
	cout << "Number of speeds: " << this->numberOfSpeeds << endl;
}
