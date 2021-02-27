using System.Threading.Tasks;
using Abstraction.User;
using UserService.Abstraction;
using WbaApp.Repositories.Abstraction.User;

namespace UserService
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> GetUserAsync(long id) => _userRepository.GetUserAsync(id);
    }
}