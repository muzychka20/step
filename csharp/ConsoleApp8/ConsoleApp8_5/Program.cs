/*
Задание 1:
Для массива целых выполните следующие задания, используя
агрегатные операции из LINQ:
 Посчитайте произведение элементов массива
 Посчитайте количество элементов массива
 Посчитайте количество элементов массива, кратных 9
 Посчитайте количество элементов массива, кратных 7 и
больших, чем 945
 Посчитайте сумму элементов массива
 Посчитайте сумму чётных элементов массива
 Найдите минимум в массиве
 Найдите максимум в массиве
 Найдите среднее значение в массиве
Задание 2:
Добавьте к первому заданию новую функциональность:
 Отобразите три первых максимальных элемента
 Отобразите три первых минимальных элемента
Для реализации задания используйте семейство методов Skip,Take.
Задание 3:
Добавьте к первому заданию новую функциональность:
 Отобразите статистику вхождения каждого числа в массив.
Например: 7 – 3 раза, 5 – 2 раза, 8 – 4 раза и т. д.
 Отобразите статистику вхождения чётных чисел в массив.
Например: 2 – 4 раза, 6 – 2 раза и т. д.
 Отобразите статистику вхождения чётных и нечётных чисел
в массив. Например: чётные – 3 раза, нечётные – 2 раза
*/

using System;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

List<int> arrInt = new List<int>();

Random rnd = new Random();
for (int i = 0; i < 500; i++)
{
    arrInt.Add(rnd.Next(1, 1000));
}



BigInteger mult = arrInt.Aggregate(BigInteger.One, (total, next) => total * next);
Console.WriteLine($"Mult: {mult}\n");



int count = arrInt.Aggregate(0, (total, _) => total += 1);
Console.WriteLine($"Count: {count}\n");



var query1 = from i in arrInt
             where i % 9 == 0
             select i;
Console.WriteLine($"El % 9 == 0:");
foreach (var item in query1)
{
    Console.Write(item + " ");
}



var query2 = from i in arrInt
             where i % 7 == 0 && i > 945
             select i;
Console.WriteLine($"\n\nEl % 7 == 0 && El > 945:");
foreach (var item in query2)
{
    Console.Write(item + " ");
}



int sum = arrInt.Aggregate(0, (total, next) => total + next);
Console.WriteLine($"\n\nSum: {sum}");



int sumEven = arrInt.Aggregate(0, (total, next) => next % 2 == 0 ? total + next : 0);
Console.WriteLine($"\nSum Even: {sum}");



int min = arrInt.Aggregate(arrInt[0], (min, next) => min = next < min ? next : min);
Console.WriteLine($"\nMin: {min}");

int max = arrInt.Aggregate(arrInt[0], (max, next) => max = next > max ? next : max);
Console.WriteLine($"\nMax: {max}");



double? average = arrInt.Average();
Console.WriteLine($"\nAvg: {average}");



Console.WriteLine($"\nFrequency:");
var query3 = from i in arrInt
             group i by i into g
             select new { Number = g.Key, Count = g.Count() };
foreach (var item in query3)
{
    Console.WriteLine($"{item.Number}: {item.Count}");
}



Console.WriteLine($"\nEven Frequency:");
var query4 = from i in arrInt
             where i % 2 == 0
             group i by i into g
             select new { Number = g.Key, Count = g.Count() };
foreach (var item in query4)
{
    Console.WriteLine($"{item.Number}: {item.Count}");
}



int evenFrequency = arrInt.Aggregate(0, (cur, next) => cur += next % 2 == 0 ? 1 : 0);
int oddFrequency = arrInt.Aggregate(0, (cur, next) => cur += next % 2 != 0 ? 1 : 0);
Console.WriteLine($"\nEven & Odd Frequency:\nEven: {evenFrequency}; Odd: {oddFrequency}");



Console.WriteLine("\nMin first 3: ");
var minElements = arrInt.OrderBy(x => x).Take(3);
foreach (var item in minElements)
{
    Console.Write($"{item} ");
}



Console.WriteLine("\n\nMax first 3: ");
var maxElements = arrInt.OrderByDescending(x => x).Take(3);
foreach (var item in maxElements)
{
    Console.Write($"{item} ");
}