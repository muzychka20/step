// W3.cpp : This file contains the 'main' function. Program execution begins and ends there.
#include <iostream>
#include <string>

std::string gimme_the_letters(const std::string& sp)
{
	char start = sp[0], end = sp[2];
	std::string result = "";
	for (int i = int(start); i <= int(end); i++)
	{
		result.push_back(i);
	}
	return result;
}

int main()
{
	std::cout << gimme_the_letters("Q-Z");
	return 0;
}