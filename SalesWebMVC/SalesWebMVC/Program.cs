using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMVC.Data;
using System.Configuration;

//Program & Startup

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<SalesWebMVCContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


//conex�o para o MySQL - passando local host, database name, userid, password & vers�o do mysql
//builder.Services.AddDbContext<SalesWebMVCContext>(options => 
//options.UseMySql("server=localhost;database = saleswebmvcappdb; uid=root;pwd=1234567", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql")));


var app = builder.Build();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Departaments}/{action=Index}/{id?}");

app.Run();
