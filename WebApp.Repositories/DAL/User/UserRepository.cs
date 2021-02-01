using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WbaApp.Repositories.Abstraction.User;

namespace WbaApp.Repositories.DAL.User
{
    public class UserRepository : BaseRepository<AppDbContext>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
        
        public async Task<global::Abstraction.User.User> GetUserAsync(long id)
        {
            var dbUser = await DbContext.Set<DbUser>().SingleOrDefaultAsync(b => b.Id == id);
            return Mapper.Map<global::Abstraction.User.User>(dbUser);
        }
    }
}