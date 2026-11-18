var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/status", () => "API мониторинга скважин работает");

app.Run();
