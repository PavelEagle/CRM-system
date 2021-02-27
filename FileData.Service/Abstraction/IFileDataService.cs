using System.IO;
using System.Threading.Tasks;

namespace FileDataService.Abstraction
{
    public interface IFileDataService
    {
        Task SaveImageAsync(Stream fileDataStream, string ContentType);
    }
}