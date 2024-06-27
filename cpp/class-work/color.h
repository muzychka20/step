#ifndef COLOR_H
#define COLOR_H

#include <iostream>

using namespace std;

enum class Color
{
    PINK,
    GRAY,
    BLACK,
    WHITE,
    GREEN,
    ORANGE,
    BLUE,
    COUNT = 7
};

string colorToString(Color color);

#endif // COLOR_H
