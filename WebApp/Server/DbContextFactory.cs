using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WbaApp.Repositories;

namespace WebApp.Server
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
    
            var builder = new DbContextOptionsBuilder<AppDbContext>();
    
            var connectionString = configuration.GetConnectionString("SqlConnectionString");
    
            builder.UseSqlServer(connectionString);       
    
            return new AppDbContext(builder.Options);
        }
    }
}