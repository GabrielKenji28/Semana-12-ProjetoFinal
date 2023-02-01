using Business.Interfaces;
using Business.Services;
using Infra.Context;
using Infra.Interfaces;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BancoContext>
    (options => options.UseSqlServer(builder.Configuration["ConnectionStrings:DataBase"]));

builder.Services.AddScoped<ITorneioRepository, TorneioRepository>()
                .AddScoped<IParticipanteService, ParticipanteService>()
                .AddScoped<IParticipanteRepository, ParticipanteRepository>()
                .AddScoped<ITorneioService, TorneioService>();



var app = builder.Build();

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
