var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Terence , Welcome to ASAP .NET Core!");

app.Run();
