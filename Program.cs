using Microsoft.EntityFrameworkCore;
using SiteFinal.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);       // Add services to the container.
        builder.Services.AddControllersWithViews();

        /*builder.Services.AddDbContext<Contexto> //Ana
            (options => options.UseSqlServer("Data Source=SP-1491027\\SQLSENAI;Initial Catalog = SiteFinal;Integrated Security = True;TrustServerCertificate = True"));*/

        /*builder.Services.AddDbContext<Contexto> //Melina
            (options => options.UseSqlServer("Data Source=SP-1491008\\SQLSENAI;Initial Catalog = SiteFinal;Integrated Security = True;TrustServerCertificate = True"));*/

        /*builder.Services.AddDbContext<Contexto> //Bryan
            (options => options.UseSqlServer("Data Source=SP-1491018\\SQLSENAI;Initial Catalog = SiteFinal;Integrated Security = True;TrustServerCertificate = True"));*/

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}