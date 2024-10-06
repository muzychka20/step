/*
Создайте обобщенный класс Repository<T>,
который будет выполнять роль универсального хранилища данных для объектов любого типа.


В этом классе реализуйте следующие методы:
Add(T item) — метод для добавления элемента в хранилище.
Remove(T item) — метод для удаления элемента из хранилища.
GetAll() — метод для получения всех элементов из хранилища в виде списка.
Find(Func<T, bool> predicate) — метод для поиска элемента в хранилище по условию, переданному через лямбда-выражение.
Count — свойство, возвращающее количество элементов в хранилище.


Дополнительные требования:
Реализуйте возможность работы с любым типом данных, например, целыми числами, строками, объектами классов.
Продемонстрируйте работу класса на нескольких примерах:
Используйте Repository<int> для работы с числами.
Используйте Repository<string> для работы со строками.

Создайте пользовательский класс Product (с полями Name и Price) 
и используйте Repository<Product> для работы с объектами этого класса.
*/

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace ConsoleApp7
{

    public class Repository<T>
    {
        private List<T> list;
        public Repository()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public List<T> GetAll()
        {
            return list.ToList();
        }

        public T Find(Func<T, bool> predicate)
        {
            return list.FirstOrDefault(predicate);
        }

        public int Count => list.Count();
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Repository<int> repositoryInt = new Repository<int>();
            repositoryInt.Add(1);
            repositoryInt.Add(2);
            repositoryInt.Add(3);
            Console.WriteLine("Integers:");
            foreach (var item in repositoryInt.GetAll())
            {
                Console.WriteLine(item.ToString());
            }
            repositoryInt.Remove(1);
            Console.WriteLine("Integers Count: " + repositoryInt.Count);
            Console.WriteLine("Integer Find: " + repositoryInt.Find(x => x == 3));


            Console.WriteLine();


            Repository<string> repositoryString = new Repository<string>();
            repositoryString.Add("a");
            repositoryString.Add("b");
            repositoryString.Add("c");
            Console.WriteLine("Strings:");
            foreach (var item in repositoryString.GetAll())
            {
                Console.WriteLine(item.ToString());
            }
            repositoryString.Remove("c");
            Console.WriteLine("Strings Count: " + repositoryString.Count);
            Console.WriteLine("String Find: " + repositoryString.Find(x => x == "a"));


            Console.WriteLine();


            Repository<Product> repositoryProduct = new Repository<Product>();
            var prod = new Product("Table", 2000);
            repositoryProduct.Add(prod);
            repositoryProduct.Add(new Product("Apple", 200));
            repositoryProduct.Add(new Product("Laptop", 5000));            
            Console.WriteLine("Strings:");
            foreach (var item in repositoryProduct.GetAll())
            {
                Console.WriteLine(item.ToString());
            }
            repositoryProduct.Remove(prod);
            Console.WriteLine("Strings Count: " + repositoryProduct.Count);
            Console.WriteLine("String Find: " + repositoryProduct.Find(x => x.Name == "Laptop"));
        }
    }
}