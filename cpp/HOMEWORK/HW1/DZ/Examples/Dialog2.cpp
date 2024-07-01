#include <iostream> // ���������� ���������� ��� �����-������
#include <string> // ���������� ���������� ��� ������ �� ��������
#include <locale> 
using namespace std;

int main() {
    setlocale(LC_ALL, "Russian"); // ������������� ������ ��� ��������� ���������
    string name; // ��������� ���������� ��� �������� ����� ������������

    // ����������� � ������ �����
    cout << "������! ��� ���� �����?" << std::endl; // ������� �������������� ���������
    cout << "> "; // ����������� ��� �����
   getline(std::cin, name); // ��������� ������ (���) � ���������� � ��������� � ���������� name

    // ����������� �� �����
    std::cout << "������� �������������, " << name << "!" << std::endl; // ������� ����������� � ������

    // ������ ��������
    int age; // ��������� ���������� ��� �������� ��������
    std::cout << "������� ���� ���, " << name << "?" << std::endl; // ������� ������ ��������
    std::cout << "> "; // ����������� ��� �����
    std::cin >> age; // ��������� ����� (�������) � ���������� � ��������� � ���������� age

    // �������� �� ���� ��������
    if (age < 0) { // ���� ������� �������������
        std::cout << "��, �������, ���-�� ����� �� ���. �������� ��� ���!" << std::endl; // ������� ��������� �� ������
        return 1; // ���������� ��� ������
    }

    // ����� �� �������
    std::cout << "���, " << age << " ���! �������!" << std::endl; // ������� ��������� � ���������

    return 0; // ���������� ������� ���, ����� �������� �������� ���������� ���������
}