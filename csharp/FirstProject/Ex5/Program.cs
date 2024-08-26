/*
    Напишите программу, которая запрашивает у пользователя массив из 10 чисел и значение S. 
    Программа должна найти и вывести количество пар элементов массива, сумма которых равна S.
*/

using System.Collections;

int max = 10, S;
var arr = new List<int>();
var resultPairs = new List<Tuple<int, int>>();

for (int i = 0; i < max; i++)
{
    Console.Write($"arr[{i}] = ");
    arr.Add(int.Parse(Console.ReadLine()));
}

Console.Write($"S = ");
S = int.Parse(Console.ReadLine());

int mid = arr.Count / 2;
for (int i = 0; i < mid; i++)
{
    for (int j = 0; j < arr.Count; j++)
    {
        if (i != j && arr[i] + arr[j] == S)
        {
            resultPairs.Add(new Tuple<int, int>(arr[i], arr[j]));
        }
    }
}

PrintValues(resultPairs);

static void PrintValues(IEnumerable myList)
{
    foreach (Object obj in myList)
        Console.Write($"{obj} ");
    Console.WriteLine();
}