using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WbaApp.Repositories;

namespace WebApp.Server
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            try
            {
                var host = CreateWebHost(args);
                using (var scope = host.Services.CreateScope())
                {
                    var myKycDbContext = scope.ServiceProvider.GetService<AppDbContext>();
                    await new DbSeeder.DbSeeder(myKycDbContext).MigrateAndSeedAsync();
                }

                await host.RunAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static IWebHost CreateWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseDefaultServiceProvider((context, options) =>
                {
                    options.ValidateOnBuild = true;
                })
                .Build();
    }
}