using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WbaApp.Repositories.DAL.FileData;

namespace WbaApp.Repositories.EntityConfiguration
{
    public class ImageDataConfiguration: IEntityTypeConfiguration<DbImageData>
    {
        public void Configure(EntityTypeBuilder<DbImageData> builder)
        {
            builder.ToTable("ImagesData");
            
            builder.HasKey(b => b.Id);
            
            builder.Property(b => b.ContentType).HasMaxLength(50).IsRequired();
            builder.Property(b => b.FileData).IsRequired();
        }
    }
}