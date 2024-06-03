using Microsoft.EntityFrameworkCore;
using SWD392_Group3_Project.Entities;


var builder = WebApplication.CreateBuilder(args);

 // Add services to the container.
 builder.Services.AddRazorPages();
builder.Services.AddDbContext<RestaurantManagementContext>(option =>
{
option.UseSqlServer(builder.Configuration.GetConnectionString("Test"));
});
 var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
     app.UseExceptionHandler("/Error");
 }
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
 