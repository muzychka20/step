#include <iostream>
#include <string>

using namespace std;

static string findSpaceship(const string& map)
{
    int x = -1, y = -1, rows = 0, cols = 0, i, n = map.size();
              
    for (i = 0; i < n; i++)
    {              
        if (map[i] == '\n') 
        {
            rows++;
            cols = 0;            
         
        } 
        else 
        {
            if (map[i] == 'X') 
            {
                x = cols;
                y = rows;
            }
            cols++;
        }        
    }

    return (x != -1 && y != -1)
        ? "[" + std::to_string(x) + ", " + std::to_string(rows - y) + "]"
        : "Spaceship lost forever.";
}

int main()
{
    cout << findSpaceship(".X\n..");    
    
    cout << findSpaceship("X.\n..");
}