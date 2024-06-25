using Microsoft.EntityFrameworkCore;
using SWD392_RestaurantManagementSystem.Models;

namespace SWD392_RestaurantManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<RestaurantManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Test")));
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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=BillingInfoes}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
