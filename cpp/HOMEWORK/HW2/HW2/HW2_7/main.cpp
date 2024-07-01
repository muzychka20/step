#include <iostream>

using namespace std;

// Написати програму, яка виводить на екран шахову дошку із заданим розміром клітинки.

void PrintBlackCell(int sizeCell)
{
    for (int i = 0; i < sizeCell; i++)
    {
        cout << "*";
    }
}

void PrintWhiteCell(int sizeCell)
{
    for (int i = 0; i < sizeCell; i++)
    {
        cout << "-";
    }
}

int main()
{
    int sizeCell;
    
    cout << "Enter the size of cell: ";
    cin >> sizeCell;

    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {            
            if ((!(i & 1) && !(j & 1)) || (i & 1) && (j & 1))
            {
                PrintWhiteCell(sizeCell);
            }
            else
            {
                PrintBlackCell(sizeCell);
            }
           
            cout << " ";
        }
        cout << endl;
    }

    return 0;
}
