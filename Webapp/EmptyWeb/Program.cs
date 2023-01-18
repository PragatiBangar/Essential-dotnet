var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "<h1>Hello World!</h1>");

app.Run();
