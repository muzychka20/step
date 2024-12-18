var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



// Задание: Создать маршруты с условием
// Создайте приложение, которое обрабатывает маршруты с проверкой параметров:

// /add/{x}/{y} — принимает два числа {x} и {y}, возвращает их сумму. Если хотя бы один параметр не число, возвращает ошибку "Invalid input".
// /is-even/{number} — принимает число {number} и возвращает true, если оно чётное, и false, если нет. Если параметр не является числом, возвращает "Invalid number".

app.Map("/add/{x}/{y}", async (HttpContext context) => {
    if (!int.TryParse(context.Request.RouteValues["x"]?.ToString(), out var x) ||
        !int.TryParse(context.Request.RouteValues["y"]?.ToString(), out var y)) {        
        await context.Response.WriteAsync("Error: Parameters 'x' and 'y' must be valid integers.");
        return;
    }

    await context.Response.WriteAsync($"Res = {x + y}");    
});

app.Map("/is-even/{x}", async (HttpContext context, int x) => {
    await context.Response.WriteAsync($"Res = {(x % 2 == 0 ? "even" : "odd")}");
});

app.Run();
