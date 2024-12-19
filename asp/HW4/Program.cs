var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Задание: КалькуляторСоздайте маршрут /calculate/{operation}/{x}/{y}, где:
// operation — это математическая операция (add, subtract, multiply, divide),
// x и y — числа.Приложение должно выполнять соответствующую операцию и возвращать результат.
// Пример:
// /calculate/add/10/5 → 15    /calculate/multiply/4/2 → 8

var calculateGroup = app.MapGroup("/calculate");

calculateGroup.Map("/{operation}/{x}/{y}", (HttpContext context) =>
{
    var operation = context.Request.RouteValues["operation"]?.ToString();    
    if (!int.TryParse(context.Request.RouteValues["x"]?.ToString(), out var x) ||
        !int.TryParse(context.Request.RouteValues["y"]?.ToString(), out var y))
    {
        return Results.Json("Input integer!");
    }
    switch (operation)
    {
        case "add":
            {
                return Results.Json(new Operation { name = "add", x = x, y = y, result = x + y });
            }
        case "subtract":
            {
                return Results.Json(new Operation { name = "substract", x = x, y = y, result = x - y });
            }
        case "multiply":
            {
                return Results.Json(new Operation { name = "multiply", x = x, y = y, result = x * y });
            }
        case "divide":
            {
                if (y == 0)
                {
                    return Results.Json("Zero division!");
                }
                return Results.Json(new Operation { name = "divide", x = x, y = y, result = x / y });
            }
    }
    return Results.Json("Path not valid!");
});

app.Run();

public record Operation
{
    public string name { get; set; }
    public int x { get; set; }
    public int y { get; set; }
    public int result { get; set; }
}