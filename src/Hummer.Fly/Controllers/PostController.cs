using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Hummer.Fly.Controllers
{
    [Route("[controller]/[action]")]
    public class PostController : Controller
    {
        [Route("/[controller]/{page:int?}")]
        public IActionResult Index(int page = 1)
        {
            return View();
        }

        [Route("{id:int}")]
        public IActionResult Detail(int id)
        {
            return View();
        }

        [Authorize]
        public IActionResult Add()
        {
            return View();
        }
    }
}
