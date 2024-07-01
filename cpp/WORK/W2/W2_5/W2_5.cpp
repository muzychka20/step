#include <iostream>
#include <conio.h>
#include <ctype.h>

using namespace std;


int GetAvg(int array[], int size)
{
    int sum = 0;
    
    for (int i = 0; i < size; i++)
    {
        sum += array[i];
    }

    return (float)sum / size;
}


void FillArray(int array[], int size)
{
    for (int i = 0; i < size; i++)
    {
        cout << "Enter " << i + 1 << " mark: ";
        cin >> array[i];
    }
}


void ChangeElement(int array[], int size)
{
    int position, value;
    cout << "Enter position: ";
    cin >> position;
    cout << "Enter new value: ";
    cin >> value;
    if (position < size && position >= 0)
    {
        array[position] = value;
    }
}


void PrintArray(int array[], int size)
{
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }
}


void PrintMenu()
{
    cout << "1. Eneter marks\n";
    cout << "2. Repass exam\n";
    cout << "3. Print marks\n";
    cout << "4. Calculate scholarship\n";
    cout << "5. Exit\n";
}


void CalculateScholarchip(int array[], int size)
{
    (GetAvg(array, size) >= 10.7) ? cout << "You can get scholarship!" : cout << "You can't get scholarship!";    
}


int main()
{
    int choose, array[10];
    const int size = 10;

    do
    {
        system("cls");
        PrintMenu();
        cout << "Enter: ";
        cin >> choose;
        switch (choose)
        {
        case 1:
            FillArray(array, size);
            _getch();
            break;
        case 2:
            ChangeElement(array, size);
            _getch();
            break;
        case 3:
            PrintArray(array, size);
            _getch();
            break;
        case 4:
            CalculateScholarchip(array, size);
            _getch();
            break;        
        }
    } while (choose != 5);
}