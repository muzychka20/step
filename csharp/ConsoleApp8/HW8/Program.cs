/*
Для массива строк реализуйте пользовательскую сортировку.
Сортировка должна работать по количеству символов (по
возрастанию и убыванию). Например, если сортировка
производится по убыванию, нужно вернуть строки с
максимальной длиной в порядке убывания длины.
*/

List<string> strings = new List<string>()
{
    "hello",
    "world",
    "sam",
    "environment"
};

var orderAsc = from i in strings
               orderby i.Length
               select i;

var orderDesc = from i in strings
                orderby i.Length descending
                select i;

void ASC()
{
    foreach (var item in orderAsc)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

void DESC()
{
    foreach (var item in orderDesc)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

while (true)
{
    try
    {
        Console.WriteLine("0. Exit");
        Console.WriteLine("1. Add string");
        Console.WriteLine("2. DESC");
        Console.WriteLine("3. ASC");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose == 0)
            break;
        switch (choose)
        {
            case 1:
                {
                    Console.WriteLine("Enter string: ");
                    strings.Add(Console.ReadLine());
                    break;
                }
            case 2:
                DESC();
                break;
            case 3:
                ASC();
                break;
            default:
                Console.WriteLine("Invalid Input!");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message.ToString());
    }
}
