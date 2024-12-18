var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var products = new List<Product>
{
    new Product(1, "Laptop", 1500.00m),
    new Product(2, "Smartphone", 800.00m),
    new Product(3, "Headphones", 200.00m),
};

var productsGroup = app.MapGroup("/products");

productsGroup.Map("/all", () => Results.Json(products));

productsGroup.Map("/details/{id:int}", (int id) =>
{
    var product = products.FirstOrDefault(p => p.Id == id);
    return product is not null
        ? Results.Json(product)
        : Results.NotFound("Product not found");
});

productsGroup.Map("/add/{name}/{price:decimal}", (string name, decimal price) =>
{
    var newProduct = new Product(products.Count + 1, name, price);
    products.Add(newProduct);
    return Results.Ok("Product added");
});

app.Run();

public record Product(int Id, string Name, decimal Price);