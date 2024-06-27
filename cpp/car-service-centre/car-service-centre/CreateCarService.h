#pragma once
#include <iostream>
#include "CarService.h"
#include "CarServiceQueue.h"
#include "CarServiceStack.h"
#include "CarServiceQueueVector.h"
#include "CarServiceStackVector.h"

using namespace std;

class CreateCarService
{
public:
    static CarService* carService;
    CreateCarService();
};