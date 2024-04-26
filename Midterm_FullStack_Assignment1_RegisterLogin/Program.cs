using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;
using Service;
using Midterm_FullStack_Assignment1_RegisterLogin.Models;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase(databaseName: "InMemoryDb"));

builder.Services.AddSingleton<IUserRepository, repositories>();
builder.Services.AddScoped<IUserService, Services>();

//Session for determining login status
builder.Services.AddSession(options => { options.Cookie.IsEssential = true; });

var app = builder.Build();
app.UseSession();

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
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
