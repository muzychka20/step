#include <iostream>
#define MAX 7

using namespace std;

int main()
{
    float n, max;

    cout << "Enter number [1] : ";
    cin >> max;

    for (int i = 1; i < MAX; i++)
    {
        cout << "Enter number [" << i + 1 << "] : ";
        cin >> n;
    
        if (max < n)
        {
            max = n;
        }
    }

    cout << "Max: " << max;

    return 0;
}
