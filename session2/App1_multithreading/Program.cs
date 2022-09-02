var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();
var handler=new Handler();
//app.MapGet("/",async ()=>await handler.Hello2());
app.MapGet("/",async ()=>await handler.Hello3());
app.Run();
class Handler{

//* eager Execution
    public async Task<string> Hello2(){
        var result =await Task.FromResult("Async Instance Method ");
        return result;
    }
//* Defer Execution
    public Task<string> Hello3(){
        return Task.FromResult("Async Instance Method ");
        
    }

}