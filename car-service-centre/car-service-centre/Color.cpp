#include "Color.h"

string colorToString(Color color)
{
    switch (color) {
    case Color::BLACK:
        return "BLACK";
    case Color::BLUE:
        return "BLUE";
    case Color::GRAY:
        return "GRAY";
    case Color::PINK:
        return "PINK";
    case Color::WHITE:
        return "WHITE";
    case Color::GREEN:
        return "GREEN";
    case Color::ORANGE:
        return "ORANGE";
    default:
        return "UNKNOWN";
    }
}