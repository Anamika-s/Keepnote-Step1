using Keepnote_Step1.Context;
using Keepnote_Step1.IRepo;
using Keepnote_Step1.Repo;
using Microsoft.EntityFrameworkCore;

namespace Keepnote_Step1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<INoteRepository,NoteRepository>();
            builder.Services.AddDbContext<NoteDBContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));
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