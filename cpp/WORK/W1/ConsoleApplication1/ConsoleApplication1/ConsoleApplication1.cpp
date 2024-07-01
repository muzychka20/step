#include <iostream>
#define _USE_MATH_DEFINES
#include <math.h>

int main()
{
    setlocale(LC_ALL, "Russian");
    std::cout << "Hello World!\n\\\\\"Denis\\\\\"\n";


    float V, R, length, width, height;
    int grn, cop;

    //1
    int year, days = 365;
    std::cout << "Year = ";
    std::cin >> year;
    if (!(year % 4) || (!(year % 100) && !(year % 400)))
    {
        days = 366;
    }
    std::cout << "Days = " << days << std::endl;

    //2
    std::cout << "Money\n";
    std::cout << "грн = ";
    std::cin >> grn;
    std::cout << "коп = ";
    std::cin >> cop;
    int t = cop / 100;
    cop = cop - t * 100;
    grn += t;
    std::cout << grn << " грн " << cop << " коп" << std::endl;

    //3
    std::cout << "Parallelepiped\n";
    std::cout << "Length = ";
    std::cin >> length;
    std::cout << "Width = ";
    std::cin >> width;
    std::cout << "Height = ";
    std::cin >> height;
    std::cout << "V = " << length * width * height << std::endl;

    //5
    std::cout << "Sphere\n";
    std::cout << "R = ";
    std::cin >> R;
    V = (4 * M_PI * pow(R, 3)) / 3; 
    std::cout << V;
    return 0;
}
    