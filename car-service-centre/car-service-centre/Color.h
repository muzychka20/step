#pragma once
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