/*
    Напишите программу, которая запрашивает у пользователя массив из 10 чисел 
    и удаляет все повторяющиеся элементы, оставляя только уникальные. 
    Программа должна вывести массив после удаления повторов
*/

int MAX = 10, currentIndex = 0;
int[] arr = new int[MAX];
int[] res = new int[MAX];


fillArray(arr);

for (int i = 0; i < arr.Length; i++)
{
    bool copy = false;
    for (int j = 0; j < arr.Length; j++)
    {
        if (i != j && arr[i] == arr[j])
        {
            copy = true;
        }
    }
    if (!copy)
    {
        res[currentIndex++] = arr[i];
    }
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