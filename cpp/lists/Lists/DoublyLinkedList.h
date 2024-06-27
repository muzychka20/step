#pragma once
#include <iostream>

class DoublyLinkedList
{
private:
	struct Node {
        int data;
        Node* next;
        Node* prev;
        Node(int _data) : data(_data), next(nullptr), prev(nullptr) {}
	};
    Node* head;

public:
    DoublyLinkedList();
    ~DoublyLinkedList();
    void printList();
    void printReverseList();
    void pushBack(int value);
    void pushFront(int value);
    void popBack();
    void removeAtIndex(int index);
    void insertAtIndex(int index, int value);
};