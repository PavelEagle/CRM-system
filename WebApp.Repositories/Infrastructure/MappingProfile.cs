using Abstraction.ImageData;
using AutoMapper;
using WbaApp.Repositories.DAL.FileData;

namespace WbaApp.Repositories.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ConfigureLeadIdentityMapping();
        }

        #region Configuration

        private void ConfigureLeadIdentityMapping() =>
            CreateMap<ImageData, DbImageData>();

        #endregion
    }
}