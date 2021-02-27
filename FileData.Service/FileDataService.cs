using System.IO;
using System.Threading.Tasks;
using Abstraction.ImageData;
using FileDataService.Abstraction;
using WbaApp.Repositories.Abstraction.FileData;

namespace FileDataService
{
    public class FileDataService : IFileDataService
    {
        private readonly IFileRepository _fileRepository;

        public FileDataService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }

        public Task SaveImageAsync(Stream stream, string contentType)
        {
            return _fileRepository.SaveImage(new ImageData
            {
                ContentType = contentType,
                FileData = GetByteArrayFromStream(stream)
            });
        }

        private byte[] GetByteArrayFromStream(Stream stream)
        {
            using var ms = new MemoryStream();
            stream.CopyTo(ms);
            return ms.ToArray();
        }
    }
}