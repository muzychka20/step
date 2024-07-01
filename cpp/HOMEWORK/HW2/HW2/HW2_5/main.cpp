#include <iostream>

using namespace std;

void PrintMenu()
{
    cout << "s. Enter the size" << endl;
    cout << "1 pattern" << endl;
    cout << "2 pattern" << endl;
    cout << "3 pattern" << endl;
    cout << "4 pattern" << endl;
    cout << "5 pattern" << endl;
    cout << "6 pattern" << endl;
    cout << "7 pattern" << endl;
    cout << "8 pattern" << endl;
    cout << "9 pattern" << endl;
    cout << "a pattern" << endl;
    cout << "e. Exit" << endl;
}

void PrintFromHeight(int size, int minus, char ch)
{
    for (int j = size; j > size - minus; j--)
    {
        cout << ch;
    }
}

void PrintFromBelow(int size, int minus, char ch)
{
    for (int j = 0; j < size - minus; j++)
    {
        cout << ch;
    }
}

void Print1(int size)
{    
    for (int i = 0; i < size; i++)
    {
        PrintFromHeight(size, i, ' ');          
        PrintFromBelow(size, i, '*');
        cout << endl;
    }
}

void Print2(int size)
{    
    for (int i = 0; i < size; i++)
    {
        PrintFromBelow(size, i, '*');       
        cout << endl;
    }
}

void Print3(int size)
{    
    if (size & 1)
        size--;

    for (int i = 0; i <= size; i++)
    {
        PrintFromHeight(size, i, ' ');    
        for (int j = 0; j <= size - 2 * i; j++) {
            cout << "*";
        }
        cout << endl;
    }
}

void Print4(int size)
{
    if (!size) return;

    if (size & 1)
        size--;
        
    for (int i = 0; i <= size / 2; i++)
        cout << endl;

    for (int i = 0; i <= size / 2; i++)
    {     
        PrintFromBelow(size / 2, i, ' ');        
        for (int j = size; j >= size - 2 * i; j--) {
            cout << "*";
        }
        cout << endl;
    }
}

void Print5(int size)
{    
    if (!size) return;
    
    if (!(size & 1))
        size--;
       
    for (int i = 0; i < size / 2; i++)
    {    
        PrintFromHeight(size, i, ' ');
        PrintFromBelow(size, i * 2, '*');
        cout << endl;
    }

    for (int i = 0; i <= size / 2; i++)
    {
        PrintFromBelow(size / 2, i, ' ');        
        for (int j = size; j >= size - 2 * i; j--)
        {
            cout << "*";
        }
        cout << endl;
    }
}

void Print6(int size)
{       
    if (size & 1)
        size--;

    for (int i = 1; i <= size / 2; i++)
    {
        PrintFromHeight(size, i, '*');
        PrintFromBelow(size, 2 * i, ' ');
        PrintFromHeight(size, i, '*');
        cout << endl;        
    }

    for (int i = 1; i < size / 2; i++)
    {
        PrintFromBelow(size / 2, i, '*');
        PrintFromHeight(size, 2 * i, ' ');
        PrintFromBelow(size / 2, i, '*');
        cout << endl;
    }        
}

void Print7(int size)
{        
    for (int i = 1; i < size / 2; i++)
    {
        PrintFromHeight(size, i, '*');        
        cout << endl;
    }

    for (int i = 0; i < size / 2; i++)
    {
        PrintFromBelow(size / 2, i, '*');
        cout << endl;
    }
}

void Print8(int size)
{    
    if (size & 1)
        size--;

    for (int i = 1; i <= size / 2; i++)
    {
        PrintFromBelow(size, i, ' ');
        PrintFromHeight(size, i, '*');        
        cout << endl;
    }

    for (int i = 1; i < size / 2; i++)
    {
        PrintFromBelow(size / 2, -i, ' ');        
        PrintFromBelow(size / 2, i, '*');
        cout << endl;
    }
}

void Print9(int size)
{    
    for (int i = 0; i < size; i++)
    {
        PrintFromBelow(size, i, '*');
        cout << endl;
    }
}

void PrintA(int size)
{    
    for (int i = 1; i <= size; i++)
    {
        PrintFromBelow(size, i, ' ');
        PrintFromHeight(size, i, '*');
        cout << endl;
    }
}

int main()
{
    char choose;
    int size = 0;
    do {
        system("clear");
        PrintMenu();        
        cin >> choose;
        switch(choose)
        {
            case 's':
                cout << "Enter the size: ";
                cin >> size;         
                break;         
            case '1':
                Print1(size);
                break;
            case '2':
                Print2(size);
                break;
            case '3':
                Print3(size);
                break;
            case '4':
                Print4(size);
                break;
            case '5':
                Print5(size);
                break;
            case '6':
                Print6(size);
                break;
            case '7':
                Print7(size);
                break;    
            case '8':
                Print8(size);
                break;
            case '9':
                Print9(size);
                break;
            case 'a':
                PrintA(size);
                break;
        }
        cout << "Press Enter to continue...";
        cin.ignore();
        cin.get();
    } while(choose != 'e');
    
    return 0;
}