var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.Run(async (context) => {
    context.Response.ContentType = "text/html; charset=utf-8";


    // -------------------------------------------------------------------------------------------------------


    if (context.Request.Path == "/old") {
        context.Response.Redirect("/new");
    } else if (context.Request.Path == "/new") {
        context.Response.Redirect("https://www.google.com.ua");
    } else if (context.Request.Path == "/postpizza") {
        var form = context.Request.Form;        
        string pizza_type = form["type"];
        string pizza_size = form["size"];
        string phone = form["phone"];
        string name = form["name"];
        string address = form["address"];        
        await context.Response.WriteAsync($"<div style=\"position: absolute;top: 50%; left: 50%; transform: translate(-50%, -50%); display: flex; flex-direction: column; justify-content: center; width: 500px; align-items: start; background-color: rgb(140, 140, 140); border-radius: 30px; padding: 100px 50px; color: rgb(212, 212, 212); font-size: 18px;\"> <p style=\"font-weight: 900;\">Type: {pizza_type}</p><p style=\"font-weight: 900;\">Size: {pizza_size}</p><p style=\"font-weight: 900;\">Phone: {phone}</p><p style=\"font-weight: 900;\">Name: {name}</p><p style=\"font-weight: 900;\">Address: {address}</p></div>");
    }
    else if (context.Request.Path == "/postpizza2") {
        var message = "Invalid data!";
        try {
            var order = await context.Request.ReadFromJsonAsync<Order>();
            if (order != null) {
                message = $"type: {order.type}; size: {order.size}; phone: {order.phone}; name: {order.name}; age: {order.address}";
            }
        } catch {}        
        await context.Response.WriteAsJsonAsync(new {text = message});
    }
    else {
        await context.Response.SendFileAsync("html/form.html");
    }


    // -------------------------------------------------------------------------------------------------------


});

app.Run();

public record Order(string type, string size, string phone, string name, string address);
