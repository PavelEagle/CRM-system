using System.IO;
using System.Threading.Tasks;
using Abstraction.ImageData;
using WbaApp.Repositories.Abstraction.FileData;

namespace WbaApp.Repositories.DAL.FileData
{
    public class FileRepository: BaseRepository<AppDbContext>, IFileRepository
    {
        public FileRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task SaveImage(ImageData imageData)
        {
            var data = Mapper.Map<DbImageData>(imageData);
            
            await DbContext.Images.AddAsync(data);
            await DbContext.SaveChangesAsync();
        }
    }
}