//Користувач вводить з клавіатури час у секундах, що минув з початку дня.Вивести на екран поточний
//час у годинах, хвилинах і секундах.Порахувати, скільки
//годин, хвилин і секунд залишилося до півночі.

#include <iostream>

int main() {
    int secondsInput;

    // Запитуємо в користувача кількість секунд
    std::cout << "Введіть кількість секунд, що минуло з початку дня: ";
    std::cin >> secondsInput;

    // Обчислення годин, хвилин та секунд поточного часу
    int hours = secondsInput / 3600;
    int minutes = (secondsInput % 3600) / 60;
    int seconds = secondsInput % 60;

    // Виведення поточного часу
    std::cout << "Поточний час: " << hours << " годин, " << minutes << " хвилин, " << seconds << " секунд." << std::endl;

    // Обчислення залишку часу до півночі
    int remainingSeconds = 86400 - secondsInput; // 86400 - кількість секунд у добі

    // Обчислення годин, хвилин та секунд до півночі
    int remainingHours = remainingSeconds / 3600;
    int remainingMinutes = (remainingSeconds % 3600) / 60;
    int remainingSecondsFinal = remainingSeconds % 60;

    // Виведення часу до півночі
    std::cout << "Час до півночі: " << remainingHours << " годин, " << remainingMinutes << " хвилин, " << remainingSecondsFinal << " секунд." << std::endl;

    return 0;
}

