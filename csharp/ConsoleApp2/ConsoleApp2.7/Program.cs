/*
Задание 4
Создайте перечисление AccessLevel, представляющее различные уровни доступа в системе (User, Moderator, Admin). 
Напишите функцию HasAdminAccess, которая принимает значение этого перечисления и возвращает true, 
если уровень доступа равен Admin, и false в противном случае.
*/

using System;

namespace ConsoleApp2._7
{
    class Program
    {
        [Flags]
        enum AccessLevel
        {
            User,
            Moderator,
            Admin
        }

        static bool HasAdminAccess(int levelNumber)
        {
            AccessLevel accesLevel = (AccessLevel)levelNumber;
            return accesLevel.HasFlag(AccessLevel.Admin);
        }

        static void Main(string[] args)
        {
            AccessLevel level = AccessLevel.Moderator | AccessLevel.Admin;
            if (HasAdminAccess((int)level)) {
                Console.WriteLine("You are admin!");
            }
            else
            {
                Console.WriteLine("Denied!");
            }
        }
    }
}
