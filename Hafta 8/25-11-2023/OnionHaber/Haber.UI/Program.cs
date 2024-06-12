using Haber.Application.Services.AppUserService;
using Haber.Domain.Entities;
using Haber.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



#region BİZİM EKLEDİĞİMİZ KISIM


builder.Services.AddDbContext<HaberContext>(x => x.UseOracle());
builder.Services.AddIdentity<AppUser, AppRole>(x => x.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<HaberContext>()
                .AddRoles<AppRole>();

// IoC
builder.Services.AddTransient<IAppUserService, AppUserService>();




#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
