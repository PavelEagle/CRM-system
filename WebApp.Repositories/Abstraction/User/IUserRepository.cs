using System.Threading.Tasks;

namespace WbaApp.Repositories.Abstraction.User
{
    public interface IUserRepository
    {
        Task<global::Abstraction.User.User> GetUserAsync(long id);
    }
}