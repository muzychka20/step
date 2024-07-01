#include <iostream>
#include <cfloat>
#include "source.h"

using namespace std;

// Завдання 3. В одновимірному масиві, що складається з 
// N дійсних чисел, обчислити:
// ■ Суму від'ємних елементів;
// ■ Добуток елементів, що розташовані між min і max 
// елементами;
// ■ Добуток елементів з парними номерами;
// ■ Суму елементів, що розташовані між першим і останнім від'ємними елементами.

int FindFirstNegative(float array[], int n)
{
    for (int i = 0; i < n; i++)
        if (array[i] < 0)
            return i;
    return -1;
}

int FindLastNegative(float array[], int n)
{
    for (int i = n - 1; i >= 0; i--)
        if (array[i] < 0)
            return i;
    return -1;
}

int main()
{
    srand(unsigned(time(0)));

    float min = FLT_MAX, max = FLT_MIN, array[arraySize], sumNegative = 0, multBetweenMinMax = 1, multElementsWithEvenIndex = 1, sumBetweenNegative = 0;    
    int indexMin = 0, indexMax = 0;

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = rand() % 100 - 50;
        
        if (array[i] < 0)
        {
            sumNegative += array[i];            
        }

        if (min > array[i])
        {
            min = array[i];
            indexMin = i;
        }

        if (max < array[i])
        {
            max = array[i];
            indexMax = i;
        }

        if (!(i & 1))
        {
            multElementsWithEvenIndex *= array[i];
        }
        
        cout << "array[" << i << "] = " << array[i] << endl;
    }

    for (int i = indexMin + 1; i < indexMax; i++)
    {
        multBetweenMinMax *= array[i];
    }

    for (int i = FindFirstNegative(array, arraySize) + 1; i < FindLastNegative(array, arraySize); i++)
    {
        sumBetweenNegative += array[i];
    }

    cout << "Sum negative elemets: " << sumNegative << endl;
    cout << "Multiply between min and max: " << multBetweenMinMax << endl;
    cout << "Multiply elements with even indexes: " << multElementsWithEvenIndex << endl;
    cout << "Sum between first and last negative elements: " << sumBetweenNegative << endl;

    return 0;
}