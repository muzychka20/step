var builder = WebApplication.CreateBuilder();
var app = builder.Build();
 
app.Use(async(context, next) =>
{
    string? path = context.Request.Path.Value?.ToLower();
    if (path == "/date")
    {
        await context.Response.WriteAsync($"Date: {DateTime.Now.ToShortDateString()}");
    }
    else if (path == "/time")
    {
        await context.Response.WriteAsync($"Time: {DateTime.Now.ToShortTimeString()}");         
    }
    else
    {
        await next.Invoke();
    }
});
 
app.Run(async(context) => await context.Response.WriteAsync($"Hello ASP NET"));
 
app.Run();