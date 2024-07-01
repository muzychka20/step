#include <iostream>

using namespace std;

void SelectionSort(int array[], int n)
{
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j <= i - 1; j++)
        {
            if (array[i] < array[j])
            {
                int t = array[i];                
                for (int k = i; k >= j + 1; k--) array[k] = array[k - 1];
                array[j] = t;
            }
        }
    }
}

int main()
{
    int array[] = { -2, -10, 0, 4, 2, -1 };

    SelectionSort(array, size(array));

    for (int i = 0; i < size(array); i++)
    {
        cout << array[i] << " ";
    }

    return 0;
}