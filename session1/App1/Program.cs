//?Information
//! Warning
//* sample code 
//Todo (Product Management)


var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//app.MapGet("/", () => "Hello World");


//! lambada expersion
//var handller = () => "sample code";
//app.MapGet("/" , handller);

//! local inline
//string LocalFuce() => "LocalFuc";
//app.MapGet("/",LocalFuce);

//!Instance Method
/*
var hello = new HelloHandler();
app.MapGet("/",hello.Hello);
*/



//!Custom Route
//app.MapGet("/product/{id}",(int id) => $"Product Detail {id}"); 
//app.MapGet("/product/{id}",(int id)=> new Product{Id = id,Name=$"Product {id}",Price=2*id});

var list = new List<Product>();

list.Add(new Product{Id=1, Name=$"Product {1}"});
list.Add(new Product{Id=2, Name=$"Product {2}",Price=2*100});
list.Add(new Product{Id=3, Name=$"Product {3}",Price=3*100});


app.MapGet("/product",()=>list);
//? LINQ (C# query data)
app.MapGet("/product/test/{id}",(int id)=>list.FirstOrDefault(p => p.Id==id));





app.Run();




class HelloHandler{
    public string Hello(){

        return "Instance Method";
    }
}

class Product{
    
    public int Id{get;set;}
    public string Name{get;set;}
    public int Price{get;set;}
}