// Задание:
// Создайте веб-приложение на ASP.NET Core, которое определяет целочисленную переменную, изменяет её в процессе обработки запроса, а затем отправляет результат клиенту.

// Шаги:
// Инициализация WebApplication:

// Используйте WebApplication.CreateBuilder для создания билдера.
// Используйте билдер для создания приложения.
// Определите целочисленную переменную:

// Инициализируйте целочисленную переменную значением.
// Настройте конвейер обработки запросов:

// Используйте метод Run для настройки терминального промежуточного программного обеспечения, которое обрабатывает входящий запрос.
// Измените значение целочисленной переменной внутри этого промежуточного программного обеспечения.
// Отправьте изменённое значение обратно клиенту в составе HTTP-ответа.

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var value = 5;

app.Run(async (context) => {
    value++;
    Console.WriteLine($"Request received. Current value: {value}"); 
    await context.Response.WriteAsync($"{value}");
});

app.Run();