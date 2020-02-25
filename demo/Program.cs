using System;
using demo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace demo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            // var builder = new ConfigurationBuilder()
            // .AddJsonFile($"appsettings.json", true, true)
            // .AddJsonFile($"appsettings.{environmentName}.json", true, true)
            // .AddEnvironmentVariables(); 
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    context.Database.Migrate(); // apply all migrations
                    DbInitiailzer.Seed(services); // Insert default data
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
