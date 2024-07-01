#include <iostream>
#include <vector>
#include <limits>

using namespace std;

int main()
{
    srand(time(0));
    vector<int> array; int max = INT_MIN, min = INT_MAX;
    for(int i = 0; i < 10; i++) {        
        array.push_back(rand() % 100);
        cout << array[i] << "  ";
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }   
    cout << endl;
    cout << "min: " << min << endl;
    cout << "max: " << max << endl;    
    return 0;
}