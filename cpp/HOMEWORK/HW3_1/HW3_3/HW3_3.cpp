#include <iostream>

//Написати функцію, що визначає, чи є «щасливим» шестизначне число

using namespace std;

int CountDigits(int number)
{
    int amount = 0;
    
    while (number)
    {
        number /= 10;
        amount++;
    }        

    return amount;
}

int GetSumOfNumberWith3Digits(int n)
{
    int sum = 0;
   
    while (n)
    {
        sum += n % 10;
        n /= 10;
    }

    return sum;
}

bool HappyNumber(int number)
{    
    if (CountDigits(number) != 6)
        return false;

    int firstPart = number % 1000, secondPart = number / 1000;

    return GetSumOfNumberWith3Digits(firstPart) == GetSumOfNumberWith3Digits(secondPart);
}

int main()
{
    HappyNumber(123) ? cout << "Yes\n" : cout << "No\n";
    HappyNumber(123132) ? cout << "Yes\n" : cout << "No\n";
    HappyNumber(123124) ? cout << "Yes\n" : cout << "No\n";
    return 0;
}