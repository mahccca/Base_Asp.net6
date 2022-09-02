using App.Model;


namespace App.Middleware
{

     public class SampleMiddleware{
       
       private RequestDelegate _next;

        public SampleMiddleware(RequestDelegate next){
            _next=next;
        }


       public async Task InvokeAsync(HttpContext context)
       {
         var product =new Product
         {
            Id=1,
            Name ="Sample Product"
         };

         await context.Response.WriteAsJsonAsync(product);
       }
     }

     

}
