#include "SinglyLinkedList.h"

SinglyLinkedList::SinglyLinkedList() : head(nullptr) {}

SinglyLinkedList::~SinglyLinkedList()
{
    while (head != nullptr) {
        Node* temp = head;
        head = head->next;
        delete temp;
    }
}

void SinglyLinkedList::printList()
{
	Node* current = head;
	while (current != nullptr) {
		std::cout << current->data << " ";
		current = current->next;
	}
}

void SinglyLinkedList::pushBack(int value)
{
    Node* newNode = new Node(value);
    if (head == nullptr) {
        head = newNode;
        return;
    }
    Node* current = head;
    while (current->next != nullptr) {
        current = current->next;
    }
    current->next = newNode;
}

void SinglyLinkedList::pushFront(int value)
{
    Node* newNode = new Node(value);
    if (head == nullptr) {
        head = newNode;
        return;
    }
    newNode->next = head;
    head = newNode;
}

void SinglyLinkedList::insertAtIndex(int index, int value)
{
    Node* newNode = new Node(value);

    if (head == nullptr) {
        head = newNode;
        return;
    }

    if (index <= 0) {
        newNode->next = head;
        head = newNode;
        return;
    }

    int count = 0;
    Node* current = head;
    while (current->next != nullptr && index - 1 != count) {
        current = current->next;
        count++;
    }
    Node* temp = current->next;
    current->next = newNode;
    newNode->next = temp;
}

void SinglyLinkedList::popBack()
{
    if (head == nullptr) return;
    if (head->next == nullptr) {
        delete head;
        head = nullptr;
        return;
    }
    Node* current = head;
    while (current->next->next != nullptr) {
        current = current->next;
    }
    delete current->next;
    current->next = nullptr;
}

void SinglyLinkedList::removeAtIndex(int index)
{
    if (head == nullptr || index < 0) return;    

    if (index == 0) {
        Node* temp = head;
        head = head->next;
        delete temp;
        return;
    }

    Node* current = head;    
    int count = 0;
    while (current->next && index - 1 != count) {
        current = current->next;
        count++;
    }
    if (current->next == nullptr || count != index - 1) return;    
    
    Node* temp = current->next;    
    current->next = current->next->next;   
    delete temp;
}
