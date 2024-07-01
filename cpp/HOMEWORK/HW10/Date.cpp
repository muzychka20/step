#include "Date.hpp"

// Задание 1: Проверка формата даты
// Задача : Напишите функцию, которая принимает строку, представляющую дату в формате "дд.мм.гггг".Функция должна проверять, соответствует ли строка этому формату.Если строка не соответствует, функция должна генерировать исключение invalid_argument.Также убедитесь, что месяц и день находятся в допустимых пределах.

Date::Date(string _date) : date(_date), day(0), month(0), year(0) {};

int Date::getDay() {
    return day;
}

int Date::getMonth() {
    return month;
}

int Date::getYear() {
    return year;
}

bool Date::validDateForm() {
    try {
        istringstream iss(date);
        vector<int> dateParts;
        string el;
        while (getline(iss, el, '.')) {
            if (!el.empty())
                dateParts.push_back(stoi(el));
        }
        if (dateParts.size() != 3) {
            throw invalid_argument("Enter the valid date! (dd.mm.yyyy)");
        }
        day = dateParts[0];
        month = dateParts[1];
        year = dateParts[2];
        if (day < 1 || day > 31 || month < 1 || month > 12) {
            throw invalid_argument("Invalid day or month value!");
        }
        return true;
    } catch (const invalid_argument& error) {
        cerr << error.what() << endl;
        return false;
    }
}

bool Date::isLeapYear() {
    return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
}

bool Date::validDate() {
    if (!validDateForm()) return false;
    try {
        if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30) {
            throw invalid_argument("Invalid date for the given month!");
        }
        if (month == 2) {
            if (isLeapYear() && day > 29) {
                throw invalid_argument("Invalid date for February in a leap year!");
            }
            if (!isLeapYear() && day > 28) {
                throw invalid_argument("Invalid date for February in a non-leap year!");
            }
        }
        return true;
    } catch (const invalid_argument& error) {
        cerr << error.what() << endl;
        return false;
    }
}
