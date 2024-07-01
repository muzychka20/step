#include <iostream>
#include <queue>
#define SIZE 5
using namespace std;

void addClient(queue<int>& q, int value) {
	cout << "New client arrived!\n";
	if (q.size() == SIZE)
	{
		cout << "Time is out!\n";
		q.pop();
	}
	q.push(value);
}

void removeClient(queue<int>& q) {
	cout << "Client has been served!\n";
	q.pop();
}

void printClients(queue<int> q) {
	while (!q.empty()) {
		cout << q.front() << " ";
		q.pop();
	}
}

int main()
{
	queue<int> client;
	client.push(1);
	client.push(2);

	printClients(client);
	cout << endl;

	addClient(client, 3);
	printClients(client);

	cout << endl;

	removeClient(client);
	printClients(client);

	cout << endl;

	addClient(client, 4);
	addClient(client, 5);
	addClient(client, 6);
	addClient(client, 7);


	printClients(client);	

	return 0;
}