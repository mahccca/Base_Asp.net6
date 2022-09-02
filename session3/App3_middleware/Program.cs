
using App.Middleware;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseMiddleware<SampleMiddleware>();

app.Run();