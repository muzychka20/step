#include <iostream>
#include <climits> 
#include <iomanip> 
#define ROWS 5
#define COLS 10

using namespace std;

int main()
{
    srand(time(0));

    int matrix1[ROWS][COLS], matrix2[ROWS][ROWS];

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLS; j++)
        {
            matrix1[i][j] = (rand() % 50) + 1;            
        }
    }
    
    for (int i = 0; i < ROWS; i++)
    {        
        int k = 0;
        for (int j = 0; j < COLS; j += 2)
        {
            matrix2[i][k++] = matrix1[i][j] + matrix1[i][j + 1];
        }
    } 
    
    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLS; j++)
        {
            cout << setw(5) << matrix1[i][j];
        }
        cout << endl;
    }
    
    cout << endl << endl;    

    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < ROWS; j++)
        {
            cout << setw(5) << matrix2[i][j];
        }
        cout << endl;
    }
}