/*
Задача: Дан список товаров с их названиями и ценами. Используя LINQ:
Найдите товары дороже 50.
Найдите среднюю цену товаров.
Найдите товар с наибольшей и наименьшей ценой.
*/

using System;
using System.Numerics;
using System.Runtime.InteropServices;

List<Product> products = new List<Product>()
{
    new Product("Desk", 20),
    new Product("Mouse", 60),
    new Product("Laptop", 100),
    new Product("Headphones", 20)    
};

var query = from product in products
            where product.Price > 50
            select product;
Console.WriteLine("Products where price > 50: ");
foreach (var product in query)
{
    Console.WriteLine(product.ToString());
}



double? average = products.Average(s => s.Price);
Console.WriteLine($"\nAvg price: {average}");



var minProductPrice = products.Min(s => s.Price);
var queryMin = from product in products
               where product.Price == minProductPrice
               select product;
Console.WriteLine($"\nMin Product Price: {minProductPrice}");
foreach (var product in queryMin)
{
    Console.WriteLine(product.ToString());
}



var maxProductPrice =products.Max(s => s.Price);
var queryMax = from product in products
               where product.Price == maxProductPrice
               select product;
Console.WriteLine($"\nMax Product Price: {maxProductPrice}");
foreach (var product in queryMax)
{
    Console.WriteLine(product.ToString());
}



class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Name: {Name}; Price: {Price}";
    }
}