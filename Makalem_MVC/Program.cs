using Makalem.BLL.Services.Abstract;
using Makalem.BLL.Services.Concrete;
using Makalem.DAL;
using Makalem.DAL.Repositories.Abstract;
using Makalem.DAL.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*-----Session-----------*/
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
/*----------------------------------*/

builder.Services.AddDbContext<ApplicationDbContext>();


/*---------------Service--------------------*/
builder.Services.AddScoped(typeof(IService<>), typeof(GenericService<>));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IArticleService, ArticleService>();
/*-------------------------------------------*/



/*----------------DAL------------------*/
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
/*----------------------------------*/




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseSession();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
