#include <iostream>
#include <stack>

using namespace std;

int main()
{
	stack<int> myStack;
	int eaten = 0, i;

	for (i = 1; i <= 5; i++) {
		myStack.push(i);
	}
	
	while (!myStack.empty()) {
		if (eaten == 3) {
			myStack.push(i++);
		}
		if (myStack.size() == 1) {
			cout << "The most delicious: ";
		}
		cout << myStack.top() << endl;
		myStack.pop();
		eaten++;
	}

	return 0;
}