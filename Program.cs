namespace bfw_WebApp_ModelBinding_mit_Validierung;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddControllersWithViews();
        
        //builder.Services.AddControllersWithViews().AddMvcOptions
        //(
        //    //https://stackoverflow.com/questions/55295323/asp-net-core-how-to-override-not-valid-value-message
        //    options => options.ModelBindingMessageProvider.SetAttemptedValueIsInvalidAccessor((x, y) => $"{x} ist kein gültiger Zahlenwert für den {y}.")
        //);
        
        var app = builder.Build();
        
        //app.MapGet("/", () => "Hello World!");
        
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        
        app.UseStaticFiles();

        app.UseRouting();
        
        app.Run();
    }
}