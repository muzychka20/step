var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Задание: Создать вложенные маршруты
// Создайте группу маршрутов для обработки запросов о товарах:
// /products/all — возвращает список всех продуктов.
// /products/{id} — возвращает информацию о продукте по его {id}. Если продукт с таким ID не найден, возвращает "Product not found".
// /products/add/{name}/{price} — добавляет новый продукт с именем {name} и ценой {price}. Возвращает сообщение "Product added".

// Список продуктов
var products = new List<Product>();

// Группа маршрутов для обработки запросов о товарах
app.Map("/products/all", async (HttpContext context) => await ShowProducts(context));
app.Map("/products/{name}/{price}", async (HttpContext context, string name, decimal price) => {
    products.Add(new Product(name, price));
    await context.Response.WriteAsync("Added!");
});
app.Map("/products/{id}", async (HttpContext context, int id) => {
    var product = products.Find(p => p.Id == id);
    if (product != null) {
        await context.Response.WriteAsync($"Product: {product.Id} - {product.Name} - {product.Price}");
    } else {
        await context.Response.WriteAsync($"Not found!");
    }
});
    
app.Run();

async Task ShowProducts(HttpContext context) {
    string res = "";
    foreach(var product in products) {
        string detail = $"{product.Name}: {product.Price}\n";
        res += detail;
    }
    await context.Response.WriteAsync(res);
}

public record Product {
    private static int id = 0;

    public int Id { set; get; }
    public string Name { set; get; }
    public decimal Price { set; get; }

    public Product(string name, decimal price) {
        Id = ++id;
        Name = name;
        Price = price;
    }
}
