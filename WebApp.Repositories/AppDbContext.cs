using Microsoft.EntityFrameworkCore;
using WbaApp.Repositories.DAL.User;
using WbaApp.Repositories.EntityConfiguration;

namespace WbaApp.Repositories
{
    public class AppDbContext: DbContext
    {
        // example of migration creation: dotnet ef migrations Add Migration --project WebApp.Repositories --startup-project WebApp.Server
        // example of migration applying: dotnet ef database update --project WebApp.Repositories --startup-project WebApp.Server
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(builder);
        }
        
        public DbSet<DbUser> Leads { get; set; }
    }
}