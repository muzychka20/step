/*
    Напишите программу, которая запрашивает у пользователя два массива целых чисел
    (размер каждого массива - 10 элементов). Программа должна объединить эти два массива в один,
    отсортировать его и вывести 
*/

using System.Collections;

int MAX = 4;
int[] array1 = new int[MAX];
int[] array2 = new int[MAX];
// List<int> res = new List<int>();
ArrayList res = new ArrayList();

fillArray(array1);
fillArray(array2);

printArray(array1);
printArray(array2);

for (int i = 0; i < MAX; i++)
{
    res.Add(array1[i]);
    res.Add(array2[i]);
}
 
res.Sort();
PrintValues(res);
// printArray(res.ToArray()); // if res is List<int>

static void printArray(int[] arr)
{
    foreach (int el in arr)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

static void fillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"arr[{i}] = ");
        arr[i] = int.Parse(Console.ReadLine());
    }
}

static void PrintValues(IEnumerable myList)
{
    foreach (Object obj in myList)
        Console.Write($"{obj} ");
    Console.WriteLine();
}
