#include <iostream>

using namespace std;

int main()
{
	//1
	int number;
	cout << "number = ";
	cin >> number;
	(number & 1) ? cout << "odd\n" : cout << "even\n";

	//2
	int n1, n2;
	cout << "number1 = ";
	cin >> n1;
	cout << "number2 = ";
	cin >> n2;
	(n1 > n2) ? cout << "n2\n" : cout << "n1\n";


	//3
	int num;
	cout << "num = ";
	cin >> num;
	if (num > 0) {
		cout << "num > 0\n";
	}
	else if (num < 0) {
		cout << "num < 0\n";
	}
	else {
		cout << "num == 0\n";
	}

	//4
	int num1, num2;
	cout << "num1 = ";
	cin >> num1;
	cout << "num2 = ";
	cin >> num2;
	if (num1 != num2) {
		(num1 > num2) ? cout << num2 << " " << num1 << endl : cout << num1 << " " << num2 << endl;
	}
}
