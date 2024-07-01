#include <iostream>
#include <algorithm>

using namespace std;

string bucketOf(const string& said)
{   
    string res = "";

    string lowerSaid = said;
    transform(lowerSaid.begin(), lowerSaid.end(), lowerSaid.begin(), ::tolower);


    if (
        lowerSaid.find("water") != std::string::npos ||
        lowerSaid.find("wet") != std::string::npos ||
        lowerSaid.find("wash") != std::string::npos
        ) 
    {
        res.append("water");
    }
    
    if (
        lowerSaid.find("i don't know") != std::string::npos ||
        lowerSaid.find("slime") != std::string::npos
        )
    {
        res.append("slime");
    }
    
    if (res == "waterslime")
        res = "sludge";
    
    if (res == "")
        res = "air";

    return res;
}

int main()
{
    cout << bucketOf("Will I get wet? I don't know.");
    cout << "\n";
    cout << bucketOf("I don't know if I'm doing this right.");
    cout << "\n";
    cout << bucketOf("SLIME");
    
}
