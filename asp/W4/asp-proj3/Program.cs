var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.UseWhen(
    context => context.Request.Path == "/time", // если путь запроса "/time"
    appBuilder =>
    {
        // логгируем данные - выводим на консоль приложения
        appBuilder.Use(async (context, next) =>
        {
            var time = DateTime.Now.ToShortTimeString();
            Console.WriteLine($"Time: {time}");
            await next();   // вызываем следующий middleware
        });

        // отправляем ответ
        appBuilder.Run(async context =>
        {
            var time = DateTime.Now.ToShortTimeString();
            await context.Response.WriteAsync($"Time: {time}");
        });
    });


app.UseWhen(
    context => context.Request.Path == "/index",
    appBuilder =>
    {
        // логгируем данные - выводим на консоль приложения
        appBuilder.Use(async (context, next) =>
        {
            Console.WriteLine("index");
            await next();   // вызываем следующий middleware
        });

        // отправляем ответ
        appBuilder.Run(async context =>
        {
            await context.Response.WriteAsync("Index");
        });
    }
);

app.UseWhen(
    context => context.Request.Path == "/data",
    appBuilder =>
    {
        // логгируем данные - выводим на консоль приложения
        appBuilder.Use(async (context, next) =>
        {
            Console.WriteLine("data");
            await next();   // вызываем следующий middleware
        });

        // отправляем ответ
        appBuilder.Run(async context =>
        {
            await context.Response.WriteAsync("data");
        });
    }
);

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello ASP");
});

app.Run();