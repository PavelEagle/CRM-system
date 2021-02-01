using System.Threading.Tasks;
using DbSeeder.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace DbSeeder
{
    public class DbSeeder
    {
        private readonly DbContext _context;

        public DbSeeder(DbContext context)
        {
            _context = context;
        }

        public async Task MigrateAndSeedAsync()
        {
            await MigrateAsync();
        }

        private Task MigrateAsync() =>
            !_context.AllMigrationsApplied() ? _context.Database.MigrateAsync() : Task.CompletedTask;
    }
}