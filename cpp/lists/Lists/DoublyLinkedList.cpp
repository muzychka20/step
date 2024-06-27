#include "DoublyLinkedList.h"

DoublyLinkedList::DoublyLinkedList() : head(nullptr) {}

DoublyLinkedList::~DoublyLinkedList()
{
	while (head != nullptr) {
		Node* temp = head;
		head = head->next;
		delete temp;
	}
}

void DoublyLinkedList::printList()
{
	Node* current = head;
	while (current != nullptr) {
		std::cout << current->data << " ";
		current = current->next;
	}
}

void DoublyLinkedList::printReverseList()
{
	Node* current = head;
	while (current->next != nullptr) {
		current = current->next;
	}
	while (current != nullptr) {
		std::cout << current->data << " ";
		current = current->prev;
	}
}

void DoublyLinkedList::pushBack(int value)
{
	Node* newNode = new Node(value);
	if (head == nullptr) {
		head = newNode;
		return;
	}
	Node* current = head;
	while (current->next != nullptr)
		current = current->next;			
	current->next = newNode;
	newNode->prev = current;
}

void DoublyLinkedList::pushFront(int value)
{
	Node* newNode = new Node(value);
	if (head == nullptr) {
		head = newNode;
		return;
	}
	newNode->next = head;
	head->prev = newNode;
	head = newNode;
}

void DoublyLinkedList::popBack()
{
	if (head == nullptr)
		return;	
	if (head->next == nullptr) {
		delete head;
		head = nullptr;
		return;
	}
	Node* current = head;
	while (current->next != nullptr)
		current = current->next;	
	current->prev->next = nullptr;
	delete current;
}

void DoublyLinkedList::removeAtIndex(int index)
{
	if (head == nullptr || index < 0) 
		return;
	if (!index) {
		Node* temp = head;
		head = head->next;
		if (head != nullptr)
			head->prev = nullptr;
		delete temp;
		return;
	}
	Node* current = head;
	int i = 0;
	while (current != nullptr && i < index) {
		i++;
		current = current->next;
	}
	if (current == nullptr)
		return;			
	current->prev->next = current->next;
	if (current->next != nullptr)
		current->next->prev = current->prev;
	delete current;
}

void DoublyLinkedList::insertAtIndex(int index, int value)
{
	Node* newNode = new Node(value);
	if (head == nullptr)
		head = newNode;	
	if (index < 0) 
		return;
	Node* current = head;
	int i = 0;
	while (current != nullptr && i < index) {
		i++;
		current = current->next;
	}
	if (current == nullptr) 
		return;
	if (current->prev == nullptr) {
		newNode->next = current;
		current->prev = newNode;
		head = newNode;
		return;
	}
	newNode->prev = current->prev;
	newNode->next = current;
	current->prev->next = newNode;
	current->prev = newNode;
}
