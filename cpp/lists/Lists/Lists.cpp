#include <iostream>
#include "SinglyLinkedList.h"
#include "DoublyLinkedList.h"

int main()
{
    /*SinglyLinkedList* singlyLinkedList = new SinglyLinkedList();       

    singlyLinkedList->pushBack(10);
    singlyLinkedList->pushBack(7);
    singlyLinkedList->pushFront(14);
    std::cout << "1) "; singlyLinkedList->printList(); std::cout << std::endl;
    
    singlyLinkedList->insertAtIndex(2, 25);    
    std::cout << "2.1) "; singlyLinkedList->printList(); std::cout << std::endl;
    singlyLinkedList->insertAtIndex(9, 4);
    std::cout << "2.2) "; singlyLinkedList->printList(); std::cout << std::endl;
    singlyLinkedList->insertAtIndex(0, 100);
    std::cout << "2.3) "; singlyLinkedList->printList(); std::cout << std::endl;
    singlyLinkedList->insertAtIndex(-2, -2);        
    std::cout << "2.4) "; singlyLinkedList->printList(); std::cout << std::endl;
    singlyLinkedList->insertAtIndex(2, 55);
    std::cout << "2.5) "; singlyLinkedList->printList(); std::cout << std::endl;
    
    singlyLinkedList->popBack();
    std::cout << "3) "; singlyLinkedList->printList(); std::cout << std::endl;

    singlyLinkedList->removeAtIndex(-1);
    std::cout << "4.1) "; singlyLinkedList->printList(); std::cout << std::endl;
    singlyLinkedList->removeAtIndex(0);
    std::cout << "4.2) "; singlyLinkedList->printList(); std::cout << std::endl;
    singlyLinkedList->removeAtIndex(2);
    std::cout << "4.3) "; singlyLinkedList->printList(); std::cout << std::endl;
    singlyLinkedList->removeAtIndex(2);
    std::cout << "4.4) "; singlyLinkedList->printList(); std::cout << std::endl;
    singlyLinkedList->removeAtIndex(2);
    std::cout << "4.5) "; singlyLinkedList->printList(); std::cout << std::endl;
    singlyLinkedList->removeAtIndex(3);
    std::cout << "4.6) "; singlyLinkedList->printList(); std::cout << std::endl;*/
    
    DoublyLinkedList* doublyLinkedList = new DoublyLinkedList();
    
    doublyLinkedList->pushBack(2);
    doublyLinkedList->pushBack(3);
    doublyLinkedList->pushBack(4);
    std::cout << "1) "; doublyLinkedList->printList(); std::cout << std::endl;  

    doublyLinkedList->pushFront(1);
    std::cout << "2) "; doublyLinkedList->printList(); std::cout << std::endl; 

    doublyLinkedList->popBack();
    std::cout << "3) "; doublyLinkedList->printList(); std::cout << std::endl;
    
    doublyLinkedList->removeAtIndex(1);
    std::cout << "4) "; doublyLinkedList->printList(); std::cout << std::endl;    

    doublyLinkedList->insertAtIndex(-1, 100);
    std::cout << "5) "; doublyLinkedList->printList(); std::cout << std::endl;

    doublyLinkedList->insertAtIndex(20, 100);
    std::cout << "6) "; doublyLinkedList->printList(); std::cout << std::endl;

    doublyLinkedList->insertAtIndex(0, 200);
    std::cout << "7) "; doublyLinkedList->printList(); std::cout << std::endl;

    doublyLinkedList->insertAtIndex(2, 300);
    std::cout << "8) "; doublyLinkedList->printList(); std::cout << std::endl;

    doublyLinkedList->insertAtIndex(2, 400);
    std::cout << "9) "; doublyLinkedList->printList(); std::cout << std::endl;
    
    std::cout << "10) "; doublyLinkedList->printReverseList(); std::cout << std::endl;

    return 0;
}