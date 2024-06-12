using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MehmetHusnaKisla.Infrastructure;
using MehmetHusnaKisla.Domain.Entities;
using MehmetHusnaKisla.Application.Services.EssayService;
using MehmetHusnaKisla.Domain.Repositories;
using MehmetHusnaKisla.Infrastructure.Concrete;
using MehmetHusnaKisla.Application.Mapper;
using MehmetHusnaKisla.Application.Services.TopicService;
using MehmetHusnaKisla.Application.Services.AppUserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>(x => x.UseOracle(builder.Configuration.GetConnectionString("connStr"))); 

builder.Services.AddIdentity<AppUser, AppRole>(x => x.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<Context>()
                .AddRoles<AppRole>();

builder.Services.AddTransient<IAppUserService, AppUserService>();


builder.Services.AddTransient<IEssayService, EssayService>();
builder.Services.AddTransient<IEssayRepository, EssayRepository>();

builder.Services.AddTransient<ITopicService, TopicService>();
builder.Services.AddTransient<ITopicRepository, TopicRepository>();

// AutoMapper Settings
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(EssayMapper)));
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(TopicMapper)));
/*

*/

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
