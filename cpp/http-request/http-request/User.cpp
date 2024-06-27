#include "User.h"

void User::saveInFile()
{
	std::ofstream file("user.txt");
	file << "id: " << id << std::endl;
	file << "email: " << email << std::endl;
	file << "first_name: " << first_name << std::endl;
	file << "last_name: " << last_name << std::endl;
	file << "avatar: " << avatar << std::endl;
}
