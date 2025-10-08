using Microsoft.EntityFrameworkCore;
using mvc2025EFCoreRelationship.Data;

namespace mvc2025EFCoreRelationship
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Defining DbContext service Configuration

            string? connectionString = builder.Configuration.GetConnectionString("RelationshipsSrAConnection") ??
                throw new InvalidOperationException($"ConnectionString was not found");
            builder.Services
                .AddDbContext<EFCoreRelationshipContext>(option => option.UseSqlServer(connectionString));







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
