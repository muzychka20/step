/*  
    Напишите программу, которая находит и выводит наибольшую последовательность возрастающих элементов 
    в массиве. Пользователь вводит массив из 10 чисел.
*/

int MAX = 10;
int[] arr = new int[MAX];

fillArray(arr);

int currentElementsCount = 1, elementsCount = 1, currentStartIndex = 0, startIndex = 0;
for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i + 1] > arr[i])
    {
        currentElementsCount++;
    }
    else
    {
        if (currentElementsCount > elementsCount)
        {
            elementsCount = currentElementsCount;
            startIndex = currentStartIndex;
        }
        currentElementsCount = 1;
        currentStartIndex = i + 1;
    }
}

if (currentElementsCount > elementsCount)
{
    elementsCount = currentElementsCount;
    startIndex = currentStartIndex;
}

for (int i = startIndex; i < startIndex + elementsCount; i++)
{
    Console.Write($"{arr[i]}");
}

static void fillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"arr[{i}] = ");
        arr[i] = int.Parse(Console.ReadLine());
    }
}
