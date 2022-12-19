using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PeopleApp.Data;
using PeopleApp.Models;
using PeopleApp.Models.Repos;
using PeopleApp.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();

builder.Services.AddIdentity<AppUser, IdentityRole>()
.AddEntityFrameworkStores<PeopleDbContext>()
.AddDefaultTokenProviders();

builder.Services.AddDbContext<PeopleDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPeopleRepo, DataBasePeopleRepo>();// IoC & DI
builder.Services.AddScoped<IPeopleService, PeopleService>();// IoC & DI

builder.Services.AddScoped<ICityRepo, DatabaseCityRepo>();// IoC & DI
builder.Services.AddScoped<ICityService, CityService>();// IoC & DI

builder.Services.AddScoped<ICountryRepo, DatabaseCountryRepo>();// IoC & DI
builder.Services.AddScoped<ICountryService, CountryService>();// IoC & DI

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

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.Run();
