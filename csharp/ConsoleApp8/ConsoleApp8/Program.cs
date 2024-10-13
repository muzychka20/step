/*
Задача:
Дан список целых чисел. Используя LINQ, выполните следующие операции:
Найдите все четные числа.
Найдите максимальное и минимальное число.
Найдите сумму всех чисел.
Упорядочьте список по возрастанию.
*/

using System;
using System.Linq;

int[] intArr = [1, 67, 4, 5, 32, 84, 100, 28];

Console.WriteLine("Origninal: ");
foreach (var i in intArr)
{
    Console.Write(i + " ");
}

var query1 = from i in intArr
             where i % 2 == 0
             select i;
Console.WriteLine("\nEven: ");
foreach (var i in query1)
{
    Console.Write(i + " ");
}

var query2 = from i in intArr
             orderby i ascending
             select i;
Console.WriteLine("\nOrder by ascending: ");
foreach (var i in query2)
{
    Console.Write(i + " ");
}


int min = intArr.Aggregate(intArr[0], (min, next) => 
                           min = next < min ? next : min);
Console.WriteLine($"\nMin: {min}");

int max = intArr.Aggregate(intArr[0], (max, next) =>
                           max = next > max ? next : max);
Console.WriteLine($"Max: {max}");

int sum = intArr.Aggregate(0, (total, next) => total + next);
Console.WriteLine($"Sum: {sum}");