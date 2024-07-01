// Вывод приветствия
function sayHello() {
    console.log("Привет!");
}
sayHello();

// Прощание
const sayGoodbye = function() {
    console.log("Пока!");
};
sayGoodbye();

// Сумма чисел
const addNumbers = (a, b) => a + b;
console.log("Сумма чисел 3 и 7: ", addNumbers(3, 7));

// Пример использования переменных
let age = 25;
const name = "Alice";
var oldVar = "deprecated";

console.log("Имя: " + name + ", возраст: " + age);

// Области видимости переменных
if (true) {
    let blockScoped = "Доступна только внутри блока";
    console.log(blockScoped);
}

function testScope() {
    var testVar = "Доступна в любом месте функции";
    if (true) {
        var testVar = "Переопределена в блоке";
    }
    console.log(testVar); // Выведет "Переопределена в блоке"
}
testScope();

// Функции с параметрами и возвращаемыми значениями
function calculateSum(a, b) {
    return a + b;
}
console.log("Вычисленная сумма 5 и 3: ", calculateSum(5, 3));

// Условная логика в функции
function canDrive(age) {
    if (age >= 18) {
        return "Можно водить машину";
    } else {
        return "Слишком молод, чтобы водить машину";
    }
}
console.log("Статус вождения для возраста 21: ", canDrive(21));
