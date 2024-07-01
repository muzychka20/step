#include <iostream>
#include <climits> 
#include <iomanip> 
#define ROWS 5
#define COLS 6

using namespace std;

int main()
{
    srand(time(0));

    int matrix[ROWS][COLS], min = INT_MAX, max = INT_MIN, sum = 0, avg, sumColumns[COLS] = { 0 }, sumRows[ROWS] = { 0 };
   
    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLS; j++)
        {
            matrix[i][j] = rand() % 100;
            
            if (matrix[i][j] > max)
            {
                max = matrix[i][j];
            }

            if (matrix[i][j] < max)
            {
                min = matrix[i][j];
            }

            sum += matrix[i][j];

            sumRows[i] += matrix[i][j];
        }
    }

    for (int i = 0; i < COLS; i++)
    {
        for (int j = 0; j < ROWS; j++)
        {           
            sumColumns[i] += matrix[j][i];
        }
    }

    avg = sum / (ROWS * COLS);


    for (int i = 0; i < ROWS; i++) 
    {
        for (int j = 0; j < COLS; j++) 
        {
            cout << setw(5) << matrix[i][j] << " ";
        }
        cout << "|" << setw(5) << sumRows[i];
        cout << endl;
    }

    for (int j = 0; j < COLS; j++)
    {
        cout << "-------";
    }

    cout << endl;

    for (int j = 0; j < COLS; j++)
    {
        cout << " " << setw(5) << sumColumns[j];
    }

    cout << "|" << setw(5) << sum;
    cout << endl;

    cout << "Max: " << max << endl;
    cout << "Min: " << min << endl;
    cout << "Avg: " << avg << endl;    
}