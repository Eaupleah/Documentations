using CSharp.RazorPagesWebApp.Data;
using CSharp.RazorPagesWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharp.RazorPagesWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<CSharpRazorPagesWebAppContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CSharpRazorPagesWebAppContext") ?? throw new InvalidOperationException("Connection string 'CSharpRazorPagesWebAppContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                SeedData.Initialize(services);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
