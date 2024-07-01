#include <iostream>
#include <vector>

using namespace std;

template <typename T>
T getElement(vector<T>& vec, int index) {
	try {
		if (index < 0 || index >= vec.size()) throw out_of_range("Index is invalid!");
		return vec[index];
	}
	catch(const exception& e) {
		cerr << e.what() << endl;
		return 0;
	}
}


int main()
{
	//int number;
	//cout << "number: "; cin >> number;
	//try {
	//	/*if (number == 0) {
	//		throw runtime_error("Zero division!");
	//	}*/
	//	int result = 1 / number;
	//	cout << "result: " << result << endl;
	//}
	//catch (const exception& e) {
	//	cerr << e.what() << endl;
	//	int result = 1 / 1;
	//	cout << "result: " << result << endl;
	//}
	
	vector<int> v = { 0, 1, 2, 3, 4, 5 };
	cout << getElement(v, 6);


	return 0;
}