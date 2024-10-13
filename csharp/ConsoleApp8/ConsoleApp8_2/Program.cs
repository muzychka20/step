/*
Задача: Дан список строк, представляющих имена людей. Используя LINQ:
Найдите все имена, начинающиеся с буквы 'A'.
Найдите имена, содержащие более 5 символов.
Найдите первое имя, которое заканчивается на букву 'n'.
*/

string[] names = {"Sam", "Kate", "Annabet", "John", "Ivan", "Anna"};

var query1 = from name in names
             where name.StartsWith('A')
             select name;

Console.Write("Names start with 'A': ");
foreach(var item in query1)
    Console.Write(item + " ");
Console.WriteLine();



var query2 = from name in names
             where name.Length > 5
             select name;

Console.Write("Names where chars > 5: ");
foreach (var item in query2)
    Console.Write(item + " ");
Console.WriteLine();



var query3 = (from name in names
             where name.EndsWith('n')
             select name).First();

Console.Write($"First name ends with 'n': {query3}");