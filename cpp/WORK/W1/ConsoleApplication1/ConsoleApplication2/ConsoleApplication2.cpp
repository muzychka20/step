#include <iostream>
#define _USE_MATH_DEFINES
#include <math.h>

int main()
{

    //5
    double gb, speed;
    int sec, min, h;
    std::cout << "Gb: ";
    std::cin >> gb;
    std::cout << "speed bits/s: ";
    std::cin >> speed;
    speed *= 1.25e-10; // in gb/s
    sec = (int)ceil(gb / speed);

    min = sec / 60;
    sec -= min * 60;
    h = min / 60;
    min -= h * 60;
    std::cout << h << " hours " << min << " min " << sec << " sec" << std::endl;


    //3
    float price, amount, sale;
    std::cout << "Price: ";
    std::cin >> price;
    std::cout << "Amount: ";
    std::cin >> amount;
    std::cout << "Sale: ";
    std::cin >> sale;
    std::cout << "Total: " << price * amount - price * amount * (sale / 100) << std::endl;

    //4
    float salary, selling;
    std::cout << "Salary: ";
    std::cin >> salary;
    std::cout << "Selling: ";
    std::cin >> selling;
    std::cout << "Salary total: " << salary + selling * 0.05 << std::endl;

    // 1
    int time, seconds, minutes, hours;
    std::cout << "Time(seconds): ";
    std::cin >> seconds;
    minutes = seconds / 60;
    seconds -= minutes * 60;
    hours = minutes / 60;
    minutes -= hours * 60;
    std::cout << hours << " hours " << minutes << " min " << seconds << " sec" << std::endl;
    std::cout << "Time left: \n";
    std::cout << 24 - hours << " hours " << 60 - minutes << " min " << 60 - seconds << " sec" << std::endl;

    // 2
    float diameter;
    std::cout << "Diameter: ";
    std::cin >> diameter;
    std::cout << "S = " << (M_PI * diameter * diameter) / 4;
    std::cout << "l = " << M_PI * diameter;

}