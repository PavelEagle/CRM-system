using System.Threading.Tasks;
using Abstraction.User;

namespace UserService.Abstraction
{
    public interface IUserService
    {
        Task<User> GetUserAsync(long id);
    }
}