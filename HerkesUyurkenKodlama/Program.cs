using HerkesUyurkenKodlama.Entity;
using Microsoft.EntityFrameworkCore;

namespace HerkesUyurkenKodlama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
            // addRazorRuntimeCompilation eklendi...
            //builder.Services.AddDbContext<DatabaseContext>(opts =>
            //{
            //    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            //});

            builder.Services.AddDbContext<DatabaseContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

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
        }
    }
}