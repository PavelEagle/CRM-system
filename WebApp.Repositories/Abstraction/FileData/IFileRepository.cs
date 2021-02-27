using System.IO;
using System.Threading.Tasks;
using Abstraction.ImageData;

namespace WbaApp.Repositories.Abstraction.FileData
{
    public interface IFileRepository
    {
        Task SaveImage(ImageData imageData);
    }
}