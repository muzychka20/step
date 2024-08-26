/*
    Напишите программу, которая выводит таблицу умножения для чисел от 1 до 10. 
    Пользователь может указать, до какого числа должна строиться таблица умножения 
    (например, до 5 или до 10).
*/

Console.Write("N = ");
int limit = int.Parse(Console.ReadLine());

for (int i = 1; i <= limit; i++)
{
    for (int j = 1; j <= limit; j++)
    {
        Console.Write($"{i} * {j} = {i * j}\t");
    }
    Console.WriteLine();
}