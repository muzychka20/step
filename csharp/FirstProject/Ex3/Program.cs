/*Напишите программу, которая запрашивает у пользователя число N
 * и выводит первые N чисел последовательности Фибоначчи.*/

Console.Write("Fibonacci N = ");
int fib = int.Parse(Console.ReadLine());

for (int i = 0; i < fib; i++)
{
    Console.Write($"{Fibonacci(i)} ");
}
Console.WriteLine();

static int Fibonacci(int number)
{
    if (number == 0 || number == 1)
    {
        return number;
    }
    return Fibonacci(number - 1) + Fibonacci(number - 2);
}