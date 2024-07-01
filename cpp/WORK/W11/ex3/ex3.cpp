#include <iostream>
#include <stack>
#include <vector>

using namespace std;

bool isOperator(string s) {
	return (s == "*" || s == "/" || s == "+" || s == "-") ? true : false;
}

int calculate(vector<string> str) {
	stack<int> stackCalculate;
	
	for (int i = 0; i < str.size(); i++) {
		if (!isOperator(str[i])) {
			stackCalculate.push(atoi(str[i].c_str()));
		}
		else {
			int second = stackCalculate.top();
			stackCalculate.pop();
			int first = stackCalculate.top();
			stackCalculate.pop();
			if (str[i] == "*")
				stackCalculate.push(first * second);
			else if (str[i] == "/")
				stackCalculate.push(first / second);
			else if (str[i] == "+")
				stackCalculate.push(first + second);
			else if (str[i] == "-")
				stackCalculate.push(first - second);
		}
	}
	
	return stackCalculate.top();
}

int main()
{
	vector<string> testString = { "12", "2", "3", "4", "*", "10", "5", "/", "+", "*", "+"};
	cout << calculate(testString);
	return 0;
}