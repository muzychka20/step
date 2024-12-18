var builder = WebApplication.CreateBuilder();
var app = builder.Build();
 
string date = "";
 
app.Use(async(context, next) =>
{
    date = DateTime.Now.ToShortDateString();
    await next.Invoke();                 // вызываем middleware из app.Run
    Console.WriteLine($"Current date: {date}");  // Current date: 08.12.2021
});
 
app.Run(async(context) => await context.Response.WriteAsync($"Date: {date}"));
 
app.Run();