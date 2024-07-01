#include <iostream>
#include <cstdlib>
#include <climits>
#include "source.h"

using namespace std;

//В одновимірному масиві, заповненому випадковими числами, визначити мінімальний і максимальний едемнти

int main() {
    srand((unsigned)time(0));
    
    int array[arraySize], min = INT_MAX, max = INT_MIN;
    
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = rand() % 1000;
        
        if (min > array[i])
        {
            min = array[i];
        }
        
        if (max < array[i])
        {
            max = array[i];
        }
        
        cout << "array[" << i + 1 << "] = " << array[i] << endl;
    }
    
    cout << "Min: " << min << endl;
    cout << "Max: " << max << endl;
    
    return 0;
}
