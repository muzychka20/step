/*
Написать класс Money, предназначенный для хранения денежной суммы (в гривнах и копейках).
Для класса реализовать перегрузку операторов + (сложение денежных сумм),
- (вычитание сумм), / (деление суммы на целое число), * (умножение суммы на целое число),
++ (сумма увеличивается на 1 копейку), -- (сумма уменьшается на 1 копейку), 
<, >, ==, !=.
Класс не может содержать отрицательную сумму. В случае если при исполнении какой-либо операции
получается отрицательная сумма денег, то класс генерирует исключительную ситуацию «Банкрот».
Программа должна с помощью меню продемонстрировать все возможности класса Money.
Обработка исключительных ситуаций производится в программе.
 */

public class BankruptException : Exception
{
    public BankruptException(string message) : base(message) { }
}

public class Money
{
    int uah;
    int kop;

    public Money(int _uah, int _kop)
    {
        if (_kop >= 100)
            throw new ArgumentOutOfRangeException(nameof(kop), "Kopecks must be between 0 and 99.");
        if (_uah < 0 || _kop < 0)
            throw new BankruptException("Bankrupt");

        uah = _uah;
        kop = _kop;
    }

    public override string ToString()
    {
        return $"UAH: {uah}.{kop}";
    }

    public static Money operator +(Money a, Money b)
    {
        int a_kop = a.uah * 100 + a.kop;
        int b_kop = b.uah * 100 + b.kop;
        int sum = a_kop + b_kop;
        return new Money((int)(sum / 100), sum % 100);
    }

    public static Money operator -(Money a, Money b)
    {
        int a_kop = a.uah * 100 + a.kop;
        int b_kop = b.uah * 100 + b.kop;
        int sum = a_kop > b_kop ? a_kop - b_kop : b_kop - a_kop;
        return new Money((int)(sum / 100), sum % 100);
    }

    public static Money operator /(Money a, int b)
    {
        int sum = (a.uah * 100 + a.kop) / b;
        return new Money((int)(sum / 100), sum % 100);
    }

    public static Money operator *(Money a, int b)
    {
        int sum = (a.uah * 100 + a.kop) * b;
        return new Money((int)(sum / 100), sum % 100);
    }

    public static Money operator ++(Money a)
    {
        int sum = a.uah * 100 + a.kop + 1;
        return new Money((int)(sum / 100), sum % 100);
    }
    public static Money operator --(Money a)
    {
        int sum = (a.uah * 100 + a.kop) - 1;
        return new Money((int)(sum / 100), sum % 100);
    }

    public static bool operator <(Money a, Money b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
        return (a.uah * 100 + a.kop) < (b.uah * 100 + b.kop);
    }
    public static bool operator >(Money a, Money b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
        return (a.uah * 100 + a.kop) > (b.uah * 100 + b.kop);
    }
    public static bool operator ==(Money a, Money b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
        return (a.uah * 100 + a.kop) == (b.uah * 100 + b.kop);
    }
    public static bool operator !=(Money a, Money b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
        return (a.uah * 100 + a.kop) != (b.uah * 100 + b.kop);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Money money1 = null;
        Money money2 = null;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mooney 1 " + money1?.ToString());
            Console.WriteLine("Mooney 2 " + money2?.ToString());
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Enter the first amount");
            Console.WriteLine("2. Enter the second amount");
            Console.WriteLine("3. Add amounts");
            Console.WriteLine("4. Subtract amounts");
            Console.WriteLine("5_1. Multiply money1 amount by a number");
            Console.WriteLine("5_2. Multiply money2 amount by a number");
            Console.WriteLine("6_1. Divide money1 amount  by a number");
            Console.WriteLine("6_2. Divide money2 amount by a number");
            Console.WriteLine("7_1. Increase the first amount by 1 kopeck");
            Console.WriteLine("7_2. Increase the second amount by 1 kopeck");
            Console.WriteLine("8_1. Decrease the first amount by 1 kopeck");
            Console.WriteLine("8_2. Decrease the second amount by 1 kopeck");
            Console.WriteLine("9. Compare amounts");
            Console.WriteLine("0. Exit\n");

            Console.Write("Select an action: ");
            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        {
                            Console.Write("Enter hryvnias: ");
                            int uah1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter kopecks: ");
                            int kop1 = int.Parse(Console.ReadLine());
                            money1 = new Money(uah1, kop1);
                            Console.WriteLine("First amount: " + money1);
                            break;
                        }

                    case "2":
                        {
                            Console.Write("Enter hryvnias: ");
                            int uah2 = int.Parse(Console.ReadLine());
                            Console.Write("Enter kopecks: ");
                            int kop2 = int.Parse(Console.ReadLine());
                            money2 = new Money(uah2, kop2);
                            Console.WriteLine("Second amount: " + money2);
                            break;
                        }

                    case "3":
                        {
                            if (money1 == null || money2 == null)
                                throw new InvalidOperationException("Please enter both amounts first.");
                            Money sum = money1 + money2;
                            Console.WriteLine("Sum: " + sum.ToString());
                            break;
                        }

                    case "4":
                        {
                            if (money1 == null || money2 == null)
                                throw new InvalidOperationException("Please enter both amounts first.");
                            Money difference = money1 - money2;
                            Console.WriteLine("Difference: " + difference.ToString());
                            break;
                        }

                    case "5_1":
                        {
                            if (money1 == null)
                                throw new InvalidOperationException("Please enter the first amount first.");
                            Console.Write("Enter a number: ");
                            int multiplier = int.Parse(Console.ReadLine());
                            money1 *= multiplier;
                            Console.WriteLine("Result of multiplication: " + money1.ToString());
                            break;
                        }

                    case "5_2":
                        {
                            if (money2 == null)
                                throw new InvalidOperationException("Please enter the second amount first.");
                            Console.Write("Enter a number: ");
                            int multiplier = int.Parse(Console.ReadLine());
                            money2 *= multiplier;
                            Console.WriteLine("Result of multiplication: " + money2.ToString());
                            break;
                        }

                    case "6_1":
                        {
                            if (money1 == null)
                                throw new InvalidOperationException("Please enter the first amount first.");
                            Console.Write("Enter a divisor: ");
                            int divider = int.Parse(Console.ReadLine());
                            money1 /= divider;
                            Console.WriteLine("Result of division: " + money1.ToString());
                            break;
                        }

                    case "6_2":
                        {
                            if (money1 == null)
                                throw new InvalidOperationException("Please enter the second amount first.");
                            Console.Write("Enter a divisor: ");
                            int divider = int.Parse(Console.ReadLine());
                            money2 /= divider;
                            Console.WriteLine("Result of division: " + money2.ToString());
                            break;
                        }

                    case "7_1":
                        {
                            if (money1 == null)
                                throw new InvalidOperationException("Please enter the first amount first.");
                            money1++;
                            Console.WriteLine("First amount after increasing by 1 kopeck: " + money1.ToString());
                            break;
                        }

                    case "7_2":
                        {
                            if (money2 == null)
                                throw new InvalidOperationException("Please enter the second amount first.");
                            money2++;
                            Console.WriteLine("Second amount after increasing by 1 kopeck: " + money2.ToString());
                            break;
                        }

                    case "8_1":
                        {
                            if (money1 == null)
                                throw new InvalidOperationException("Please enter the first amount first.");
                            money1--;
                            Console.WriteLine("First amount after decreasing by 1 kopeck: " + money1.ToString());
                            break;
                        }

                    case "8_2":
                        {
                            if (money2 == null)
                                throw new InvalidOperationException("Please enter the second amount first.");
                            money2--;
                            Console.WriteLine("Second amount after decreasing by 1 kopeck: " + money2.ToString());
                            break;
                        }

                    case "9":
                        {
                            if (money1 == null || money2 == null)
                                throw new InvalidOperationException("Please enter both amounts first.");                            
                            Console.WriteLine($"Money 1 < Money 2: {money1 < money2}");
                            Console.WriteLine($"Money 1 > Money 2: {money1 > money2}");
                            Console.WriteLine($"Money 1 == Money 2: {money1 == money2}");
                            Console.WriteLine($"Money 1 != Money 2: {money1 != money2}");
                            break;
                        }
                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
