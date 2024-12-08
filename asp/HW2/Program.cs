var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.Run(async (context) => {
    // context.Response.ContentType = "text/html; charset=utf-8";
   
    // var stringBuilder = new System.Text.StringBuilder("<h3>Parameters of Query String</h3>");    
    // stringBuilder.Append("<table>");
    // stringBuilder.Append("<tr><td>Parameter</td><td>Value</td></tr>");

    // foreach(var param in context.Request.Query)
    // {
    //     stringBuilder.Append($"<tr><td>{param.Key}</td><td>{param.Value}</td></tr>");
    // }

    // stringBuilder.Append("</table>");
    // await context.Response.WriteAsync(stringBuilder.ToString());


    // ------------------------------------------------------------------------------------------------------------


    // await context.Response.SendFileAsync("D:/image.jpg");


    // ------------------------------------------------------------------------------------------------------------


    // context.Response.ContentType = "text/html; charset=utf-8";
    // await context.Response.SendFileAsync("pages/index.html");


    // ------------------------------------------------------------------------------------------------------------


    var path = context.Request.Path;
    var fullPath = $"pages/{path}.html";
    var response = context.Response;

    response.ContentType = "text/html; charset=utf-8";

    if (File.Exists(fullPath)) {
        await response.SendFileAsync(fullPath);
    } else {
        response.StatusCode = 404;
        await response.WriteAsync("<h2>Not found</h2>");
    }
});

app.Run();
