#include <iostream>

using namespace std;

struct Node {
    int number;
    Node* next;

    Node(int n, Node* p) : number(n), next(p) {}
};

void showList(Node* node) {
    while (node != nullptr) {
        cout << node->number << "  ";
        node = node->next;
    }
}

void addToList(Node* node, int n) {
    while (node->next != nullptr) {        
        node = node->next;
    }    
    node->next = new Node(n, nullptr);
}

int getSize(Node* node) {
    int size = 0;
    while (node != nullptr) {        
        size++;
        node = node->next;
    }
    return size;
}

int getIndex(Node* node, int n) {
    int index = 0;
    while (node != nullptr) {        
        if (node->number == n) return index;
        node = node->next;
        index++;
    }
    return -1;
}

int main()
{
    Node* p1 = new Node(4, nullptr);
    Node* p2 = new Node(6, nullptr);
    Node* p3 = new Node(9, nullptr);
    p1->next = p2; p2->next = p3;

    showList(p1); cout << endl;
    addToList(p1, 123);    
    showList(p1);
    cout << endl << "Size: " << getSize(p1);
    cout << endl << "Index of 9: " << getIndex(p1, 9);
    cout << endl << "Index of 100: " << getIndex(p1, 100);

    return 0;
}