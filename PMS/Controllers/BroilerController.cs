using Microsoft.AspNetCore.Mvc;

namespace PMS.Controllers
{
    public class BroilerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
