#include <iostream>

using namespace std;

int main()
{
    int seconds, minutes, hours;
    
    do {
        cout << "Enter time in seconds: ";
        cin >> seconds;
    } while (seconds < 0);
            
    hours = seconds / 3600;
    minutes = (seconds % 3600) / 60;
    seconds = seconds % 60;

    cout << hours << " hours " << minutes << " minutes " << seconds << " seconds";

    return 0;
}