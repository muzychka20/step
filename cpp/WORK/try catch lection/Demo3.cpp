//#include <iostream>
//#include <string>
//using namespace std;
//
//int main() {
//    setlocale(LC_ALL, "Russian");
//    string text = "abcd";
//    int number = std::stoi(text); // Неверный формат строки
//    cout << "Число: " << number << endl;
//    return 0;
//}


#include <iostream>
#include <string>
using namespace std;

int main() {
    setlocale(LC_ALL, "Russian");
    string text = "abcd";
    try {
        int number = stoi(text);
        cout << "Число: " << number << endl;
    }
    catch (const invalid_argument& e) {
        cerr << "Ошибка: " << e.what() << endl;
    }
    return 0;
}
