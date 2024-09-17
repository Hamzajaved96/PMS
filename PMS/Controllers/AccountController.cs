using Microsoft.AspNetCore.Mvc;
using PMS.Application.DTOs;
using PMS.Application.IServices;
using PMS.Models;

namespace PMS.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();

        }
        public IActionResult Register()
        {
            return View();

        }
        public async Task<IActionResult> CrateUser(CreateUserDTO createUserDto) {

            CreateUserModel model=new CreateUserModel();
            model.Id= await  _userService.CreateUserAsync(createUserDto);

            return View(model);
        }
    }
}
