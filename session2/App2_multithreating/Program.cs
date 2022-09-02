var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();


app.Use(async (context,next) =>
{
   app.Logger.LogInformation($"start time: {DateTime.Now.ToString()}");
   await next.Invoke();
   app.Logger.LogInformation($"stop time: {DateTime.Now.ToString()}");

});
app.MapGet("/",async()=> await Task.FromResult("Hello ALi :D"));
app.Run();
// Configure the HTTP request pipeline