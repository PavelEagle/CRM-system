using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WbaApp.Repositories.DAL.User;

namespace WbaApp.Repositories.EntityConfiguration
{
    public class UserConfiguration: IEntityTypeConfiguration<DbUser>
    {
        public void Configure(EntityTypeBuilder<DbUser> builder)
        {
            builder.ToTable("Brands");
            
            builder.HasKey(b => b.Id);
            
#if DEBUG
            builder.HasData(new DbUser()
            {
                Id = 1,
                Name = "TestUser"
            });
#endif
        }
    }
}