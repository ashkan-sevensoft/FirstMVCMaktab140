using FirstMVCMaktab140.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCMaktab140.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {

            var users = _userService.GetAllUsers();
            return View(users);
        }

        public IActionResult Detail(Guid id)
        {
            var user = _userService.GetById(id);

            return View(user);
        }

    }
}
