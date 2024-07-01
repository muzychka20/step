#include <iostream>
using namespace std;
int main()
{

    //1
    int sum = 0;
    for (int i = 0; i < 5; i++)
    {
        int t;
        cin >> t;
        sum += t;
    }
    (sum / 5) >= 4 ? cout << "pass" : cout << "not";
    

    //2
    int number;
    cout << "number = ";
    cin >> number;
    (number & 1) ? cout << number / 2 : cout << number * 3;
    cout << endl;
}