/*
    Напишите программу, которая выполняет циклический сдвиг элементов массива на N позиций. 
    Пользователь вводит массив из 10 элементов и значение N, 
    на сколько позиций нужно сдвинуть массив.
*/

int MAX = 10, n;
int[] arr = new int[MAX];
int[] res = new int[MAX];

fillArray(arr);

Console.Write($"n = ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < MAX; i++)
{
    res[i] = arr[(i + n) % MAX];
}

printArray(res);

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