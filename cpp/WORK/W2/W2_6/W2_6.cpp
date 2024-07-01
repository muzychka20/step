#include <iostream>

using namespace std;

int Partition(int arr[], int start, int end)
{
    int pivot = arr[start];

    int count = 0;
    for (int i = start + 1; i <= end; i++) {
        if (arr[i] <= pivot)
            count++;
    }
   
    int pivotIndex = start + count;
    swap(arr[pivotIndex], arr[start]);

    int i = start, j = end;

    while (i < pivotIndex && j > pivotIndex) {

        while (arr[i] <= pivot) {
            i++;
        }

        while (arr[j] > pivot) {
            j--;
        }

        if (i < pivotIndex && j > pivotIndex) {
            swap(arr[i++], arr[j--]);
        }
    }

    return pivotIndex;
}

void QuickSort(int arr[], int start, int end)
{

    if (start >= end)
        return;

    int p = Partition(arr, start, end);

    QuickSort(arr, start, p - 1);

    QuickSort(arr, p + 1, end);
}


int main()
{
    int array[] = { -2, -10, 0, 4, 2, -1 };

    QuickSort(array, 0, size(array) - 1);

    for (int i = 0; i < size(array); i++)
    {
        cout << array[i] << " ";
    }

    return 0;
}