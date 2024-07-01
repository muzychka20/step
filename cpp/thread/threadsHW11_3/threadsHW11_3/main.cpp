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

bool isPrime(int n) {
    int t = 0;
    for (int j = 1; j <= n; j++) {
        t += (n % j) ? 0 : 1;
    }
    return t == 2;
}

void getCountPrimeNumber(vector<int> arr, int* res)
{
    for (int i = 0; i < arr.size(); i++) {
        if (isPrime(arr[i])) {
            (*res)++;
            cout << arr[i] << " ";
        }
    }
}

int main()
{
    int primeAmount = 0;
    
    vector<int> m = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
    vector<int> m1 = slicing(m, 0, m.size() / 2 - 1), m2 = slicing(m, m.size() / 2, m.size() - 1);
    
    thread t1(getCountPrimeNumber, m1, &primeAmount);
    thread t2(getCountPrimeNumber, m2, &primeAmount);

    t1.join();
    t2.join();

    cout << "\nPrime number: " << primeAmount << endl;

    return 0;
}
