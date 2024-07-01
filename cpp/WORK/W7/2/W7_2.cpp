// Задание 2: Класс Book и его наследники
// Задача : Создайте класс Book, который содержит атрибуты названия, автора и цены.
// Реализуйте производный класс EBook, который наследуется от Book и добавляет специфический атрибут для формата файла книги
// (например, PDF или ePub) и метод для отображения полной информации об электронной книге.

#include <iostream>
#include "EBook.h"

int main()
{
	EBook ebook;
	ebook.title = "Inferno";
	ebook.author = "Dan Brown";
	ebook.price = 100;
	ebook.format = "pdf";

	ebook.showEBookInfo();

	return 0;
}