#include <iostream>

using namespace std;

int main()
{
    int array[] = { 1, 2, 3, 0, 4, 0, 5, 0 }, j = 0, n = size(array);    

    for (int i = 0; i < n; i++)
    {
        if (array[i])
        {
            array[j++] = array[i];            
        }
        if (!array[i] && i + 1 < n)
        {
            array[j++] = -1;
            i++;
        }
    }
    n = j;
    
    for (int i = 0; i < n; i++)
    {
        cout << array[i] << " ";
    }

    return 0;
}