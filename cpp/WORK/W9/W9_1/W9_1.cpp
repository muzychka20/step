#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int number;
    vector<int> array;

    while (true) {
        cin >> number;
        if (number < 0) break;
        array.push_back(number);
    }

    for (int i = array.size() - 1; i >= 0; i--) {
        cout << array[i] << "  ";
    }

    cout << endl;

    return 0;
}