/*
Задание 6. Реализация пользовательского сравнения сложных объектов
Создайте класс Product с полями Name, Price, Category. 
Реализуйте два способа сортировки продуктов с помощью интерфейса IComparer<Product>:
По цене. По категории, а затем по имени внутри категории.
Напишите программу, которая выводит список продуктов,
отсортированных сначала по цене, затем по категории и имени.
*/


using System.Collections;

public class Category
{
    public string title;
    public Category(string _title)
    {
        title = _title;
    }
}

public class Product
{
    public string name;
    public double price;
    public Category category;

    public Product(string _name, double _price, Category _category)
    {
        name = _name;
        price = _price;
        category= _category;
    }

    public override string ToString()
    {
        return $"{name}: {price} ({category.title})";
    }
}

public class PriceComparer : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x == null || y == null) throw new ArgumentException("Objects cannot be null");
        return x.price.CompareTo(y.price);
    }
}

public class NameComparer : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x == null || y == null) throw new ArgumentException("Objects cannot be null");
        return string.Compare(x.name, y.name);            
    }
}

public class CategoryComparer : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x == null || y == null) throw new ArgumentException("Objects cannot be null");
        return x.category.title.CompareTo(y.category.title);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Category cat1 = new Category("CA");
        Category cat2 = new Category("CD");
        Category cat3 = new Category("CH");

        List<Product> products = new List<Product>
        {
            new Product("A", 12.3, cat1),
            new Product("C", 23.3, cat2),
            new Product("B", 1.3, cat3),
        };

        products.Sort(new PriceComparer());
        Console.WriteLine("Sorted by price:");
        PrintMovies(products);

        products.Sort(new NameComparer());
        Console.WriteLine("Sorted by name:");
        PrintMovies(products);

        products.Sort(new CategoryComparer());
        Console.WriteLine("Sorted by category name:");
        PrintMovies(products);
    }

    public static void PrintMovies(IEnumerable<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine(product.ToString());
        }
    }
}