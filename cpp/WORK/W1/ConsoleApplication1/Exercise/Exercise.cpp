#include <iostream>

using namespace std;

void PrintLine()
{
    for (int i = 1; i < 120; i++)
    {
        cout << "-";
    }
    cout << endl;
}

void Empty()
{
    cout << "\t\t";
}

void Mult(int start, int end, int emptiness)
{
    for (int i = 1; i < 10; i++)
    {
        cout << "|";
        for (int j = start; j < end; j++)
        {
            cout << j << " * " << i << " = " << j * i << "\t|";
        }
        for (int j = 1; j <= emptiness; j++)
        {
            cout << "\t\t|";
        }
        cout << endl;
    }
    
}


int main()
{
    PrintLine();
    Mult(1, 6, 0);
    PrintLine();
    Mult(6, 10, 1);
    PrintLine();
    return 0;
}