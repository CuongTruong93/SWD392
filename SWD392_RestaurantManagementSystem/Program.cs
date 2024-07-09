using Microsoft.EntityFrameworkCore;
using SWD392_RestaurantManagementSystem.Models;
using SWD392_RestaurantManagementSystem.Services;

namespace SWD392_RestaurantManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<RestaurantManagementContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Test")));

           
            builder.Services.AddSession();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

          
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Login}/{id?}");

            app.Run();
        }
    }
}
