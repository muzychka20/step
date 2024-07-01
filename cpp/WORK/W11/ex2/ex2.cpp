#include <iostream>
#include <stack>

using namespace std;

bool checkPairs(string str)
{
	stack<char> stackSymbols;
	for (int i = 0; i < str.length(); i++) {
		if (str[i] == '{' || str[i] == '(' || str[i] == '[') {
			stackSymbols.push(str[i]);
		}
		else {
			if (stackSymbols.empty()) return false;
			if (
				(str[i] == '}' && stackSymbols.top() == '{')
				|| (str[i] == ']' && stackSymbols.top() == '[')
				|| (str[i] == ')' && stackSymbols.top() == '(')
				) {
				stackSymbols.pop();
			}
		}
		return !stackSymbols.empty();
	}
}

int main()
{
	string testString = ")[]";
	cout << checkPairs(testString);
	return 0;
}