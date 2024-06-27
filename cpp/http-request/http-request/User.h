#pragma once
#include <string>
#include <fstream>

class User
{
public:
	int id;
	std::string email;
	std::string first_name;
	std::string last_name;
	std::string avatar;

	void saveInFile();
};

