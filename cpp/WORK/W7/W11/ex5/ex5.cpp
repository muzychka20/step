#include <iostream>
#include <vector>

using namespace std;

class StackOnVector {
private:
	vector<int> vec;

public:
	StackOnVector() {}
	
	void addItem(int value) {
		vec.push_back(value);
	}

	void removeTopElement() {
		if (!vec.empty()) vec.pop_back();
	}

	int getSize() {
		return vec.size();
	}

	int getElementAt(int index) {
		if (index < vec.size()) {
			return vec.at(index);
		}
		else {
			throw out_of_range("Index out of range");
		}		
	}

	void printElements() {
		for (int i = vec.size() - 1; i >= 0; i--) {
			cout << vec[i] << " ";
		}
		cout << endl;
	}

};

int main()
{
	StackOnVector* stack = new StackOnVector();
	stack->addItem(1);
	stack->addItem(2);
	stack->addItem(3);

	stack->printElements();
	
	stack->removeTopElement();
	stack->addItem(4);
	stack->printElements();

	//stack->getElementAt(32);
	cout << stack->getElementAt(2) << endl;
	cout << stack->getSize() << endl;

	return 0;
}