#include <iostream>
#include <thread>
#include <vector>
using namespace std;

vector<int> slicing(vector<int>& arr, int X, int Y)
{
    // Starting and Ending iterators
    auto start = arr.begin() + X;
    auto end = arr.begin() + Y + 1;

    // To store the sliced vector
    vector<int> result(Y - X + 1);

    // Copy vector using copy function()
    copy(start, end, result.begin());

    // Return the final sliced vector
    return result;
}

void getSum(vector<int> arr, int* res)
{
    int sum = 0;
    for (int i = 0; i < arr.size(); i++) {
        sum += arr[i];
    }
    *res = sum;
}

int sum(vector<int> arr)
{
    int sum = 0;
    for (int i = 0; i < arr.size(); i++) {
        sum += arr[i];
    }
    return sum;
}

int main()
{
    int a, b;

    vector<int> m = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
    vector<int> m1 = slicing(m, 0, m.size() / 2 - 1), m2 = slicing(m, m.size() / 2, m.size() - 1);
    
    thread t1(getSum, m1, &a);
    thread t2(getSum, m2, &b);

    t1.join();
    t2.join();

    cout << "Sum = " << a + b << " (" << sum(m) << ")";

    return 0;
}
