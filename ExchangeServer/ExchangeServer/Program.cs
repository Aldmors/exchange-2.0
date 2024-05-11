using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ExchangeServer.Data;
using System.Configuration;
using ExchangeServer;
using System;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ExchangeServerContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ExchangeServerContext")));
    // options.UseNpgsql(builder.Configuration.GetSection("ConnectionStrings")["ExchangeServerContext"] ?? throw new InvalidOperationException("Connection string 'ExchangeServerContext' not found.")));


builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    

}

app.ApplyMigrations();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


app.Run();

