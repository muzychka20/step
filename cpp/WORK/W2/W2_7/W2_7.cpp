#include <iostream>

using namespace std;

void BubbleSort(int array[], int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (array[j + 1] < array[j])
            {
                int t = array[j];
                array[j] = array[j + 1];
                array[j + 1] = t;
            }
        }
    }
}

int GetAvg(int array[], int size)
{
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
        sum += array[i];
    }

    return (float)sum / size;
}

void ReverseArray(int array[], int start, int end)
{
    while (start < end)
    {
        int t = array[start];
        array[start] = array[end];
        array[end] = t;
        start++;
        end--;
    }
}

void MySort(int array[], int n)
{
    cout << GetAvg(array, n) << endl;
    if (GetAvg(array, n) > 0)
    {        
        BubbleSort(array, (2 * n) / 3);
        ReverseArray(array, (2 * n) / 3, n - 1);
    }
    else 
    {        
        BubbleSort(array, n / 3);
        ReverseArray(array, n / 3, n - 1);
    }    
}

void PrintArray(int array[], int size)
{
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }
}


int main()
{
    int array[] = { -2, -10, 0, 4, 2, -1 }, n = size(array);
    MySort(array, n);
    PrintArray(array, n);
}
