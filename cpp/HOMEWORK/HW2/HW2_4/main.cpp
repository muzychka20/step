#include <iostream>
#include <iomanip>
#include "source.h"

using namespace std;

// Напишіть програму, яка створює двовимірний 
// масив і заповнює його за таким принципом: користувач 
// вводить число (наприклад, 3) перший елемент масиву 
// приймає значення цього числа, наступний елемент масиву 
// приймає значення цього числа + 1 (тобто 4 для нашого 
// прикладу), третій елемент масиву — попередній елемент 
// + 1 (тобто 5 для нашого прикладу). Створений масив 
// вивести на екран.

int main()
{
    int matrix[ROWS][COLS], start;

    cout << "Enter the start: ";
    cin >> start;

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLS; j++)
        {
            matrix[i][j] = start++;
            cout << setw(5) << matrix[i][j];
        }
        cout << endl;
    }

    return 0;
}