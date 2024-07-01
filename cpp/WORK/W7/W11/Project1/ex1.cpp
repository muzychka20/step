#include <iostream>
#include <stack>

using namespace std;

stack<char> getReverseString(string str) {
	stack<char> reverse;
	for (int i = 0; i < str.length(); i++) {
		reverse.push(str[i]);
	}
	return reverse;
}

template <typename T>
void printStack(stack<T> st) {
	while (!st.empty()) {
		cout << st.top();
		st.pop();
	}
}

int main()
{
	string testString = "Hello world";
	printStack<char>(getReverseString(testString));
	return 0;
}