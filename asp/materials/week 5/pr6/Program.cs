var builder = WebApplication.CreateBuilder();
var app = builder.Build();
 
app.MapWhen(
    context => context.Request.Path == "/time", // условие: если путь запроса "/time"
    appBuilder => appBuilder.Run(async context =>
    {
        var time = DateTime.Now.ToShortTimeString();
        await context.Response.WriteAsync($"current time: {time}");
    })
);
 
app.Run(async context =>
{
    await context.Response.WriteAsync("Hello ASP");
});
 
app.Run();