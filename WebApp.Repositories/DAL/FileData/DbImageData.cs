namespace WbaApp.Repositories.DAL.FileData
{
    public class DbImageData
    {
        public long Id { get; set; }
        public string ContentType { get; set; }
        public byte[] FileData { get; set; }
    }
}