// Функция для демонстрации условного оператора, тернарного оператора и switch
function checkNumber() {
    var number = parseFloat(prompt("Введите число:"));
    if (isNaN(number)) {
        alert("Это не число!");
        return;
    }

    // Условный оператор
    if (number % 2 === 0) {
        alert(number + " - четное число.");
    } else {
        alert(number + " - нечетное число.");
    }

    // Тернарный оператор
    var isPositive = number > 0 ? "положительное" : "отрицательное";
    alert(number + " - это " + isPositive + " число.");

    // Switch
    switch (Math.sign(number)) {
        case 1:
            alert("Число положительное.");
            break;
        case -1:
            alert("Число отрицательное.");
            break;
        case 0:
            alert("Число равно нулю.");
            break;
        default:
            alert("Что-то не так с числом.");
    }
}

// Функции для демонстрации циклов
function showForLoop() {
    var result = "Цикл for от 1 до 5: ";
    for (let i = 1; i <= 5; i++) {
        result += i + " ";
    }
    alert(result.trim());
}

function showWhileLoop() {
    var number = 5;
    var result = "Цикл while от 5 до 1: ";
    while (number > 0) {
        result += number + " ";
        number--;
    }
    alert(result.trim());
}

function showDoWhileLoop() {
    var number = 1;
    var result = "Цикл do...while от 1 до 5: ";
    do {
        result += number + " ";
        number++;
    } while (number <= 5);
    alert(result.trim());
}

// Запуск функций
checkNumber();
showForLoop();
showWhileLoop();
showDoWhileLoop();
