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

int main()
{
    int array[] = { -2, -10, 0, 4, 2, -1 };
    
    BubbleSort(array, size(array));
    
    for (int i = 0; i < size(array); i++)
    {
        cout << array[i] << " ";
    }

    return 0;
}