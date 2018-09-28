using Microsoft.AspNetCore.Mvc;

namespace Hummer.Fly.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            return View();
        }

        public IActionResult Case()
        {
            return View();
        }

        [Route("[controller]/tips/{view}")]
        public IActionResult View2(string view)
        {
            return View($"tips/{view}");
        }
    }
}
