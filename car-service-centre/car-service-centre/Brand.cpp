#include "Brand.h"

string brandToString(Brand brand)
{
    switch (brand) {
    case Brand::HONDA:
        return "HONDA";
    case Brand::SKODA:
        return "SKODA";
    case Brand::MAZDA:
        return "MAZDA";
    case Brand::FORD:
        return "FORD";
    case Brand::RENAULT:
        return "RENAULT";
    default:
        return "UNKNOWN";
    }
}
