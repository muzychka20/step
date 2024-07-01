#include <iostream>
#include <vector>

using namespace std;

vector<int> squareUp(int n)
{
    vector<int> vec; int j, i;
    for (i = 0; i < n; i++)
    {
        for (j = 1; j <= n - i; j++)        
            vec.push_back(j);        
        while (j++ <= n) 
            vec.push_back(0);
    }
    reverse(vec.begin(), vec.end());
    return vec;
}

int main()
{
    for (auto el : squareUp(4))
        cout << el;
    return 0;
}