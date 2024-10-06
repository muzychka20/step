/*
1.Создать примитивный англо-украинский и украино-английский словарь,
содержащий пары слов — названий стран на украинском и английском языках. 
Пользователь должен иметь возможность выбирать направление перевода и запрашивать перевод.
*/

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{

    class Program
    {
        static Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            { "Ukraine", "Україна" },
            { "United States", "Сполучені Штати" },
            { "Germany", "Німеччина" },
            { "France", "Франція" },
            { "Spain", "Іспанія" },
            { "Italy", "Італія" },
            { "Canada", "Канада" },
            { "Australia", "Австралія" }
        };

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Eng to Ukr");
                Console.WriteLine("2. Ukr to Eng");
                Console.WriteLine("3. Exit");

                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 3)
                    break;

                Console.WriteLine("Country: ");
                string word = Console.ReadLine();

                switch (choose)
                {
                    case 1:
                        {
                            if (dictionary.ContainsKey(word))
                            {
                                Console.WriteLine($"Translated: {dictionary[word]}");
                            }
                            else
                            {
                                Console.WriteLine("Not found!");
                            }
                            break;
                        }
                    case 2:
                        {
                            var translated = dictionary.FirstOrDefault(x => x.Value == word).Key;
                            if (translated != null)
                            {
                                Console.WriteLine($"Translated: {translated}");
                            }
                            else
                            {
                                Console.WriteLine("Not found!");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice.");
                            break;
                        }
                }

                Console.ReadKey();
            }
        }
    }
}