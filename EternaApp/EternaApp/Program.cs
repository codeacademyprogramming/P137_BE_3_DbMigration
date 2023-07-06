using EternaApp;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EternaDbContext>(opt =>
{
    opt.UseSqlServer("Server=VENUS00\\SQLEXPRESS;Database=EternaAppDb2;Trusted_Connection=True");
});

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    "default",
    "{controller=home}/{action=index}/{id?}"
    );

app.Run();
