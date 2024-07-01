#include <iostream>
#include <stdlib.h>
using namespace std;

// Користувач вводить число. Визначити кількість цифр у цьому числі, порахувати їхню суму та середнє арифметичне.
// Визначити кількість нулів у цьому числі. Спілкування з користувачем організувати через меню.

void PrintMenu()
{
    cout << "1. Enter the number" << endl;
    cout << "2. Calculate amount of digits" << endl;
    cout << "3. Calculate sum of digits" << endl;
    cout << "4. Calculate avg of digits" << endl;
    cout << "5. Calculate zero in digits" << endl;
    cout << "6. Exit" << endl;
}

int CalculateAmountOfDigits(int n)
{
    int amount = 0;
    
    while (n)
    {
        n /= 10;
        amount++;
    }

    return amount; 
}

int CalculateZero(int n)
{
    int amount = 0;
    
    while (n)
    {        
        if (!(n % 10))
            amount++;
        n /= 10;
    }

    return amount;
}

int CalculateSumOfDigits(int n)
{
    int sum = 0;
    
    while (n)
    {        
        sum += n % 10;
        n /= 10;
    }

    return sum;
}

float CalculateAvgOfDigits(int n)
{
    return (float)CalculateSumOfDigits(n) / CalculateAmountOfDigits(n);
}

int GetNumber()
{
    int n;
    cout << "Enter the number: ";
    cin >> n;
    return n;
}

int main()
{
    int number = 0, choose, t;
    
    do {
        system("clear");
        PrintMenu();    
        cin >> choose;
        switch (choose)
        {                        
            case 1:
            {
                number = GetNumber();                
                break;
            }
            case 2:
            {
                int amount = CalculateAmountOfDigits(number);
                cout << "Amount of digits: " << amount << endl;
                break;
            }
            case 3:
            {
                int sum = CalculateSumOfDigits(number);
                cout << "Sum of digits: " << sum << endl;
                break;
            }
            case 4:
            {
                float avg = CalculateAvgOfDigits(number);
                cout << "Avg of digits: " << avg << endl;
                break;
            }
            case 5:
            {
                int amountZero = CalculateZero(number);
                cout << "Zero in number: " << amountZero << endl;
                break;   
            }         
        }
        
        cout << "Press Enter to continue...";
        cin.ignore();
        cin.get();
        
    } while(choose != 6);

    return 0;
}
