var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "dev web");

app.Run();
