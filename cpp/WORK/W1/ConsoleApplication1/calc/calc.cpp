#include <iostream>
#include <string>

using namespace std;

float MySum(float a, float b)
{
	return a + b;
}

float MyDif(float a, float b)
{
	return a - b;
}

float MyDiv(float a, float b)
{
	return a / b;
}

float MyMult(float a, float b)
{
	return a * b;
}


int main()
{
	char operation;
	float res, x, y;

	cout << "operation: ";
	operation = getchar();

	cout << "x = ";
	cin >> x;

	cout << "y = ";
	cin >> y;	

	switch (operation)
	{
	case '+':
		res = MySum(x, y);
		break;
	case '-':
		res = MyDif(x, y);
		break;
	case '/':
		res = MyDiv(x, y);
		break;
	case '*':
		res = MyMult(x, y);
		break;
	}
	cout << "Result = " << res;
}