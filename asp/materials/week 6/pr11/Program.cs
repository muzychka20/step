using pr11.Middlewares; // Замените "pr11" на название вашего проекта

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.UseMiddleware<TokenMiddleware>();

app.Run(async(context) => await context.Response.WriteAsync("Hello ASP NET"));

app.Run();