using Microsoft.AspNetCore.Mvc;
using UserService.Abstraction;

namespace WebApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Get(long userId)
        {
            return Ok(_userService.GetUserAsync(userId));
        }
    }
}