#include <iostream>
#include <cmath>

using namespace std;

int main()
{	
	setlocale(LC_CTYPE, "ukr");

	float grn, cop, money;

	do {
		cout << "¬ведiть число: ";
		cin >> money;
	} while (money < 0);

	cop = modff(money, &grn) * 100;	

	cout << grn << " грн " << cop << " коп";

	return 0;
}