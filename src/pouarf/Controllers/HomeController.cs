using Microsoft.AspNetCore.Mvc;

namespace Pouarf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
