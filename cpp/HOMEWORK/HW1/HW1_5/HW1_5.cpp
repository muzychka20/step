#include <iostream>
#define WORK_HOURS 8

using namespace std;

int main()
{
	int seconds, hoursLeft, hoursPass;
	
	do {
		cout << "Enter seconds: ";
		cin >> seconds;
	} while (seconds < 0);

	hoursPass = seconds / 3600;

	hoursLeft = (seconds % 3600) ? (WORK_HOURS - hoursPass - 1) : (WORK_HOURS - hoursPass);

	cout << "Hours left: " << hoursLeft;

	return 0;
}