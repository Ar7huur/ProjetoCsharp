using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMVC.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<SalesWebMVCContext>(options =>
    //options.UseMySql(builder.Configuration.GetConnectionString("SalesWebMVCContext"), builder => builder.MigrationsAssembly("SalesWebMVC")));

//string conex�o para o MySQL
//string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<SalesWebMVCContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


//sdadwd
builder.Services.AddDbContext<SalesWebMVCContext>(options => 
options.UseMySql("server=localhost;inital catalog=saleswebmvcappdb; uid=root;pwd=1234567",Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql")));


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
