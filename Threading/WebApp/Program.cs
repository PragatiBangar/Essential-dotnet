var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/AboutUs", () => "Welcome to transflower learning");
Thread theThread = Thread.CurrentThread;
Console.WriteLine("primary thread" +theThread.ManagedThreadId);
app.Run();
