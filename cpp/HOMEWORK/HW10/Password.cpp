#include "Password.hpp"


//Задание 3 : Валидация пользовательского ввода
//Задача : Разработайте функцию, которая принимает введенный пользователем парольпроверяет его на соответствие набору правил(минимум 8 символов, должен содержать заглавные и строчные буквы, а также цифры).Если пароль не соответствует хотя бы одному из критериев, генерируйте исключение invalid_argument с указанием причины.

Password::Password(string _password) : password(_password) {};

bool Password::hasUppercase() {
    for (char c : password) {
        if (isupper(c)) {
            return true;
        }
    }
    return false;
}

bool Password::hasLowercase() {
    for (char c : password) {
        if (islower(c)) {
            return true;
        }
    }
    return false;
}

bool Password::hasDigits() {
    for (char c : password) {
        if (isdigit(c)) {
            return true;
        }
    }
    return false;
}

bool Password::hasLength() {
    return password.size() >= 8;
}

bool Password::hasFormat() {
    for (char c : password) {
        if (!isdigit(c) && !isupper(c) && !islower(c)) {
            return false;
        }
    }
    return true;
}

bool Password::validPassword() {
    try {
        if (!hasFormat()) {
            throw invalid_argument("Possible only letters (uppercase & lowercase) and digits");
        }
        if (!hasLength()) {
            throw invalid_argument("Invalid length of password! (>=8)");
        }
        if (!hasUppercase()) {
            throw invalid_argument("Need uppercase letters!");
        }
        if (!hasLowercase()) {
            throw invalid_argument("Need lowercase letters!");
        }
        if (!hasDigits()) {
            throw invalid_argument("Need digits!");
        }
        return true;
    } catch (invalid_argument& error) {
        cerr << error.what() << endl;
        return false;
    }
}
