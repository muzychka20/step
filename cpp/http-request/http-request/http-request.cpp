#include <iostream>
#include <curl/curl.h>
#include "HTTPrequest.h"

int main()
{
    HTTPrequest* request = new HTTPrequest("https://reqres.in/api/users/2");
    request->GET();
    User* user = request->parse();
    user->saveInFile();
    return 0;
}