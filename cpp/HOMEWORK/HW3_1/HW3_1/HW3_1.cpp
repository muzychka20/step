#include <iostream>
#include <cmath>

using namespace std;

//Завдання 1. Написати функцію, яка приймає два параметри : основа степеня і показник степеня, та обчислює
//степінь числа на основі отриманих даних.

int Pow(int base, int n)
{
	int res = 1;
	
	while (n)
	{
		if (n & 1)
		{
			res *= base;
			n--;
		}
		base *= base;
		n /= 2;
	}	

	return res;
}

int main()
{
	cout << Pow(2, 7);
	cout << endl;
	cout << Pow(2, 6);
	return 0;
}