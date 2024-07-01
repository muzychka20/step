// Примеры использования переменных
let age = 30; // Используйте let для переменных, значение которых может изменяться
const nameT = "Alice"; // Используйте const для констант, значение которых не изменится
var oldStyleVar = "Этот способ объявления переменных устарел"; // var имеет функциональную область видимости

console.log("Имя: " + nameT + ", возраст: " + age);

// Условные операторы
if (age >= 18) {
    console.log(nameT + " совершеннолетний(я).");
} else {
    console.log(nameT + " несовершеннолетний(я).");
}

// Тернарный оператор для условного присваивания
const canVote = age >= 18 ? "может голосовать" : "не может голосовать";
console.log(nameT + " " + canVote + ".");

// Циклы
// Цикл for для вывода чисел от 1 до 5
console.log("Цикл for:");
for (let i = 1; i <= 5; i++) {
    console.log(i);
}

// Цикл while для вывода чисел от 5 до 1
console.log("Цикл while:");
let count = 5;
while (count > 0) {
    console.log(count);
    count--;
}

// Цикл do...while для вывода чисел от 1 до 5
console.log("Цикл do...while:");
let start = 1;
do {
    console.log(start);
    start++;
} while (start <= 5);

// Пример цикла с использованием break и continue
console.log("Цикл for с break и continue:");
for (let j = 1; j <= 10; j++) {
    if (j === 4) {
        console.log("Пропускаем число 4");
        continue; // пропускает текущую итерацию цикла
    }
    if (j === 8) {
        console.log("Останавливаем цикл на числе 8");
        break; // прекращает цикл
    }
    console.log(j);
}
