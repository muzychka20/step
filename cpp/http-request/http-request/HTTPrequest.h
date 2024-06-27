#pragma once
#include <iostream>
#include <curl/curl.h>
#include <fstream>
#include <nlohmann/json.hpp>
#include "User.h"

class HTTPrequest
{
private:	
	CURL* curl;                // Указатель на объект CURL
	CURLcode res;              // Переменная для хранения кода результата
	std::string readBuffer;    // Строка для сохранения полученного ответа
	std::string url;
	
	// Функция обратного вызова для записи полученных данных
	static size_t WriteCallback(void* contents, size_t size, size_t nmemb, std::string* userp);

public:
	HTTPrequest(std::string _url);
	~HTTPrequest();
	void GET();
	User* parse();
};

