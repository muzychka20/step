using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace pr12.Middlewares // Замените "pr12" на название вашего проекта
{
    public static class TokenExtensions
{
    public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string pattern)
    {
        return builder.UseMiddleware<TokenMiddleware>(pattern);
    }
}
public class TokenMiddleware
{
    private readonly RequestDelegate next;
    string pattern;
    public TokenMiddleware(RequestDelegate next, string pattern)
    {
        this.next = next;
        this.pattern = pattern;
    }
 
    public async Task InvokeAsync(HttpContext context)
    {
        var token = context.Request.Query["token"];
        if (token != pattern)
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsync("Token is invalid");
        }
        else
        {
            await next.Invoke(context);
        }
    }
}
}