using Microsoft.AspNetCore.Mvc;

namespace Sheenam.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
