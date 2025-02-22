var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => Results.Json(new { message = "Hello World!" }));

app.MapGet("/", async (context) =>
{
    context.Response.Headers.Add("Content-Type", "text/html; charset=UTF-8");
    await context.Response.WriteAsync("<style>body { background-color: black; color: white; }</style>");
    await context.Response.WriteAsync("<h1>Перейдите по адресу <a href='/hello' style='color: white;'>/hello</a></h1>");
});

app.Run();
