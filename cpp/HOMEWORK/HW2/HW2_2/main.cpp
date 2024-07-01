#include <iostream>
#include <climits>
#include "source.h"

using namespace std;

// Завдання 2. Користувач вводить прибуток фірми за рік (12 
// місяців). Потім користувач вводить діапазон (наприклад, 
// 3 і 6 — пошук між третім і шостим місяцем). Необхідно 
// визначити місяць, у якому прибуток був максимальним, і 
// місяць, у якому прибуток був мінімальним, з урахуванням 
// обраного діапазону.

int main()
{
    int min = INT_MAX, max = INT_MIN, array[arraySize], lowLimit, highLimit;
    
    for (int i = 0; i < arraySize; i++)
    {
        cout << "Month " << i + 1 << ": ";
        cin >> array[i];
    }

    cout << "Enter low limit: ";
    cin >> lowLimit;

    cout << "Enter high limit: ";
    cin >> highLimit;

    for (int i = lowLimit - 1; i < highLimit; i++)
    {         
        if (min > array[i])
        {
            min = array[i];
        }

        if (max < array[i])
        {
            max = array[i];
        }
    }

    cout << "Min: " << min << endl;
    cout << "Max: " << max << endl;

    return 0;
}