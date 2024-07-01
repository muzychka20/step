#include <iostream>

using namespace std;

//Завдання 2. Написати функцію, яка отримує в якості
//параметрів 2 цілих числа та повертає суму чисел із діапазону між ними.

int GetSumOfRange(int start, int end)
{
	int res = 0;
	for (int i = start + 1; i < end; i++)
		res += i;
	return res;
}

int main()
{
	cout << GetSumOfRange(1, 10);
	return 0;
}
