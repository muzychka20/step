//dotnet new razor
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Маршрут для авторизации
app.MapPost("/login", async context =>
{
    context.Response.ContentType = "text/plain; charset=utf-8";

    var form = context.Request.Form;
    var username = form["username"];
    var password = form["password"];

    var users = UserManager.LoadUsers();
    var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

    if (user != null)
    {
        context.Response.Redirect("index2.html");
    }
    else
    {
        await context.Response.WriteAsync("Неверный логин или пароль.");
    }
});

// Маршрут для регистрации
app.MapPost("/register", async context =>
{
    context.Response.ContentType = "text/plain; charset=utf-8";

    var form = context.Request.Form;
    var username = form["username"];
    var password = form["password"];

    var users = UserManager.LoadUsers();
    if (users.Any(u => u.Username == username))
    {
        await context.Response.WriteAsync("Пользователь с таким именем уже существует.");
        return;
    }

    users.Add(new User { Username = username, Password = password });
    UserManager.SaveUsers(users);

    context.Response.Redirect("index.html");
});

// Маршрут для формы обратной связи
app.MapPost("/feedback", async context =>
{
    context.Response.ContentType = "text/plain; charset=utf-8";
    
    var form = context.Request.Form;
    var message = form["message"];

    await File.AppendAllTextAsync("feedback.json", $"{message}\n");
    await context.Response.WriteAsync("Спасибо за ваше сообщение!");
});

app.Map("/ukr_news", async (HttpContext context) =>
{        
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("wwwroot/ukr_news.html");        
});

app.Map("/world_news", async (HttpContext context) =>
{        
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("wwwroot/world_news.html");        
});

app.Map("/sport_news", async (HttpContext context) =>
{        
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("wwwroot/sport_news.html");        
});


// Подключение статических файлов
app.UseStaticFiles();
app.MapFallbackToFile("index.html");

app.Run();

// Вынесение всех вспомогательных классов вне кода верхнего уровня
public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class UserManager
{
    private const string FilePath = "users.json";

    public static List<User> LoadUsers()
    {
        if (!File.Exists(FilePath)) return new List<User>();
        var json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }

    public static void SaveUsers(List<User> users)
    {
        var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }
}