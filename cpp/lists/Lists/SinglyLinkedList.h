#pragma once
#include <iostream>

class SinglyLinkedList
{
private:
    struct Node {
        int data;
        Node* next;       
        Node(int _data) : data(_data), next(nullptr) {}        
    };
    Node* head;
public:   
    SinglyLinkedList();
    ~SinglyLinkedList();
    void printList();    
    void pushBack(int value);
    void pushFront(int value);
    void insertAtIndex(int index, int value);
    void popBack();
    void removeAtIndex(int index);  
};

