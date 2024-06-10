using Microsoft.EntityFrameworkCore;
using SWD392_Group3_Project.Entities;
using SWD392_Group3_Project.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RestaurantManagementContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Test"));
});

// Register UserRepository and IUserRepository
builder.Services.AddScoped<IUserRepository, UserRepository>();

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

// Redirect to Login page as default
app.MapGet("/", async context =>
{
    context.Response.Redirect("/Login");
});

app.Run();