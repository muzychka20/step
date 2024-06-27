// написать функции расчета площади квадрата, прямоугольника, треугольника
// написать юнит тесты

function squareArea(a) {
    return a * a
}

function rectangeArea(a, b) {
    return a * b
}

function triangleArea(a, b, c) {
    let p = (a + b + c) / 2
    return Math.sqrt(p * (p - a) * (p - b) * (p - c))
}