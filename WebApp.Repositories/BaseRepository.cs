using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WbaApp.Repositories.Infrastructure;

namespace WbaApp.Repositories
{
    public abstract class BaseRepository<TDbContext> where TDbContext: DbContext
    {
        protected readonly IMapper Mapper = new Mapper(MappingConfiguration.GetMapperConfiguration());
        protected readonly TDbContext DbContext;

        protected BaseRepository(TDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}