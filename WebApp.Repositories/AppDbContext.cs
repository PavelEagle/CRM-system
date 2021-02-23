using Microsoft.EntityFrameworkCore;
using WbaApp.Repositories.DAL.User;
using WbaApp.Repositories.EntityConfiguration;

namespace WbaApp.Repositories
{
    public class AppDbContext: DbContext
    {
        // example of migration creation
        //        .NET CLI:   dotnet ef migrations Add *MigrationName* --project WebApp.Repositories --startup-project WebApp/Server
        // package manager:   add-migration *MigrationName* -project WebApp.Repositories --startup-project WebApp/Server

        // example of migration applying
        //        .NET CLI:   dotnet ef database update --project WebApp.Repositories --startup-project WebApp/Server
        // package manager:   update-database -project WebApp.Repositories --startup-project WebApp/Server

        // example of last migration removal (if it wasn't applied to DB)
        //        .NET CLI:   dotnet ef migrations remove --project WebApp.Repositories --startup-project WebApp/Server
        // package manager:   remove-migration -project MyKycDb.Repositories
        
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(builder);
        }
        
        public DbSet<DbUser> Leads { get; set; }
    }
}