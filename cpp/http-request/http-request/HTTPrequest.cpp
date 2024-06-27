#include "HTTPrequest.h"


HTTPrequest::HTTPrequest(std::string _url) : url(_url)
{
    curl_global_init(CURL_GLOBAL_DEFAULT);  // Глобальная инициализация libcurl
    curl = curl_easy_init();                // Инициализация объекта CURL
    if (!curl) {
        throw std::runtime_error("Failed to initialize CURL");
    }
}

HTTPrequest::~HTTPrequest()
{    
    curl_easy_cleanup(curl); // Очистка ресурсов
    curl_global_cleanup();   // Глобальная очистка libcurl
}

void HTTPrequest::GET()
{
    curl_easy_setopt(curl, CURLOPT_URL, url.c_str());              // URL для запроса
    curl_easy_setopt(curl, CURLOPT_WRITEFUNCTION, WriteCallback);  // Установка функции обратного вызова для записи данных
    curl_easy_setopt(curl, CURLOPT_WRITEDATA, &readBuffer);        // Указатель, который будет передан функции обратного вызова

    // Выполнение запроса
    res = curl_easy_perform(curl);
    if (res != CURLE_OK) {  // Проверка на ошибки
        std::cerr << "curl_easy_perform() failed: " << curl_easy_strerror(res) << '\n';
    }
    else {
        std::cout << "Received Data: " << readBuffer << '\n';  // Вывод полученных данных
    }
}

User* HTTPrequest::parse()
{
    User* user = new User();
    nlohmann::json jsonResponse = nlohmann::json::parse(readBuffer);    
    user->id = jsonResponse["data"]["id"].get<int>();
    user->email = jsonResponse["data"]["email"].get<std::string>();
    user->first_name = jsonResponse["data"]["first_name"].get<std::string>();
    user->last_name = jsonResponse["data"]["last_name"].get<std::string>();
    user->avatar = jsonResponse["data"]["avatar"].get<std::string>();
    return user;
}

// Функция обратного вызова для записи полученных данных
size_t HTTPrequest::WriteCallback(void* contents, size_t size, size_t nmemb, std::string* userp) {
    userp->append((char*)contents, size * nmemb);
    return size * nmemb;
}