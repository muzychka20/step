#include <iostream>
#include <string>

using namespace std;

float getFloatFromString(string str)
{
    try {
        return stof(str);        
    }
    catch (const invalid_argument& e) {
        cerr << e.what() << endl;
        return -1;
    }
}

int main()
{
    string s = "4.34";
    cout << "pi: " << getFloatFromString(s);
    return 0;
}