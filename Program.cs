using System.Text.Json;
using WebApp_Tabelle_2024_03_05.Models;

namespace WebApp_Tabelle_2024_03_05;

public class Program
{
    public static List<Artikel> artikelListe = JsonSerializer.Deserialize<List<Artikel>>( System.IO.File.ReadAllText("Data/Json/Artikels.json"));
    
    public static void Main(string[] args)
    {
        
        
        
        var builder = WebApplication.CreateBuilder(args);
        // Configure the App as MVC-App
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        app.UseStaticFiles();
        app.UseRouting();
        
        // app.MapGet("/", () => "Hello World!");
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
        );
        app.Run();
    }
}