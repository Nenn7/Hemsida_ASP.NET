using Hemsida_ASP.NET.Contexts;
using Hemsida_ASP.NET.Helpers.Repos;
using Hemsida_ASP.NET.Helpers.Services;
using Hemsida_ASP.NET.Models.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IdentityContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Identity")));
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Standard")));

//Repositiories
builder.Services.AddScoped<ContactsRepo>();
builder.Services.AddScoped<ProductsRepo>();
builder.Services.AddScoped<MessagesRepo>();

//Services
builder.Services.AddScoped<ContactsService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<ProductService>();

builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
{
	x.SignIn.RequireConfirmedAccount = false;
	x.User.RequireUniqueEmail = true;
	x.Password.RequiredLength = 5;
}).AddEntityFrameworkStores<IdentityContext>(); 



var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
