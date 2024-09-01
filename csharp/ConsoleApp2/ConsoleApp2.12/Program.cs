/*
Задание 5
Создайте класс BankAccount, который будет представлять банковский счет.
Класс должен содержать закрытые поля: accountNumber (номер счета) и balance (баланс).
Реализуйте свойства для доступа к этим полям, при этом баланс должен быть только для чтения.
Добавьте конструктор для инициализации номера счета и начального баланса. Создайте методы Deposit (для пополнения счета)
и Withdraw (для снятия средств с учетом проверки наличия достаточных средств).
*/
using System;

namespace ConsoleApp2._12
{
    class Program
    {
        class BankAccount
        {
            private string accountNumber;
            public string AccountNumber
            {
                get { return accountNumber; }
                set { accountNumber = value; }
            }

            private int balance;
            public int Balance
            {
                get { return balance; }
            }

            public BankAccount(string accountNumber, int balance)
            {
                this.accountNumber = accountNumber;
                this.balance = balance;
            }


            public void Deposit(int amount)
            {
                balance += amount;
            }

            public void Withdraw(int amount)
            {
                if (balance > amount)
                    balance -= amount;
            }
        }
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("1", 1000);
            Console.WriteLine("Balance: " + account.Balance);
            account.Deposit(1000);
            Console.WriteLine("Balance: " + account.Balance);
            account.Withdraw(1000);
            Console.WriteLine("Balance: " + account.Balance);
            account.Withdraw(2000);
            Console.WriteLine("Balance: " + account.Balance);            
        }
    }
}
