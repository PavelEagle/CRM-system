using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WbaApp.Repositories;

namespace WebApp.Server
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                var host = CreateWebHost(args);
                using (var scope = host.Services.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetService<AppDbContext>();
                    await new DbSeeder.DbSeeder(dbContext).MigrateAndSeedAsync();
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
                .UseDefaultServiceProvider((context, options) => { options.ValidateOnBuild = true; }).Build();
    }
}