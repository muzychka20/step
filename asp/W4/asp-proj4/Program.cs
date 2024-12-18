var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Map("/main", (appBuilder) =>
{
    appBuilder.Map("/contact", Contact); // middleware "/home/contact"
    appBuilder.Map("/profile", Profile); // middleware "/home/profile"
    appBuilder.Run(async (context) => await context.Response.WriteAsync("Main"));
});

app.Run(async (context) => await context.Response.WriteAsync("Page Not Found"));

app.Run();

void Contact(IApplicationBuilder appBuilder)
{
    appBuilder.Run(async (context) => await context.Response.WriteAsync("Contact"));
}

void Profile(IApplicationBuilder appBuilder)
{
    appBuilder.Run(async (context) => await context.Response.WriteAsync("Profile"));
}

