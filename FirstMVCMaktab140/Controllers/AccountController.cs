using FirstMVCMaktab140.Models;
using FirstMVCMaktab140.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCMaktab140.Controllers
{
    public class AccountController : Controller
    {

        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(RegisterVM dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            var result = _userService.RegisterUser(dto.FullName, dto.Email, dto.Password);

            if(!result)
            {
                ModelState.AddModelError(string.Empty, "خطا در ثبت نام کاربر");
                return View(dto);
            }

           
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult Login()=> View();




        [HttpPost]
        public IActionResult Login(LoginDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            var result = _userService.ValidateUser( dto.Email, dto.Password);

            if (result is null)
            {
                ModelState.AddModelError(string.Empty, "نام کاربری یا رمز عبور اشتباه است");
                return View(dto);
            }


            return RedirectToAction("Index", "Home");
        }

    }
}
