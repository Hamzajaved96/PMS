using Microsoft.AspNetCore.Mvc;

namespace PMS.Controllers
{
    public class BreaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
