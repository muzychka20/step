using pr12.Middlewares;
var builder = WebApplication.CreateBuilder();
var app = builder.Build();
 
app.UseToken("555555");
 
app.Run(async(context) => await context.Response.WriteAsync("Hello ASP NET CORE"));
 
app.Run();