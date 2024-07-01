#include <iostream>
#include <climits>


//Завдання 1. визначити мінімальний і максимальний
//елементи.


//Завдання 3. В одновимірному масиві, що складається з
//N дійсних чисел, обчислити:
//■ Суму від'ємних елементів;
//■ Добуток елементів, що розташовані між min і max
//елементами;
//■ Добуток елементів з парними номерами;
//■ Суму елементів, що розташовані між першим і останнім від'ємними елементами.


using namespace std;


pair<int, int> FindMaxMinInArray(int array[], int size)
{
    int min = INT_MAX, max = INT_MIN;
    for (int i = 0; i < size; i++)
    {
        if (min > array[i])
            min = array[i];
        if (max < array[i])
            max = array[i];
    }
    
    return { min, max };
}


int SumNegativeElements(int array[], int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
        if (array[i] < 0)
            sum += array[i];           
    return sum;
}

int MultiplyElementsBetweenMinMax(int array[], int size)
{
    pair<int, int> p = FindMaxMinInArray(array, size);
    int min = p.first, max = p.second, i, mult = 1;
    
    for (i = 0; i < size; i++)    
        if (array[i] == min || array[i] == max)
            break;
    
    for (i = i + 1; i < size; i++)
    {
        if (array[i] == min || array[i] == max)
            break;
        mult *= array[i];
    }

    return mult;
}

int SumBetweenFirstAndLastNegativeElements(int array[], int size)
{
    int i, j, sum = 0;

    for (i = 0; i < size; i++)
        if (array[i] < 0)
            break;

    for (j = size - 1; j >= 0; j--)
        if (array[j] < 0)
            break;
    i++;
    while (i < j)    
        sum += array[i++];    

    return sum;
}

int MultiplyElementsWithEvenIndexes(int array[], int size)
{
    int mult = 1;
 
    for (int i = 0; i < size; i++)
        if (!(i & 1))
            mult *= array[i];

    return mult;
}

int main()
{
    int arr[] = { -1, 2, -3, 4, -5, 8, -7, -1, -9 };
    pair<int, int> p = FindMaxMinInArray(arr, size(arr));
    cout << "Min: " << p.first << endl;
    cout << "Max: " << p.second << endl; 
    cout << "Sum negative elements: " << SumNegativeElements(arr, size(arr)) << endl;
    cout << "Multiply between min and max: " << MultiplyElementsBetweenMinMax(arr, size(arr)) << endl;
    cout << "Multiply elements with even indexes: " << MultiplyElementsWithEvenIndexes(arr, size(arr)) << endl;
    cout << "Sum between first and last negative elements: " << SumBetweenFirstAndLastNegativeElements(arr, size(arr)) << endl;
    return 0;
}
