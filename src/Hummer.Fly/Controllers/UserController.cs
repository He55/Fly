using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Hummer.Fly.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = User;
            return View();
        }

        public IActionResult Center()
        {
            return View();
        }

        public IActionResult Setting()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

        public IActionResult Activate()
        {
            return View();
        }
    }
}
