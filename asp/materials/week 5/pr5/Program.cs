var builder = WebApplication.CreateBuilder();
var app = builder.Build();
 
app.UseWhen(
    context => context.Request.Path == "/time", // если путь запроса "/time"
    appBuilder =>
    {
        var time = DateTime.Now.ToShortTimeString();
        // логгируем данные - выводим на консоль приложения
        appBuilder.Use(async (context, next) =>
        {
            Console.WriteLine($"Time: {time}");
            await next();   // вызываем следующий middleware
        });
 
        // отправляем ответ
        appBuilder.Run(async context =>
        {
            await context.Response.WriteAsync($"Time: {time}");
        });
});
 
app.Run(async context =>
{
    await context.Response.WriteAsync("Hello ASP");
});
 
app.Run();