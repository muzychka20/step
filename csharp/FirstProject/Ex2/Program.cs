/*
    Задача№2 Напишите программу, которая проверяет, является ли введённое пользователем число простым. 
    Простое число делится только на 1 и на само себя.
*/

Console.Write("Prime number or not = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(isPrime(n) ? "Yes" : "No");
static bool isPrime(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            count++;
        }
    }
    return count == 2;
}
