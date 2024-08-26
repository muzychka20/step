/*
    Напишите программу, которая запрашивает у пользователя число и выводит все его делители.
*/

Console.Write("Number for division = ");
int nd = int.Parse(Console.ReadLine());
for (int i = 1; i <= nd; i++)
{
    if (nd % i == 0)
    {
        Console.Write($"{i} ");
    }
}