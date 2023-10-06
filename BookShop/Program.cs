using Microsoft.EntityFrameworkCore;
using BookShop.Data;

var builder = WebApplication.CreateBuilder(args);

string book = builder.Configuration.GetConnectionString("Book") ?? "[None]";

builder.Services.AddDbContext<AppDbContext>(options =>
{
  options.UseMySql(book, ServerVersion.AutoDetect(book));
});

builder.Services.AddTransient<IBookRepository, EFBookRepository>();
builder.Services.AddSingleton<OrderRepository>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();

app.MapControllerRoute("", "{controller=home}/{action=index}/{id?}");

Seed.EnsurePopulated(app);
app.Run();
