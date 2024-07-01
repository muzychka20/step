#include <iostream>

using namespace std;

int main()
{   
    const int arrayResultSize = 10;
    int amountZero = 0, array1[] = { 1, -2, 3, 0, 0 }, array2[] = { -10, 0, 45, -1, -10 }, j = 0, n1 = size(array1), arrayResult[arrayResultSize];
    
    for (int i = 0; i < n1; i++)
    {
        if (array1[i] > 0)
        {
            arrayResult[j++] = array1[i];
        }
        if (array2[i] > 0)
        {
            arrayResult[j++] = array2[i];
        }
        if (!array1[i] || !array2[i])
        {
            amountZero++;
        }
    }

    for (int i = 0; i < amountZero; i++)
    {
        arrayResult[j++] = 0;
    }

    for (int i = 0; i < n1; i++)
    {
        if (array1[i] < 0)
        {
            arrayResult[j++] = array1[i];
        }
        if (array2[i] < 0)
        {
            arrayResult[j++] = array2[i];
        }
    }

    for (int i = 0; i < arrayResultSize; i++)
    {
        cout << arrayResult[i] << " ";
    }

    return 0;
}